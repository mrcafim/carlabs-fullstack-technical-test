import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions } from '@angular/http';
import { Menu } from '../models/menu.model';
import { CreateOrder, Order } from '../models/order.model';

@Injectable()
export class RestaurantClientService {
  private baseURL: string = "https://localhost:44311/";

  constructor(private http: Http) { }

  getMenuByType(type: number): Promise<Menu> {
    return this.http.get(`${this.baseURL}menu/menutype/${type}`)
      .toPromise()
      .then(response => {
        return Menu.parse(response.json());
      })
      .catch(error => {
        console.error('An error occured: ', error.statusText);
        return Promise.reject(error.statusText || error);
      })
  }

  getOrdersByTable(tableId: number): Promise<any> {
    return this.http.get(`${this.baseURL}order/table/${tableId}`)
      .toPromise()
      .then(response => {
        return response.json();
      })
      .catch(error => {
        console.error('An error occured: ', error.statusText);
        return Promise.reject(error.statusText || error);
      })
  }
  
  getBill(tableId: number){
    return this.http.get(`${this.baseURL}order/bill/${tableId}`);
  }

  postOrder(orderData: CreateOrder){
    return this.http.post(`${this.baseURL}order`, orderData);
  }
}
