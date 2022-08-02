import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MasterComponentComponent } from './master-component/master-component.component';
import { TileComponentComponent } from './master-component/tile-component/tile-component.component';
import { TableComponentComponent } from './master-component/table-component/table-component.component';



@NgModule({
  declarations: [
    MasterComponentComponent,
    TileComponentComponent,
    TableComponentComponent
  ],
  imports: [
    CommonModule
  ]
})
export class SecurityMasterViewerModule { }
