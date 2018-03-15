using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI;

            Console.WriteLine("請輸入你的體重:");

            double Weight = double.Parse(Console.ReadLine());

            Console.WriteLine("請輸入你的體重(公分):");

            double Height = double.Parse(Console.ReadLine());
            
            BMI = Weight / (Height / 100 * 2);


            if (BMI < 18.5)
                Console.WriteLine("可憐的孩子多吃點！過輕");

            if (BMI >= 18.5 && BMI < 24)
                Console.WriteLine("偏輕，再多吃點就體重適中囉~");

            if (BMI >= 24 && BMI < 27)
                Console.WriteLine("適中！身體保持真好！要維持下去喔~");

            if (BMI >= 27 && BMI < 30)
                Console.WriteLine("偏重，要控制一下體重囉~");

            if (BMI >= 30 && BMI < 35)
                Console.WriteLine("營養過剩了啦！過重！");

            if (BMI >= 35)
                Console.WriteLine("我對你感到絕望");
            
            Console.ReadLine();
            
            }
        }
    }

