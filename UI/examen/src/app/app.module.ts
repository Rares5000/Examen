import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar/navbar.component';
import { AddAutorComponent } from './features/autor/add-autor/add-autor/add-autor.component';
import { AutorListComponent } from './features/autor/autor-list/autor-list/autor-list.component';
import { AddCarteComponent } from './features/carte/add-carte/add-carte/add-carte.component';
import { CarteListComponent } from './features/carte/carte-list/carte-list/carte-list.component';
import { AddEdituraComponent } from './features/editura/add-editura/add-editura/add-editura.component';
import { EdituraListComponent } from './features/editura/editura-list/editura-list/editura-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    AddAutorComponent,
    AutorListComponent,
    AddCarteComponent,
    CarteListComponent,
    AddEdituraComponent,
    EdituraListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
