import { IOpcao } from './opcao.model';

export interface ICardapio extends IOpcao {
  descricao: string;
  preco: string;
}
