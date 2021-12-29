using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace MediaBazaarApplication
{
    class PDFGenerator
    {
        DBSchedule DBSchedule = new DBSchedule();
        DBDepartment DBDepartment = new DBDepartment();
        DBEmployees DBEmployees = new DBEmployees();



        public void GenerateSchedulePDF(string date, int dep_id)
        {
            DateTime now = DateTime.Now;
            try
            {
                // Configure save file dialog box
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = $"{date}"; // Default file name
                dlg.DefaultExt = ".pdf"; // Default file extension
                dlg.Filter = "PDF documents (.pdf)|*.pdf"; // Filter files by extension
                DateTime printDate = DateTime.Now;

                // Process save file dialog box results
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string filename = dlg.FileName;
                    Document doc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));

                    //Open Document to write
                    doc.Open();

                    //Generate LOGO image
                    Image image = Image.GetInstance(@"../../Images/Logo.png");
                    //Write something
                    Paragraph paragraph = new Paragraph($"SCHEDULE \n\nPrint Date: {printDate.ToString("yyyy-MM-dd")} \n{DBDepartment.GetDepartmentName(dep_id)} department shifts for {date}: \n{GetShiftsToString(date, dep_id)}");

                    //Now add the above created text using different class object to our pdf document
                    doc.Add(image);
                    doc.Add(paragraph);

                    //Close the doc
                    doc.Close();
                    // Save document
                    
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        public string GetShiftsToString(string date, int dep_id)
        {
            string shiftsString = "";

            List<Shift> todayShifts = DBSchedule.GetShifts(date, dep_id);

            shiftsString += "\nMORNING";
            shiftsString += "\n____________________________________________";

            foreach (Shift shift in todayShifts)
            {
                string employeeName = DBEmployees.GetNameById(shift.EmployeeId);
                if(shift.TimeFrame == "MORNING" || shift.TimeFrame == "MORNING-AFTERNOON" || shift.TimeFrame == "MORNING-EVENING")
                {
                    shiftsString += $"\n - {employeeName}";
                }
            }

            shiftsString += "\n";
            shiftsString += "\nAFTERNOON";
            shiftsString += "\n____________________________________________";

            foreach (Shift shift in todayShifts)
            {
                string employeeName = DBEmployees.GetNameById(shift.EmployeeId);
                if (shift.TimeFrame == "AFTERNOON" || shift.TimeFrame == "MORNING-AFTERNOON" || shift.TimeFrame == "AFTERNOON-EVENING")
                {
                    shiftsString += $"\n - {employeeName}";
                }
            }

            shiftsString += "\n";
            shiftsString += "\nEVENING";
            shiftsString += "\n____________________________________________";

            foreach (Shift shift in todayShifts)
            {
                string employeeName = DBEmployees.GetNameById(shift.EmployeeId);
                if (shift.TimeFrame == "EVENING" || shift.TimeFrame == "MORNING-EVENING" || shift.TimeFrame == "AFTERNOON-EVENING")
                {
                    shiftsString += $"\n - {employeeName}";
                }
            }
            return shiftsString;
        }
    }
}
