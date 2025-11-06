using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.@class
{
    internal class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("먹습니다.");
        }
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine("준규가 먹습니다.");

        }
    }
    class Cat : Animal
    {
        public new void Eat()  // new 키워드는 부모의 메서드를 숨기고 새로운 메서드를 정의
        {
            Console.WriteLine("야옹이가 먹습니다.");
        }
    }
}
