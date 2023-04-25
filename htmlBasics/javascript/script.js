let year = document.getElementById("year")
let lastyear = new Date().getFullYear();
let curYear = 2000;
while(curYear<lastyear){
    let dateOption = document.createElement("option");
    dateOption.text = curYear;
    dateOption.value = curYear;
    year.add(dateOption);
    curYear+=1;
}

let day = document.getElementById("day");
let curDay = 1;
while(curDay<=31){
    let dayOption = document.createElement("option");
    dayOption.text = curDay;
    dayOption.value = curDay;
    day.add(dayOption);
    curDay+=1;
}


let employeeform = document.getElementById("employeeform");

employeeform.addEventListener("submit", (e) => {
    e.preventDefault();

var form = new FormData(employeeform);
var username = form.get("name");
console.log(username);
var profile = form.get("dp");
console.log(profile);
var gender = form.get("gender");
console.log(gender);
var dept = form.getAll("dept");
console.log(dept);
var salary = form.get("salary");
console.log(salary);
var day = form.get("Day");
console.log(day);
var month = form.get("Month");
console.log(month);
var year = form.get("Year");
console.log(year);
var notes = form.get("notes");
console.log(notes);


});