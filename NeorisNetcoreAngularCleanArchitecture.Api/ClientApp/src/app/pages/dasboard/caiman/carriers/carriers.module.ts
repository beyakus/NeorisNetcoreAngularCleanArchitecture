import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { CarriersComponent } from './carriers.component';
import { SharedModule } from '@shared/shared-modules/shared.module';

const routes: Routes = [{ path: '', component: CarriersComponent }];

@NgModule({
  declarations: [CarriersComponent],
  imports: [CommonModule, RouterModule.forChild(routes), SharedModule],
})
export class CarriersModule {}
