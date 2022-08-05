import { DatePipe } from '@angular/common';
import { Component,Input, OnInit } from '@angular/core';
import { Interface } from 'src/app/Shared/Interfaces/interface';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.scss']
})
export class TableComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
  public showForm: boolean = false;
  public name?: string;
  public closeEditForm(){
    this.showForm=false
  }
  public toggleEditForm(name:string){
    this.showForm=false
    this.showForm=true
    this.name=name
  }

  public ELEMENT_DATA_EQUITY: Interface.tableInterface[] = [
    {SECID: 1, NAME: 'ABC!', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "edit", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'ABC2', DESCRIPTION: 'ABC', PRICE: -100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'ABC3', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"}
  ];

  public ELEMENT_DATA_BONDS: Interface.tableInterface[] = [
    {SECID: 1, NAME: 'DEF1', DESCRIPTION: 'DEF', PRICE: 500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'DEF2', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'DEF3', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'DEF', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'DEF', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'DEF', DESCRIPTION: 'DEF', PRICE: -500, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"}
  ];
  constructor() { }

  ngOnInit(): void {
  }
  displayedColumns: string[] = ['SECID', 'NAME', 'DESCRIPTION', 'PRICE', 'DATE', 'EDIT', 'DELETE'];
  dataSourceEquity = this.ELEMENT_DATA_EQUITY;
  dataSourceBonds = this.ELEMENT_DATA_BONDS;
}
