import { Component, Input, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared/Services/shared.service';

@Component({
  selector: 'app-tile-component',
  templateUrl: './tile-component.component.html',
  styleUrls: ['./tile-component.component.scss']
})
export class TileComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
 
  constructor(private service: SharedService) { }
  EquityList: any  = [];
  EactiveSecurities!: number ;
  EinactiveSecurities!: number;

  BondList: any  = [];
  BactiveSecurities!: number ;
  BinactiveSecurities!: number;

  ngOnInit(): void {
    this.refreshEquityList()
    this.refreshBondList()
  }

  refreshEquityList(){
    
    this.service.getEquities().subscribe(data=>{
      this.EquityList = data;  
      this.EactiveSecurities=0
      this.EinactiveSecurities=0
     
      data.forEach(obj => {
        Object.entries(obj).forEach(
          ([key, value]) => {
          
          if(key=='isActive' && value===true)
          this.EactiveSecurities++;
        });
        
      });
      this.EinactiveSecurities=data.length-this.EactiveSecurities
      console.log("No of active securities are: "+this.EactiveSecurities);
      console.log("No of inactive securities are: "+ this.EinactiveSecurities);
     
    });
  }

  refreshBondList(){
    
    this.service.getBonds().subscribe(data=>{
      this.BondList = data;  
      this.BactiveSecurities=0
      this.BinactiveSecurities=0
     
      data.forEach(obj => {
        Object.entries(obj).forEach(
          ([key, value]) => {
          
          if(key=='isActive' && value===1)
          this.BactiveSecurities++;
        });
        
      });
      this.BinactiveSecurities=data.length-this.BactiveSecurities
    });
  }
    
 
}
