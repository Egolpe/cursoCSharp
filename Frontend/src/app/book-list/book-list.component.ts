import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book.model';
@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  books: Book[] = [
    {id: 1, title: "Angular", author: "google", price: 100},
    {id: 2, title: "CSharp", author: "Adecco", price: 54.33},
    {id: 3, title: "React", author: "facebook", price: 90 },
  ];
  
  columnNames: string[] = ['Identificador', 'Título', 'Autor', 'Precio', 'Acciones']; 
  constructor() { }

  ngOnInit(): void {
  }

}
