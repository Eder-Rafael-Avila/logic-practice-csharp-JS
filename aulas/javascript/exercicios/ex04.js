import prompt from 'prompt-sync';
let ler = prompt();

console.log("QUAL NÚMERO É MAIOR?\n");

console.log("Insira um número: ");
const num1 = Number(ler());

console.log("Insira outro número: ");
const num2 = Number(ler());

if (num1 > num2) {
    console.log(`\n${num1} é maior que ${num2}.`)
} else if (num2 > num1) {
    console.log(`\n${num2} é maior que ${num1}.`)
} else {
    console.log(`\n${num1} e ${num2} são iguais.`);
}
