using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    abstract class Challenge
    {
        public RootObject root { get; set; }
        public Question question { get; set; }
        public List<InputValue> inputValues { get; set; }

        abstract public void get();
        abstract public void post();
        abstract public void crack();
    }
}
