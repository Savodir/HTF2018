using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge03 : Challenge
    {
        public override void crack()
        {
            foreach (InputValue item in inputValues)
            {

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

        public bool isLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }
    }
}
