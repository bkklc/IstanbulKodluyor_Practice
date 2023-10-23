// See https://aka.ms/new-console-template for more information


// Value Types
Console.WriteLine("Types & Variables");

// int 	-2.147.483.648 ile 2.147.483.647
int number1 = 1547296;

// long -9.223.372.036.854.775.808 ile 9.223.372.036.854.775.807 // 19 basamaklı sayı
long number2 = 922370854775807678;

// short  -32.768 ile 32.767
short number3 = -32768;

// byte 0 ile 255
byte number4 = 255;

// double
double number5 = 10.4;

// decimal
decimal number6 = 101.48m;

// boolean = true or false
bool condition = false;

// char 
char character = 'A';

// var keyword
var number7 = 10;
number7 = 'A';


Console.WriteLine("Number 1 is {0}", number1);
Console.WriteLine("Number 2 is {0}", number2);
Console.WriteLine("Number 3 is {0}", number3);
Console.WriteLine("Number 4 is {0}", number4);
Console.WriteLine("Number 5 is {0}", number5);
Console.WriteLine("Number 6 is {0}", number6);
Console.WriteLine("Number 7 is {0}", number7);
Console.WriteLine(condition);
Console.WriteLine("Character is : {0}",(int)character);
Console.WriteLine((int)Days.Friday);

// enum
enum Days
{
    Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

