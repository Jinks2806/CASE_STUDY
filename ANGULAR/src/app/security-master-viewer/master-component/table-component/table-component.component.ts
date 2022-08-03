import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Interface } from 'src/app/shared/Interfaces/interface';

@Component({
  selector: 'app-table-component',
  templateUrl: './table-component.component.html',
  styleUrls: ['./table-component.component.scss']
})
export class TableComponentComponent implements OnInit {

  public ELEMENT_DATA: Interface.tableInterface[] = [
    {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: 100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"},
    {SECID: 1, NAME: 'ABC', DESCRIPTION: 'ABC', PRICE: -100, DATE: '08-03-2022', EDIT: "https://www.google.com/", DELETE: "https://www.google.com/"}
  ];
  constructor() { }

  ngOnInit(): void {
  }
  displayedColumns: string[] = ['SECID', 'NAME', 'DESCRIPTION', 'PRICE', 'DATE', 'EDIT', 'DELETE'];
  dataSource = this.ELEMENT_DATA;
}
