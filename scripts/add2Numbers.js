// function add2Numbers(){
//     fetch('https://allforoneapibrandon.azurewebsites.net/allforone/add2numbers/20/11')
//     .then((response) => response.text())
//     .then((data) => console.log(data));
//     }


    function add2Numbers(){
        fetch('https://allforoneapibrandon.azurewebsites.net/allforone/add2numbers/20/11').then(
            response => response.text()
        ).then(
            data => {
                response.textContent = data
                console.log(data)
            }
        )
    }