import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-car-config',
  templateUrl: './car-config.component.html',
  styleUrls: ['./car-config.component.css']
})
export class CarConfigComponent implements OnInit {
  isLinear = true;
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;

  constructor(private _formBuilder: FormBuilder) { }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
  }

  form1() {
    console.log(this.firstFormGroup.value);
  }

  form2() {
    console.log(this.secondFormGroup.value);
  }

}
