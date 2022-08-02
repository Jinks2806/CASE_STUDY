import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SecMasterUploaderModule } from './sec-master-uploader/sec-master-uploader.module';
import { SecurityMasterViewerModule } from './security-master-viewer/security-master-viewer.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    SecurityMasterViewerModule,
    SecMasterUploaderModule,
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
