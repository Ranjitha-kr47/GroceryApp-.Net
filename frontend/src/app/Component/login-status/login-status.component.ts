import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { OktaAuthService } from '@okta/okta-angular';
import { Register } from 'src/app/models/Register';
import { FormService } from 'src/app/Service/form.service';
import { LoginService } from 'src/app/Service/login.service';

@Component({
  selector: 'app-login-status',
  templateUrl: './login-status.component.html',
  styleUrls: ['./login-status.component.css']
})
export class LoginStatusComponent implements OnInit {


  formGroup: FormGroup;
  register: Register = new Register;


  constructor(private loginService: LoginService,
    private formService: FormService,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router) { }


    ngOnInit(): void {
    }

  Register() {
    this.loginService.Register(this.register).subscribe(
      (resp) => {
        console.log(resp);
        this.router.navigate(["/login"]);
      },
      (error) => {
        console.log(error.error);
      }
    );

  }
  onFormSubmit() {
    console.log(this.register);
    this.Register();
  }
  // resetForm(userForm:NgForm){
  //   userForm.resetForm();
  // }
}