using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Array.Models;

namespace Array.Helpers
{
    public class SortHelper
    {
        public int NMenor(IEnumerable<int> Numeros)
        {
            int max = int.MinValue;
            foreach(int num in Numeros)
            
                if(num > max)
                
                    max = num; 
                
                return max;
       
        }

        public int NMayor(IEnumerable<int> Numeros)
        {
            int min = int.MaxValue;
            foreach (int num in Numeros)
                if (num < min)
                    min = num;
            return min;
        }
    }

}
