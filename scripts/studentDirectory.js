function studentDirectory() {
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/GetStudentByFirstName/Brandon')
        .then((response) => response.text())
        .then((data) => console.log(data));
}

function studentDirectory() {
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/GetStudentByLastName/Le')
        .then((response) => response.text())
        .then((data) => console.log(data));
}

function studentDirectory() {
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/GetStudentBySlackName/Brandon Le')
        .then((response) => response.text())
        .then((data) => console.log(data));
        
}

function studentDirectory() {
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/GetStudentByEmail/ble@codestack.co')
        .then((response) => response.text())
        .then((data) => console.log(data));
}