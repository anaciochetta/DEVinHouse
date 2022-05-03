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

const ROUTES: Route[] = [
  {
    path: '',
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
    path: 'bebidas',
    component: BebidasComponent,
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
  ],
  imports: [BrowserModule, HttpClientModule, RouterModule.forRoot(ROUTES)],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
