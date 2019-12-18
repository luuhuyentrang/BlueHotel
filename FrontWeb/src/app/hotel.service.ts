import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable, of} from 'rxjs';

import {Hotel} from './model/hotel';

@Injectable({
  providedIn: 'root'
})
export class HotelService {

  private apiUrl = 'https://localhost:44393/api/hotels';


  constructor(
    private http: HttpClient) { }


  getHotels() : Observable<Hotel[]>{
    /*let test = this.http.get<Hotel[]>(this.apiUrl);*/

    return this.http.get<Hotel[]>(this.apiUrl);
  }

  getHotel(hotelId: number) : Observable<Hotel>{
    /*let test = this.http.get<Hotel[]>(this.apiUrl);*/

    return this.http.get<Hotel>('${this.apiUrl}/${hotelId}');
  }


}
