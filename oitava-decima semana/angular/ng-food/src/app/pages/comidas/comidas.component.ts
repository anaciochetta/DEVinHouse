import { Component, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';
import { ComidasService } from 'src/app/services/comidas.service';
import { PedidoService } from 'src/app/services/pedido.service';

@Component({
  selector: 'ngf-comidas',
  templateUrl: './comidas.component.html',
  styleUrls: ['./comidas.component.scss'],
})
export class ComidasComponent implements OnInit {
  listaComidas: ICardapio[] = []; //faz a lista com o modelo do cardapio

  constructor(
    private comidaService: ComidasService,
    private pedidoService: PedidoService
  ) {} //usa o serviço na variável

  ngOnInit(): void {
    this.buscarComidas(); //faz aparecer na tela quando inicia
  }

  buscarComidas() {
    this.comidaService.devolverComidas().subscribe((resultado) => {
      this.listaComidas = resultado;
    }); //busca no fakebackend
  }

  addComida(comida: any) {
    this.pedidoService.addItensPedido(comida.item, comida.quantidade);
  }
}
