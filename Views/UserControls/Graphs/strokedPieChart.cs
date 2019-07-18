using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject.Views.UserControls.Graphs
{
    public partial class strokedPieChart : UserControl
    {
        List<GraphValue> graphValues;
        int strokeWidth;
        int height;
        int width;
        int X;
        int Y;
        Double startAngle = 270;
        Double sweepAngle = 90;
        Double total;
        GraphValue title;
        GraphValue description;
        

        class GraphValue
        {
            string title;
            Double value;
            Color color;

            public GraphValue(Double value, Color color)
            {
                this.value = value;
                this.color = color;
            }

            public GraphValue(Color color, string title)
            {
                this.color = color;
                this.title = title;
            }

            public string getTitle()
            {
                return this.title;
            }

            public void setTitle(string title)
            {
                this.title = title;
            }

            public Double getValue()
            {
                return this.value;
            }

            public void setValue(Double value)
            {
                this.value = value;
            }

            public Color getColor()
            {
                return this.color;
            }

            
        }
        
        public strokedPieChart()
        {
            InitializeComponent();
            graphValues = new List<GraphValue>();
            strokeWidth = 30;
            height = this.Height;
            width = this.Width;
            X = 0;
            Y = 0;
            total = 0;
        }

        private void strokedPieChart_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

       /* public void setValues(List<GraphValue> values)
        {
            this.graphValues = values;
        } */

        public void addValue(Double value, Color color)
        {
            graphValues.Add(new GraphValue(value,color));
            this.updateTotal();
        }

        public void setDescription(string strTitle, Color titleColor)
        {
            this.description = new GraphValue(titleColor, strTitle);
        }

        public void setTiyle(string strTitle, Color titleColor)
        {
            this.title = new GraphValue(titleColor, strTitle);
        }

        public void updateTotal()
        {
            total = 0;
            foreach (GraphValue value in graphValues)
                total += value.getValue();
        }

        private void panel1_Paint(object sender, PaintEventArgs es)
        {
            //DrawArcRectangle(es);
            Graphics graph = es.Graphics;
            graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Pen pen = new Pen(Color.DarkRed, 30);
            Rectangle rect = new Rectangle(PointToScreen(panel1.Location).X, panel1.Location.Y, panel1.Width - 50, panel1.Height - 50);

            foreach (GraphValue value in graphValues)
            {

                sweepAngle = value.getValue() / total * 360;
                rect.X = (panel1.Width - rect.Width) / 2;
                rect.Y = (panel1.Height - rect.Height) / 2;
                pen.Color = value.getColor();
                pen.Color = value.getColor();
                graph.DrawArc(pen, rect, (float)startAngle, (float)sweepAngle);
                startAngle = sweepAngle - 90;

                // pen.Color.

            }

            try
            {
                percentLabel.Text = (int)((graphValues.First().getValue() / total) * 100) + "%";
                descriptionLabel.Text = description.getTitle();
            }

            catch
            {

            }
        }

        public void DrawArcRectangle()
        {
            
        }


        private void strokedPieChart_Load(object sender, EventArgs e)
        {
            
        }
    }
}