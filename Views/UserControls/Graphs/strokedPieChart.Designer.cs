namespace DBproject.Views.UserControls.Graphs
{
    partial class strokedPieChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Lato Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.descriptionLabel.Location = new System.Drawing.Point(61, 146);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(150, 25);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "INCOME RECEIVED";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentLabel
            // 
            this.percentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percentLabel.BackColor = System.Drawing.Color.Transparent;
            this.percentLabel.Font = new System.Drawing.Font("Lato Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.percentLabel.Location = new System.Drawing.Point(51, 86);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(170, 62);
            this.percentLabel.TabIndex = 0;
            this.percentLabel.Text = "100%";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.percentLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 269);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // strokedPieChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.panel1);
            this.Name = "strokedPieChart";
            this.Size = new System.Drawing.Size(260, 269);
            this.Load += new System.EventHandler(this.strokedPieChart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.strokedPieChart_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
