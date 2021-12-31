let num=0;
const randomNumber=[];
while(num<5){
    randomNumber[num]= Math.floor( Math.random()*899+100);
    console.log(randomNumber[num]);
    num++;
}
let i=0;
let max =0,min=1000;
while(i<randomNumber.length){
    if(max<randomNumber[i]){
        max = randomNumber[i];
    }
    if(min>randomNumber[i]){
        min = randomNumber[i];
    }
    i++;
}
console.log("max = "+max+"   min = "+min);