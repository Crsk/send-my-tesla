import { DispatchService } from './services/dispatch.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CarService } from './services/car.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { CarComponent } from './components/car/car.component';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatIconModule } from '@angular/material/icon';
import { ConfigComponent } from './components/config/config.component';
import { DispatchComponent } from './components/dispatch/dispatch.component';
import { HomeComponent } from './home/home.component';
import { CarConfigComponent } from './components/car-config/car-config.component';
import { MatStepperModule, MatInputModule, MatAutocompleteModule } from '@angular/material';
import { MatSelectModule } from '@angular/material/select';
import { OptionService } from './services/option.service';
import { FooterComponent } from './components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    CarComponent,
    NavbarComponent,
    ConfigComponent,
    DispatchComponent,
    HomeComponent,
    CarConfigComponent,
    FooterComponent
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatButtonModule,
    MatSidenavModule,
    MatToolbarModule,
    MatIconModule,
    MatStepperModule,
    MatInputModule,
    MatAutocompleteModule,
    MatSelectModule
  ],
  providers: [CarService, OptionService, DispatchService],
  bootstrap: [AppComponent]
})
export class AppModule { }
