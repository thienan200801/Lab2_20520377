using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Data;


namespace ExportExcel
{
    public partial class Form1 : Form
    {

        string filePath = @"C:\Users\phong\Desktop\sampleData.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

            for (int i=0;i<reference.Length;i++)
            {
                Row row = new Row();
                for (int j=0;j<reference.Length;j++)
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
    }
}