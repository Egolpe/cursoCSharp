import { Component, OnInit } from '@angular/core';
import { Book } from '../models/book.model';
@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  books: Book[] = [
    {id: 1, title: "Angular", author: "google", price: 100, description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
    {id: 2, title: "CSharp", author: "Adecco", price: 54.33, description: "lorem Ipsum"},
    {id: 3, title: "React", author: "facebook", price: 90 },
  ];
  
  columnNames: string[] = ['Identificador', 'Título', 'Autor', 'Precio', 'Acciones']; 
  constructor() { }

  ngOnInit(): void {
  }

}
