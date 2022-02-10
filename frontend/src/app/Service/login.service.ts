import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Register } from '../models/Register';
import { BehaviorSubject, throwError } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private baseUrl = 'https://localhost:5001/api/Authentication';

  // invalidLogin: boolean;
  isLoggedIn = new BehaviorSubject(false);
  errorData: {};

  constructor(private httpClient: HttpClient,
    private router: Router) { }

  Register(register: Register): Observable<any> {
    return this.httpClient.post(`${this.baseUrl}`, register);
  }
  GetUser():Observable<any>{
    return this.httpClient.get<any>(`${this.baseUrl}/get`);
  }
  
  logout(){
    localStorage.removeItem("jwt");
    this.isLoggedIn.next(false);
    this.router.navigate(['/login'])
  }

}
