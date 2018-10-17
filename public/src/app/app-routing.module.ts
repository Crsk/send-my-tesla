import { ConfigComponent } from './components/config/config.component';
import { HomeComponent } from './home/home.component';
import { CarComponent } from './components/car/car.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DispatchComponent } from './components/dispatch/dispatch.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full'},
  { path: 'home', component: HomeComponent },
  { path: 'car', component: CarComponent },
  { path: 'config', component: ConfigComponent },
  { path: 'dispatch', component: DispatchComponent },
  { path: '**', redirectTo: '/home' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
