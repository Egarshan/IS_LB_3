using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_LB_3
{
    public partial class NumbersReader : Form
    {
        const int SIZE = 35;
        NumbersData ND;
        string Message = "";

        int TestCounter;

        int InputNum;

        static int[] weights = new int[SIZE];
        static int limit = 7;
        static Random RND = new Random(Guid.NewGuid().GetHashCode());

        public NumbersReader()
        {
            InitializeComponent();
            ND = new NumbersData();
        }

        private void Numbers_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Active_btn.Visible = true;

            foreach (Control c in Defect_box.Controls)
                c.BackColor = Color.White;

            Message_field.Text = null;

            TestCounter = 0;

            InputNum = int.Parse(Numbers_list.SelectedItem.ToString());
            DrawCipher(InputNum, ND.nums[InputNum], Original_box);
        }

        private void Active_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SIZE; i++)
                weights[i] = 0;

            Training();
            Test_btn.Visible = true;

            TestCounter = 0;
        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
            if (TestCounter < 3)
            {
                DrawCipher(InputNum, ND.def[InputNum][TestCounter], Defect_box);
                if (Check(ND.def[InputNum][TestCounter++]))
                    Message_field.Text = "This is " + InputNum;
                else
                    Message_field.Text = "This is NOT " + InputNum;
            }
            else
                TestCounter = 0;
        }

        void Training()
        {
            for (int i = 0; i < 10; i++)
            {
                var RandNum = RND.Next(0, 10);
                if (RandNum != InputNum)
                    if (Check(ND.nums[RandNum]))
                        Dec(ND.nums[RandNum]);
                else
                    if (!Check(ND.nums[InputNum]))
                        Inc(ND.nums[InputNum]);
            }
            for (int i = 0; i < 10; i++)
                Message += i + " is " + Numbers_list.SelectedItem.ToString() + ": " + Check(ND.nums[i]) + '\n';

            DialogResult DR = MessageBox.Show(Message);
            Message = "";
        }

        static bool Check(char[] NumberString)
        {
            var sum = 0;
            for (int i = 0; i < SIZE; i++)
            {
                sum += int.Parse(NumberString[i].ToString()) * weights[i];
            }
            if (sum >= limit) return true;
            else return false;
        }

        static void Dec(char[] NumberString)
        {
            for (int i = 0; i < SIZE; i++)
                if (int.Parse(NumberString[i].ToString()) == 1)
                    weights[i]--;
        }
        
        static void Inc(char[] NumberString)
        {
            for (int i = 0; i < SIZE; i++)
                if (int.Parse(NumberString[i].ToString()) == 1)
                    weights[i]++;
        }

        void DrawCipher(int cipher, char[] array, GroupBox GB)
        {
            foreach (Control c in GB.Controls)
            {
                c.BackColor = Color.White;
                if (int.Parse(array[c.TabIndex].ToString()) == 1)
                    c.BackColor = Color.Black;
            }
        }
    }
}
