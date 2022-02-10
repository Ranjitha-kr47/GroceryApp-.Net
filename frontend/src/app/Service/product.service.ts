import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Product } from '../models/product';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ProductCategory } from '../models/product-category';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private baseUrl = 'https://localhost:5001/api/Product';

  private categoryUrlById = 'https://localhost:5001/api/Product/findByCategoryId';

  private categoryUrl = 'https://localhost:5001/api/Product/product-category';

  private searchByName = 'https://localhost:5001/api/Product/findByNameContaining';



  constructor(private httpClient: HttpClient) { }

  getProduct(theProductId: number): Observable<Product> {

    // need to build URL based on product id
    const productUrl = `${this.baseUrl}/findById/${theProductId}`;

    return this.httpClient.get<Product>(productUrl);
  }

  getProductListPaginate(theCategoryId: number): Observable<Product[]> {
    // thePage: number, 
    // thePageSize: number, 

    // need to build URL based on category id, page and size 
    const searchUrl = `${this.categoryUrlById}/${theCategoryId}`;
    // + `&page=${thePage}&size=${thePageSize}`;

    return this.httpClient.get<Product[]>(searchUrl);
  }


  // getProductList(theCategoryId: number): Observable<Product[]> {

  //   // need to build URL based on category id 
  //   const searchUrl = `${this.categoryUrlById}/${theCategoryId}`;

  //   return this.getProducts(searchUrl);
  // }

  searchProducts(theKeyword: string): Observable<Product[]> {

    // need to build URL based on the keyword 
    const searchUrl = `${this.searchByName}/${theKeyword}`;

    return this.getProducts(searchUrl);
  }

  searchProductsPaginate(
    theKeyword: string): Observable<Product[]> {
    //   thePage: number, 
    // thePageSize: number, 

    // need to build URL based on keyword, page and size 
    const searchUrl = `${this.searchByName}/${theKeyword}`;
    // + `&page=${thePage}&size=${thePageSize}`;

    return this.httpClient.get<Product[]>(searchUrl);
  }



  private getProducts(searchUrl: string): Observable<Product[]> {
    return this.httpClient.get<Product[]>(searchUrl);
  }

  getProductCategories(): Observable<ProductCategory[]> {

    return this.httpClient.get<ProductCategory[]>(this.categoryUrl);

  }

}

interface GetResponseProducts {
  _embedded: {
    products: Product[];
  },
  // page: {
  //   size: number,
  //   totalElements: number,
  //   totalPages: number,
  //   number: number
}


interface GetResponseProductCategory {
  _embedded: {
    productCategory: ProductCategory[];
  }
}