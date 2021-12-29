<?php
session_start();
//require_once('../includes/init.php');
require_once("../init.php");

if(isset($_POST['login']))
{
    if(!empty($_POST['email']) && !empty($_POST['password']))
    {
        $email = $_POST['email'];
        $password = $_POST['password'];
        $user = UserLogic::GetUserByEmail($email);
        $correctpassword = UserLogic::GetUsersPassword($email);
        

        if(!password_verify($password, $correctpassword))
        {
//            header("location: ../../presentation/login.php");
            echo $password;
            echo $correctpassword;
        }
        else
        {
            if(isset($_POST['remember']))
            {
                setcookie('email',$email,time()+60*60*7);
                $_SESSION['email'] = $email;
            }
            if($user->GetRole() == "Employee")
            {
                $_SESSION['id'] = $user->GetId();
                $_SESSION['role'] = "Employee";
                header("location: ../../presentation/profile.php");
            }
            else
            {
                $_SESSION['id'] = $user->GetId();
                $_SESSION['role'] = "Admin";
                header("location: ../../presentation/profile.php");
            }
        }
    }
    else
    {
        header("location: ../../presentation/login.php");    
    }

    $_SESSION["department_id"] = $user->GetDepartmentId();

}
else{
    header("location: ../../presentation/login.php");    
}
?>
