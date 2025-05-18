import { Component } from '@angular/core';
import { SalaryCalculatorComponent } from './components/salary-calculator/salary-calculator.component';
import { SalaryResultComponent } from './components/salary-result/salary-result.component';
import { SalaryResponse } from './models/salary-response.model';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [SalaryCalculatorComponent, SalaryResultComponent],
  templateUrl: './app.component.html'
})
export class AppComponent {
  result?: SalaryResponse;

  onCalculated(result: SalaryResponse) {
    this.result = result;
  }
}
