import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';

@Component({
  selector: 'ngf-item-cardapio',
  templateUrl: './item-cardapio.component.html',
  styleUrls: ['./item-cardapio.component.scss'],
})
export class ItemCardapioComponent implements OnInit {
  constructor() {}

  quantidade: number = 0;

  @Input() //decorator in a child component or directive signifies that the property can receive its value from its parent component
  itemCardapio?: ICardapio;

  @Output() adicionaListaPedido = new EventEmitter();
  ngOnInit(): void {}

  addListaPedido() {
    const itemQuantidade = {
      item: this.itemCardapio,
      quantidade: this.quantidade,
    };
    this.adicionaListaPedido.emit(itemQuantidade);
  }

  maisQuantidade() {
    this.quantidade = this.quantidade + 1;
  }

  menosQuantidade() {
    this.quantidade = this.quantidade - 1;
  }
}
