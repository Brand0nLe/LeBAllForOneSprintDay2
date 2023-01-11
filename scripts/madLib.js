function madLib(){
    fetch('https://allforoneapibrandon.azurewebsites.net/allforone/greaterorlessthan/30/20https://allforoneapibrandon.azurewebsites.net/allforone/MadLib/Brandon/Daniel/Chocolate/banana/4/giraffe/red/7/sad/100')
    .then((response) => response.text())
    .then((data) => console.log(data));
    }