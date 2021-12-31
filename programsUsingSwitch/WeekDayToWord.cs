const ps = require("prompt-sync");
const prompt = ps();

let text ="";
//let digit = parseInt(prompt("enter a day 0-6 : "));
switch (new Date().getDay())
{
    case 0:
        text ="SUNDAY";
        break;
    case 1:
        text ="MONDAY";
        break;
    case 2:
        text ="TUESDAY";
        break;
    case 3:
        text ="WEDNESDAY";
        break;
    case 4:
        text ="THURSDAY";
        break;
    case 5:
        text ="FRIDAY";
        break;
    case 6:
        text ="SATURDAY";
        break;
    default:
        text ="enter valid day as 0-6 "
}
console.log(new Date().getDay()+" : " + text);