using System;
using Ncal
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge09 : Challenge
    {
        double result = 0;
        String formula = "";
        public override void crack()
        {
            foreach (InputValue item in inputValues)
            {
                formula += item.name;
                formula += item.data;
            }

            result = Math.Round((double)result, 2);

        }

        public override void get()
        {
            root = getManager.get("8d77e8f00e8e2ca67edcb07e90fb82fc");
            inputValues = root.question.inputValues;
        }

        public override void post()
        {
            List<Value> values = new List<Value>();
            Value value = new Value("answer", result.ToString());
            Value value2 = new Value("formula", formula);
            values.Add(value);
            values.Add(value2);
            postManager.postChallenge("8d77e8f00e8e2ca67edcb07e90fb82fc", "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx", root.id, values);
        }
    }
}
