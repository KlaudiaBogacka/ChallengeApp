string name = "Ewa";
var gender = "Kobieta";
int age = 33;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "Mężcyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}