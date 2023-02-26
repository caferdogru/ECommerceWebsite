import { HttpClient, HttpParams } from '@angular/common/http';
import { BoundElementProperty } from '@angular/compiler';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';
import { CrudService } from './crud.service';

@Injectable({
  providedIn: 'root'
})
export class ProductService extends CrudService<Product> {

  constructor(
    httpClient: HttpClient
  ) {
    super(httpClient, "Product");
  }
  

  getByCategory(categoryId: number) {
    const params = new HttpParams().append("categoryId", categoryId.toString());
    return this._httpClient.get<Product[]>(this.baseRoute + "GetProductByCategory", {observe:"body", responseType:"json", params:params});
  }

}
