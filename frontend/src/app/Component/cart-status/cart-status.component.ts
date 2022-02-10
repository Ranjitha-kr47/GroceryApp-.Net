  
import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/Service/cart.service';
import { LoginService } from 'src/app/Service/login.service';

@Component({
  selector: 'app-cart-status',
  templateUrl: './cart-status.component.html',
  styleUrls: ['./cart-status.component.css']
})
export class CartStatusComponent implements OnInit {

  totalPrice: number = 0.00;
  totalQuantity: number = 0;
  isLoggedIn:Boolean=false;
  loginSubscription$;

  constructor(private cartService: CartService,
    private loginService:LoginService) { }

  ngOnInit(): void {
    this.loginSubscription$=this.loginService.isLoggedIn.subscribe(value=>{
      this.isLoggedIn=value;
      if(!this.isLoggedIn){
        this.totalPrice=0.00;
        this.totalQuantity=0;
      }
    })
    this.updateCartStatus();
  }

  updateCartStatus() {

    // subscribe to the cart totalPrice
    this.cartService.totalPrice.subscribe(
      data => this.totalPrice = data
    );

    // subscribe to the cart totalQuantity
    this.cartService.totalQuantity.subscribe(
      data => this.totalQuantity = data
    );

  }

}