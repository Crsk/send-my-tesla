import { DispatchService } from './../../services/dispatch.service';
import { Dispatches } from '../../models/Dispatches';
import { OptionService } from './../../services/option.service';
import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Option } from 'src/app/models/Option';
import { Car } from 'src/app/models/Car';

@Component({
  selector: 'app-car-config',
  templateUrl: './car-config.component.html',
  styleUrls: ['./car-config.component.css']
})
export class CarConfigComponent implements OnInit {
  isLinear = true;
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  selectedExterior: Option;
  selectedWheel: Option;
  wheelList: Option[];
  exteriorList: Option[];

  @Input() selectedCar: Car;

  constructor(private _formBuilder: FormBuilder, private optionService: OptionService, private dispatchService: DispatchService) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
    this.optionService.getWheels().subscribe(options => this.wheelList = options);
    this.optionService.getExteriors().subscribe(exterior => this.exteriorList = exterior);
  }

  form1() {
    console.log(this.firstFormGroup.value);
  }

  form2() {
    console.log(this.secondFormGroup.value);
  }

  onExtChange(ev, ext) {
    this.selectedExterior = ext;
  }
  onWheChange(ev, whe) {
    this.selectedWheel = whe;
  }

  send(address: string, option_one_id, option_two_id) {
    this.dispatchService.createDispatch({ClientId: 1, DispatchAddress: 'asdasdasd'});
  }
}
