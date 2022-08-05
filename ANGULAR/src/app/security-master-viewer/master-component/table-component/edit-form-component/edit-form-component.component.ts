import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-edit-form-component',
  templateUrl: './edit-form-component.component.html',
  styleUrls: ['./edit-form-component.component.scss']
})
export class EditFormComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
  editEquityFormGroup!: FormGroup;
  editBondsFormGroup!: FormGroup;
  constructor() { }

  ngOnInit(): void {
    this.initForm();
  }
  private initForm(){
    this.editEquityFormGroup = new FormGroup({
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

  // onSubmit(): void {
  //   if (this.form.invalid) {
  //     return;
  //   }
    // continue work here
}

