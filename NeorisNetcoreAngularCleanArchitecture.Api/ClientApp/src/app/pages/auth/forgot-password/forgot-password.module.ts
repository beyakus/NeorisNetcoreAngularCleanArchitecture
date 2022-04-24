import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ForgotPasswordComponent } from './forgot-password.component';
import { Routes, RouterModule } from '@angular/router';
import { SharedModule } from '@shared/shared-modules/shared.module';

const routes: Routes = [{ path: '', component: ForgotPasswordComponent }];

@NgModule({
  declarations: [ForgotPasswordComponent],
  imports: [CommonModule, RouterModule.forChild(routes), SharedModule],
})
export class ForgotPasswordModule {}
