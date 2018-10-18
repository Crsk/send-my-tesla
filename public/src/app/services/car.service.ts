import { Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Car } from '../models/Car';
import { environment } from 'src/environments/environment.prod';

export class CarService {
  private headers: HttpHeaders;
  private accessUrl: string = `${environment.serverUrl}/api/cars/`;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  getCars() {
    return this.http.get<Car[]>(this.accessUrl, { headers: this.headers });
  }

  getCar(id) {
    return this.http.get<Car>(`${this.accessUrl}${id}`, { headers: this.headers });
  }

  createCar(car) {
    return this.http.post(this.accessUrl, car, { headers: this.headers });
  }

  remove(id) {
    return this.http.delete(`${this.accessUrl}${id}`, { headers: this.headers });
  }

  update(car) {
    return this.http.put(`${this.accessUrl}${car.id}`, car, { headers: this.headers });
  }
}
