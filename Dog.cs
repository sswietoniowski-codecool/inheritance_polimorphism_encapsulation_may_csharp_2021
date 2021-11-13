namespace csharp_oop_1_demo
{
    public class Dog : Animal
    {
        private static string defaultDogSound = "hałhał";
        public Dog(string name): base(name, defaultDogSound)
        {

        }
    }
}