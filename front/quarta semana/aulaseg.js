var pessoas = [{ nome: 'teste' }, { nome: 'teste2' }]; //4

pessoas.forEach(function (pessoa) {
  console.log(pessoa.nome);
});


var contador = 0;
var entrar = true;

do {
  console.log('contador', contador);
  contador++;
  if (contador === 10) {
    entrar = false;
  }
} while (entrar);