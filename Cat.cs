namespace csharp_oop_1_demo
{
    public class Cat : Animal
    {
        private static string defaultCatSound = "miałmiał";

        public Cat(string name) : base(name, defaultCatSound)
        {

        }
    }
}