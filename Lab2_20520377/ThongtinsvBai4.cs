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
using System.Text.RegularExpressions;

namespace Lab2_20520377
{
    public partial class ThongtinsvBai4 : Form
    {
        public ThongtinsvBai4()
        {
            InitializeComponent();
        }

        public float AvgScore(float a, float b)
        {            
            return (a+b) / 2;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (StreamWriter inputFile = new StreamWriter(Path.Combine(doc, "input.txt")))
            {
                await inputFile.WriteAsync(textBox1.Text);
                await inputFile.WriteAsync(";");
                await inputFile.WriteAsync(textBox2.Text);
                await inputFile.WriteAsync(";");
                await inputFile.WriteAsync(textBox3.Text);
                await inputFile.WriteAsync(";");
                await inputFile.WriteAsync(textBox4.Text);
                await inputFile.WriteAsync(";");
                await inputFile.WriteAsync(textBox5.Text);
            }

        }

    }
}
