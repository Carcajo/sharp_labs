using System;

namespace c_sharp_lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Food dessert = new Desserts("cake", 15, 10);

            Food BaseCocktail = new Cocktails("juice", 7, false);

            BaseCocktail.ChangeName("orange juice");

            BaseCocktail.View();
            
            Cocktails DerivedCocktail = new Cocktails("Mohito", 10, true);

            DerivedCocktail.ChangeName("Mohito");

            DerivedCocktail.View();

        }
    }
}
