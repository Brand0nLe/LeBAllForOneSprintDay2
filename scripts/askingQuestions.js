function askingQuestions(){
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/askingquestions/Brandon/30')
    .then((response) => response.text())
    .then((data) => console.log(data));
    }