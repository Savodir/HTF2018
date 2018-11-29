using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    public class InputValue
    {
        public string name { get; set; }
        public string data { get; set; }
    }

    public class Question
    {
        public List<InputValue> inputValues { get; set; }
    }

    public class InputValue2
    {
        public string name { get; set; }
        public string data { get; set; }
    }

    public class Question2
    {
        public List<InputValue2> inputValues { get; set; }
    }

    public class Value
    {
        public string name { get; set; }
        public string data { get; set; }
    }

    public class Answer
    {
        public string challengeId { get; set; }
        public List<Value> values { get; set; }
    }

    public class Example
    {
        public Question2 question { get; set; }
        public Answer answer { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public string identifier { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Question question { get; set; }
        public Example example { get; set; }
    }
}
