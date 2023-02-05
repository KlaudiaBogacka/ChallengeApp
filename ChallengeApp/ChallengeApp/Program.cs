string name = "Ewa";
string gender = "Kobieta";
string gender2 = "Mezczyzna";
int age = 17;

if(age < 30 && gender == "Kobieta")
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
else if(gender == "Kobieta" && age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 30");
    }
else if(name == "Karol" && gender2 == "mężczyzna" && age <= 17)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
else
{
    Console.WriteLine("To jest Ania i ma 40 lat");
}