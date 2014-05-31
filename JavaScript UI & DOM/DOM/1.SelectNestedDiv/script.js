function getNestedDivQuery() {
    var divs = document.querySelectorAll('div > div')
    for (var i in divs) {
        console.log(divs[i].innerText);
    }
}

function getNestedDivByTag() {
    var divs = document.getElementsByTagName('div')
    for (var i in divs) {
        if (divs[i].parentNode instanceof HTMLDivElement) {
            console.log(divs[i].innerText);
        }

    }
}

getNestedDivQuery();
getNestedDivByTag();