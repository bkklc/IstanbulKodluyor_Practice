﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditionals");

var number = 21;

/*
// Single Line If İle Çalışmak
Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
*/

// If - Else
/*
if (number == 10)
{
    Console.WriteLine("Number is 10");
}

else if (number == 20)
{
    Console.WriteLine("Number is 20");
}

else
{
    Console.WriteLine("Number is not 10 or 20");
}
*/

/*
// switch-case
switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;  
}
*/

// Demo: Çoklu Şartlarla Çalışmak
/*
if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0 - 100");
}

else if (number > 100 && number <= 200)
{ 
    Console.WriteLine("Number is between 100 - 200");
}

else if (number > 100 || number < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}
*/

/*
// İç İçe If Bloklarıyla Çalışmak
if (number < 100)
{
    if (number >= 90 && number <= 95)
    {
        Console.WriteLine("Number is between 90 - 95");
    }
}
*/