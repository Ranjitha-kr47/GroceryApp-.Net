import { Injectable } from "@angular/core";
import { CanActivate, Router } from "@angular/router";
import { JwtHelperService } from "@auth0/angular-jwt";
import { FormService } from "../Service/form.service";


@Injectable({
    providedIn: 'root' // ADDED providedIn root here.
  })
export class Authguard implements CanActivate {

    constructor(private jwtHelper: JwtHelperService, private router: Router, private formService: FormService) {
    }
      canActivate(){
      const token = localStorage.getItem("jwt");
      if (token && !this.jwtHelper.isTokenExpired(token)){
            this.jwtHelper.decodeToken(token)
            //console.log(this.jwtHelper.decodeToken(token));
          return true;
        }
        alert("please sign-in to access the app");
        this.router.navigate(["/login"]);
        return false;
    }
}
