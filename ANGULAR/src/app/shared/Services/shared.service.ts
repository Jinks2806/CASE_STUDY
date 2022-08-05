import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs'; //used to handle asynchronous responses 

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl = "http://localhost:5057/api";
  constructor(private http:HttpClient) { }

  getEquities():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Equities');
  }

  //edit and delete functionalities for update and delete(edit) to be written
}
