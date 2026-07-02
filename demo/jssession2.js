 //if else statements 

let age=20
if (age>18) 
{
    console.log("Eligible to vote");
}
else
{
    console.log("not eligible to vote");

}

//nested if else

let marks=69
if(marks>75)
{
    console.log("Distintion");
}
else if (marks<75 && marks>=60) 
{
    console.log("first class");
} 
else {
    console.log("pass");
    
}

//loops

var i=1
for(i=1;i<=10;i++)
{
    console.log(i)
}

//for in loop

var p
var person = {name: "Subahan", language: "JavaScript", age: 17 , };
for( p in person)
{
    console.log(p+"="+person[p])
}

//for eeach loop

const  evenno = [2,4,6,8,10];
evenno.forEach(showen);
 
function showen(item, index)
{
console.log(item,index);
}
