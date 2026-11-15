import prompt from 'prompt-sync';
let ler = prompt();

console.log("CONTAGEM DE 1 ATÉ N.");

console.log("Digite um número: ");
const num = Number(ler());

contar(num);





function contar(n) {
    for (let i = 1; i <= 5; i++) {
        process.stdout.write(`${i} `);
    }
}