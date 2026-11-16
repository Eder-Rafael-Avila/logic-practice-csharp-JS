import prompt from 'prompt-sync';
let ler = prompt();

console.log("MAIOR NÚMERO DA LISTA\n");

console.log("Quantos números você deseja inserir?");
const qtdNumeros = Number(ler());

const listaNum = [];
pedirNumeros(qtdNumeros, listaNum);

exibirNumeros(listaNum);
console.log(`\nO maior número da lista é: ${maiorDaLista(listaNum)}.`);




function exibirNumeros(array) {
    for (let num of array) {
        process.stdout.write(`${num} `);
    }
}

function pedirNumeros(qtd, array) {
    for (let i = 0; i < qtd; i++) {
        console.log('Insira um número: ');
        array.push(Number(ler()));
        console.log("");
    }
}

function maiorDaLista(lista) {
    let maior = lista[0];

    for (let pos of lista) {
        if (maior < pos) {
            maior = pos;
        };
    }

    return maior;
}