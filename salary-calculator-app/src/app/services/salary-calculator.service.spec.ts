import { TestBed } from '@angular/core/testing';
import { SalaryService } from './salary-calculator.service';


describe('SalaryCalculatorService', () => {
  let service: SalaryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SalaryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
