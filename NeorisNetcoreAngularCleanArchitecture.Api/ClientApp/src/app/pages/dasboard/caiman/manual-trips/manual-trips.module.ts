import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ManualTripsComponent } from './manual-trips.component';
import { SharedModule } from '@shared/shared-modules/shared.module';

const routes: Routes = [{ path: '', component: ManualTripsComponent }];

@NgModule({
  declarations: [ManualTripsComponent],
  imports: [CommonModule, RouterModule.forChild(routes), SharedModule],
})
export class ManualTripsModule {}
