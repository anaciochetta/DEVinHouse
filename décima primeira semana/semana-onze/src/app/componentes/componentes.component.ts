import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'smo-componentes',
  templateUrl: './componentes.component.html',
  styleUrls: ['./componentes.component.scss'],
})
export class ComponentesComponent implements OnInit {
  tamanhoFonte: number = 0;

  constructor() {}

  ngOnInit(): void {}
}
