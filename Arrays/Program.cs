// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array - Diziler");
Console.WriteLine("---------------------------");

/*
string[] students = new string[3];
students[0] = "Engin";
students[1] = "Ahmet";
students[2] = "Berk";


string[] students2 = {"Derin", "Engin ", "Berk" }; // tek boyutlu diziler

foreach (var student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine("---------------------------");

foreach (var student in students2)
{
    Console.WriteLine(student);
}

Console.WriteLine("---------------------------");

*/
// Çok Boyutlu Diziler

string[,] regions = new string[5,3]
{
    {"İstanbul","İzmit","Bursa"},
    {"Ankara","Konya","Kırıkkale"},
    {"Antalya","Adana","Mersin"},
    {"Rize","Trabzon","Samsun"},
    {"İzmir","Muğla","Manisa"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("***************");
}