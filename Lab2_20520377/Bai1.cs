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
        private object openFileDialog;

        public Bai1()
        {
            InitializeComponent();
        }

        private void btnRead(object sender, EventArgs e)
        {
            try
            {
                string fileContent, filePath;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {                   
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {                      
                        filePath = openFileDialog.FileName;

                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        richTextBox.Text = fileContent;
                    }
                }
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
                string fileContent, filePath;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.ShowDialog();
                    FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs.Name);
                    string txt = richTextBox.Text;
                    string contentWriteUpper = txt.ToUpper();
                    sw.WriteLine(contentWriteUpper);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
