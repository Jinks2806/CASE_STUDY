import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-tile-component',
  templateUrl: './tile-component.component.html',
  styleUrls: ['./tile-component.component.scss']
})
export class TileComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
  constructor() { }

  ngOnInit(): void {
  }
}
