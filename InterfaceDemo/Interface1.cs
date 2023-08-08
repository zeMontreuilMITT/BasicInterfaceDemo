using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace InterfaceDemo
{

    public interface ISayHello
    {
        string SayHello();
    }

    public interface IMakeBreakfast
    {
        string MakeBreakfast();
    }


    public abstract class Human
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 0)
                {
                    _name = value;
                }
            }
        }
        public void CountToTen()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(10);
            }
        }
    }


    public class HumanFromCanada : Human, IMakeBreakfast, ISayHello
    {
        public string MakeBreakfast()
        {
            return "Pancakes, Maple Syrup, and Back Bacon";
        }

        public string SayHello()
        {
            return "Hey there bud!";
        }
    }

    public class DuckFromCanada: ISayHello
    {
        public string SayHello()
        {
            return "QUACK";
        }
    }
}
