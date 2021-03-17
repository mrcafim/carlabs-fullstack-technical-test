import { Product } from "./menu.model";

export class CreateOrder {

    constructor(tableId, productId) {
        this.Table = tableId;
        this.ProductId = productId;
    }

    Table: number;
    ProductId: string;
}


export class Order {

    static parse(data: any) {
        let order = Object.assign(new Order(), data);
        return order;
    }
    
    Id: string;
    TableNumber: number;
    ProductId: string;
    Product: Product;
}