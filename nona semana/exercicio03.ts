let aluno: {
  nome: string;
  matricula: number;
  ativo: boolean;
  cadeiras: string[];
};

aluno.nome = "Ana Ciochetta";
aluno.matricula = 18101484;
aluno.ativo = true;
aluno.cadeiras = [
  "Arquitetura da Informação",
  "Mineração de Texto",
  "Estatística",
  "Marketing da Informação",
  "História do Brasil",
];

console.log(aluno);
