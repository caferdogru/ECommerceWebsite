import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ProductCategory } from '../models/product-category.model';
import { Product } from '../models/product.model';
import { CrudService } from './crud.service';

@Injectable({
  providedIn: 'root'
})
export class ProductCategoryService extends CrudService<ProductCategory> {


  productCategories: ProductCategory[];

  constructor(
    httpClient: HttpClient
  ) {
    super(httpClient, "ProductCategory");
  }


}
