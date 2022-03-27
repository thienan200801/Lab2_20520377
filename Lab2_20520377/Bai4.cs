﻿using System;
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


namespace Lab2_20520377
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ThongtinsvBai4().ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exportExc
        }

        private void exportExcel()
        {

            string filePath = @"C:\Users\phong\Desktop\sampleData.xlsx";
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook);

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
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
