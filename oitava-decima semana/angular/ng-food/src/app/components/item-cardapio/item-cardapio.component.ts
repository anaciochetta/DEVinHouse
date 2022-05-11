import { Component, Input, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/lista.model';
import { IOpcao } from 'src/app/models/opcao.model';

@Component({
  selector: 'ngf-item-cardapio',
  templateUrl: './item-cardapio.component.html',
  styleUrls: ['./item-cardapio.component.scss'],
})
export class ItemCardapioComponent implements OnInit {
  constructor() {}

  @Input() //decorator in a child component or directive signifies that the property can receive its value from its parent component
  itemCardapio?: ICardapio;

  ngOnInit(): void {}
}
