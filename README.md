<div dir="ltr">
# Salary Calculator App

מערכת לחישוב שכר לעובדים בהתאם לפרמטרים כמו ותק, אחוז משרה, דרגת ניהול וזכאות לפי חוק.  
המערכת כוללת צד שרת ב־ASP.NET Core וצד לקוח ב־Angular 18.

## תוכן העניינים
- [טכנולוגיות בשימוש](#טכנולוגיות-בשימוש)
- [מבנה הפרויקט](#מבנה-הפרויקט)
- [צד שרת - ASP.NET Core](#צד-שרת---aspnet-core)
- [צד לקוח - Angular 18](#צד-לקוח---angular-18)
- [הוראות הפעלה](#הוראות-הפעלה)
- [בדיקות](#בדיקות)
- [מבנה הנתונים](#מבנה-הנתונים)

## טכנולוגיות בשימוש

- Backend: ASP.NET Core 8  
- Frontend: Angular 18 (standalone components)  
- תקשורת: HTTP API  
- כלי בדיקות: Postman, Swagger  
- ניהול גרסאות: Git + GitHub

## מבנה הפרויקט

salary-calculator-solution/  
├── SalaryCalculator.Api/  
│   ├── Controllers/  
│   │   └── SalaryCalculatorController.cs  
│   ├── Models/  
│   │   ├── SalaryRequest.cs  
│   │   └── SalaryResponse.cs  
│   └── Services/  
│       └── SalaryCalculatorService.cs  
├── salary-calculator-app/  
│   ├── src/app/  
│   │   ├── models/  
│   │   │   ├── salary-request.model.ts  
│   │   │   └── salary-response.model.ts  
│   │   ├── services/  
│   │   │   └── salary-calculator.service.ts  
|   |   ├── components/
│   │   ├── salary-calculator/  
│   │   │   └── salary-calculator.component.ts/html/css  
│   │   └── salary-result/  
│   │       └── salary-result.component.ts/html/css  
└── README.md

## צד שרת - ASP.NET Core

- `SalaryCalculatorController.cs`: קונטרולר שמקבל את הבקשות מהקליינט.  
- `SalaryRequest.cs`: מייצג את מבנה הבקשה שמתקבלת מהקליינט.  
- `SalaryResponse.cs`: מייצג את מבנה התשובה שחוזרת לקליינט.  
- `SalaryCalculatorService.cs`: מכיל את לוגיקת החישוב בפועל.

## צד לקוח - Angular 18

- `salary-request.model.ts`: ממשק נתונים לבקשה מהשרת.  
- `salary-response.model.ts`: ממשק נתונים לתשובת השרת.  
- `salary-calculator.service.ts`: שירות לתקשורת עם ה־API.  
- `salary-calculator.component`: קומפוננטה להזנת נתוני הטופס.  
- `salary-result.component`: קומפוננטה להצגת התוצאה.

## הוראות הפעלה

### צד שרת

1. לפתוח את התיקייה `SalaryCalculator.Api` ב־Visual Studio או ב־VS Code.  
2. להריץ את הפרויקט (`dotnet run`).  
3. לבדוק שה־API פעיל ב־Swagger: `https://localhost:PORT/swagger`

### צד לקוח

```bash
cd salary-calculator-app
npm install
ng serve
```

המערכת תעלה על `http://localhost:4200`.

## בדיקות

- בדיקות ידניות ב־Swagger ו־Postman.
- תרחישים שנבדקו:
  - שליחת נתונים תקינים וקבלת תוצאה.
  - בדיקת שדות ריקים או שגויים.
  - התאמה בין תוצאה לנתונים שהוזנו.

## מבנה הנתונים

**SalaryRequest:**
```json
{
  "jobPercentage": 100,
  "professionalLevel": "מנוסה",
  "managementLevel": 2,
  "yearsOfSeniority": 6,
  "eligibleByLaw": true,
  "lawGroup": "A"
}
```

**SalaryResponse:**
```json
{
  "baseSalary": 8400,
  "seniorityBonus": 900,
  "managementBonus": 1200,
  "lawBonus": 300,
  "totalSalary": 10800
}
```

## תודות

תודה על ההזדמנות להציג את הפרויקט.  
המערכת נבנתה בצורה מקצועית, מודולרית ונוחה לתחזוקה, תוך הפרדה בין צד לקוח לצד שרת, ומבוססת על עקרונות SOLID ו־Best Practices.

</div>

