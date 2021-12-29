const calendar = document.querySelector("#app-calendar");

const isWeekend = day => {
    return day === 6;
}

console.log(calendar)

for (let day = 1; day <= 31; day ++){
    const weekend = isWeekend(day)
    calendar.insertAdjacentHTML("beforeend", `<a class="day ${weekend ? "weekend" : ""}" href="shifts_per_day.php"><div>${day}</div></a>`);
}