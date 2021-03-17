import { MealType, ProductType } from "./enum.model";

export class Menu {
    Id: string = '';
    Type: MealType = '';
    Products: Product[] = [];

    static parse(data: any) {
        let menu = Object.assign(new Menu(), data);
        return menu;
    }
}

export class Product {
    Id: string = '';
    Description: string = '';
    Type: ProductType;
    Price: number = 0;
}


