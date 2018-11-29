using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge08 : Challenge
    {
        String solution = "";
        public override void crack()
        {
            foreach (InputValue item in inputValues)
            {
                Byte[] data = GetBytesFromBinaryString(item.data);
                solution = Encoding.ASCII.GetString(data);
            }
        }

        public override void get()
        {
            root = getManager.get("6451359698245e2b02bdf79d5f99fe5b");
            inputValues = root.question.inputValues;
        }

        public override void post()
        {
            List<Value> values = new List<Value>();
            Value value = new Value("decoded", solution);
            values.Add(value);
            postManager.postChallenge("6451359698245e2b02bdf79d5f99fe5b", "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx", root.id, values);
        }

        public Byte[] GetBytesFromBinaryString(String binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }
    }
}
