import prompt from 'prompt-sync';
let ler = prompt();

console.log("CONTAGEM DE OCORRÊNCIAS DE UMA LISTA\n");

console.log("Quantos números terá a lista?");
const qtdNumeros = Number(ler());
console.log("");

const lista = [];
pedirNumeros(qtdNumeros, lista);

console.log("\nQual número você deseja verificar?");
const valor = Number(ler().replace(",", "."));

const ocorrencias = verificarOcorrencias(valor, lista);
console.log(`\n${lista}`)
console.log(`O número ${valor} aparece ${ocorrencias} vezes.`);








function pedirNumeros(qtd, lista) {
    for (let i = 0; i < qtd; i++) {
        process.stdout.write("Insira um número: ");
        lista.push(Number(ler().replace(",", ".")));
        console.log("");
    }
}

function verificarOcorrencias(valor, lista) {
    let ocorrencias = 0;

    for (let pos of lista) {
        if (pos === valor) {
            ocorrencias++;
        }
    }

    return ocorrencias;
}