using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        public String CurrentValue { get; set; }
        public String CurrentValue2 { get; set; }

        public enum Action
        {
            None,
            Add,
            Sub,
            MUl,
            Div,
            Recipro,
            Mod
        }

        public Action currentAction;

        public Calc()
        {
            InitializeComponent();

            currentAction = Action.None;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void Append(string val)
        {
            if (currentAction == Action.None)
            {
                CurrentValue += val;
                CurrentValue = CurrentValue.TrimStart("0".ToCharArray());
                txtVal.Text = CurrentValue;
            }
            else
            {
                CurrentValue2 += val;
                CurrentValue2 = CurrentValue2.TrimStart("0".ToCharArray());
                txtVal.Text = CurrentValue2;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Append(((Button)sender).Text.Trim());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CurrentValue = CurrentValue.Substring(0, CurrentValue.Length - 1);
            txtVal.Text = CurrentValue;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentAction = Action.Add;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            currentAction = Action.Sub;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            currentAction = Action.Div;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            currentAction = Action.MUl;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentAction == Action.None)
                return;

            int i = Int32.Parse(CurrentValue);
            int j = Int32.Parse(CurrentValue2);

            switch (currentAction)
            {
                case Action.Add:
                    txtVal.Text = (i + j).ToString();
                    break;
                case Action.Sub:
                    txtVal.Text = (i - j).ToString();
                    break;
                case Action.MUl:
                    txtVal.Text = (i*j).ToString();
                    break;
                case Action.Div:
                    txtVal.Text = (i*j).ToString();
                    break;

            }

            currentAction = Action.None;

            CurrentValue = CurrentValue2 = String.Empty;
        }


    }
}
