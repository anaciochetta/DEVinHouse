import { Component, OnInit } from '@angular/core';
import { PedidoService } from 'src/app/services/pedido.service';

@Component({
  selector: 'ngf-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit {
  quantidadePedidos: number = 0;

  constructor(private pedidoService: PedidoService) {}

  ngOnInit(): void {
    this.quantidadePedidos = this.pedidoService.pegarTotalItensPedido();
  }

  buscarTotalItem() {
    return this.pedidoService.pegarTotalItensPedido();
  }
}
