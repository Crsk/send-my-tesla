import { Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Dispatches } from '../models/Dispatches';
import { environment } from 'src/environments/environment.prod';
import { Observable } from 'rxjs';

export class DispatchService {
  private headers: HttpHeaders;
  private accessUrl: string = `${environment.serverUrl}/api/dispatches/`;
  newDispatch: Observable<any>;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  getDispatches() {
    return this.http.get<Dispatches[]>(this.accessUrl, { headers: this.headers });
  }

  getDispatch(id) {
    return this.http.get<Dispatches>(`${this.accessUrl}${id}`, { headers: this.headers });
  }

  createDispatch(dispatch) {
    // test
    const data: Dispatches = {
      ClientId: 1,
      DispatchAddress: 'wqeqgasdasd'
    };
    this.newDispatch = this.http.post(this.accessUrl, data, { headers: this.headers });
  }

  remove(id) {
    return this.http.delete(`${this.accessUrl}${id}`, { headers: this.headers });
  }

  update(dispatch) {
    return this.http.put(`${this.accessUrl}${dispatch.id}`, dispatch, { headers: this.headers });
  }
}
