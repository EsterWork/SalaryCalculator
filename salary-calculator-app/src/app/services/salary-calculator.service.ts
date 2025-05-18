import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { SalaryResponse } from '../models/salary-response.model';
import { SalaryRequest } from '../models/salary-request.model';

@Injectable({
  providedIn: 'root'
})
export class SalaryService {
  private apiUrl = 'http://localhost:5018/api/salary/calculate';

  constructor(private http: HttpClient) {}

  calculateSalary(request: SalaryRequest): Observable<SalaryResponse> {
    return this.http.post<SalaryResponse>(this.apiUrl, request);//  שליחת הבקשה לשרת והתשובה מהשרת
  }
}
