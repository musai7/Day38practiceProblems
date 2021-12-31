const readline = require('readline');
const r1 = readline.createInterface({
    input: process.stdin,
    output : process.stdout
});
let year
r1.question('enter a year ',(value)=>{
    year=value;
    if((year %4==0 && year%100!=0) || year%400 == 0){
         console.log("leap year : "+year);
    }else{
         console.log("not a leao year : "+ year);
    }
    r1.close();
})