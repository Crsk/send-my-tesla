import { Car } from './../../models/Car';
import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-config',
  templateUrl: './config.component.html',
  styleUrls: ['./config.component.css']
})
export class ConfigComponent implements OnInit, OnDestroy {
  
  id: number;
  private sub: any;
  car: Car;

  constructor(private route: ActivatedRoute, private carService: CarService) { }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
       this.id = +params['id'];
       this.carService.getCar(this.id).subscribe(car => {
         this.car = car;
       });
    });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

}
