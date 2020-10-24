using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Calc
{
    class Value
    {
        public double a;
        public List<modifier> modifiers = new List<modifier>();

        public Value(double a = 0)
        {
            this.a = a;
        }

        public void ParseValue(string value)
        {
            try
            {
                a = double.Parse(value);
            } catch (FormatException)
            {
                Console.WriteLine("Could not parse value!");
            }
        }
        public void PushModifier(modifier m)
        {
            modifiers.Add(m);
        }

        public double Evaluate()
        {
            double result = a;
            foreach(modifier m in modifiers)
            {
                switch(m)
                {
                    case modifier.INVERSE:
                        result = 1 / result;
                        break;
                    case modifier.SQROOT:
                        result = Math.Sqrt(result);
                        break;
                    case modifier.SQUARE:
                        result = result * result;
                        break;
                    case modifier.OPPOSITE:
                        result *= -1;
                        break;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string result = a.ToString();
            foreach(modifier m in modifiers)
            {
                result = result.Insert(0,m.ToString() + "(") + ")";
            }
            return result;
        }
    }
}
