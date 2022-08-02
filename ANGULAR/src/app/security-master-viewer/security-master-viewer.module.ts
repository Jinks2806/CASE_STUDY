import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MasterComponentComponent } from './master-component/master-component.component';
import { TileComponentComponent } from './master-component/tile-component/tile-component.component';
import { TableComponentComponent } from './master-component/table-component/table-component.component';
import { EditFormComponentComponent } from './master-component/tile-component/edit-form-component/edit-form-component.component';
import {MatCardModule} from '@angular/material/card';
import {MatGridListModule} from '@angular/material/grid-list';
import { FlexLayoutModule } from '@angular/flex-layout';



@NgModule({
  declarations: [
    MasterComponentComponent,
    TileComponentComponent,
    TableComponentComponent,
    EditFormComponentComponent,
    ],
  imports: [
    CommonModule,
    MatCardModule,
    MatGridListModule,
    FlexLayoutModule
  ],
  exports:[MasterComponentComponent, TileComponentComponent]
})
export class SecurityMasterViewerModule { }
