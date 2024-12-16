namespace Teo2
{
    public class Ucenik
    {
        public string Name;
        public int Age;

        public Ucenik(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Pozdrav()
        {
            Console.WriteLine($"ja sam {Name} i imam {Age} godina.");
        }
    }
}
