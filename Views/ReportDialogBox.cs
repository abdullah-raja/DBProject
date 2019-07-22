using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DBproject.Controller;
using DBproject.Model;

namespace DBproject.Views
{
    public partial class ReportDialogBox : Form
    {
        ControllerModule controller;
        Building apartment;
        public ReportDialogBox()
        {
            InitializeComponent();
        }

        public ReportDialogBox(Building apartment): this()
        {
            this.apartment = apartment;
        }


        private void incomeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            flatNumberCheckBox.Visible = incomeCheckbox.Checked;
            amountCheckbox.Visible = incomeCheckbox.Checked;
            dateCheckbox.Visible = incomeCheckbox.Checked;
            monthCheckbox.Visible = incomeCheckbox.Checked;
            receivableCheckbox.Visible = incomeCheckbox.Checked;

        }

        private void expenseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            expenseDateCheckbox.Visible = expenseCheckbox.Checked;
            expenseAmount.Visible = expenseCheckbox.Checked;
            expenseDetails.Visible = expenseCheckbox.Checked;
        }

        public void exportPdf(DataTable income, DataTable expense, int incomeSum, int expenseSum)
        {
            int closing = 0, startingBal = apartment.getBalance();
            string path = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                path = saveFileDialog1.FileName + ".pdf";

            // creating a file object
            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None);

            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            // Header
            Paragraph headingPara = new Paragraph();
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font headingFont = new iTextSharp.text.Font(baseFont, 22, 1, iTextSharp.text.BaseColor.BLACK);
            headingPara.Alignment = Element.ALIGN_CENTER;
            headingPara.Add(new Chunk(this.apartment.getAppartmentName().ToUpper(), headingFont));
            doc.Add(headingPara);
            
            // Separator
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 0)));
            doc.Add(line);

            doc.Add(new Chunk("\n"));

            // Column Heading
            PdfPTable incomeTable = new PdfPTable(income.Columns.Count);
            BaseFont columnBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font columnFont = new iTextSharp.text.Font(baseFont, 11, 1, iTextSharp.text.BaseColor.WHITE);

            for(int i = 0; i < income.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.HorizontalAlignment = 2;
                cell.VerticalAlignment = 2;

                if (income.Columns[i].ColumnName == "DATE PAID" && !dateCheckbox.Checked) 
                    continue;

                if (income.Columns[i].ColumnName == "FOR THE MONTH" && !monthCheckbox.Checked)
                    continue;

                if (income.Columns[i].ColumnName == "RECEIVABLE DUES" && !receivableCheckbox.Checked)
                    continue;

                cell.AddElement(new Chunk(income.Columns[i].ColumnName.ToUpper(), columnFont));
                incomeTable.AddCell(cell);

            }

            incomeTable.CompleteRow();

            // rows
            for(int r = 0; r < income.Rows.Count; r++)
            {
                for(int c = 0; c < income.Columns.Count; c ++)
                {
                    if (income.Columns[c].ColumnName == "DATE PAID" && !dateCheckbox.Checked)
                        continue;

                    if (income.Columns[c].ColumnName == "FOR THE MONTH" && !monthCheckbox.Checked)
                        continue;

                    if (income.Columns[c].ColumnName == "RECEIVABLE DUES" && !receivableCheckbox.Checked)
                        continue;

                    incomeTable.AddCell(income.Rows[r][c].ToString());
                }

                incomeTable.CompleteRow();
            }

            doc.Add(incomeTable);


            // Separator
            line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 0)));
            doc.Add(line);

            doc.Add(new Chunk("\n"));

            // Closing
            doc.Add(new Chunk("Starting Balance:\t" + startingBal + " Rs\n"));
            doc.Add(new Chunk("Total Income:\t" + incomeSum + " Rs\n"));
            doc.Add(new Chunk("Total Expenses:\t" + expenseSum + " Rs\n"));
            doc.Add(new Chunk("Closing Balance:\t" + (startingBal + incomeSum - expenseSum) + " Rs\n"));


            doc.Close();
            writer.Close();
            fs.Close();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            controller = new ReportModule(Util.CONNECTION_DETAILS.CONNECITION_STRING);
            controller.generateReprt(this, this.apartment, 7,2019);
        }
    }
}
