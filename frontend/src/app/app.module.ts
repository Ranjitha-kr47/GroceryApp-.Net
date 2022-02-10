import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductListComponent } from './product-list/product-list.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http'
import { ProductService } from './Service/product.service';
import { ProductDetailsComponent } from './Component/product-detail/product-detail.component';
import { ProductCategoryMenuComponent } from './Component/product-category-menu/product-category-menu.component';
import { CartStatusComponent } from './Component/cart-status/cart-status.component';
import { CartDetailsComponent } from './Component/cart-details/cart-details.component';
import { CheckoutComponent } from './Component/checkout/checkout.component';
import { SearchComponent } from './Component/search/search.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ContactComponent } from './Component/contact/contact.component';
import { AboutComponent } from './Component/about/about.component';
import { PrivacyComponent } from './Component/privacy/privacy.component';
import { LoginComponent } from './Component/login/login.component';
import { LoginStatusComponent } from './Component/login-status/login-status.component';
import { JwtModule } from '@auth0/angular-jwt';



// import { AuthenticationService } from './Service/authentication.service';
import { Router } from '@angular/router';
import { OrderHistoryComponent } from './Component/order-history/order-history.component';
import { HomeComponent } from './Component/home/home.component';
import { Authguard } from './config/authguard';
import { LoginHeaderComponent } from './Component/login-header/login-header.component';

export function tokenGetter() {
  return localStorage.getItem("jwt");
}


@NgModule({
  declarations: [
    AppComponent,
    ProductListComponent,
    ProductDetailsComponent,
    ProductCategoryMenuComponent,
    CartStatusComponent,
    CartDetailsComponent,
    CheckoutComponent,
    SearchComponent,
    ContactComponent,
    AboutComponent,
    PrivacyComponent,
    LoginComponent,
    LoginStatusComponent,
    OrderHistoryComponent,
    HomeComponent,
    LoginHeaderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    NgbModule,
    FontAwesomeModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        whitelistedDomains: ["localhost:5000"],
        blacklistedRoutes: []
      }
    })  
  ],
  providers: [ProductService,Authguard],
  bootstrap: [AppComponent]
})
export class AppModule { }
