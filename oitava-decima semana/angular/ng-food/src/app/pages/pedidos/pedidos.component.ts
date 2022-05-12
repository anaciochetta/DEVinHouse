import { Component, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';
import { PedidoService } from 'src/app/services/pedido.service';

@Component({
  selector: 'ngf-pedidos',
  templateUrl: './pedidos.component.html',
  styleUrls: ['./pedidos.component.scss'],
})
export class PedidosComponent implements OnInit {
  listaItensPedido: ICardapio[] = [];

  constructor(private pedidoService: PedidoService) {}

  ngOnInit(): void {
    this.buscarItensPedido();
  }

  buscarItensPedido() {
    this.listaItensPedido = this.pedidoService.buscarItensPedido();
  } //atribui aos pedidos para a tela}

  removerItem(item: ICardapio) {
    this.pedidoService.removerItemPedido(item.id);
    this.buscarItensPedido();
  }

  apagarTudo() {
    this.pedidoService.limparPedido();
    this.buscarItensPedido();
  }
}
