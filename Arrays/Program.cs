// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array - Diziler");
Console.WriteLine("---------------------------");


string[] students = new string[3];
students[0] = "Engin";
students[1] = "Ahmet";
students[2] = "Berk";


string[] students2 = {"Derin", "Engin ", "Berk" };

foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine("---------------------------");



foreach (var student in students2)
{
    Console.WriteLine(student);
}