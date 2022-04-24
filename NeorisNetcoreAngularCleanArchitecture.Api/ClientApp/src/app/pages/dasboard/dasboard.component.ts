import { Component, OnInit } from '@angular/core';
import { menuSidenav } from '@config/menu/menu';
import { IMenu } from '@config/menu/menu.interfaces';

@Component({
  selector: 'app-dasboard',
  templateUrl: './dasboard.component.html',
  styleUrls: ['./dasboard.component.scss'],
})
export class DasboardComponent implements OnInit {
  rtl = false;
  variant = 'positive';
  userName = 'Example user';
  title = 'app';
  width = '80px';
  termsRoute = '';
  termsPolicy = '';
  menu: IMenu[] = menuSidenav;

  constructor() {}

  ngOnInit(): void {}
}
