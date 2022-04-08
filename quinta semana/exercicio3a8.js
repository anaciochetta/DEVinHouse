class Produtos {
  nome;
  preco;
  emEstoque;
  quantidade;

  constructor(nome, preco, emEstoque, quantidade) {
    this.nome = nome;
    this.preco = preco;
    this.emEstoque = emEstoque;
    this.quantidade = quantidade;
  }
}

class Pedidos {
  numeroPedido;
  dataPedido;
  estaPago;
  listaProdutos;
  nomeCliente;

  constructor(numeroPedido, nomeCliente) {
    this.dataPedido = new Date().toLocaleDateString();
    this.estaPago = false;
    this.listaProdutos = [];
    this.numeroPedido = numeroPedido;
    this.nomeCliente = nomeCliente;
  }

  adcionarProduto(produto) {
    this.listaProdutos.push(produto);
  } //adciona produtos dentro da lista de produtos

  calcularTotal() {
    let valorTotal = 0;
    this.listaProdutos.forEach((produto) => {
      valorTotal += produto.quantidade * produto.preco;
    });
    return valorTotal;
  }
}
const arroz = new Produtos("arroz", 5, true, 20);
const abobrinha = new Produtos("abobrinha", 1.5, true, 20);
const feijao = new Produtos("feijao", 10, true, 15);
const brocolis = new Produtos("brocolis", 4.4, true, 5);
const maionese = new Produtos("maionese", 8, true, 50);

const meuPedido = new Pedidos(20220001, "ana");
const outroPedido = new Pedidos(20220002, "fábio");

meuPedido.adcionarProduto(arroz, feijao, maionese);
outroPedido.adcionarProduto(brocolis, abobrinha);

console.log(meuPedido);
console.log(outroPedido);

meuPedido.listaProdutos.forEach((produto) =>
  console.log(
    `Produto: ${produto.nome} | Valor un: ${produto.preco} | Total: ${
      produto.preco * produto.quantidade
    }`
  )
);
console.log(
  `Preço total do Pedido de ${
    meuPedido.nomeCliente
  }: R$${meuPedido.calcularTotal()}`
);
