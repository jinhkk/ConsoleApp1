using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        private string brand;
        private string model;
        private string color;


        public Car()
        {
            brand = "현대";
            model = "소나타";
            color = "검정";
        }

        public void showInfo()
        {
            Console.WriteLine("브랜드: " + brand);
            Console.WriteLine("모델: " + model);
            Console.WriteLine("색상: " + color);
        }
        public void showInfo(bool displayBrand = true, bool displayModel = true, bool displayColor = true)
        {
            if (displayBrand) Console.WriteLine("브랜드: " + brand);
            if (displayModel) Console.WriteLine("모델: " + model);
            if (displayColor) Console.WriteLine("색상: " + color);
        }

        public string GetBrand()
        {
            return brand;
        }

        public string GetModel()
        {
            return model;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetInfo(string brand, string model, string color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }

        public Car(string brand, string model, string color = "파랑") 
        {// color는 기본값이 설정되어있어 생략가능
            this.brand = brand;
            this.model = model;
            this.color = color;
        }

        public void showInfo(params string[] options)
        {
            foreach (string option in options)
            {
            if (option == "brand") Console.WriteLine("브랜드: " + brand);
            if (option == "model") Console.WriteLine("모델: " + model);
            if (option == "color") Console.WriteLine("색상: " + color);
            }
        }
    }

}
