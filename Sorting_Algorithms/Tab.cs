using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Tab
    {
        private int[] Table = new int[100];
        public int Lenght { get; set; }

        public Tab()
        {
            Lenght = 0;
        }

        public void Add(int x)
        {
            Table[Lenght] = x;
            Lenght++;
        }

        public bool Contains(int x)
        {
            for (int i = 0; i < Lenght; i++)
            {
                if (Table[i] == x)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Lenght; i++)
            {
                if (i != 0)
                {
                    str += ", ";
                }
            }
            return str;
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < Lenght; i++)
            {
                sum += Table[i];
            }
            return sum;
        }

        public int Min()
        {
            int Min = Table[0];
            for (int i = 0; i < Lenght; i++)
            {
                if (Min > Table[i])
                {
                    Min = Table[i];
                }
            }
            return Min;
        }

        public int Max()
        {
            int Max = Table[0];
            for (int i = 0; i < Lenght; i++)
            {
                if (Max < Table[i])
                {
                    Max = Table[i];
                }
            }
            return Max;
        }

        public double Avg()
        {
            double avg = 0.00;
            avg = (double)Sum() / (double)Lenght;
            return avg;
        }


        ///      ///    ///
        /// Heavy Shit  ///
        ///     ///     ///


        public bool Binary(int x)
        {
            int min = 0;
            int max = Lenght;
            int mid = Lenght / 2;
            int count = 0;

            while (true)
            {
                if (x == mid)
                {
                    return true;
                }
                else if (x > mid)
                {
                    min = mid;
                    mid = (max + min) / 2;
                }
                else if (x < mid)
                {
                    max = mid;
                    mid = (max + min) / 2;
                }
                count++;
            }
        }

        public bool Edit()
        {
            int last = Lenght - 1;
            for(int i = 0; i < Lenght; i++)
            {
                int x = last - i;
                if (Table[last] > Table[x])
                {
                    Table[x] = Table[last];
                }
                last--;
            }
            return false;
        }

        public bool BubbleSort()
        {
            bool sorted;
            int x;
            int newLenght = Lenght;
            do
            {
                sorted = false;
                for (int i = 0; i < newLenght; i++)
                {
                    int iplusena = i + 1;
                    if (Table[i] > Table[iplusena])
                    {
                        x = Table[i];
                        Table[i] = Table[iplusena];
                        Table[iplusena] = x;
                        sorted = true;

                    }
                }
            }
            while (sorted);
            return true;
        }

        public bool Selection()
        { 
            int min, temp; 
            for (int first = 0; first < Lenght; first++)
            {
                min = first;
                for(int i = first + 1; i < Lenght; i++)
                {
                    if(Table[i] < Table[min])
                    {
                        min = i;
                    }
                    temp = Table[min];
                    Table[min] = Table[first];
                    Table[first] = temp;
                }
            }
            return true;
        }





    }
}
        
    

