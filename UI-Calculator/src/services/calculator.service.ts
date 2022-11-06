import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse} from '@angular/common/http'
import { Observable, throwError } from 'rxjs'
import { catchError, retry } from 'rxjs/operators'
import { Request } from '../models/request.model'
import { Response } from '../models/response.model';

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {
  headers = new HttpHeaders()

  constructor(private http: HttpClient) {
    this.headers = 
    this.headers.set('accept', 'application/json;odata=verbose')
                .set('content-type', 'application/json;odata=verbose')
                .set('IF-MATCH', '*')
  }
  
  postBasicOperation(request: Request, operator: string){
    let url = 'https://localhost:7127/api/BasicOperations/' + operator;
    return this.http.post<Response>(url, request)
                    .pipe(
                      retry(3),
                      catchError(this.handleError)
                    );
  }

  handleError(error: HttpErrorResponse){
    if(error.error instanceof ErrorEvent){
      //a client-side or network error ocurred. Handle it accodringly.
      console.error("An error ocurred:" ,error.error.message);
    } else{
      //backend returned an unsuccessful response code
      //the response body may contain clues as to what went wrong.
      console.error(`Backend returned code ${error.status}, body was: ${error.error}`)
    }

    return throwError("Something bad happened, please try latter (" + error.status + ")");
  }

}
