import { DatePipe } from '@angular/common';
import { Component,Input, OnInit } from '@angular/core';
import { Interface } from 'src/app/shared/Interfaces/interface';
import { SharedService } from 'src/app/shared/Services/shared.service';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.scss']
})
export class TableComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
  pipe = new DatePipe('en-US')
  public showForm: boolean = false;
  public selectedEquity!: string;
  public selectedBonds!: string;
  public closeEditForm(){
    this.showForm=false
  }
  public toggleEquityEditForm(secID: number, name:string){
    this.closeEditForm()
    this.showForm=true
    this.selectedEquity=name
    this.service.setSEquity(secID);
    this.service.setEquity(name);
  }
  public toggleBondsEditForm(secID: number, name:string){
    this.closeEditForm()
    this.showForm=true
    this.selectedBonds=name
    this.service.setSBonds(secID);
    this.service.setBonds(name);
    // console.log(this.selectedBonds);
  }
  EquityList: any  = [];
  BondsList: any  = [];
  
  constructor(public service: SharedService) { }

  ngOnInit(): void {
    this.service.selectedEquity$.subscribe((value) => {
    this.selectedEquity = value;
    this.service.getEquities().subscribe(data=>{
      data.forEach(obj => {
        Object.entries(obj).forEach(([key, value]) => {
          if(key=='securityName' && value==this.selectedEquity){
            this.service.setEquityList(obj);
          }
          });
        });
      });
    });

    this.service.selectedBonds$.subscribe((value) => {
      this.selectedBonds = value;
      this.service.getBonds().subscribe(data=>{
        data.forEach(obj => {
          Object.entries(obj).forEach(([key, value]) => {
            if(key=='securityName' && value==this.selectedBonds){
              this.service.setBondsList(obj);
            }
            });
          });
        });
      });
    this.refreshEquityList();
    this.refreshBondsList();
    // this.deleteEquities();
    // this.deleteBonds();
    
  }
  displayedColumns: string[] = ['SECID', 'NAME', 'DESCRIPTION', 'PRICE', 'DATE', 'EDIT', 'DELETE'];
  // dataSourceEquity = this.EquityList;
  // dataSourceBonds = this.BondsList;

  refreshEquityList(){
    this.service.getEquities().subscribe(data=>{
      this.EquityList = data;
    });
  }

  refreshBondsList(){
    this.service.getBonds().subscribe(data=>{
      this.BondsList = data;
      console.log(this.BondsList)
    });
  }

  
public dateObj(date: any){
  return this.pipe.transform(new Date(date), 'dd/MM/yyyy')
}
}
