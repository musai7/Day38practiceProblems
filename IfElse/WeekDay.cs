const ps = require("prompt-sync")
const prompt = ps();

let day = prompt("enter single day 0-6 : ");

if(day == 0){
    console.log(day + " : sunday")
}else if (day ==1){
    console.log(day + " : monday")
}else if (day ==2){
    console.log(day + " : tuesday")
}else if (day ==3){
    console.log(day + " : wednesday")
}else if (day == 4){
    console.log(day + " : thursday")
}else if (day == 5){
    console.log(day + " : friday")
}else if (day == 6){
    console.log(day + " : saturday")
}

