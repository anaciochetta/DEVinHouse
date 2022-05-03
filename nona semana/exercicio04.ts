class Filme {
  nome: string;
  anoDeLancamento: number;
  diretor: string;
}

const shrek2 = new Filme();

shrek2.nome = "Shrek 2";
shrek2.anoDeLancamento = 2004;
shrek2.diretor = "Andrew Adamson, Kelly Asbury e Conrad Vernon";

console.log(
  "O filme, " +
    shrek2.nome +
    " lançou em " +
    shrek2.anoDeLancamento +
    ". Os diretores são " +
    shrek2.diretor +
    ". Sendo o melhor filme do Shrek feito."
);
