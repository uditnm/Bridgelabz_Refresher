function displayTable(){
  fetch("http://localhost:3000/employees")
  .then(response => response.json())
  .then(data => {

    var table = document.getElementById("tablebody");

    data.forEach(item => {

      let row = document.createElement("tr");
      row.setAttribute("id",item.id);
      row.innerHTML = `<td>
                <div class = "name">
                    <img src=${item.dp} >
                    <span style="vertical-align: middle;"> ${item.name}</span>
                </div>
            </td>
            <td>${item.gender}</td>
            <td>
                <div class = "dept">
                ${item.dept.map(dep=>
                    `<p> ${dep}</p>`
                ).join(``)}
                </div>
                            
            </td>
            <td><i class="fa-solid fa-indian-rupee-sign" style="color: #606366;"></i>${item.salary}</td>
            <td>${item.Day} ${item.Month} ${item.Year}</td>
            <td>
                <button class="delete-button"><i class="fa-solid fa-trash-can" style = "color: #658292;"></i></button>
                <button class="edit-button" onclick = "editEmployee(${item.id})"><i class="fa-solid fa-pen" style = "color: #658292;"></i></button>
            </td>`

            table.appendChild(row);
    });

  })
  .catch(error => {
    console.error("Error fetching data:", error);
  });
}

function deleteEmployee(event) {
  var button = event.target;
  var parentTR = button.closest('tr');
  var id = parentTR.getAttribute('id');

  fetch('http://localhost:3000/employees/' + id, {
      method: 'DELETE',
    })
    .then(response => {
      if (response.ok) {
        parentTR.remove();
      } else {
        console.error('Error:', response.status);
      }
    })
    .catch(error => console.error('Error:', error));

}

document.addEventListener('click', function(event) {
  if (event.target.matches('.delete-button')) {
    deleteEmployee(event);
  }
});



function editEmployee(e) {
  console.log(e);
  var employeeId = e
  window.location.href = "file:///D:/bridgelabz/Bridgelabz_Refresher/htmlBasics/PayrollForm.html?id="+employeeId;
  console.log(e);
}

document.addEventListener('click', function(event) {
  if (event.target.matches('.edit-button')) {
    editEmployee(event);
  }
});
