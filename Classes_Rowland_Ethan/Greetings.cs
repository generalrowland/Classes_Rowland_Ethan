using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Rowland_Ethan
{
    class Greetings
    {
        /// <summary>
        ///  
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, Welcome!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
        
    }
}
