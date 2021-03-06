//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

////Microsoft.Office.Interop.Excel.Application oXL;
////Microsoft.Office.Interop.Excel._Workbook oWB;
////Microsoft.Office.Interop.Excel._Worksheet oSheet;
////Microsoft.Office.Interop.Excel.Range oRng;
////object misvalue = System.Reflection.Missing.Value;

//namespace Lab2_20520377
//{
//    public partial class Bai4 : Form
//    {
//        public Bai4()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            new ThongtinsvBai4().ShowDialog();
//            this.Hide();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            //OpenFileDialog ofd = new OpenFileDialog();
//            //ofd.ShowDialog();
//            //FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
//            //StreamReader sr = new StreamReader(fs);

//            //string rawString = sr.ReadToEnd();

//            //char[] separators = new char[] { ';' };
//            //string[] subs = rawString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
//            //float Toan, Van;
//            //Toan = float.Parse(subs[subs.Length - 2]);
//            //Van = float.Parse(subs[subs.Length - 1]);

//            //textBox6.Text = AvgScore(Toan, Van).ToString();

//            //try
//            //{
//            //    //Start Excel and get Application object.
//            //    oXL = new Microsoft.Office.Interop.Excel.Application();
//            //    oXL.Visible = true;

//            //    //Get a new workbook.
//            //    oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
//            //    oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

//            //    //Add table headers going cell by cell.
//            //    oSheet.Cells[1, 1] = "First Name";
//            //    oSheet.Cells[1, 2] = "Last Name";
//            //    oSheet.Cells[1, 3] = "Full Name";
//            //    oSheet.Cells[1, 4] = "Salary";

//            //    //Format A1:D1 as bold, vertical alignment = center.
//            //    oSheet.get_Range("A1", "D1").Font.Bold = true;
//            //    oSheet.get_Range("A1", "D1").VerticalAlignment =
//            //        Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

//            //    // Create an array to multiple values at once.
//            //    string[,] saNames = new string[5, 2];

//            //    saNames[0, 0] = "John";
//            //    saNames[0, 1] = "Smith";
//            //    saNames[1, 0] = "Tom";

//            //    saNames[4, 1] = "Johnson";

//            //    //Fill A2:B6 with an array of values (First and Last Names).
//            //    oSheet.get_Range("A2", "B6").Value2 = saNames;

//            //    //Fill C2:C6 with a relative formula (=A2 & " " & B2).
//            //    oRng = oSheet.get_Range("C2", "C6");
//            //    oRng.Formula = "=A2 & \" \" & B2";

//            //    //Fill D2:D6 with a formula(=RAND()*100000) and apply format.
//            //    oRng = oSheet.get_Range("D2", "D6");
//            //    oRng.Formula = "=RAND()*100000";
//            //    oRng.NumberFormat = "$0.00";

//            //    //AutoFit columns A:D.
//            //    oRng = oSheet.get_Range("A1", "D1");
//            //    oRng.EntireColumn.AutoFit();

//            //    oXL.Visible = false;
//            //    oXL.UserControl = false;
//            //    oWB.SaveAs("c:\\test\\test505.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
//            //        false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
//            //        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

//            //    oWB.Close();
//            //    oXL.Quit();

//            //    //...
//        }
//    }
//}

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
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Data.OleDb;

namespace Lab2_20520377
{
    public partial class Bai4 : Form
    {
        private object dataGridView1;

        public Bai4()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            new ThongtinsvBai4().ShowDialog();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            exportExcel();
        }

        private void exportExcel()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Output";
            saveFileDialog1.ShowDialog();

            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(saveFileDialog1.FileName, SpreadsheetDocumentType.Workbook);

            WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();

            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            Sheets Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

            Sheet sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "Sample Data"
            };

            Sheets.Append(sheet);

            Worksheet worksheet = worksheetPart.Worksheet;
            SheetData sheetData = worksheet.GetFirstChild<SheetData>();

            char[] reference = "ABCDEFGH".ToCharArray();

            for (int i = 0; i < reference.Length; i++)
            {
                Row row = new Row();
                for (int j = 0; j < reference.Length; j++)
                {
                    Cell cell = new Cell()
                    {
                        CellValue = new CellValue("1"),
                        DataType = CellValues.String,

                    };
                    row.Append(cell);
                }
                sheetData.Append(row);
            }

            worksheetPart.Worksheet.Save();
            spreadsheetDocument.Close();
        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }
            return dtexcel;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user  
            {
                filePath = file.FileName; //get the path of the file  
                fileExt = Path.GetExtension(filePath); //get the file extension  
                if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(filePath, fileExt); //read excel file  
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = dtExcel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                }
            }
        }

        private DataTable ReadExcel(string filePath, string fileExt)
        {
            throw new NotImplementedException();
        }
    }
}

