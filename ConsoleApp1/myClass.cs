using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class myClass
    {
        private readonly int index;

        public myClass(int index)
        {
            this.index = index;
        }

        ~myClass()
        {
            Console.WriteLine("myClass 인스턴스가 소멸됩니다. index: " + index);
        }
        // 클래스 객체가 생성할 때 힙 메모리에 할당
        // 클래스 객체가 더 이상 참조되지 않을 때
        // 가비지 컬렉터에 의해 메모리에서 해제
    }
}
