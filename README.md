<div dir="ltr">
# Salary Calculator App

מערכת לחישוב שכר לעובדים בהתאם לפרמטרים כמו ותק, אחוז משרה, דרגת ניהול וזכאות לפי חוק.  
המערכת כוללת צד שרת ב־ASP.NET Core וצד לקוח ב־Angular 18.

## טכנולוגיות בשימוש

- Backend: ASP.NET Core 8  
- Frontend: Angular 18 (standalone components)  
- תקשורת: HTTP API  
- כלי בדיקות: Postman, Swagger  
- ניהול גרסאות: Git + GitHub

## מבנה הפרויקט

SalaryCalculator/  
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
 
- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 
  -  לקריאה נוספת: ➕ [הסבר מפורט על הפרויקט](PROJECT-DESCRIPTION.md)

</div>

