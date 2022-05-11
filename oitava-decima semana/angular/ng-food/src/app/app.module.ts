import { Component, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { ContentComponent } from './components/content/content.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { Route, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { BebidasComponent } from './pages/bebidas/bebidas.component';
import { ComidasComponent } from './pages/comidas/comidas.component';
import { ItemCardapioComponent } from './components/item-cardapio/item-cardapio.component';
import { PedidosComponent } from './pages/pedidos/pedidos.component';

const ROUTES: Route[] = [
  {
    path: '', //sem nada pois entra na página principal, sem o / alguma coisa
    component: HomeComponent,
  },
  {
    path: 'sobre',
    component: AboutComponent,
  },
  {
    path: 'comidas',
    component: ComidasComponent,
  },
  {
    path: 'bebidas', //caminho na url
    component: BebidasComponent, //qual caminho deve chegar
  },
  {
    path: 'pedidos',
    component: PedidosComponent,
  },
];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    ContentComponent,
    HomeComponent,
    AboutComponent,
    BebidasComponent,
    ComidasComponent,
    ItemCardapioComponent,
    PedidosComponent,
  ],
  imports: [BrowserModule, HttpClientModule, RouterModule.forRoot(ROUTES)],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
