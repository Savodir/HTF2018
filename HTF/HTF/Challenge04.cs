using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge04: Challenge
    {
        List<int> primesList = new List<int>();
        int min, max;
        public Challenge04(int min, int max)
        {
            this.max = max;
            this.min = min;
            crack();
        }

        public override void crack()
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
                        if (j > min)
                        {
                            primesList.Add(j);
                            Trace.WriteLine(j);
                        }
                    }
                }
        }

        public override void get()
        {
            throw new NotImplementedException();
        }
        public override void post()
        {
            throw new NotImplementedException();
        }
    }
}
