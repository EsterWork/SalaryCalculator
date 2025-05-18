import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { SalaryRequest } from '../../models/salary-request.model';
import { SalaryResponse } from '../../models/salary-response.model';
import { SalaryService } from '../../services/salary-calculator.service';
import { SalaryResultComponent } from "../salary-result/salary-result.component";

@Component({
  selector: 'app-salary-calculator',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, FormsModule, SalaryResultComponent],
  templateUrl: './salary-calculator.component.html',
  styleUrls: ['./salary-calculator.component.css']
})
export class SalaryCalculatorComponent {

    request: SalaryRequest = {
      jobPercentage: null,
      professionalLevel: null,
      managementLevel: null,
      yearsOfSeniority: 0,
      eligibleByLaw: false,
      lawGroup: null
};


  result?: SalaryResponse;

  jobPercentages = [100, 75, 50];
  professionalLevels = ['מתחיל', 'מנוסה'];
  managementLevels = [0, 1, 2, 3, 4];
  lawGroups = ['A', 'B'];

  constructor(private salaryService: SalaryService) {}

@Output() calculated = new EventEmitter<SalaryResponse>();

onSubmit() {
  if (this.request.eligibleByLaw === false) {
    this.request.lawGroup = null;
  }

  this.salaryService.calculateSalary(this.request).subscribe({
    next: res => {
      this.result = res;
      this.calculated.emit(res);
    },
    error: err => console.error(err)
  });
}
}