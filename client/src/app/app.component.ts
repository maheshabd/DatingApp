import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'DatingApp';
  Users:any;

  constructor(public http: HttpClient) {

  }
  ngOnInit() {
      this.getusers();
  }
  
  getusers(){
    this.http.get('https://localhost:7052/api/Users').subscribe(response =>{
      this.Users = response;
    },error =>{
      console.log(error);
    }
    )
  }
}
