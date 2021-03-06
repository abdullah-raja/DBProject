﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DBproject.Views.UserControls.Graphs
{
    public partial class BarGraph : UserControl
    {
        public static int maxVal = 100000, minVal = 0, maxSize = 300, minSize = 0, maxY = 58, valX = 120, offsetX = 189-120, minY = 318, offsetY = maxY - minY;
        MonthData[] data;
        Pen greenPen;

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        

        Point[] curvePoints;
        public class MonthData
        {
            int income;
            int expense;
            int total;
            Panel bar;
            Panel incomeBar;
            




            public MonthData(int income, int expense, int total)
            {
                this.income = income;
                this.expense = expense;
                this.total = total;
                
            }

            public int getIncome()
            {
                return this.income;
            }

            public void setIncome(int income)
            {
                this.income = income;
            }

            public int getExpense()
            {
                return this.expense;
            }

            public void setExpense(int expense)
            {
                this.expense = expense;
            }

            public int getTotal()
            {
                return this.total;
            }

            public void setTotal(int total)
            {
                this.total = total;
            }

            public void updateBar()
            {
                float incHeight = ((float)(income-expense) / (float)maxVal) * maxSize;
                this.incomeBar.Height = (int)incHeight;

                float exHeight = ((float)expense / maxVal) * maxSize;
                this.bar.Height = (int)exHeight;
                //this.bar.Height = maxSize / (((expense) * 100) / maxVal);
                // MessageBox.Show(this.incomeBar.Name + " = " + this.incomeBar.Height + this.bar.Name + " = " + this.bar.Height);
            }

            public void setBar(Panel bar, Panel incomeBar, BarGraph parent)
            {

                this.bar = bar;
                this.incomeBar = incomeBar;
                this.bar.MouseEnter += (s, e) =>
                {
                    this.bar.BorderStyle = BorderStyle.Fixed3D;
                };

                this.bar.MouseHover += (s, e2) =>
                {
                    parent.showBubble("EXPENSES", expense, this.bar.BackColor);
                    
                };

                this.bar.MouseLeave += (s, e3) =>
                {
                    this.bar.BorderStyle = BorderStyle.None;
                    parent.hideBubble();
                };

                this.incomeBar.MouseEnter += (s, e) =>
                {
                    this.incomeBar.BorderStyle = BorderStyle.Fixed3D;
                };

                this.incomeBar.MouseHover += (s, e2) =>
                {
                    parent.showBubble("CLOSING BALANCE", income-expense, this.incomeBar.BackColor);

                };

                this.incomeBar.MouseLeave += (s, e3) =>
                {
                    this.incomeBar.BorderStyle = BorderStyle.None;
                    parent.hideBubble();
                };



            }

            public Panel getParentBar()
            {
                return (Panel)this.bar.Parent;
            }

            


        }

        public BarGraph()
        {
            InitializeComponent();
            data = new MonthData[12];
            for(int i = 0; i < 12; i++)
            {
                data[i] = new MonthData(0, 0, 0);
            }

            data[0].setBar(januaryBar, januaryIncome, this);
            data[1].setBar(februaryBar, februaryIncome, this);
            data[2].setBar(marchBar, marchIncome, this);
            data[3].setBar(aprilbar, aprilIncome, this);
            data[4].setBar(mayBar, mayIncome, this);
            data[5].setBar(juneBar, juneIncome, this);
            data[6].setBar(julyBar, julyIncome, this);
            data[7].setBar(augustbar, augustIncome, this);
            data[8].setBar(septemberBar, septemberIncome, this);
            data[9].setBar(octoberBar, octoberIncome, this);
            data[10].setBar(novemberBar, novemberIncome, this);
            data[11].setBar(decemberBar, decemberIncome, this);


            
            
        }

        private void BarGraph_Paint(object sender, PaintEventArgs e)
        {
           
            // Create points that define curve.

            //Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

            // Draw lines between original points to screen.
            //e.Graphics.DrawLines(redPen, curvePoints);

            // Create tension.
           // float tension = 1.0F;

            // Draw curve to screen.
          //  e.Graphics.DrawCurve(greenPen, curvePoints, tension);
            
        }

        public void drawG()
        {

           
            greenPen = new Pen(Color.Green, 3);

            curvePoints = new Point[12];

            for (int i = 0; i < 12; i++)
            {
                int tempX;
                float tempY = 0;
                tempX = valX;
                valX = valX + offsetX;

                tempY = (float)minY + ((data[i].getIncome() - data[i].getExpense()) / (float)maxVal) * (float)offsetY;
                curvePoints[i] = new Point(tempX, (int)tempY);

                //(25/50)*(20-10)
            }


           
            /*
            Graphics g = a.CreateGraphics();
           
            g.DrawCurve(greenPen, curvePoints, 0.5F);
            */
        }

        public void setData(int index, int income, int expense)
        {
            data[index-1].setIncome(income);
            data[index-1].setExpense(expense);
            data[index-1].setTotal(income + expense);
            //data[index].updateBar();

        }

        public void updateGraph()
        {
            maxVal = this.getMaxVal();
            int offset = maxVal / 6;
            maxLabel.Text = string.Format("{0:n0}", maxVal);
            fourthVal.Text = string.Format("{0:n0}", maxVal - offset);
            thirdVal.Text = string.Format("{0:n0}", maxVal - offset*2);
            secondVal.Text = string.Format("{0:n0}", maxVal - offset*3);
            firstVal.Text = string.Format("{0:n0}", maxVal - offset*4);
            zeroVal.Text = string.Format("{0:n0}", maxVal - offset*5);

            foreach (MonthData item in data)
            {
                item.updateBar();
                string toolTipText = "INCOME " + item.getIncome() + Environment.NewLine +"EXPENSES\t" + item.getExpense() + Environment.NewLine + "TOTAL\t" + (item.getIncome()-item.getExpense());
                toolTip1.SetToolTip(item.getParentBar(), toolTipText);
            }
        }

        public int getMaxVal()
        {
            int max = data[0].getIncome();
            for(int i = 0; i < 12; i++)
            {
                if (data[i].getIncome()> max)
                    max = data[i].getIncome();

            }

            return (max + 1000) - max % 1000;

        }
        
        public void showBubble(string title, int value, Color color)
        {
            barBubble.Show();
            barBubble.Location = this.PointToClient(MousePosition);
            BarLabel.Text = title;
            valueLabel.Text = value.ToString();
            valueLabel.ForeColor = color;

        }

        public void hideBubble()
        {
            barBubble.Hide();
        }
    }
}
