import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Product } from 'src/app/models/menu.model';
import { Order } from 'src/app/models/order.model';
import { RestaurantClientService } from 'src/app/services/restaurant-client.service';

@Component({
  selector: 'app-bill',
  templateUrl: './bill.component.html',
  styleUrls: ['./bill.component.css']
})
export class BillComponent implements OnInit {

  ordersList: Order[] = [];
  tableId: number; 
  search: string = '';
  error: string = '';
  pagination: number = 0;
  totalBill: string = '';

  constructor(private router: ActivatedRoute,
              private restaurantApi: RestaurantClientService,
              private route: Router) { }

  ngOnInit(): void {
    this.router.params.forEach((params: Params) => {
      this.tableId = +params['tableId'];
      this.restaurantApi.getOrdersByTable(this.tableId)
        .then((res: any) => {
          this.ordersList = res;
        });
      this.restaurantApi.getBill(this.tableId)
        .subscribe((res: any) => {
          this.totalBill = res._body;
        });
    })
  }

}
