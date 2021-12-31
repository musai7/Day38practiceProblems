const MARCH= 3;
const JUNE = 6;

const ps = require("prompt-sync");
const prompt = ps();

let month = prompt("enter month : ");
let date = prompt("enter date : ");
 if(month>=MARCH && month<=JUNE){
     if(month ==6 && date <= 20&& date > 0){
        console.log("true");
     }else if(month ==5 && date<= 31 && date>0){
        console.log("true");
     }else if(month == 4 && date <=30 && date>0){
        console.log("true");
     }else if(month==3 && date>=20&&date<31){
        console.log("true");
     }else
     {
        console.log("false");
     }
}else{
   console.log("false"); 
}
