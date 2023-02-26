import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../models/user.model';
import { CrudService } from './crud.service';

@Injectable({
  providedIn: 'root'
})
export class UserService extends CrudService<User> {

  constructor(
    httpClient: HttpClient
  ) {
    super(httpClient, "User");
  }


  login(email:string, password:string) {
    const params = new HttpParams()
      .append("email", email)
      .append("password", password);
    return this._httpClient.get<any>(this.baseRoute + 'Login', {observe: "body", responseType:"json", params:params})
  }


}

