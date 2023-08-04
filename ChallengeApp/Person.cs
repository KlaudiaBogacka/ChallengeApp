using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public abstract class Person : System.Object
    {
        public Person(string name, string surname, char sex, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.sex = sex;
            this.age = age;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char sex { get; private set; }
        public int age { get; private set; }
    }
}
