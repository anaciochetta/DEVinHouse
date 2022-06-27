class Veiculo {
  tipo;
  cor;
  ano = 2012;
  modelo;
  fabricante;
  combustivel = "alcool";
  ativo = true;

  constructor(tipo, outroValor) {
    this.tipo = tipo;
    this.cor = outroValor;

    Object.freeze(this); //trava as propriedades, fica imodificavel
  }

  buzinar() {
    console.log("Bi");
  }
}

const umVeiculo = new Veiculo();

umVeiculo.fabricante = "Fiat";
umVeiculo.modelo = "147";
umVeiculo.ano = 1980;
umVeiculo.cor = "Bege";
umVeiculo.tipo = "Carro";
umVeiculo.potencia = "-1";

const novoVeiculo = new Veiculo();

umVeiculo.buzinar();
