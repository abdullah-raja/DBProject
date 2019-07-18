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
            controller.showIncomePieChart(this, apartment);

        }

        public void showIncomeGraph(int receivedCount, int receivedSum,  int totalSum)
        {
            int totalCount = this.apartment.getNoOfFloors() * this.apartment.getFlatsPerFloor();
            int remainingCount = totalCount - receivedCount;
            int remainingSum = totalSum - receivedSum;
            UserControls.Graphs.strokedPieChart pie = new UserControls.Graphs.strokedPieChart();
            pie.addValue(receivedCount, receivedLegend.BackColor);
            pie.addValue(remainingCount, remainingLegend.BackColor);
            pie.setDescription("INCOME RECEIVED", Color.Silver);
            incomeChartPanel.Controls.Add(pie);

            receivedValue.Text = receivedCount + "(" + String.Format("{0:n0}", receivedSum) + "RS)";
            notReceivedValue.Text = remainingCount + "(" + String.Format("{0:n0}", remainingSum) + "RS)";
            totalIncomeValue.Text = (receivedCount + remainingCount) + "(" + String.Format("{0:n0}", receivedSum+remainingSum) + "RS)";
        }

        public void showExpenseGraph(int paidCount, int paidSum, int unpaidCount, int unpaidSum)
        {
            
            UserControls.Graphs.strokedPieChart expensePie = new UserControls.Graphs.strokedPieChart();
            expensePie.addValue(paidCount, paidLegend.BackColor);
            expensePie.addValue(unpaidCount, unpaidLegend.BackColor);
            expensePie.setDescription("EXPENSES PAID", Color.Silver);

            expenseChartPanel.Controls.Add(expensePie);

            paidValue.Text = paidCount + "(" + String.Format("{0:n0}", paidSum) + "RS)";
            unpaidValue.Text = unpaidCount + "(" + String.Format("{0:n0}", unpaidSum) + "RS)";

            totalExpensesValue.Text = (paidCount + unpaidCount) + "(" + String.Format("{0:n0}", paidSum+unpaidSum) + "RS)";

        }

        private void incomeChartPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
