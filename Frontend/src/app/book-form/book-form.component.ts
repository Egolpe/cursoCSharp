import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Book } from '../models/book.model';
import { BookService } from '../services/book.service';

@Component({
  selector: 'app-book-form',
  templateUrl: './book-form.component.html',
  styleUrls: ['./book-form.component.css']
})
export class BookFormComponent implements OnInit {

  editForm = this.createFormGroup();
  
  
  constructor(
    private bookService: BookService, 
    private router: Router, 
    private activatedRoute: ActivatedRoute
  ) { }

  ngOnInit(): void {

    //Extraer id de la url 
    this.activatedRoute.paramMap.subscribe(
      {
        next: pmap => {
          let id = pmap.get("id");
          if(id){
            console.log("Existe el Id, es una actualización" + id);
            //recuperar el libro
            this.bookService.findByIdWithInclude(Number(id)).subscribe({
              next: bookFromBackend => {
                this.editForm.reset({
                  id: { value: bookFromBackend.id, disable: true },
                  title: bookFromBackend.title,
                  price: bookFromBackend.price,
                   isbn: bookFromBackend.isbn,
                   description: bookFromBackend.description
                })
              },
              error: err => console.log(err)
            });
            
          }else{
            console.log("No existe el IdleDeadline, esto es una creación");
          }

        }
        
      }
    );
  }
  
  
  

  createFormGroup(){
    return new FormGroup({
      id: new FormControl(),
      isbn: new FormControl(),
      title: new FormControl(),
      releaseYear: new FormControl(),
      price: new FormControl(),
      description: new FormControl(),
    })
  }
  save() {

   let book = { 
    
    title: this.editForm.get("title")?.value,
    isbn: this.editForm.get("isbn")?.value,
    releaseYear: this.editForm.get("releaseYear")?.value,
    price: this.editForm.get("price")?.value,
    }as any;


    let id = this.editForm.get("id")?.value;
    if(book.id){
      book.id = id;
    this.bookService.update(book).subscribe({
      next: response => this.navigateToList(),
      error: err => console.log(err)
    });
    }else {
      this.bookService.create(book).subscribe({
        next: response => this.navigateToList(),
        error: err => console.log(err)
      });
    }
  }

  private navigateToList(){
    this.router.navigate(["/books"]);
  }
}
