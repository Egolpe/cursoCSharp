import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Book } from '../models/book.model';
import { BookService } from '../services/book.service';

@Component({
  selector: 'app-book-detail',
  templateUrl: './book-detail.component.html',
  styleUrls: ['./book-detail.component.css']
})
export class BookDetailComponent implements OnInit {
  book: Book = {
    id: 1,
    title: "angular", 
    author: "Author 1", 
    price: 9.99, 
    description: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
  };
  
  constructor(private activatedRoute: ActivatedRoute, 
    private service: BookService,
    private router: Router
    ) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(
      {
        next: pmap => this.findById(pmap.get("id")),
        error: err => console.log(err)
      }
    );
  }

  private findById(id:string | number | null){
    this.service.findByIdWithInclude(Number(id)).subscribe(
      {
        next: bookFromBackend => this.book = bookFromBackend,
        error: err => console.log(err)
      }
    )
  }

  onDelete(id: number) {
    console.log(id)
    this.service.deleteById(id).subscribe(
     {
      next: response => this.navigateToList() ,
      error: err => console.log(err)
    }
    );
  }

  private navigateToList(){
    this.router.navigate(["/books"]);
  }

 

}
