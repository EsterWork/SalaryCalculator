using SalaryCalculatorApi.Models;
using System;

namespace SalaryCalculatorApi.Services
{
    public class SalaryService
    {
        public SalaryResult CalculateSalary(SalaryRequest request)
        {
            Console.WriteLine($"ManagementLevel: {request.ManagementLevel}");

            // 1. חישוב שעות חודשיות לפי אחוז משרה
            double hoursPerMonth = request.JobPercentage switch
            {
                100 => 170,
                75 => 127.5,
                50 => 85,
                _ => throw new ArgumentException("אחוז משרה לא תקין")
            };

            // 2. חישוב שכר לשעה לפי רמה מקצועית + תוספת ניהול
            double baseHourlyRate = request.ProfessionalLevel switch
            {
                "מתחיל" => 100,
                "מנוסה" => 120,
                _ => throw new ArgumentException("רמה מקצועית לא תקינה")
            };

            if (request.ManagementLevel < 0)
                  throw new ArgumentException("דרגת ניהול לא תקינה");

            Console.WriteLine($"דרגת ניהול: {request.ManagementLevel}");

            double hourlyRate = baseHourlyRate + (request.ManagementLevel * 20);

            // 3. חישוב שכר יסוד
            double baseSalary = hourlyRate * hoursPerMonth;

            Console.WriteLine($"BaseHourlyRate: {baseHourlyRate}");
            Console.WriteLine($"HourlyRate (with management): {hourlyRate}");


            // 4. חישוב תוספת וותק: 1.25% לכל שנת וותק מלאה (ללא חלקי שנים) משכר היסוד בלבד
            int fullYearsSeniority = (int)Math.Floor((double)request.YearsOfSeniority);
            double seniorityBonusPercent = fullYearsSeniority * 1.25;
            double seniorityBonusAmount = baseSalary * (seniorityBonusPercent / 100.0);

            // 5. (חישוב תוספת חוק במידה והעובד זכאי (1% או 0.5% משכר היסוד בלבד
            double LawBonusAmount = 0;
            if (request.EligibleByLaw)
            {
                LawBonusAmount = request.LawGroup switch
                {
                    "A" => baseSalary * 0.01,
                    "B" => baseSalary * 0.005,
                    _ => 0
                };
            }

            // 6. חישוב שכר בסיס הכולל
            double salaryBeforeRaise = baseSalary + seniorityBonusAmount + LawBonusAmount;

            // 7. (חישוב תוספת העלאה לפי טווח השכר + תוספת לפי דרגת ניהול (0.1% לכל דרגה
            double raisePercent = salaryBeforeRaise switch
            {
                <= 20000 => 1.5,
                <= 30000 => 1.25,
                _ => 1.0
            };
            raisePercent += request.ManagementLevel * 0.1;

            // 8. חישוב סכום תוספת העלאה
            double raiseAmount = salaryBeforeRaise * (raisePercent / 100.0);

            // 9. שכר סופי אחרי העלאה
            double NewBaseSalary = salaryBeforeRaise + raiseAmount;

            // החזרת תוצאה מסודרת
            return new SalaryResult
            {
                BaseSalary = baseSalary,
                SeniorityBonusPercent = seniorityBonusPercent,
                SeniorityBonusAmount = seniorityBonusAmount,
                LawBonusAmount = LawBonusAmount,
                SalaryBeforeRaise = salaryBeforeRaise,
                RaisePercent = raisePercent,
                RaiseAmount = raiseAmount,
                NewBaseSalary = NewBaseSalary
            };
        }
    }
}
