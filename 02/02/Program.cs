using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

         // 隨機產生序號 
            Random rand = new Random();
            int a = 0;
         // 迴圈重複10次
            while (a < 10)
           {
             // 用亂數物件產生亂數
              int q1 = rand.Next(0, 43);
              int q2 = rand.Next(0, 43);
              int q3 = rand.Next(0, 43);
              int q4 = rand.Next(0, 43);
              int q5 = rand.Next(0, 43);
              int q6 = rand.Next(0, 43); 
              a++;

             // 顯示
                Console.WriteLine("第" + a + "組號碼:{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", q1, q2, q3, q4, q5, q6);
             
           }
             //結束
              Console.ReadLine();
            
        } 
    } 
 }
