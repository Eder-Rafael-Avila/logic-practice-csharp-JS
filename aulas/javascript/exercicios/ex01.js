import prompt from 'prompt-sync';
let ler = prompt();

console.log("SOMA DE DOIS NÚMEROS\n");

console.log("Insira um número:");
const num1 = Number(ler());

console.log("Insira outro número:");
const num2 = Number(ler());

console.log(`\nA soma de ${num1} + ${num2} é igual a: ${num1 + num2}.`);