using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_20520377
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        static bool isOperand(string str)
        {
            foreach(var i in str)
            {
                if (i > '9' || i < '0') return false;
            }
            return true;
        }

        static float value(string c) 
        { 
            return float.Parse(c); 
        }

        static float calculate(string[] exp)
        {
            if (exp.Length == 0) return -1;

            float res = value(exp[0]);

            for (int i = 1; i < exp.Length; i += 2)
            {
                string opr = exp[i], opd = exp[i + 1];

                if (isOperand(opd) == false) return -1;

                if (opr == "+") res += value(opd);
                else if (opr == "-") res -= value(opd);
                else if (opr == "*") res *= value(opd);
                else if (opr == "/") res /= value(opd);

                else return -1;
            }
            return res;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String content = readFromFile.Text;
                content = content.Replace('\r', ' ');
                String[] numb = content.Split(new char[] { '+', '-', '*', '/', '\n' }, StringSplitOptions.RemoveEmptyEntries);
             
                String[] lines = content.Split('\n');
                string resString = "0";
                foreach(var line in lines)
                {
                    writeToFile.Text += calculate(line).ToString() + "\n";
                }
                //MessageBox.Show(lines[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private float calculate(object expr1)
        {
            throw new NotImplementedException();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                ofd.Filter = "txt files (*.txt)|*.txt";
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                string content = writeToFile.Text;
                sw.WriteLine(content);
                MessageBox.Show("Successful write to file");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {                
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                ofd.Filter = "txt files (*.txt)|*.txt";
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();

                string s = content.Trim(' ');
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex("[ ]{2,}", options);
                s = regex.Replace(s, " ");

                readFromFile.Text = s;
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

    }
}




