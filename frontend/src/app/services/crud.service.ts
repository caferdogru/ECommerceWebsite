import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export abstract class CrudService<Model> {

  baseRoute: string = `https://localhost:44314/${this.modelUrl}/`


  constructor(
    protected _httpClient: HttpClient,
    protected modelUrl:string
  ) {

  }


  create(model: Model) {
    return this._httpClient.post<Model>(this.baseRoute + "Create", model)
  }

  update(model: Model) {
    return this._httpClient.post<Model>(this.baseRoute + "Update", model)
  }

  delete(id: number) {
    let params = new HttpParams().append("id", id.toString());
    return this._httpClient.delete<Model>(this.baseRoute + "Delete", {observe:"body", responseType:"json", params:params});
  }

  get(id: number) {
    let params = new HttpParams().append("id", id.toString());
    return this._httpClient.get<Model>(this.baseRoute + "Get", { observe: "body", responseType: "json", params: params });
  }

  getAll() {
    return this._httpClient.get<Model[]>(this.baseRoute + "GetAll", { observe: "body", responseType: "json" });

  }






}
