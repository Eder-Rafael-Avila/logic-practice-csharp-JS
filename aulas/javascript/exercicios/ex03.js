import prompt from 'prompt-sync';
let ler = prompt();

console.log("PAR OU ÍMPAR?\n");

console.log("Insira um número: ");
const num = Number(ler());

if (num % 2 === 0) {
    console.log("\nNúmero é par.");
} else {
    console.log("\nNúmero é ímpar");
}