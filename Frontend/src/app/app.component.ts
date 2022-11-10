import { Component } from '@angular/core';

export interface Book {
  id: number;
  title: string;
  author: string;
  price: number;
}



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular';
  books: Book[] = [
    {id: 1, title: "Angular", author: "google", price: 100},
    {id: 2, title: "CSharp", author: "Adecco", price: 54.33},
    {id: 3, title: "React", author: "facebook", price: 90 },
  ];
  
  columnNames: string[] = ['Identificador', 'Título', 'Autor', 'Precio']; 




  onClick() {
    this.title = "titulo cambiado desde un boton"
  }
}
