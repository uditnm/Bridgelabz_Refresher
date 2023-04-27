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

    const formdata = {}

    var form = new FormData(employeeform);

    var username = form.get("name");
    console.log(username);
    formdata["name"] = username;
    var profile = form.get("dp");
    console.log(profile);
    formdata["dp"] = profile;
    var gender = form.get("gender");
    console.log(gender);
    formdata["gender"] = gender;
    var dept = form.getAll("dept");
    console.log(dept);
    formdata["dept"] = dept;
    var salary = form.get("salary");
    console.log(salary);
    formdata["salary"] = salary;
    var day = form.get("Day");
    console.log(day);
    formdata["Day"] = day;
    var month = form.get("Month");
    formdata["Month"] = month;
    console.log(month);
    var year = form.get("Year");
    console.log(year);
    formdata["Year"] = year;
    var notes = form.get("notes");
    console.log(notes);
    formdata["notes"] = notes;

    const formdataJSON = JSON.stringify(formdata);
    console.log(formdataJSON);

    fetch('http://localhost:3000/employees', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: formdataJSON
    })
    .then(response => response.json())
    .then(data => console.log(data))
    .catch(error => console.error(error));

});

