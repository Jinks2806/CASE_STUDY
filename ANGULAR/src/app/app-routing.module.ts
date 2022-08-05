import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { EditFormComponentComponent } from './security-master-viewer/master-component/table-component/edit-form-component/edit-form-component.component';
import { TileComponentComponent } from './security-master-viewer/master-component/tile-component/tile-component.component';

const routes: Routes = [
  {path: '', redirectTo:'sec-view', pathMatch:'full'},
  {path: 'sec-view', component: TileComponentComponent},
  {path: 'sec-upload', component: EditFormComponentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
