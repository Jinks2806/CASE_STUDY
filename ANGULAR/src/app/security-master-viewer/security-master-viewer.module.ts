import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MasterComponentComponent } from './master-component/master-component.component';
import { TileComponentComponent } from './master-component/tile-component/tile-component.component';
import { TableComponentComponent } from './master-component/table-component/table-component.component';
import { EditFormComponentComponent } from './master-component/tile-component/edit-form-component/edit-form-component.component';
import {MatCardModule} from '@angular/material/card';


@NgModule({
  declarations: [
    MasterComponentComponent,
    TileComponentComponent,
    TableComponentComponent,
    EditFormComponentComponent,
  ],
  imports: [
    CommonModule,
    MatCardModule
  ]
})
export class SecurityMasterViewerModule { }
