import { Injectable } from '@angular/core';
import { ICardapio } from '../models/lista.model';

@Injectable({
  providedIn: 'root',
})
export class PedidoService {
  itensPedidoLista: ICardapio[] = [];

  constructor() {}

  pegarTotalItensPedido(): number {
    return this.itensPedidoLista.length;
  }

  addItensPedido(item: ICardapio, quantidade: number) {
    this.itensPedidoLista.push(item);
  }

  limparPedido() {
    this.itensPedidoLista = [];
  }

  removerItemPedido(id: number) {
    const itemIndex = this.itensPedidoLista.findIndex((item) => item.id === id); //busca o id do item

    this.itensPedidoLista.splice(itemIndex, 1); //exclui o item
  }

  buscarItensPedido(): ICardapio[] {
    return this.itensPedidoLista;
  }
}
