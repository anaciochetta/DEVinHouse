class Conta {
  protected numeroConta: number;
  protected saldo: number;
  protected estaAtivo: boolean;
  protected dono: string;

  constructor(numero: number, saldo: number, ativado: boolean, dono: string) {
    this.numeroConta = numero;
    this.saldo = saldo;
    this.estaAtivo = ativado;
    this.dono = dono;
  }
}

class ContaEmpresa extends Conta {
  private limiteDeDeposito: 1000;
  constructor(numero: number, saldo: number, ativado: boolean, dono: string) {
    super(numero, saldo, ativado, dono);
  }
  deposito(valor: number) {
    if (valor > this.limiteDeDeposito) {
      let novoSaldo: number = valor + this.saldo;
      novoSaldo = this.saldo;
      this.imprimeValorConta(novoSaldo);
    } else {
      console.log("Valor maior que o permitido para depósito!");
    }
  }
  imprimeValorConta(saldo: number) {
    console.log("Seu saldo é de: ", saldo);
  }
}

let contaUm = new ContaEmpresa(12, 12.45, true, "Casa da pintura");
contaUm.deposito(3500);

contaUm.deposito(1000);
contaUm.deposito(1000);
contaUm.deposito(1000);
contaUm.deposito(500);
