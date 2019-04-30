import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { HttpClient } from '@angular/common/http';

// npm install rxjs@6 rxjs-compat@6 --save
@Injectable()
export class AppService {
    constructor(private http: HttpClient) { }

    CallAllService(apiUrl: string) {
        return this.http.post(apiUrl, null, null).map((data: any) => {
            return data.json();
        });
    }
    CallByResquestService(apiUrl: string, request: any) {
        return this.http.post(apiUrl, request, null).map((data: any) => {
            return data.json();
        });
    }
}
