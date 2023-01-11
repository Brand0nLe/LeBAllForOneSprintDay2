function reverseIt(){
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/reverseit/hello1234')
    .then((response) => response.text())
    .then((data) => console.log(data));
    }