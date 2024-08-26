// See https://aka.ms/new-console-template for more information

// Line to ask for the amount of loan
Console.Write("What is the principal amount of the loan in dollars? ");

// Makes the input be a number value
double principal = Convert.ToDouble(Console.ReadLine());

// This line asks for the interest rate
Console.Write("What is the interest rate (input 0.05 for 5%)? ");

// Makes the interest rate a number value
double rate = Convert.ToDouble(Console.ReadLine());

// This line asks for the loan in years
Console.Write("What is the period of loan in years? ");

// Makes the loan be a number value
double time = Convert.ToDouble(Console.ReadLine());

// This is used to calculate the interest
double interest = principal * rate * time;

// This shows the total interest of the loan
Console.WriteLine($"Total interest of Loan: ${interest}");

