// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditionals");

var number = 21;

/*
// Single Line If İle Çalışmak
Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
*/

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