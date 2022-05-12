import { Component, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';
import { BebidasService } from 'src/app/services/bebidas.service';
import { PedidoService } from 'src/app/services/pedido.service';

@Component({
  selector: 'ngf-bebidas',
  templateUrl: './bebidas.component.html',
  styleUrls: ['./bebidas.component.scss'],
})
export class BebidasComponent implements OnInit {
  listaBebidas: ICardapio[] = [];

  constructor(
    private bebidaService: BebidasService,
    private pedidoService: PedidoService
  ) {}
  ngOnInit(): void {
    this.buscarBebidas();
  }

  buscarBebidas() {
    this.bebidaService.devolverBebidas().subscribe((resultado) => {
      this.listaBebidas = resultado;
    });
  }

  addBebida(bebida: ICardapio) {
    this.pedidoService.addItemPedido(bebida);
  }
}
