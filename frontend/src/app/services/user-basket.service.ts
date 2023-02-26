import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserBasket } from '../models/user-basket';
import { CrudService } from './crud.service';

@Injectable({
  providedIn: 'root'
})
export class UserBasketService extends CrudService<UserBasket>{

  constructor(
    httpClient: HttpClient
  ) {
    super(httpClient, "UserBasket");
  }

}