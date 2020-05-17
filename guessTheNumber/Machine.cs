using System;
using System.Collections.Generic;
using System.Text;

namespace guessTheNumber
{
    class Machine
    {
        //находим рандомное значение
        static Random random = new Random(); 
       public int machineGiveNumber { get; } = random.Next(0, 101);

        //бинарный поиск
        int tmp;
        public int BinarySearch(int max, int min) 
        {
            int searchNum;
            if (max == this.tmp) { 
             searchNum = (max + min)/2 + min;
                this.tmp = searchNum;
            }
            else
            {
                 searchNum = (max + min) / 2;
            }
            return searchNum;
        }
       
        
    }
}
