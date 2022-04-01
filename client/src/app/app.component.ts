import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  users: any;

  constructor(private http: HttpClient){}

  ngOnInit() {
   
   this.getUsers();
    
  }

  getUsers(){
    

    this.http.get('https://localhost:5001/api/users').subscribe(x=>{
      this.users = x;
    
    });

   }

   
  

 
}
