
function cifra_de_cesar(texto, chave) {
    let resultado = '';
    const alfabeto = 'abcdefghijklmnopqrstuvwxyz';

    for(let i = 0; i < texto.length; i++) {
        for(let j = 0; j < alfabeto.length; j++) {
            if (texto[i] === alfabeto[j]) {
                let posicaoNova = (j + chave) % alfabeto.length;
                resultado += alfabeto[posicaoNova];
            }
        }
    }
    return resultado;
}

function main () {
    const texto = 'teste';
    const chave = 3;
    const resultado = cifra_de_cesar(texto, chave);
    console.log(`Texto original: ${texto}`);
    console.log(resultado);
}