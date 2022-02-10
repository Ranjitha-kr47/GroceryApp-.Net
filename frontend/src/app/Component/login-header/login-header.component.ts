import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { Register } from 'src/app/models/Register';
import { LoginService } from 'src/app/Service/login.service';

@Component({
  selector: 'app-login-header',
  templateUrl: './login-header.component.html',
  styleUrls: ['./login-header.component.css']
})
export class LoginHeaderComponent implements OnInit {
  isinvalidlogin: boolean = false;
  register: Register;
  userFullName: string;
  theEmail :string;
  loggedIn$: Subscription;

  storage: Storage = localStorage;


  constructor(private loginService: LoginService) { }

  ngOnInit(): void {
    // this.invalidLogin=this.loginService.getInvalidLogin();
    this.loggedIn$ = this.loginService.isLoggedIn.subscribe(
      value => this.isinvalidlogin = !value
    );
    // this.getUserDetails();

    // this.loginService.isLoggedIn.subscribe(
    //   (result) => {
    //     this.invalidlogin = result;
    //     this.getUserDetails();
    //   }
    // );
  }
  // getUserDetails() {
  //   if (this.isinvalidlogin) {

  //     // Fetch the logged in user details (user's claims)
  //     //
  //     // user full name is exposed as a property name
  //     this.loginService.GetUser().subscribe(
  //       (res) => {
  //         this.userFullName = res.firstName;

  //         // retrieve the user's email from authentication response
  //         this.theEmail = res.Email;

  //         // now store the email in browser storage
  //         this.storage.setItem('userEmail', this.theEmail);
  //       }
  //     );
  //   }
  // }

  logout() {
    this.loginService.logout();
  }

}
