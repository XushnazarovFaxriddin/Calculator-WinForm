using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kankulyator
{
    public partial class Form1 : Form
    {
        public Dictionary<string, string> History = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        public string eTxt = "";

        private void ekranTxt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //amalTxt.Text = ekranTxtBox.Text;
            
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            eTxt += "0";
            ekranTxtBox.Text = eTxt;
        }

        private void tenglikBtn_Click(object sender, EventArgs e)
        {
            amalTxt.Text = ekranTxtBox.Text;
            ekranTxtBox.Text = Hisoblash.Eval(ekranTxtBox.Text);
            eTxt = ekranTxtBox.Text;
            try
            {
                History.Add(amalTxt.Text, eTxt);
            }
            catch
            {
                amalTxt.Text = "";
            }
        }

        private void ochirBtn_Click(object sender, EventArgs e)
        {
            eTxt = Remove.ochir(ekranTxtBox.Text);
            ekranTxtBox.Text = eTxt;
        }
        private void negativBtn_Click(object sender, EventArgs e)
        {
            if(ekranTxtBox.Text != string.Empty && ekranTxtBox.Text[0] == '+')
            {
                eTxt = '-' + Remove.oldOchir(eTxt);
                ekranTxtBox.Text = eTxt;
            }
            if (ekranTxtBox.Text==string.Empty || ekranTxtBox.Text[0]!='-' || ekranTxtBox.Text[0] == '+')
            {
                eTxt = '-' + eTxt;
                ekranTxtBox.Text = eTxt;
            }
            else
            {
                eTxt = Remove.oldOchir(ekranTxtBox.Text);
                ekranTxtBox.Text = eTxt;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            eTxt += "1";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            eTxt += "2";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            eTxt += "3";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            eTxt += "4";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            eTxt += "5";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            eTxt += "6";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            eTxt += "7";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            eTxt += "8";
            ekranTxtBox.Text = eTxt;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            eTxt += "9";
            ekranTxtBox.Text = eTxt;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            eTxt += "+";
            ekranTxtBox.Text = eTxt;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            eTxt += "-";
            ekranTxtBox.Text = eTxt;
        }

        private void kopaytirishBtn_Click(object sender, EventArgs e)
        {
            eTxt += "×";
            ekranTxtBox.Text = eTxt;
        }

        private void bolishBtn_Click(object sender, EventArgs e)
        {
            eTxt += "/";
            ekranTxtBox.Text = eTxt;
        }

        private void vergulBtn_Click(object sender, EventArgs e)
        {
            eTxt += ",";
            ekranTxtBox.Text = eTxt;
        }

        private void factorialBtn_Click(object sender, EventArgs e)
        {
            eTxt += ")";
            ekranTxtBox.Text = eTxt;
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            amalTxt.Text = "";
            eTxt = "";
            ekranTxtBox.Text = "0";
        }

        private void Btn1x_Click(object sender, EventArgs e)
        {
            eTxt = "1/(" + eTxt + ")";
            ekranTxtBox.Text = eTxt;
        }

        private void x2Btn_Click(object sender, EventArgs e)
        {
            amalTxt.Text = "Pow(" + ekranTxtBox.Text.Replace(',','.') + ",2)";
            ekranTxtBox.Text = Hisoblash.Eval(ekranTxtBox.Text, "sqr");
            eTxt = ekranTxtBox.Text;
            try
            {
                History.Add(amalTxt.Text, eTxt);
            }
            catch
            {
                amalTxt.Text = "";
            }
            /*eTxt += "^2";
            ekranTxtBox.Text = eTxt;*/
        }

        private void ildizBtn_Click(object sender, EventArgs e)
        {
            amalTxt.Text = "Sqrt(" + ekranTxtBox.Text.Replace(',', '.') + ")";
            ekranTxtBox.Text = Hisoblash.Eval(ekranTxtBox.Text,"sqrt");
            eTxt = ekranTxtBox.Text;
            try
            {
                History.Add(amalTxt.Text, eTxt);
            }
            catch
            {
                amalTxt.Text = "";
            }
            /* eTxt = "Sqrt(" + eTxt + ")";
             ekranTxtBox.Text = eTxt;*/
        }

        private void foizBtn_Click(object sender, EventArgs e)
        {
            eTxt += "(";
            ekranTxtBox.Text = eTxt;
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            string HistoryLists = "";
            foreach(var h in History)
            {
                HistoryLists += h.Key + "   =>   " + h.Value + "\n";
            }
            MessageBox.Show(HistoryLists);
        }

        private void NavbarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".NET Developer: Faxriddin Xushnazarov");
        }

        private void ekranTxtBox_TextChanged(object sender, EventArgs e)
        {
            //ekranTxtBox.Text = "salom";
        }
    }
}
