export interface SalaryRequest {
  jobPercentage: number | null;
  professionalLevel: string | null;
  managementLevel: number | null;
  yearsOfSeniority: number;
  eligibleByLaw: boolean;
  lawGroup: string | null;
}
