class Animal {
  nome: string;
  raca: string;
  corPelagem: string;
  peso: number;

  constructor(nome: string, raca: string, pelo: string, peso: number) {
    this.nome = nome;
    this.raca = raca;
    this.corPelagem = pelo;
    this.peso = peso;
  }
}

let vaca = new Animal("Mimosa", "Vacona", "Malhada", 345);
