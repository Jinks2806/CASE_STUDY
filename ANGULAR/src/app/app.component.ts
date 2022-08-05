import { Component } from '@angular/core';
import { TileComponentComponent } from './security-master-viewer/master-component/tile-component/tile-component.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'SECURITY MASTER';
  isShownEquity: boolean = true ; // hidden by default
  isShownBonds: boolean = false;
  public toggleShowEquity() {
    this.isShownEquity = true;
    this.isShownBonds = false;
  }
  public toggleShowBonds() {
    this.isShownEquity = false;
    this.isShownBonds = true;
  }
}
