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
  public showForm: boolean = false;
  public SECID!: number;
  public name?: string;
  public closeEditForm(){
    this.showForm=false
  }
  public toggleEditForm(secID:number, name:string){
    this.showForm=false
    this.showForm=true
    this.SECID=secID
  }

  EquityList: any  = [];
  
  // public EQUITY: any []= this.EquityList;
  // [
  //   {SECID: 1, NAME: 'ABC!', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "edit", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'ABC2', DESCRIPTION: 'ABC', PRICE: -100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'ABC3', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"}
  // ];

  // public ELEMENT_DATA_BONDS: Interface.tableInterface[] = [
  //   {SECID: 1, NAME: 'DEF1', DESCRIPTION: 'DEF', PRICE: 500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'DEF2', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'DEF3', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'DEF', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'DEF', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
  //   {SECID: 1, NAME: 'DEF', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"}
  // ];
  constructor(private service: SharedService) { }

  ngOnInit(): void {
    this.refreshEquityList();
  }
  displayedColumns: string[] = ['SECID', 'NAME', 'DESCRIPTION', 'PRICE', 'DATE', 'EDIT', 'DELETE'];
  dataSourceEquity = this.EquityList;
  // dataSourceBonds = this.ELEMENT_DATA_BONDS;

  refreshEquityList(){
    this.service.getEquities().subscribe(data=>{
      this.EquityList = data;
    });
  }
 
}
