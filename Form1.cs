using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Calc
{
    public partial class Calculator : Form
    {
        #region Dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Dragging(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        SoundPlayer click = new SoundPlayer(Properties.Resources.click);

        bool shift = false;
        bool terminate = false;
        operationBuffer ob = new operationBuffer();
        Value value = new Value();
        
        string rawValue = "";
        int maxLength = 16;


        public Calculator()
        {
            InitializeComponent();
            /*
            //DEBUG
            Value debug_value = new Value();
            //Add modifiers
            debug_value.PushModifier(modifier.SQROOT);
            debug_value.PushModifier(modifier.SQROOT);
            debug_value.PushModifier(modifier.SQROOT);
            //assign value
            debug_value.a = 256;

            Console.WriteLine(debug_value.ToString());
            Console.WriteLine();

            //add operations
            operationBuffer debug_buffer = new operationBuffer();

            debug_buffer.Add(new valueOp(debug_value, operation.ADD));
            debug_value.a = 290625;
            debug_buffer.Add(new valueOp(value, operation.TERMINATE));

            foreach(valueOp v in ob)
            {
                Console.WriteLine(v.ToString());
            }

            Console.WriteLine(debug_buffer.evaluate());
            */

        }

        #region keyboardInput
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            shift = e.Shift ? !shift : false;
            btn_SHIFT.Enabled = shift;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine((int)e.KeyChar);

           switch(e.KeyChar)
            {
                case '1':
                    btn_ONE.PerformClick();
                    break;
                case '2':
                    btn_TWO.PerformClick();
                    break;
                case '3':
                    btn_THREE.PerformClick();
                    break;
                case '4':
                    btn_FOUR.PerformClick();
                    break;
                case '5':
                    btn_FIVE.PerformClick();
                    break;
                case '6':
                    btn_SIX.PerformClick();
                    break;
                case '7':
                    btn_SEVEN.PerformClick();
                    break;
                case '8':
                    btn_EIGHT.PerformClick();
                    break;
                case '9':
                    btn_NINE.PerformClick();
                    break;
                case '0':
                    btn_ZERO.PerformClick();
                    break;
                case (char)8: //backspace
                    btn_delete.PerformClick();
                    break;
                case '+':
                    btn_plus.PerformClick();
                    break;
                case '=':
                    btn_calculate.PerformClick();
                    break;
                case '-':
                    btn_minus.PerformClick();
                    break;
                case '*':
                    btn_multiply.PerformClick();
                    break;
                case '/':
                    btn_divide.PerformClick();
                    break;
                case '.':
                    btn_decimal.PerformClick();
                    break;

            }

        }
        #endregion


        #region functionButtons
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            click.Play();
            
            if (ob.Count() > 0)
            {
                if (ob.Last().O != operation.TERMINATE)
                    ob.Add(new valueOp(value, operation.TERMINATE));
            }
            else
                ob.Add(new valueOp(value, operation.TERMINATE));

            value.ParseValue(rawValue);
            Console.WriteLine(ob);
            value = new Value(ob.evaluate());
            rawValue = ob.evaluate().ToString();
            terminate = true;
            updateDisplay();

        }

        private void del_Click(object sender, EventArgs e)
        {
            click.Play();

            if (rawValue.Length == 0)
                return;
            rawValue = rawValue.Remove(rawValue.Length - 1);
            updateDisplay();
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            click.Play();

            ob = new operationBuffer();
            value = new Value();
            rawValue = "";
            updateDisplay();
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            click.Play();

            value = new Value();
            rawValue = "";
            updateDisplay();
        }
        private void btn_SHIFT_Click(object sender, EventArgs e)
        {
            click.Play();
            shift = !shift;
        }
        #endregion


        #region numberButtons

        void addDigit(char digit)
        {
            click.Play();

            if (rawValue.Length >= maxLength)
                return;

            if (terminate)
            {
                rawValue = "";
                ob = new operationBuffer();
            }
            terminate = false;
            rawValue += digit;
            updateDisplay();
        }
        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (!rawValue.Contains('.'))
                addDigit('.');
        }
        private void btn_ZERO_Click(object sender, EventArgs e)
        {
            addDigit('0');
        }

        private void btn_ONE_Click(object sender, EventArgs e)
        {
            addDigit('1');
        }

        private void btn_TWO_Click(object sender, EventArgs e)
        {
            addDigit('2');
        }

        private void btn_THREE_Click(object sender, EventArgs e)
        {
            addDigit('3');
        }

        private void btn_FOUR_Click(object sender, EventArgs e)
        {
            addDigit('4');
        }

        private void btn_FIVE_Click(object sender, EventArgs e)
        {
            addDigit('5');
        }

        private void btn_SIX_Click(object sender, EventArgs e)
        {
            addDigit('6');
        }

        private void btn_SEVEN_Click(object sender, EventArgs e)
        {
            addDigit('7');
        }

        private void btn_EIGHT_Click(object sender, EventArgs e)
        {
            addDigit('8');
        }

        private void btn_NINE_Click(object sender, EventArgs e)
        {
            addDigit('9');
        }
        #endregion


        #region operatorButtons
        private void pushOp(operation op)
        {
            click.Play();

            if(terminate)
            {
                ob = new operationBuffer();
                rawValue = "";
            }
            terminate = false;
            value.ParseValue(rawValue);

            ob.Add(new valueOp(value, op)) ;
            button_CE_Click(null, null);
            updateDisplay();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            pushOp(operation.ADD);
        }


        private void btn_minus_Click(object sender, EventArgs e)
        {
            pushOp(operation.SUBTRACT);
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            pushOp(operation.MULTIPLY);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            pushOp(operation.DIVIDE);
        }
        #endregion


        #region modifierButtons
        private void pushMod(modifier mod)
        {
            click.Play();
            value.modifiers.Add(mod);
            updateDisplay();
        }

        private void btn_opposite_Click(object sender, EventArgs e)
        {
            click.Play();

            if(value.modifiers.Count() > 0)
            {
                value.modifiers.Add(modifier.OPPOSITE);
            }
            else
            {
                rawValue = rawValue.Contains('-') ? rawValue.Remove(0,1) : rawValue.Insert(0, "-");
            }
            updateDisplay();
        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            pushMod(modifier.SQROOT);
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            pushMod(modifier.SQUARE);
        }

        private void btn_inverse_Click(object sender, EventArgs e)
        {
            pushMod(modifier.INVERSE);
        }
        #endregion


        void updateDisplay()
        {
            lbl_calculation.Text = ob.ToString(); 

            if(value.modifiers.Count() > 0)
            {
                value.ParseValue(rawValue);
                lbl_operation.Text = value.Evaluate().ToString();
                lbl_calculation.Text += value.ToString();

            }
            else
            {
                lbl_operation.Text = rawValue;
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                btn_calculate.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
