using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBproject.Model;
using DBproject.Controller;

namespace DBproject.Views.UserControls
{
    public partial class Anaytics : UserControl
    {
        Controller.ControllerModule controller;
        Building apartment;
        public Anaytics()
        {
            InitializeComponent();

            
            //pie.DrawArcRectangle();
           // pie.DrawArcRectangle(new PaintEventArgs(this.CreateGraphics(), new Rectangle(5, 5, 200, 200)));

            
        }

        public Anaytics(Building apartment): this()
        {
            this.apartment = apartment;
            controller = new AnalyticsModule(Util.CONNECTION_DETAILS.CONNECITION_STRING);
            controller.showExpensePieChart(this, apartment);

        }

        public void showIncomeGraph(int receivedCount, int receivedSum, int remainingCount, int remainingSum)
        {
            UserControls.Graphs.strokedPieChart pie = new UserControls.Graphs.strokedPieChart();
            pie.addValue(receivedCount, receivedLegend.BackColor);
            pie.addValue(remainingCount, remainingLegend.BackColor);
            pie.setDescription("INCOME RECEIVED", Color.Silver);
            incomeChartPanel.Controls.Add(pie);

            receivedValue.Text = receivedCount + "(" + String.Format("{0:n}", receivedSum) + "RS)";
            notReceivedValue.Text = remainingCount + "(" + String.Format("{0:n}", remainingSum) + "RS)";

        }

        public void showExpenseGraph(int paidCount, int paidSum, int unpaidCount, int unpaidSum)
        {
            UserControls.Graphs.strokedPieChart expensePie = new UserControls.Graphs.strokedPieChart();
            expensePie.addValue(paidCount, paidLegend.BackColor);
            expensePie.addValue(unpaidCount, unpaidLegend.BackColor);
            expensePie.setDescription("EXPENSES PAID", Color.Silver);

            expenseChartPanel.Controls.Add(expensePie);

            paidValue.Text = paidCount + "(" + String.Format("{0:n}", paidSum) + "RS)";
            unpaidValue.Text = unpaidCount + "(" + String.Format("{0:n}", unpaidSum) + "RS)";
        }

        private void incomeChartPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
