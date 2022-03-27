using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_20520377
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "txt files (*.txt)|*.txt";
                ofd.ShowDialog();
                
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                textBox1.Text = ofd.SafeFileName.ToString();
                textBox2.Text = fs.Name.ToString();

                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                // Count character
                int charCount = content.Length;
                textBox3.Text = charCount.ToString();
                // Count line 
                content = content.Replace("\r\n", "\r");
                int lineCount = richTextBox1.Lines.Count();
                content = content.Replace('\r', ' ');
                textBox4.Text = lineCount.ToString();
                // Count word 
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int wordCount = source.Count();
                textBox5.Text = wordCount.ToString();

                fs.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc.Message);
            }
        }
    }
}
