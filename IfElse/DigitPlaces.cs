const ps = require("prompt-sync");
const prompt = ps();

let digit = prompt("enter single digit 1,10,..10000 : ");
 if(digit == 1){
    console.log(digit + " : unit")
}else if(digit ==10){
    console.log(digit + " : tens")
}else if(digit ==100){
    console.log(digit + " : hundreds")
}else if(digit ==1000){
    console.log(digit + " : thousands")
}else if(digit == 10000){
    console.log(digit + " : ten thousands")
}else if(digit == 100000){
    console.log(digit + " : one lac")
}