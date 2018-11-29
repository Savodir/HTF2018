using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class Challenge03 : Challenge
    {
        String solution = "";
        public override void crack()
        {
            
            foreach (InputValue item in inputValues)
            {
                for (int i = 0; i < item.data.Length; i++)
                {
                    char c = item.data[i];
                    if (isLetter(c))
                    {
                        switch (c)
                        {
                            case 'a':
                                solution += 'z';
                                break;
                            case 'b':
                                solution += 'y';
                                break;
                            case 'c':
                                solution += 'x';
                                break;
                            case 'd':
                                solution += 'w';
                                break;
                            case 'e':
                                solution += 'v';
                                break;
                            case 'f':
                                solution += 'u';
                                break;
                            case 'g':
                                solution += 't';
                                break;
                            case 'h':
                                solution += 's';
                                break;
                            case 'i':
                                solution += 'r';
                                break;
                            case 'j':
                                solution += 'q';
                                break;
                            case 'k':
                                solution += 'p';
                                break;
                            case 'l':
                                solution += 'o';
                                break;
                            case 'm':
                                solution += 'n';
                                break;
                            case 'n':
                                solution += 'm';
                                break;
                            case 'o':
                                solution += 'l';
                                break;
                            case 'p':
                                solution += 'k';
                                break;
                            case 'q':
                                solution += 'j';
                                break;
                            case 'r':
                                solution += 'i';
                                break;
                            case 's':
                                solution += 'h';
                                break;
                            case 't':
                                solution += 'g';
                                break;
                            case 'u':
                                solution += 'f';
                                break;
                            case 'v':
                                solution += 'e';
                                break;
                            case 'w':
                                solution += 'd';
                                break;
                            case 'x':
                                solution += 'c';
                                break;
                            case 'y':
                                solution += 'b';
                                break;
                            case 'z':
                                solution += 'a';
                                break;
                        }
                    }
                    else
                    {
                        solution += item.data[i];
                    }

                }
            }
            Trace.WriteLine(solution);
        }

        public override void get()
        {
            root = getManager.get("5be0b78cc8dc68e6009a8b6fd347a819");
            inputValues = root.question.inputValues;
        }

        public override void post()
        {
            List<Value> values = new List<Value>();
            Value value = new Value("decoded", solution);
            values.Add(value);
            postManager.postChallenge("5be0b78cc8dc68e6009a8b6fd347a819", "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx", root.id, values);
        }

        public bool isLetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }
    }
}
