// let x = 123;
// console.log(x);
// console.log(x.toString());

// let y = 9.656;
// console.log(y.toFixed(2));

// let p = "10";
// let q = "50";
// console.log(Number(p)+Number(q));

console.log(parseFloat("10.33"));

console.log(Number("asssss"));

let age = 20;
if( age > 30)
{
    console.log("My age is greater than 30");
}
else if(age > 18)
{
    console.log("My age is greater than 18");
}
else
{
    console.log("My age is less than or 18");
}

console.log(Date());

switch (new Date().getDay()) 
{
    case 6:
      text = "Today is Saturday";
      break;
    case 0:
      text = "Today is Sunday";
      break;
    default:
      text = "Looking forward to the Weekend";
}

for(let i=0;i<=100;i++)
{
console.log(i);
}

var person = {name: "Shree", language: "JavaScript", age: 28, city : "Delhi"};
for(var p in person) 
{  
console.log( p + " = " + person[p]); 
}

const  evenno = [2,4,6,8,10];
evenno.forEach(showen);
 
function showen(item, index)
{
console.log(item);
}

let x = 1, y = 6;
while (x <= y) 
{
console.log(x);
x += 1;
}

let a1 = 10;
let b1 =3;
do {
console.log(a1);
a1++;
} while(a1 <= b1);

const fruits = new Map();
fruits.set("apples", 500);
fruits.set("bananas", 300);
fruits.set("oranges", 200);

console.log(fruits.get("apples")); 
console.log(fruits.size);

let num1 = "5000";
let num2 = "7000";
let result = Number(num1)+Number(num2);
console.log(result);



