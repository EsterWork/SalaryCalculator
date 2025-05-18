import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SalaryResponse } from '../../models/salary-response.model';

@Component({
  selector: 'app-salary-result',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './salary-result.component.html',
  styleUrls: ['./salary-result.component.scss']
})
export class SalaryResultComponent {
     @Input() result!: SalaryResponse;
  }
