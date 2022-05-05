import { Pessoa } from "./outro-arquivo";

class Aluno implements Pessoa {
  nome: string;
  idade: number;
  rua: string;
  matricula: number;
  cadeira: string[];

  constructor(
    nome: string,
    idade: number,
    rua: string,
    matricula: number,
    cadeira: string[]
  ) {
    this.nome = nome;
    this.idade = idade;
    this.rua = rua;
    this.matricula = matricula;
    this.cadeira = cadeira;
    this.cadastrar();
  }

  cadastrar() {
    console.log("Nome: ", this.nome);
    console.log("Idade: ", this.idade);
    console.log("Rua: ", this.rua);
    console.log("Matrícula: ", this.matricula);
    console.log("Cadeiras: ", this.cadeira);
  }
}

class Funcionario implements Pessoa {
  nome: string;
  idade: number;
  rua: string;
  identificador: number;
  setor: string;
  constructor(
    nome: string,
    idade: number,
    rua: string,
    identificador: number,
    setor: string
  ) {
    this.nome = nome;
    this.idade = idade;
    this.rua = rua;
    this.identificador = identificador;
    this.setor = setor;
    this.cadastrar();
  }
  cadastrar() {
    console.log("Nome: ", this.nome);
    console.log("Idade: ", this.idade);
    console.log("Rua: ", this.rua);
    console.log("Setor: ", this.setor);
    console.log("Identificador", this.identificador);
  }
}

let pessoa1 = new Aluno("Ana", 22, "Adolfo Konder", 18101484, [
  "Magia",
  "Programação",
  "Jogos",
  "Soninho",
]);

let pessoa2 = new Funcionario("Fábio", 34, "Martins Costa", 123, "TI");
