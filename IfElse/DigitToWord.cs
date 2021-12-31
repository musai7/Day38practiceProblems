const ps = require("prompt-sync");
const prompt = ps();

let digit = prompt("enter single digit 0-9 : ");
if(digit<5){
    if(digit == 1){
        console.log(digit + " : ONE")
    }else if(digit ==2){
        console.log(digit + " : TWO")
    }else if(digit ==3){
        console.log(digit + " : THREE")
    }else if(digit ==4){
        console.log(digit + " : FOUR")
    }else if(digit ==0){
        console.log(digit + " : ZERO")
    }
}
if(digit>=5){
    if(digit == 5){
        console.log(digit + " : FIVE")
    }else if(digit ==6){
        console.log(digit + " : SIX")
    }else if(digit ==7){
        console.log(digit + " : SEVEN")
    }else if(digit ==8){
        console.log(digit + " : EIGHT")
    }else if(digit ==9){
        console.log(digit + " : NINE")
    }
}
