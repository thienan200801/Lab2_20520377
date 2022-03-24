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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                 
                string rawString = sr.ReadToEnd();
                char[] separators = new char[] { ' ' };
                string[] subs = rawString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string sub in subs)
                {
                    richTextBox1.Text += sub;
                }

                fs.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try 
            //{
            //string preprocessing
            //string rawString = richTextBox1.Text;
            //char[] separators = new char[] { ' ' };
            //string[] subs = rawString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //float[] floatPara = new float[10000];
            //string[] sign = new string[10000];

            //int memFloat = 0, memSign = 0;
            //for (int memSubs = 0; memSubs < subs.Length; memSubs++)
            //{
            //    float number;

            //    switch (subs[memSubs])
            //    {
            //        case "+":
            //        case "-":
            //        case "*":
            //        case "/":
            //            {
            //                sign[memSign++] = subs[memSubs];
            //            }
            //            continue;
            //        case "/r":
            //        case "/n":
            //        case " ": continue;
            //        default:
            //            floatPara[memFloat++] = float.Parse(subs[memSubs]);
            //            break;
            //    }

            //    string tmp = "";
            //    foreach (var i in sign)
            //    {
            //        tmp += i;
            //    }
            //    MessageBox.Show(tmp);
            //}

            //}
            //catch
            //{
            //    MessageBox.Show("Error!");
            //}

            //string rawString = richTextBox1.Text;
            //char[] separators = new char[] { '\n' };
            //string[] subs = rawString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //foreach(var sub in subs)
            //{
            //    //DataTable dt = new DataTable();
            //    //var v = dt.Compute(sub, "");
            //    //richTextBox2.Text += v;
            //    richTextBox2.Text += sub;
            //}

            String content = richTextBox1.Text;
            content = content.Replace('\r', ' ');
            String[] numb = content.Split(new char[] { '+', '-', '*', '/', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            float numb1 = float.Parse(numb[0]);
            float numb2 = float.Parse(numb[1]);
            float numb3 = float.Parse(numb[2]);
            float numb4 = float.Parse(numb[3]);
            float numb5 = float.Parse(numb[4]);
            float numb6 = float.Parse(numb[5]);
            float numb7 = float.Parse(numb[6]);
            float numb8 = float.Parse(numb[7]);
            float add = numb1 + numb2;
            float sub = numb3 - numb4;
            float mult = numb5 * numb6;
            float div = numb7 / numb8;
            content = content.Replace("\r\n", "\r");
            String[] line = content.Split('\n');
            line[0] = line[0] + " = " + add;
            line[1] = line[1] + " = " + sub;
            line[2] = line[2] + " = " + mult;
            line[3] = line[3] + " = " + div;
            String content2 = line[0] + "\n" + line[1] + "\n" + line[2] + "\n" + line[3];
            richTextBox2.Text = content2.ToString();

        }
    }
}
