using System;

namespace Ch08Ap04
{
    public class Program
    {
        static void Main(string[] args)
        {
            CupOfCoffee myCoffee = new CupOfCoffee();
            myCoffee.AddMilk(11);
            myCoffee.AddSugar(100);
            myCoffee.BeanType = "BlueMountain";
            myCoffee.Color = "Brown";
            Console.WriteLine("Your drink will be {0} {1} coffee",
                myCoffee.Color, myCoffee.BeanType);
            myCoffee.Drink();
        }
    }

    public abstract class HotDrink
    {
        public int Milk { get; set; }
        
        public int Sugar { get; set; }

        public void Drink() 
        {
            Console.WriteLine("Enjoy your drink, {0}, {1}", Milk, Sugar);
        }

        public void AddMilk(int value) 
        {
            Milk = value;
        }
        
        public void AddSugar(int value) 
        {
            Sugar = value;
        }
    }

    public class CupOfCoffee : HotDrink, ICup
    {
        public string BeanType { get; set; }

        public string Color { get; set; }
        public int volume { get; set; }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }
    }

    public class CupOfTea : HotDrink, ICup
    {
        public string LeafType { get; set; }
        public string Color 
        {
            get;
            set;     
        }
        public int volume 
        { 
            get;
            set;
        }

        public void Refill()
        {
            throw new NotImplementedException();
        }

        public void Wash()
        {
            throw new NotImplementedException();
        }
    }


    public interface ICup 
    {
        string Color { get; set; }

        int volume { get; set; }

        void Refill();

        void Wash();
    }
}
