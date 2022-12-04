using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_lab6
{
        public abstract class Food
        {
            protected int cost;
            protected string name;
            public int GetCost()
            {
                return cost;
            }

            public void ChangeName(string NewName)
            {
                name = NewName;
            }
            public abstract void View();
            public Food(int cost, string name)
            {
                this.cost = cost;
                this.name = name;
            }
        }

        public sealed class Desserts : Food
        {
            private int calories;
            public int Calories()
            {
                return calories;
            }
            public Desserts(string name_, int cost_, int calories_) : base(cost_, name_)
            {
                cost = cost_;
                calories = calories_;
                name = name_;
            }

            public override void View()
            {
                //Console.WriteLine("\nНазвание: " + name + " Стоимость: " + cost + " Калорийность: " + calories);
            }
        }
        public class Cocktails : Food
        {
            private bool isAlcohol;

            public Cocktails(string name, int cost, bool isAlcohol) : base(cost, name)
            {
                this.cost = cost;
                this.name = name;
                this.isAlcohol = isAlcohol;
            }
            public override void View()
            {
                Console.WriteLine("\nНазвание: " + name + " Стоимость: " + cost);
            }
            public bool IsAlcohol()
            {
                return isAlcohol;
            }

            public new void ChangeName(string NewName)
            {
                name = NewName + (isAlcohol
                    ?
                    " (Алкогольный)"
                    : " (Безалкогольный)");
            }

        }
    }

