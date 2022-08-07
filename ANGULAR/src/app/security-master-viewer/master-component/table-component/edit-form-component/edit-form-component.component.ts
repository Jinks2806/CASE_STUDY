import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { SharedService } from 'src/app/shared/Services/shared.service';
import { Interface } from 'src/app/shared/Interfaces/interface';


@Component({
  selector: 'app-edit-form-component',
  templateUrl: './edit-form-component.component.html',
  styleUrls: ['./edit-form-component.component.scss']
})
export class EditFormComponentComponent implements OnInit {
  @Input() showBonds!: boolean;
  @Input() showEquity! : boolean;
  @Input() selectedEquity!: string;
  @Input() preFillEquity: any;
  @Input() preFillBonds: any;
  EquityList: any  = [];
  BondList: any  = [];
  public creditRating : any
  editEquityFormGroup!: FormGroup;
  public SECID!:number;
  editBondsFormGroup!: FormGroup;

  constructor(private service: SharedService) {}

  ngOnInit(): void {
    this.service.selectedEList$.subscribe((value) => {
      this.service.list$.subscribe((value) => {
        this.creditRating = value;
      });
      this.preFillEquity = value;
      this.editEquityFormGroup.setValue({
        securityName: this.preFillEquity.securityName,
        description: this.preFillEquity.securityDescription,
        pricingCurrency : this.preFillEquity.priceCurrency,
        totalSharesOutstanding : this.preFillEquity.sharesOutstanding,
        openPrice : this.preFillEquity.openPrice,
        closePrice : this.preFillEquity.closePrice,
        dividendDeclaredDate : this.preFillEquity.declaredDate,
        pfCreditRating : this.preFillEquity.pfcreditRating
      });
    });

    this.service.selectedBList$.subscribe((value) => {
      this.service.list$.subscribe((value) => {
        this.creditRating = value;
      });
      this.preFillBonds = value;
      this.editBondsFormGroup.setValue({
        securityName : this.preFillBonds.securityName,
        description : this.preFillBonds.securityDescription,
        coupon : this.preFillBonds.couponRate,
        callableFlag : this.preFillBonds.isCallable,
        maturity : this.preFillBonds.maturityDate,
        penultimateCouponDate : this.preFillBonds.penUltimateCouponDate,
        askPrice : this.preFillBonds.askPrice,
        bidPrice : this.preFillBonds.bidPrice,
        pfCreditRating : this.preFillBonds.pfcreditRating
      });
    });
    this.initForm();
    this.refreshEquityList();
    this.refreshBondsList();
    this.updateEquities();
    this.updateBonds();
  }
  
  public initForm(){
   this.editEquityFormGroup = new FormGroup({
      securityName : new FormControl({value: 'EQUITY DISABLED', disabled: true}, Validators.compose([Validators.required])),
      description : new FormControl({},Validators.required),
      pricingCurrency : new FormControl({},[Validators.required]),
      totalSharesOutstanding : new FormControl({},[Validators.required, Validators.pattern(/^-?(((\d+)((\.\d{1,8})?))$)?$/)]),
      openPrice : new FormControl({},[Validators.required, Validators.pattern(/^-?(((\d+)((\.\d{1,8})?))$)?$/)]),
      closePrice : new FormControl({},[Validators.required, Validators.pattern(/^-?(((\d+)((\.\d{1,8})?))$)?$/)]),
      dividendDeclaredDate : new FormControl({},[Validators.required]),
      pfCreditRating : new FormControl({},[Validators.required])
    })

    this.editBondsFormGroup = new FormGroup({
      securityName : new FormControl({value: 'EQUITY DISABLED', disabled: true}, Validators.compose([Validators.required])),
      description : new FormControl({},[Validators.required]),
      coupon : new FormControl({},[Validators.required, Validators.pattern(/^-?(((\d+)((\.\d{1,8})?))$)?$/)]),
      callableFlag : new FormControl({},[Validators.required]),
      maturity : new FormControl({value: 'EQUITY DISABLED', disabled: true}, Validators.compose([Validators.required])),
      penultimateCouponDate : new FormControl({},[Validators.required]),
      askPrice : new FormControl({},[Validators.required, Validators.pattern(/^-?(((\d+)((\.\d{1,8})?))$)?$/)]),
      bidPrice : new FormControl({},[Validators.required, Validators.pattern(/^-?(((\d+)((\.\d{1,8})?))$)?$/)]),
      pfCreditRating : new FormControl({},[Validators.required])
    })
  }

public refreshEquityList(){
    this.service.getEquities().subscribe(data=>{
      this.EquityList = data;
      //console.log(this.EquityList)
});
}


public refreshBondsList(){
  this.service.getBonds().subscribe(data=>{
    this.BondList = data;
    //console.log(this.EquityList)
});
}

public hasEquityError = (control: string, error: string) => {
    return this.editEquityFormGroup.controls[control].hasError(error);
  }
  public hasBondsError = (control: string, error: string) => {
    return this.editEquityFormGroup.controls[control].hasError(error);
  }

public updateEquities(){
  if (this.editEquityFormGroup.valid) {
    console.log("Form Submitted!");
  }
    this.service.selectedSEquity$.subscribe(data=>{
      this.SECID = data;
    });
    var val = {
      BbguniqueName: '',
      SecurityName: '',
      securityDescription: this.editEquityFormGroup.controls["description"].value,
      priceCurrency: this.editEquityFormGroup.controls["pricingCurrency"].value,
      sharesOutstanding: this.editEquityFormGroup.controls["totalSharesOutstanding"].value,
      openPrice: this.editEquityFormGroup.controls["openPrice"].value,
      closePrice: this.editEquityFormGroup.controls["closePrice"].value,
      declaredDate: this.editEquityFormGroup.controls["dividendDeclaredDate"].value,
      pfcreditRating: this.editEquityFormGroup.controls["pfCreditRating"].value
    };
      console.log(val);

      this.service.updateEquities(this.SECID,val).subscribe()
  }
  public updateBonds(){
    if (this.editBondsFormGroup.valid) {
      console.log("Form Submitted!");
    }
      this.service.selectedSBonds$.subscribe(data=>{
        console.log(data)
        this.SECID = data;
      });
      var val = {
        // BbguniqueName: '',
        SecurityName: '',
        securityDescription: this.editBondsFormGroup.controls["description"].value,
        couponRate: this.editBondsFormGroup.controls["coupon"].value,
        isCallable: this.editBondsFormGroup.controls["callableFlag"].value,
        maturityDate: this.editBondsFormGroup.controls["maturity"].value,
        penUltimateCouponDate: this.editBondsFormGroup.controls["penultimateCouponDate"].value,
        askPrice: this.editBondsFormGroup.controls["askPrice"].value,
        bidPrice: this.editBondsFormGroup.controls["bidPrice"].value,
        pfcreditRating: this.editBondsFormGroup.controls["pfCreditRating"].value
      };
        console.log(val);
  
        this.service.updateBonds(this.SECID,val).subscribe()
    }
  
}
