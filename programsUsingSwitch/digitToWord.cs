const ps = require("prompt-sync");
const prompt = ps();

let text ="";
let digit = parseInt(prompt("enter single digit 0-9 : "));
switch (digit)
{
    case 0:
        text ="zero";
        break;
    case 1:
        text = "one";
        break;
    case 2:
        text = "TWO";
        break;
    case 3:
        text = "THREE";
        break;
    case 4:
        text = "FOUR";
        break;
    case 5:
        text = "FIVE";
        break;
    case 6:
        text = "SIX";
        break;
    case 7:
        text = "SEVEN";
        break;
    case 8:
        text = "EIGHT";
        break;
    case 9:
        text = "NINE";
        break;
    default:
        text ="enter digit between 0-9";
}
console.log(digit +" : "+text);