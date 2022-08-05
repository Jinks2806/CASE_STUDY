import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MasterComponentComponent } from './master-component/master-component.component';
import { TileComponentComponent } from './master-component/tile-component/tile-component.component';
import { TableComponentComponent } from './master-component/table-component/table-component.component';
import { EditFormComponentComponent } from './master-component/table-component/edit-form-component/edit-form-component.component';
import {MatCardModule} from '@angular/material/card';
import {MatGridListModule} from '@angular/material/grid-list';
import { FlexLayoutModule } from '@angular/flex-layout';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatTableModule} from '@angular/material/table';
import { ReactiveFormsModule } from '@angular/forms';
import {MatIconModule} from '@angular/material/icon';
import{ MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import {MatFormFieldModule} from '@angular/material/form-field';

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
    FlexLayoutModule,
    MatToolbarModule,
    MatTableModule,
    ReactiveFormsModule,
    MatIconModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatFormFieldModule
  ],
  exports:[MasterComponentComponent, TileComponentComponent]
})
export class SecurityMasterViewerModule { }
