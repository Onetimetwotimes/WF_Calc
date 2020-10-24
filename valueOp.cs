using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Calc
{
    class valueOp
    {
        public Value V { get; }
        public operation O { get; } = operation.TERMINATE;
        public valueOp(Value v, operation op)
        {
            this.V = v;
            this.O = op;
        }

        public override string ToString()
        {
            return V.ToString() +" "+ O.GetDescription();
        }
    }


    class operationBuffer : List<valueOp>
    {

        public double evaluate()
        {
            operation currentOp = this[0].O;
            operation nextOp;
            double result = this[0].V.Evaluate();
            foreach(valueOp vo in this.Skip(1))
            {
                nextOp = vo.O;
                switch(currentOp)
                {
                    case operation.ADD:
                        result += vo.V.Evaluate();
                        break;
                    case operation.SUBTRACT:
                        result -= vo.V.Evaluate();
                        break;
                    case operation.MULTIPLY:
                        result *= vo.V.Evaluate();
                        break;
                    case operation.DIVIDE:
                        result /= vo.V.Evaluate();
                        break;
                }
                currentOp = nextOp;
            }
            return result;
        }

        public override string ToString()
        {
            string result = "";
            foreach(valueOp vo in this)
            {
                result += vo.ToString();
            }
            return result;
        }
    }
}
