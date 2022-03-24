using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2_20520377
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnRead(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc.Message);
            }
        }

        private void btnWrite(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ThienAn\\Downloads\\output.txt");
                string txt = richTextBox1.Text;
                sw.WriteLine(txt);            
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
