import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DasboardComponent } from './dasboard.component';

const routes: Routes = [
  {
    path: '',
    component: DasboardComponent,
    children: [
      {
        path: 'caiman/manual-trips',
        loadChildren: () =>
          import('./caiman/manual-trips/manual-trips.module').then(
            (m) => m.ManualTripsModule
          ),
      },
      {
        path: 'caiman/users',
        loadChildren: () =>
          import('./caiman/users/users.module').then((m) => m.UsersModule),
      },
      {
        path: 'caiman/carriers',
        loadChildren: () =>
          import('./caiman/carriers/carriers.module').then(
            (m) => m.CarriersModule
          ),
      },
    ],
  },
];
@NgModule({
  declarations: [],
  imports: [CommonModule, RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DasboardRoutingModule {}
