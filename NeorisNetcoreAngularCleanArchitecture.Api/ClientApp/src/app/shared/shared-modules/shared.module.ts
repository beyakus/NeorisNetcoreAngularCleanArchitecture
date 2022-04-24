import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { CmxWebComponentsModule } from '@cmx-web-components/angular';
import { SharedTranslatoModule } from '@shared/translator/sharedTranslator.module';

@NgModule({
  declarations: [],
  imports: [CommonModule],
  exports: [CmxWebComponentsModule, SharedTranslatoModule, ReactiveFormsModule],
})
export class SharedModule {}
