import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs'; //used to handle asynchronous responses 

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl = "http://localhost:5057/api";
  constructor(private http:HttpClient) { }

  getEquities():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Equities');
  }

  public updateEquities(id:any, postData: Object) {
    let endPoints = id
    return this.http.put(this.APIUrl +'/Equities/'+ endPoints, postData)
  }

  public deleteEquities(id:any) {
    let endPoints = id
    return this.http.delete(this.APIUrl +'/Equities/'+ endPoints)
  }

  getBonds():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Bonds');
  }

  public updateBonds(id:any, postData: Object) {
    let endPoints = id
    return this.http.put(this.APIUrl +'/Bonds/'+ endPoints, postData)
  }

  public deleteBonds(id:any) {
    let endPoints = id
    return this.http.delete(this.APIUrl +'/Bonds/'+ endPoints)
  }


  public equity$ = new BehaviorSubject<any>({});
  selectedEquity$ = this.equity$.asObservable();
  setEquity(equity: any) {
    this.equity$.next(equity);
  }

  public sEquity$ = new BehaviorSubject<any>({});
  selectedSEquity$ = this.sEquity$.asObservable();
  setSEquity(sequity: any) {
    this.sEquity$.next(sequity);
  }

  public sBonds$ = new BehaviorSubject<any>({});
  selectedSBonds$ = this.sBonds$.asObservable();
  setSBonds(sbonds: any) {
    this.sBonds$.next(sbonds);
  }

  public eList$ = new BehaviorSubject<any>({});
  selectedEList$ = this.eList$.asObservable();
  setEquityList(equityList: any) {
    this.eList$.next(equityList);
  }

  public bonds$ = new BehaviorSubject<any>({});
  selectedBonds$ = this.bonds$.asObservable();
  setBonds(bonds: any) {
    this.bonds$.next(bonds);
  }

  public bList$ = new BehaviorSubject<any>({});
  selectedBList$ = this.bList$.asObservable();
  setBondsList(bondsList: any) {
    this.bList$.next(bondsList);
  }

  public list$ = new BehaviorSubject<any[]>([
    'AAA', 'AA+', 'AA', 'A+', 'A', 'A-', 'BBB+','BBB','BBB-', 'AA+', 'AA', 'A+', 'A', 'A-', 'CCC+','CCC'
  ]);
  //edit and delete functionalities for update and delete(edit) to be written
}
