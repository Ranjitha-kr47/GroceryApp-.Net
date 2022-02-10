import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';
import { ProductService } from 'src/app/Service/product.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CartService } from 'src/app/Service/cart.service';
import { CartItem } from 'src/app/models/cart-item';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailsComponent implements OnInit {

  products: Product = new Product();

  constructor(private productService: ProductService,
    private cartService: CartService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(() => {
    this.handleProductDetails();
    })

  }

  handleProductDetails() {

    const theProductId: number = +this.route.snapshot.paramMap.get('id');

    this.productService.getProduct(theProductId).subscribe(data => {
      this.products = data;
      console.log(data);
    });
  }

  addToCart() {

    console.log(`Adding to cart: ${this.products[0].name}, ${this.products[0].unit_Price}`);
    const theCartItem = new CartItem(this.products[0]);
    this.cartService.addToCart(theCartItem);

  }

  // backToList(){
  //   this.router.navigate(['/products']);
  // }

}