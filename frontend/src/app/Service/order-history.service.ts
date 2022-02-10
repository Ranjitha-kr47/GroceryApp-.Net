
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../models/order';
import { OrderHistory } from '../models/orderhistory';


@Injectable({
  providedIn: 'root'
})
export class OrderHistoryService {

  private orderUrl = 'https://localhost:5001/api/Order';

  constructor(private httpClient: HttpClient) { }

  getOrderHistory(theEmail: string): Observable<GetResponseOrderHistory> {

    // need to build URL based on the customer email
    const orderHistoryUrl = `${this.orderUrl}/findByEmail/${theEmail}`;

    return this.httpClient.get<GetResponseOrderHistory>(orderHistoryUrl);
  }
}

interface GetResponseOrderHistory {
  _embedded: {
    orders: OrderHistory[];
  }
}
