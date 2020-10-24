namespace WF_Calc
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbl_root = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btn_ZERO = new System.Windows.Forms.Button();
            this.btn_opposite = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_THREE = new System.Windows.Forms.Button();
            this.btn_TWO = new System.Windows.Forms.Button();
            this.btn_ONE = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_SIX = new System.Windows.Forms.Button();
            this.btn_FIVE = new System.Windows.Forms.Button();
            this.btn_FOUR = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_NINE = new System.Windows.Forms.Button();
            this.btn_EIGHT = new System.Windows.Forms.Button();
            this.btn_SEVEN = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_SHIFT = new System.Windows.Forms.Button();
            this.btn_root = new System.Windows.Forms.Button();
            this.btn_power = new System.Windows.Forms.Button();
            this.btn_inverse = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_calculation = new System.Windows.Forms.Label();
            this.lbl_operation = new System.Windows.Forms.Label();
            this.tbl_root.SuspendLayout();
            this.tbl_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_root
            // 
            this.tbl_root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tbl_root.ColumnCount = 1;
            this.tbl_root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_root.Controls.Add(this.tbl_buttons, 0, 2);
            this.tbl_root.Controls.Add(this.lbl_calculation, 0, 0);
            this.tbl_root.Controls.Add(this.lbl_operation, 0, 1);
            this.tbl_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_root.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tbl_root.Location = new System.Drawing.Point(0, 12);
            this.tbl_root.Margin = new System.Windows.Forms.Padding(0);
            this.tbl_root.Name = "tbl_root";
            this.tbl_root.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.tbl_root.RowCount = 3;
            this.tbl_root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tbl_root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tbl_root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tbl_root.Size = new System.Drawing.Size(264, 472);
            this.tbl_root.TabIndex = 0;
            this.tbl_root.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            // 
            // tbl_buttons
            // 
            this.tbl_buttons.ColumnCount = 4;
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.Controls.Add(this.btn_decimal, 2, 5);
            this.tbl_buttons.Controls.Add(this.btn_ZERO, 1, 5);
            this.tbl_buttons.Controls.Add(this.btn_opposite, 0, 5);
            this.tbl_buttons.Controls.Add(this.btn_plus, 3, 4);
            this.tbl_buttons.Controls.Add(this.btn_THREE, 2, 4);
            this.tbl_buttons.Controls.Add(this.btn_TWO, 1, 4);
            this.tbl_buttons.Controls.Add(this.btn_ONE, 0, 4);
            this.tbl_buttons.Controls.Add(this.btn_minus, 3, 3);
            this.tbl_buttons.Controls.Add(this.btn_SIX, 2, 3);
            this.tbl_buttons.Controls.Add(this.btn_FIVE, 1, 3);
            this.tbl_buttons.Controls.Add(this.btn_FOUR, 0, 3);
            this.tbl_buttons.Controls.Add(this.btn_multiply, 3, 2);
            this.tbl_buttons.Controls.Add(this.btn_NINE, 2, 2);
            this.tbl_buttons.Controls.Add(this.btn_EIGHT, 1, 2);
            this.tbl_buttons.Controls.Add(this.btn_SEVEN, 0, 2);
            this.tbl_buttons.Controls.Add(this.btn_divide, 3, 1);
            this.tbl_buttons.Controls.Add(this.btn_SHIFT, 0, 0);
            this.tbl_buttons.Controls.Add(this.btn_root, 2, 1);
            this.tbl_buttons.Controls.Add(this.btn_power, 1, 1);
            this.tbl_buttons.Controls.Add(this.btn_inverse, 0, 1);
            this.tbl_buttons.Controls.Add(this.btn_delete, 3, 0);
            this.tbl_buttons.Controls.Add(this.btn_C, 2, 0);
            this.tbl_buttons.Controls.Add(this.button_CE, 1, 0);
            this.tbl_buttons.Controls.Add(this.btn_calculate, 3, 5);
            this.tbl_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_buttons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tbl_buttons.Location = new System.Drawing.Point(3, 144);
            this.tbl_buttons.Name = "tbl_buttons";
            this.tbl_buttons.RowCount = 6;
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbl_buttons.Size = new System.Drawing.Size(258, 325);
            this.tbl_buttons.TabIndex = 0;
            // 
            // btn_decimal
            // 
            this.btn_decimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_decimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_decimal.ForeColor = System.Drawing.Color.White;
            this.btn_decimal.Location = new System.Drawing.Point(131, 273);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(58, 49);
            this.btn_decimal.TabIndex = 23;
            this.btn_decimal.Text = ".";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.btn_decimal_Click);
            // 
            // btn_ZERO
            // 
            this.btn_ZERO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ZERO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ZERO.ForeColor = System.Drawing.Color.White;
            this.btn_ZERO.Location = new System.Drawing.Point(67, 273);
            this.btn_ZERO.Name = "btn_ZERO";
            this.btn_ZERO.Size = new System.Drawing.Size(58, 49);
            this.btn_ZERO.TabIndex = 22;
            this.btn_ZERO.Text = "0";
            this.btn_ZERO.UseVisualStyleBackColor = true;
            this.btn_ZERO.Click += new System.EventHandler(this.btn_ZERO_Click);
            // 
            // btn_opposite
            // 
            this.btn_opposite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_opposite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_opposite.ForeColor = System.Drawing.Color.White;
            this.btn_opposite.Location = new System.Drawing.Point(3, 273);
            this.btn_opposite.Name = "btn_opposite";
            this.btn_opposite.Size = new System.Drawing.Size(58, 49);
            this.btn_opposite.TabIndex = 21;
            this.btn_opposite.Text = "-/+";
            this.btn_opposite.UseVisualStyleBackColor = true;
            this.btn_opposite.Click += new System.EventHandler(this.btn_opposite_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(195, 219);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(60, 48);
            this.btn_plus.TabIndex = 20;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_THREE
            // 
            this.btn_THREE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_THREE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_THREE.ForeColor = System.Drawing.Color.White;
            this.btn_THREE.Location = new System.Drawing.Point(131, 219);
            this.btn_THREE.Name = "btn_THREE";
            this.btn_THREE.Size = new System.Drawing.Size(58, 48);
            this.btn_THREE.TabIndex = 19;
            this.btn_THREE.Text = "3";
            this.btn_THREE.UseVisualStyleBackColor = true;
            this.btn_THREE.Click += new System.EventHandler(this.btn_THREE_Click);
            // 
            // btn_TWO
            // 
            this.btn_TWO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TWO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TWO.ForeColor = System.Drawing.Color.White;
            this.btn_TWO.Location = new System.Drawing.Point(67, 219);
            this.btn_TWO.Name = "btn_TWO";
            this.btn_TWO.Size = new System.Drawing.Size(58, 48);
            this.btn_TWO.TabIndex = 18;
            this.btn_TWO.Text = "2";
            this.btn_TWO.UseVisualStyleBackColor = true;
            this.btn_TWO.Click += new System.EventHandler(this.btn_TWO_Click);
            // 
            // btn_ONE
            // 
            this.btn_ONE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ONE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ONE.ForeColor = System.Drawing.Color.White;
            this.btn_ONE.Location = new System.Drawing.Point(3, 219);
            this.btn_ONE.Name = "btn_ONE";
            this.btn_ONE.Size = new System.Drawing.Size(58, 48);
            this.btn_ONE.TabIndex = 17;
            this.btn_ONE.Text = "1";
            this.btn_ONE.UseVisualStyleBackColor = true;
            this.btn_ONE.Click += new System.EventHandler(this.btn_ONE_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.Location = new System.Drawing.Point(195, 165);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(60, 48);
            this.btn_minus.TabIndex = 16;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_SIX
            // 
            this.btn_SIX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SIX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SIX.ForeColor = System.Drawing.Color.White;
            this.btn_SIX.Location = new System.Drawing.Point(131, 165);
            this.btn_SIX.Name = "btn_SIX";
            this.btn_SIX.Size = new System.Drawing.Size(58, 48);
            this.btn_SIX.TabIndex = 15;
            this.btn_SIX.Text = "6";
            this.btn_SIX.UseVisualStyleBackColor = true;
            this.btn_SIX.Click += new System.EventHandler(this.btn_SIX_Click);
            // 
            // btn_FIVE
            // 
            this.btn_FIVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FIVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FIVE.ForeColor = System.Drawing.Color.White;
            this.btn_FIVE.Location = new System.Drawing.Point(67, 165);
            this.btn_FIVE.Name = "btn_FIVE";
            this.btn_FIVE.Size = new System.Drawing.Size(58, 48);
            this.btn_FIVE.TabIndex = 14;
            this.btn_FIVE.Text = "5";
            this.btn_FIVE.UseVisualStyleBackColor = true;
            this.btn_FIVE.Click += new System.EventHandler(this.btn_FIVE_Click);
            // 
            // btn_FOUR
            // 
            this.btn_FOUR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_FOUR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_FOUR.ForeColor = System.Drawing.Color.White;
            this.btn_FOUR.Location = new System.Drawing.Point(3, 165);
            this.btn_FOUR.Name = "btn_FOUR";
            this.btn_FOUR.Size = new System.Drawing.Size(58, 48);
            this.btn_FOUR.TabIndex = 13;
            this.btn_FOUR.Text = "4";
            this.btn_FOUR.UseVisualStyleBackColor = true;
            this.btn_FOUR.Click += new System.EventHandler(this.btn_FOUR_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_multiply.ForeColor = System.Drawing.Color.White;
            this.btn_multiply.Location = new System.Drawing.Point(195, 111);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(60, 48);
            this.btn_multiply.TabIndex = 12;
            this.btn_multiply.Text = "✕";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_NINE
            // 
            this.btn_NINE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NINE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NINE.ForeColor = System.Drawing.Color.White;
            this.btn_NINE.Location = new System.Drawing.Point(131, 111);
            this.btn_NINE.Name = "btn_NINE";
            this.btn_NINE.Size = new System.Drawing.Size(58, 48);
            this.btn_NINE.TabIndex = 11;
            this.btn_NINE.Text = "9";
            this.btn_NINE.UseVisualStyleBackColor = true;
            this.btn_NINE.Click += new System.EventHandler(this.btn_NINE_Click);
            // 
            // btn_EIGHT
            // 
            this.btn_EIGHT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_EIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EIGHT.ForeColor = System.Drawing.Color.White;
            this.btn_EIGHT.Location = new System.Drawing.Point(67, 111);
            this.btn_EIGHT.Name = "btn_EIGHT";
            this.btn_EIGHT.Size = new System.Drawing.Size(58, 48);
            this.btn_EIGHT.TabIndex = 10;
            this.btn_EIGHT.Text = "8";
            this.btn_EIGHT.UseVisualStyleBackColor = true;
            this.btn_EIGHT.Click += new System.EventHandler(this.btn_EIGHT_Click);
            // 
            // btn_SEVEN
            // 
            this.btn_SEVEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SEVEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SEVEN.ForeColor = System.Drawing.Color.White;
            this.btn_SEVEN.Location = new System.Drawing.Point(3, 111);
            this.btn_SEVEN.Name = "btn_SEVEN";
            this.btn_SEVEN.Size = new System.Drawing.Size(58, 48);
            this.btn_SEVEN.TabIndex = 9;
            this.btn_SEVEN.Text = "7";
            this.btn_SEVEN.UseVisualStyleBackColor = true;
            this.btn_SEVEN.Click += new System.EventHandler(this.btn_SEVEN_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_divide.ForeColor = System.Drawing.Color.White;
            this.btn_divide.Location = new System.Drawing.Point(195, 57);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(60, 48);
            this.btn_divide.TabIndex = 8;
            this.btn_divide.Text = "÷";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_SHIFT
            // 
            this.btn_SHIFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SHIFT.Enabled = false;
            this.btn_SHIFT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SHIFT.ForeColor = System.Drawing.Color.White;
            this.btn_SHIFT.Location = new System.Drawing.Point(3, 3);
            this.btn_SHIFT.Name = "btn_SHIFT";
            this.btn_SHIFT.Size = new System.Drawing.Size(58, 48);
            this.btn_SHIFT.TabIndex = 7;
            this.btn_SHIFT.Text = "SHIFT";
            this.btn_SHIFT.UseVisualStyleBackColor = true;
            this.btn_SHIFT.Click += new System.EventHandler(this.btn_SHIFT_Click);
            // 
            // btn_root
            // 
            this.btn_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_root.ForeColor = System.Drawing.Color.White;
            this.btn_root.Location = new System.Drawing.Point(131, 57);
            this.btn_root.Name = "btn_root";
            this.btn_root.Size = new System.Drawing.Size(58, 48);
            this.btn_root.TabIndex = 6;
            this.btn_root.Text = "√x";
            this.btn_root.UseVisualStyleBackColor = true;
            this.btn_root.Click += new System.EventHandler(this.btn_root_Click);
            // 
            // btn_power
            // 
            this.btn_power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_power.ForeColor = System.Drawing.Color.White;
            this.btn_power.Location = new System.Drawing.Point(67, 57);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(58, 48);
            this.btn_power.TabIndex = 5;
            this.btn_power.Text = "x²";
            this.btn_power.UseVisualStyleBackColor = true;
            this.btn_power.Click += new System.EventHandler(this.btn_power_Click);
            // 
            // btn_inverse
            // 
            this.btn_inverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_inverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inverse.ForeColor = System.Drawing.Color.White;
            this.btn_inverse.Location = new System.Drawing.Point(3, 57);
            this.btn_inverse.Name = "btn_inverse";
            this.btn_inverse.Size = new System.Drawing.Size(58, 48);
            this.btn_inverse.TabIndex = 4;
            this.btn_inverse.Text = "⅟x";
            this.btn_inverse.UseVisualStyleBackColor = true;
            this.btn_inverse.Click += new System.EventHandler(this.btn_inverse_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(195, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(60, 48);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "⌫";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.del_Click);
            // 
            // btn_C
            // 
            this.btn_C.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_C.ForeColor = System.Drawing.Color.White;
            this.btn_C.Location = new System.Drawing.Point(131, 3);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(58, 48);
            this.btn_C.TabIndex = 2;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // button_CE
            // 
            this.button_CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CE.ForeColor = System.Drawing.Color.White;
            this.button_CE.Location = new System.Drawing.Point(67, 3);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(58, 48);
            this.button_CE.TabIndex = 1;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calculate.ForeColor = System.Drawing.Color.White;
            this.btn_calculate.Location = new System.Drawing.Point(195, 273);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(60, 49);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "=";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_calculation
            // 
            this.lbl_calculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_calculation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_calculation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculation.Location = new System.Drawing.Point(3, 24);
            this.lbl_calculation.Name = "lbl_calculation";
            this.lbl_calculation.Size = new System.Drawing.Size(258, 47);
            this.lbl_calculation.TabIndex = 1;
            this.lbl_calculation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_operation
            // 
            this.lbl_operation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_operation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation.Location = new System.Drawing.Point(3, 71);
            this.lbl_operation.Name = "lbl_operation";
            this.lbl_operation.Size = new System.Drawing.Size(258, 70);
            this.lbl_operation.TabIndex = 2;
            this.lbl_operation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AcceptButton = this.btn_calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CancelButton = this.btn_C;
            this.ClientSize = new System.Drawing.Size(264, 484);
            this.ControlBox = false;
            this.Controls.Add(this.tbl_root);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(280, 500);
            this.Name = "Calculator";
            this.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragging);
            this.tbl_root.ResumeLayout(false);
            this.tbl_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_root;
        private System.Windows.Forms.TableLayoutPanel tbl_buttons;
        private System.Windows.Forms.Label lbl_calculation;
        private System.Windows.Forms.Label lbl_operation;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button btn_power;
        private System.Windows.Forms.Button btn_inverse;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_SHIFT;
        private System.Windows.Forms.Button btn_root;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btn_ZERO;
        private System.Windows.Forms.Button btn_opposite;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_THREE;
        private System.Windows.Forms.Button btn_TWO;
        private System.Windows.Forms.Button btn_ONE;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_SIX;
        private System.Windows.Forms.Button btn_FIVE;
        private System.Windows.Forms.Button btn_FOUR;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_NINE;
        private System.Windows.Forms.Button btn_EIGHT;
        private System.Windows.Forms.Button btn_SEVEN;
    }
}

