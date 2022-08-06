import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { SharedService } from 'src/app/shared/Services/shared.service';


@Component({
  selector: 'app-edit-form-component',
  templateUrl: './edit-form-component.component.html',
  styleUrls: ['./edit-form-component.component.scss']
})
export class EditFormComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
  @Input() SECID!: number;
  editEquityFormGroup!: FormGroup;
  editBondsFormGroup!: FormGroup;
  constructor(private service: SharedService) { }

  EquityList: any  = [];

  ngOnInit(): void {
    this.initForm();
    this.refreshEquityList();
  }
  private initForm(){
    this.editEquityFormGroup = new FormGroup({
      //{value:this.EquityList.securityName}
      securityName : new FormControl(),
      description : new FormControl(),
      pricingCurrency : new FormControl(),
      totalSharesOutstanding : new FormControl(),
      openPrice : new FormControl(),
      closePrice : new FormControl(),
      dividendDeclaredDate : new FormControl(),
      pfCreditRating : new FormControl()
    })

    this.editBondsFormGroup = new FormGroup({
      //{value:this.EquityList.at(0).securityName}
      securityName : new FormControl(),
      description : new FormControl(),
      coupon : new FormControl(),
      callableFlag : new FormControl(),
      maturity : new FormControl(),
      penultimateCouponDate : new FormControl(),
      askPrice : new FormControl(),
      bidPrice : new FormControl(),
      pfCreditRating : new FormControl()
    })
  }

  refreshEquityList(){
    this.service.getEquities().subscribe(data=>{
      this.EquityList = data;
    });
  }
  // onSubmit(): void {
  //   if (this.form.invalid) {
  //     return;
  //   }
    // continue work here
}

