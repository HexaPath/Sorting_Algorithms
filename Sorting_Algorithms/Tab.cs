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
            try
            {
                Table[Lenght] = x;
                Lenght++;
            }
            catch (Exception)
            { } 
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
                    str += Table[i];
                }
                else
                {
                    str += Table[i];
                }
            }
            return str;
            //return str;
        }

        public int Sum()
        {
            int sum = 0;
            

            foreach (int element in Table)
            {
                sum += element;
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

            while (count < Lenght)
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
            return false;
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
            int n = Lenght;
            for (int x = 0; x < n; x++)
            {
                for (int i = n - 1; i > x; i--)
                {
                    if (Table[i] < Table[i - 1])
                    {
                        int z = Table[i];
                        Table[i] = Table[i - 1];
                        Table[i - 1] = z;
                    }
                }
            }
            return true;
        }

        public bool Selection()
        {
            int temp_min, temp;
            for (int i = 0; i < Lenght - 1; i++)
            {
                temp_min = Table[i];
                temp = i;
                for (int n = i + 1; n < Lenght; n++)
                {
                    if (Table[n] < temp_min)
                    {
                        temp_min = Table[n];
                        temp = n;
                    }
                }
                Table[temp] = Table[i];
                Table[i] = temp_min;
            }
            return true;
        }

        public bool Insertion(int key)
        {
            for (int i = Lenght - 1; i >= 0; i--)
            {
                if (Table[i] > key)
                {
                    Table[i + 1] = Table[i];
                    Table[i] = key;
                }
                else
                {
                    Table[i + 1] = key;
                    break;
                }
            }
            Lenght++;
            return true;
        }


        /*Tole je pa pol vse za fast sort.... če prau razumem... uglavnem, dela, to je važn*/

        int temp = 0; // Da si shranim cifro nter, ko jo premetavam...

        public int QuickSort(int low, int high)
        {
            int pivot_loc = 0;
            if (low < high)
            {
                pivot_loc = Partition(low, high);
                QuickSort(low, pivot_loc - 1);
                QuickSort(pivot_loc + 1, high);
            }
            return 1; 
        }

        private int Partition(int low, int high)
        {
            int pivot = Table[high];
            int i = low - 1;

            for (int n = low; n < high; n++)
            {
                if (Table[n] <= pivot)
                {
                    i++;
                    Rotate(i, n);
                }
            }
            Rotate(i + 1, high);
            return i + 1;
        }

        private void Rotate(int a, int b)
        {
            temp = Table[a];
            Table[a] = Table[b];
            Table[b] = temp;
        }
    }
}
        
    

