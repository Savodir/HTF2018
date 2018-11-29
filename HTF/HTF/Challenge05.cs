using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge05 : Challenge

    {
        List<Value> values = new List<Value>();

        String destinationPlanet;
        long length;
        Double selectedLength, calculatedLength;
        InputValue selectedValue;
        long earthyear;
        public Challenge05()
        {
            get();
            crack();
            Thread.Sleep(11000);
            post();

        }
        public override void crack()
        {
            length = long.Parse(inputValues.ElementAt(0).data);
            destinationPlanet = inputValues.ElementAt(1).data;
            earthyear = long.Parse(inputValues.ElementAt(2).data);
            Trace.WriteLine(destinationPlanet);
            Trace.WriteLine("Length" + length);

            for (int i = 2; i < inputValues.Count; i++)
            {
                if (inputValues.ElementAt(i).name.ToLower().Contains(destinationPlanet))
                {
                    selectedLength = Double.Parse(inputValues.ElementAt(i).data);
                    Trace.WriteLine(inputValues.ElementAt(i).name);
                }
            }
            Trace.WriteLine("Selected Length" + selectedLength);
            Double earthlength = length / earthyear;
            calculatedLength = earthlength * selectedLength;
            calculatedLength = Math.Round((double)calculatedLength, 2);
            Trace.WriteLine(calculatedLength);

            values.Add(new Value("ageInYears", calculatedLength.ToString()));
        }

        public override void get()
        {
            root = getManager.get("d230ea19237b0b1ba70e5464f00c4717");
            inputValues = root.question.inputValues;
        }

        public override void post()
        {
            postManager.postChallenge("d230ea19237b0b1ba70e5464f00c4717", MainWindow.identifier, root.id, values);
        }
    }
}
