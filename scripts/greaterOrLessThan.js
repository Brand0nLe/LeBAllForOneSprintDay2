function greaterOrLessThan(){
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/greaterorlessthan/30/20')
    .then((response) => response.text())
    .then((data) => console.log(data));
    }