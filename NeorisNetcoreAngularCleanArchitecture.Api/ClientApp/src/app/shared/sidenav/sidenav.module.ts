import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedTranslatoModule } from '@shared/translator/sharedTranslator.module';
import { MaterialModule } from '@shared/material/material.module';
import { SidenavComponent } from './sidenav.component';
import { NavbarModule } from '../navbar/navbar.module';
import { StatusSidenavService } from '@services/statusSidenav/status-sidenav.service';
@NgModule({
  declarations: [SidenavComponent],
  imports: [CommonModule, NavbarModule, SharedTranslatoModule, MaterialModule],
  exports: [SidenavComponent],
  providers: [StatusSidenavService],
})
export class SidenavModule {}
