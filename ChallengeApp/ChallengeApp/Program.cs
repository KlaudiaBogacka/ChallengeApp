
string name = "Ewa";
bool women = true;
int age = 17;

if (name == "Ewa" && age < 30 )
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (women == true && age != 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 30");
}
else if (name == "Karol" && women != true && age <= 17)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("To jest Ewa i ma 30 lat");
}
