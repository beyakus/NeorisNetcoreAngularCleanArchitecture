export interface IMenu {
  name: string;
  icon: string;
  subMenu: ISubMenu[];
}

export interface ISubMenu {
  name: string;
  route: string;
}
