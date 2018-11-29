using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge04: Challenge
    {
        List<int> primesList = new List<int>();
        int min, max;
        List<Value> values = new List<Value>();
        public Challenge04()
        {
            get();
            int max = Int32.Parse(inputValues.ElementAt(1).data);
            int min = Int32.Parse(inputValues.ElementAt(0).data);
            Trace.WriteLine(min);
            Trace.WriteLine(max);


            this.max = max;
            this.min = min;
            crack();
            Thread.Sleep(11000);
            post();
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
                for(int i = 0; i < primesList.Count; i++)
            {
                values.Add(new Value("prime", primesList.ElementAt(i).ToString()));
            }
        }

        public override void get()
        {
            root = getManager.get("7a34919d6dd4c2d9c3f05c6957946b82");
            inputValues = root.question.inputValues;
        }
        public override void post()
        {
            postManager.postChallenge("7a34919d6dd4c2d9c3f05c6957946b82", MainWindow.identifier, root.id, values);
        }
    }
}
