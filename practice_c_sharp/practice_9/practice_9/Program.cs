using Binding;
using System.Xml.Linq;
using practice_9;

namespace Binding
 { 
 class Household
 {
    static void Main()
    {
           
        Cat c = new Cat("Ozzie", false);
        Dog d = new Dog("Hank", true);
            c.Move(true);
            d.Move(true);
            Exercise(c, 20);
            Exercise(d, 20);
            Pet[] pet = new Pet[6];
            pet[0] = new Cat("cat1", false);
            pet[1] = new Dog("dog1", true);
            pet[2] = new Cat("cat2", true);
            pet[3] = new Dog("dog2", false);
            pet[4] = new Cat("cat3", false);
            pet[5] = new Dog("dog3", true);
            Exercise(pet);
            Play(c);
            Play(d);
        }

        static void Exercise(Pet p, int duration)
        {
            Random r = new Random();
            p.Speak();
            while (duration > 0)
            {
                p.Move(r.Next(2) == 0 ? false:true); 
                duration--;
            }
        }

        static void Exercise(Pet[] pets) 
        {
            Random r = new Random();
            for (int i=0;i<pets.Length;i++)
            {
                pets[i].Speak();
                pets[i].Move(r.Next(2) == 0 ? false : true);
            }
        }
         static void Play(Pet p)
        {
            if(p is Cat)
            {
                Console.WriteLine("this is a cat");
                Cat c1 = (Cat)p;
                if(c1.IsPicky) { Console.WriteLine("does want to play"); }
                else
                {
                    Console.WriteLine("wanna play but not for too long");
                }
            }
            else if(p is Dog)
            {
                Console.WriteLine("this is a Dog");
                Dog d = p as Dog;
                if(d.CanFetch)
                {
                    Console.WriteLine("wanna play");
                }
                else
                    Console.WriteLine("not ble to play");
            }
            else
            {
                Console.WriteLine("none ot these");
            }
        }
 } 
} 