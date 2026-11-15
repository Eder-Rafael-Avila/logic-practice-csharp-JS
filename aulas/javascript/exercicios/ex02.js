import prompt from 'prompt-sync';
let ler = prompt();

console.log("MÉDIA DE DUAS NOTAS\n");

console.log("Insira uma nota: ");
const n1 = Number(ler().replace(",", "."));

console.log("Insira outra nota: ");
const n2 = Number(ler().replace(",", "."));

const media = (n1 + n2) / 2;

console.log(`A média de ${n1} e ${n2} é: ${Math.round(media)}.`);