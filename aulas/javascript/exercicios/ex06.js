import prompt from 'prompt-sync';
let ler = prompt();

console.log("SOMA DE 1 ATÉ N\n");

console.log("Insira um número: ");
const num = Number(ler());

const result = somarAteN(num);
console.log(`A soma de 1 até ${num} é: ${result}.`);




function somarAteN(n) {
    let soma = 0;

    for (let i = 1; i <= 5; i++) {
        soma += i;
    }

    return soma;
}