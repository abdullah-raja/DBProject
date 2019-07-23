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
            controller = new ReportModule(Util.CONNECTION_DETAILS.CONNECITION_STRING);
            controller.setMonthAndYears(this, apartment);
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
            int numberOfIncomeColumns = 2;
            if (dateCheckbox.Checked)
                numberOfIncomeColumns++;

            if (monthCheckbox.Checked)
                numberOfIncomeColumns++;

            if (receivableCheckbox.Checked)
                numberOfIncomeColumns++;

            int startingBal = apartment.getBalance();

            string path = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
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

                
                // INCOME TABLE
                // Column Heading
                PdfPTable incomeTable = new PdfPTable(numberOfIncomeColumns);
                
                
                
                
                BaseFont columnBaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font columnFont = new iTextSharp.text.Font(baseFont, 11, 1, iTextSharp.text.BaseColor.WHITE);

                PdfPCell HeadingCell = new PdfPCell();
                HeadingCell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                HeadingCell.HorizontalAlignment = 2;
                HeadingCell.VerticalAlignment = 2;
                HeadingCell.HasFixedHeight();
                HeadingCell.Colspan = numberOfIncomeColumns;
                HeadingCell.AddElement(new Chunk("INCOME FOR " + monthBox.SelectedItem.ToString().ToUpper() + " "+ yearBox.SelectedItem, columnFont));
                incomeTable.AddCell(HeadingCell);

                for (int i = 0; i < income.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                    cell.HorizontalAlignment = 2;
                    cell.VerticalAlignment = 2;
                    cell.HasFixedHeight();

                    if (income.Columns[i].ColumnName == "DATE PAID" && !dateCheckbox.Checked)
                        continue;

                    if (income.Columns[i].ColumnName == "FOR THE MONTH" && !monthCheckbox.Checked)
                        continue;

                    if (income.Columns[i].ColumnName == "RECEIVABLE DUES" && !receivableCheckbox.Checked)
                        continue;

                    cell.AddElement(new Chunk(income.Columns[i].ColumnName.ToUpper(), columnFont));
                    incomeTable.AddCell(cell);

                }

                // incomeTable.CompleteRow();

                // rows
                for (int r = 0; r < income.Rows.Count; r++)
                {
                    for (int c = 0; c < income.Columns.Count; c++)
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

                //EXPENSE TABLE

                columnFont.Color = iTextSharp.text.BaseColor.WHITE;

                PdfPTable expenseTable = new PdfPTable(expense.Columns.Count);

                expenseTable.IsExtendLastRow(true);
                expenseTable.SetWidths(new float[] { doc.PageSize.Width * 0.2F, doc.PageSize.Width * 0.6F, doc.PageSize.Width * 0.2F });
                PdfPCell HeadingCell2 = new PdfPCell();
                HeadingCell2.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                HeadingCell2.HorizontalAlignment = 2;
                HeadingCell2.VerticalAlignment = 2;
                HeadingCell2.HasFixedHeight();
                HeadingCell2.Colspan = expense.Columns.Count;
                HeadingCell2.AddElement(new Chunk("EXPENSES FOR " + monthBox.SelectedItem.ToString().ToUpper() + " " + yearBox.SelectedItem, columnFont));
                expenseTable.AddCell(HeadingCell2);

                for (int i = 0; i < expense.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell();
                    cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                    cell.HorizontalAlignment = 2;
                    cell.VerticalAlignment = 2;
                    cell.HasFixedHeight();
                    
                    cell.AddElement(new Chunk(expense.Columns[i].ColumnName.ToUpper(), columnFont));
                    expenseTable.AddCell(cell);

                }

                // incomeTable.CompleteRow();

                // rows
                for (int r = 0; r < expense.Rows.Count; r++)
                {
                    for (int c = 0; c < expense.Columns.Count; c++)
                    {
                        expenseTable.AddCell(expense.Rows[r][c].ToString());
                    }

                    expenseTable.CompleteRow();
                }

                
                
                PdfPCell totalExpenseCell = new PdfPCell();
                columnFont.Color = iTextSharp.text.BaseColor.BLACK;
                totalExpenseCell.Colspan = expense.Columns.Count;
                totalExpenseCell.AddElement(new Chunk("TOTAL EXPENSES = " + expenseSum.ToString(), columnFont));
                expenseTable.AddCell(totalExpenseCell);

                PdfPCell totalIncomeCell = new PdfPCell();
                
                totalIncomeCell.Colspan = numberOfIncomeColumns;
                totalIncomeCell.AddElement(new Chunk("TOTAL INCOME = " + incomeSum.ToString(), columnFont));
                incomeTable.AddCell(totalExpenseCell);



                doc.Add(incomeTable);
                doc.NewPage();
                doc.Add(expenseTable);


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
                System.Diagnostics.Process.Start(path);
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            controller = new ReportModule(Util.CONNECTION_DETAILS.CONNECITION_STRING);
            controller.generateReprt(this, this.apartment, 7,2019);
        }

        public void setMonths(List<string> months)
        {
            try
            {
                monthBox.Items.AddRange(months.ToArray());
                monthBox.SelectedIndex = DateTime.Now.Month - 2;
            }

            catch
            {

            }
        }

        public void setYears(List<string> years)
        {
            yearBox.Items.AddRange(years.ToArray());
            yearBox.SelectedItem = DateTime.Now.Year.ToString();
        }

        
    }
}
