import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient) { }
  registerMode = false;
  values: any;
 
  ngOnInit() {
    this.getValues();
  }

  register() {
    this.registerMode = true;
  }

  cancel(cancelVal: boolean) {
    console.log('111: ' + cancelVal);
    this.registerMode = false;
  }
  getValues() {
    this.http.get('http://localhost:5000/api/Values').subscribe(reponse => { 
      this.values = reponse;
    }
    , error => console.log(error));
     }
}
