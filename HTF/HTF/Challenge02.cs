using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge02 : Challenge
    {
        public int total { get; set; }
        public override void crack()
        {
            total = 0;
            foreach (InputValue item in inputValues)
            {
                int num = Int32.Parse(item.data);
                total += num;
            }
        }

        public override void get()
        {
            //inputvalues = 
        }

        public override void post()
        {
            throw new NotImplementedException();
        }
    }
}
