using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {

        public Person()
        {
        }
        public Person(string name)
        {
            Name = name;
        }

        //public string Name { get; set; } //getter, setter 자동 생성
        // JAVA, python과 다름 숙지 필(잘 쓰면 좋을듯?)
        // getter, setter 커스텀 가능
        // getter, setter 하나씩만 사용 가능함

        private string _name;

        public string Name { 
            set 
            {
                _name = value;
            } 
        }
        public string GetName()
        {
            return _name;
        }

    }

   
}
