using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.@class
{
    internal interface IAnimal
    {
        void MakeSound();
        public string Name { get; set; }

    }

    class Dog2 : IAnimal
    {
        public string Name { get; set; } = "";

        public void MakeSound()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Bird : IAnimal, IFlyable
    {
        public string Name { get; set; } = "";

        public void Fly()
        {
            Console.WriteLine("날아갑니다.");
        }

        public void MakeSound()
        {
            Console.WriteLine("짹짹");
        }
    }
}
