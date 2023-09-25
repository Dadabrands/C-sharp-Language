using System;
using System.Collections.Generic;
using System.Text;

namespace Properties1
{
    class Box
    {
        //  Member variables
        private int length = 3;
        public int height;
        public int width;


        public int volume
        {
            get
            {
                return length * height * width;
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Lenght is {length} and height is {height} so the volume is {volume}");
        }





    }

}


