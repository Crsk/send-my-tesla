import { Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Car } from '../models/Car';

export class CarService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  getCars() {
    return this.http.get<Car[]>(this.baseUrl + 'api/cars/getall');
  }
}
