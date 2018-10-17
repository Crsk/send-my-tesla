import { Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Car } from '../models/Car';
import { environment } from 'src/environments/environment.prod';

export class CarService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  getCars() {
    return this.http.get<Car[]>(environment.serverUrl + '/api/cars');
  }

  getCar(id) {
    return this.http.get<Car>(environment.serverUrl + '/api/cars/' + id);
  }
}
