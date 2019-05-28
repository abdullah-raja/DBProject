using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject.Views.UserControls
{
    public partial class FloorCard : UserControl
    {
        int flats;
        public FloorCard(int flats)
        {
            InitializeComponent();
            this.flats = flats;
        }

        public void setText(string str)
        {
            button1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel FloorsPanel = (FlowLayoutPanel)this.Parent;
            
                FloorsPanel.Controls.Clear();
                for (int j = 0; j < flats; j++)
                {
                    FlatCardSquare flat = new FlatCardSquare();
                flat.Margin = new Padding(10, 10, 10, 10);
                    flat.setText((((this.TabIndex + 1) * 100) + j).ToString());
                    FloorsPanel.Controls.Add(flat);
                }
            
        }
    }
}
