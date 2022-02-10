import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginService } from 'src/app/Service/login.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  invalidLogin: boolean;
  constructor(private httpClient: HttpClient,
    private router: Router,
    private loginService: LoginService) { }

    ngOnInit(): void {
    }
    login(form: NgForm) {
      const credentials = JSON.stringify(form.value);
      this.httpClient.post("https://localhost:5001/api/Authentication/login", credentials, {
        headers: new HttpHeaders({
          "Content-Type": "application/json"
        })
      })
    .subscribe(response => {
        const token = (<any>response).token;
        localStorage.setItem("jwt", token);
        this.invalidLogin = false;
        this.router.navigate(["/home"]);
      }, err => {
        this.invalidLogin = true;
        console.log(err);
      });
  
    }

}