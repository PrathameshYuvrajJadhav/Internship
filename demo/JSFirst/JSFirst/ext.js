console.log("Hello from extrnal JS..!");

//redeclartion allowed in case of var
var a = 10;
// var a="hhhh";

//redeclartion not allowed in case of let
let b =50;
b=80;

const passing =40;

function showmsg(){
    alert("Hello from alert..!");
}

document.getElementById("btndemo").addEventListener("click",showmsg);

let txt = "Revolution IT Solutions";
let length = txt.length;
console.log(length);

let str = "Kolhapur, Mumbai, Pune";
let part = str.slice(10, 16);
console.log(part);

let str1 = "Kolhapur, Mumbai, Pune";
let part1 = str1.substring(10, 16);
console.log(part1);

let str2 = "Kolhapur, Mumbai, Pune";
let part2 = str2.substr(10, 6);
console.log(part2);

let text = "Please visit company!";
let newText = text.replace("company", "Revolution IT Solutions");
console.log(newText);

let text1 = "revolution";
let text2 = text1.toUpperCase();
console.log(text2);

let text3 = "REVOLUTION";
let text4 = text3.toLowerCase();
console.log(text4);

let text5 = "      Revolution      ";
let text6 = text5.trim();
console.log(text6);

// let cities = new Array();
let cities = [];
cities =['Kolhapur', 'Pune', 'Mumbai'];
console.log(cities[0]);
console.log(cities[1]);

const cities1 = ["Kolhapur", "Pune", "Mumbai", "Nashik"];
cities1.push("Nagpur");
cities1.pop();
cities1.splice(0, 1);
let length1 = cities1.length;
console.log(length1);

const cities5 = ["Kolhapur", "Satara"];
const cities6 = ["Pune", "Mumbai"];
let cities7 = cities5.concat(cities6);
console.log(cities7.length);

// let car = new Object();
let car = {};
car = {name:'A7',
brand:'Audi',
capacity:5};
console.log(car['name']);
console.log(car['brand']);



