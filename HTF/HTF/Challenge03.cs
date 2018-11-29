using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge03
    {
        int min, max;
        public Challenge03(int min, int max) {
            this.max = max;
        }
        public List<int> getPrimesList()
        {
            List<int> primes = new List<int>();
            long sum = 0;
            long n = max;
            bool[] e = new bool[n];//by default they're all false
            for (int i = 2; i < n; i++)
            {
                e[i] = true;//set all numbers to true
            }
            //weed out the non primes by finding mutiples 
            for (int j = 2; j < n; j++)
            {
                if (e[j])//is true
                {
                    for (long p = 2; (p * j) < n; p++)
                    {
                        e[p * j] = false;
                    }
                    if (j > min) { primes.Add(j);
                        Trace.WriteLine(j);
                    }
                }
            }
            return primes;
        }
    }
}
