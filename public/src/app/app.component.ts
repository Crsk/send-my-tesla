import { Component, ViewChild, OnInit } from '@angular/core';
import { MatSidenav } from '@angular/material';
import { SidenavService } from './services/sidenav.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'sendmytesla';
  bool = false;
  routes: any[];
  @ViewChild('sidenav') public sidenav: MatSidenav;

  constructor(private sidenavService: SidenavService) {
  }

  ngOnInit(): void {
    this.sidenavService.setSidenav(this.sidenav);
    this.routes = [
      { linkName: 'Home', url: '/home' },
      { linkName: 'Car', url: '/car' },
      { linkName: 'Config', url: '/config' },
      { linkName: 'Dispatch', url: '/dispatch' }
    ];
  }

  receiveBool($event) {
    this.bool = $event;
    this.sidenav.toggle();
  }

  close() {
    this.sidenav.toggle();
  }
}
