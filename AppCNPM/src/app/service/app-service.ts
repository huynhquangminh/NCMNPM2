import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { HttpClient, HttpHeaders } from '@angular/common/http';

// npm install rxjs@6 rxjs-compat@6 --save
@Injectable()
export class AppService {
    constructor(private http: HttpClient) { }

    CallAllService(apiUrl: string) {
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })
          };
        return this.http.post(apiUrl, null, httpOptions).map((data: any) => {
            return data;
        });
    }
    CallByResquestService(apiUrl: string, request: any) {
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type':  'application/json'
            })
          };
        return this.http.post(apiUrl, request, httpOptions).map((data: any) => {
            return data;
        });
    }
}
