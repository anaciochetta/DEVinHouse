import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/assets/exercicio09';

@Component({
  selector: 'exemp-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit, Produto {
  title = 'exercicio-app';

  valorTotal: number = 0;
  nome: string;
  valor: number;
  codigo: number;
  quantidade: number;
  emEstoque: boolean;

  comprar?(produto: Produto, quantidade: number) {
    if (produto.emEstoque) {
      //em estoque = true
      this.valorTotal = produto.valor * quantidade;
      produto.quantidade - quantidade;
    }
  }

  constructor() {}

  sofa: Produto = {
    nome: 'Sofá 4 lugares',
    valor: 120,
    codigo: 1,
    quantidade: 30,
    emEstoque: true,
  };

  ngOnInit(): void {
    this.comprar(this.sofa, 10);
  }
}
