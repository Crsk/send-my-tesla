import { CarService } from './../../services/car.service';
import { Component, OnInit } from '@angular/core';
import { Car } from '../../models/Car';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent implements OnInit {
  public cars: Car[];

  constructor(private carService: CarService) { }

  ngOnInit() {
    this.getCars();
  }

  getCars() {
    this.carService.getCars().subscribe(cars => {
      this.cars = cars;
    }, error => console.log(error));
  }
}
