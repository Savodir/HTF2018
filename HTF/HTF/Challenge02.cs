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
            root = getManager.get("593bc0a2e0dfdc53b239bc2a96ab0fd5");
            inputValues = root.question.inputValues;
        }

        public override void post()
        {
            List<Value> values = new List<Value>();
            Value value = new Value("sum", total.ToString());
            values.Add(value);
            postManager.postChallenge("593bc0a2e0dfdc53b239bc2a96ab0fd5", "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx", root.id, values);
        }
    }
}
