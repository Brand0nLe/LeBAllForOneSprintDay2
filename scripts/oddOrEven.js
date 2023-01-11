function oddOrEven(){
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/oddoreven/30')
    .then((response) => response.text())
    .then((data) => console.log(data));
    }