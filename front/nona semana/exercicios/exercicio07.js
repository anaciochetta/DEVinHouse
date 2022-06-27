"use strict";
exports.__esModule = true;
var Aluno = /** @class */ (function () {
    function Aluno(nome, idade, rua, matricula, cadeira) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.matricula = matricula;
        this.cadeira = cadeira;
        this.cadastrar();
    }
    Aluno.prototype.cadastrar = function () {
        console.log("Nome: ", this.nome);
        console.log("Idade: ", this.idade);
        console.log("Rua: ", this.rua);
        console.log("Matrícula: ", this.matricula);
        console.log("Cadeiras: ", this.cadeira);
    };
    return Aluno;
}());
var Funcionario = /** @class */ (function () {
    function Funcionario(nome, idade, rua, identificador, setor) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.identificador = identificador;
        this.setor = setor;
        this.cadastrar();
    }
    Funcionario.prototype.cadastrar = function () {
        console.log("Nome: ", this.nome);
        console.log("Idade: ", this.idade);
        console.log("Rua: ", this.rua);
        console.log("Setor: ", this.setor);
        console.log("Identificador", this.identificador);
    };
    return Funcionario;
}());
var pessoa1 = new Aluno("Ana", 22, "Adolfo Konder", 18101484, [
    "Magia",
    "Programação",
    "Jogos",
    "Soninho",
]);
var pessoa2 = new Funcionario("Fábio", 34, "Martins Costa", 123, "TI");
