import { IMenu } from '@config/menu/menu.interfaces';

export const menuSidenav: IMenu[] = [
  {
    name: 'menu.caiman.title',
    icon: 'module-control-center',
    subMenu: [
      { name: 'menu.caiman.carriers', route: 'caiman/carriers' },
      { name: 'menu.caiman.users', route: 'caiman/users' },
      { name: 'menu.caiman.manual-trips', route: 'caiman/manual-trips' },
    ],
  },
];
