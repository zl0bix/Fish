using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    
    internal class Program
    {

       public static Random _random = new Random();

        static void Main(string[] args)
        {
           Life life = new Life();

            life.GetLife();
        }
    }

    class Fish
    {
        public string _name;
        public ushort _hp;

        public Fish(string name, ushort hp)
        {
            _name = name;
            _hp = hp;
        }

        public Fish()
        {
            _name = "Goldy";
            _hp = 15;
        }

        public string GetName() //65-90 A & 97-122 a
        {
            string str = Convert.ToString((char)Program._random.Next(65,91));

            for (int i = 0; i < Program._random.Next(2,11); i++)
            {
                str += (char)Program._random.Next(97, 123);
            }
            return str;
        }

        public ushort GetHp()
        {
            return (ushort)Program._random.Next(10, 21);
        }             
    }

    class Aquarium 
    {
        List<Fish> _list = new List<Fish>();

        public void AddFish()
        {           
            Fish fish = new Fish();

            fish._name = fish.GetName();
            fish._hp = fish.GetHp();

            _list.Add(fish);
        }

        public void ReplaceFish(ref ushort num)
        {
            for(int i = 0; i < _list.Count; i++)
            {
                if (_list[i]._hp == 0)
                {
                    _list.RemoveAt(i);

                    Fish fish = new Fish();

                    fish._name = fish.GetName();
                    fish._hp = fish.GetHp();

                    _list.Add(fish);
                }
                else

                _list[i]._hp -= num;
            }
        }

        public void ShowFish()
        {
              
            
            for (int i = 0; i < _list.Count; i++)
            {
                Drow drow = new Drow();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tРыбка имя:\t" + _list[i]._name + "\tХпэшка:\t" + _list[i]._hp);
                Console.ResetColor();

                drow.DrawFish();               
            }
        }
    }


    class Life
    {
        
       public void GetLife()
        {
            Aquarium aq = new Aquarium();

            string exitStr = "exit";
            string strChoise = "";

            ushort liveFish = 1;

            aq.AddFish();  
            aq.AddFish();  
            aq.AddFish();
            //aq.AddFish();
            //aq.AddFish();         
            while (strChoise.ToLower() != exitStr)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\tНажмите клавишу Enter для продолжения или введите Exit для выхода\n");
                Console.ResetColor();
                
                aq.ReplaceFish(ref liveFish);
                aq.ShowFish();
                              
                strChoise = Console.ReadLine();

                Console.Clear();
            }
        }          
    }


    class Drow
    {
        public void DrawFish()
        {
            /*int numTmp = Program._random.Next(0, 3);*/
            /*
                        if (numTmp == 0)
                        {*/
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("        /\\\r\n      _/./\r\n   ,-'    `-:.,-'/\r\n  > O )<)    _  " +
                "(\r\n   `-._  _.:' `-.\\\r\n       `` \\;");

            Console.ResetColor();
        }   
           /* else if (numTmp == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("        /\\\r\n      _/./\r\n   ,-'    `-:.,-'/\r\n  > O )<)    _  " +
                    "(\r\n   `-._  _.:' `-.\\\r\n       `` \\;");

                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("        /\\\r\n      _/./\r\n   ,-'    `-:.,-'/\r\n  > O )<)    _  " +
                    "(\r\n   `-._  _.:' `-.\\\r\n       `` \\;");

                Console.ResetColor();
            }
*/
        

    }
}
