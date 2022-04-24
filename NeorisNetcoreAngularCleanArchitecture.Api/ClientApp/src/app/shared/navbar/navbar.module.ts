import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from '@shared/material/material.module';
import { NavbarComponent } from './navbar.component';
import { StatusSidenavService } from '@services/statusSidenav/status-sidenav.service';

@NgModule({
  declarations: [NavbarComponent],
  imports: [CommonModule, MaterialModule],
  exports: [NavbarComponent],
  providers: [StatusSidenavService],
})
export class NavbarModule {}
