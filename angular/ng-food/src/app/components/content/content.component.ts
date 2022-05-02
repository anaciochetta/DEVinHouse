import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { INotificacao } from 'src/app/models/notification.model';
import { NOTIFICATIONS_MOCK } from 'src/app/utils/notification-mock';


 
@Component({
  selector: 'ngf-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss']
})
export class ContentComponent implements OnInit {

  listaDeNotificacoes: INotificacao[] = []

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get<INotificacao[]>("http://localhost:3000/notificacoes").subscribe((resultado)=> {
      this.listaDeNotificacoes = resultado
    })
  }

  chamarClique(){
    alert("item clicado")
  }

}
