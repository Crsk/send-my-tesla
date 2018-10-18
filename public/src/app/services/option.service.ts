import { Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Option } from '../models/Option';
import { environment } from 'src/environments/environment.prod';

export class OptionService {
  private headers: HttpHeaders;
  private accessUrl: string = `${environment.serverUrl}/api/options/`;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  getOptions() {
    return this.http.get<Option[]>(this.accessUrl, { headers: this.headers });
  }
  
  getWheels() {
    return this.http.get<Option[]>(`${this.accessUrl}whe`, { headers: this.headers });
  }
  getExteriors() {
    return this.http.get<Option[]>(`${this.accessUrl}ext`, { headers: this.headers });
  }

  getOption(id) {
    return this.http.get<Option>(`${this.accessUrl}${id}`, { headers: this.headers });
  }

  createOption(option) {
    return this.http.post(this.accessUrl, option, { headers: this.headers });
  }

  remove(id) {
    return this.http.delete(`${this.accessUrl}${id}`, { headers: this.headers });
  }

  update(option) {
    return this.http.put(`${this.accessUrl}${option.id}`, option, { headers: this.headers });
  }
}
