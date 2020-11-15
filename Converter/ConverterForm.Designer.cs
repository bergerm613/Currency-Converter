namespace Converter
{
    partial class frmCurrency
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblCAD = new System.Windows.Forms.Label();
            this.lblGBP = new System.Windows.Forms.Label();
            this.lblEUR = new System.Windows.Forms.Label();
            this.lblNIS = new System.Windows.Forms.Label();
            this.lblJPY = new System.Windows.Forms.Label();
            this.lblAUD = new System.Windows.Forms.Label();
            this.ratesGroup = new System.Windows.Forms.GroupBox();
            this.rateAUD = new System.Windows.Forms.TextBox();
            this.rateJPY = new System.Windows.Forms.TextBox();
            this.rateNIS = new System.Windows.Forms.TextBox();
            this.rateEUR = new System.Windows.Forms.TextBox();
            this.rateGBP = new System.Windows.Forms.TextBox();
            this.rateCAD = new System.Windows.Forms.TextBox();
            this.quantityUSD = new System.Windows.Forms.TextBox();
            this.quantityCAD = new System.Windows.Forms.TextBox();
            this.quantityNIS = new System.Windows.Forms.TextBox();
            this.quantitiesGroup = new System.Windows.Forms.GroupBox();
            this.quantityAUD = new System.Windows.Forms.TextBox();
            this.quantityJPY = new System.Windows.Forms.TextBox();
            this.quantityEUR = new System.Windows.Forms.TextBox();
            this.quantityGBP = new System.Windows.Forms.TextBox();
            this.ratesGroup.SuspendLayout();
            this.quantitiesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUSD.Location = new System.Drawing.Point(35, 59);
            this.lblUSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(45, 20);
            this.lblUSD.TabIndex = 0;
            this.lblUSD.Text = "US $";
            // 
            // lblCAD
            // 
            this.lblCAD.AutoSize = true;
            this.lblCAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCAD.Location = new System.Drawing.Point(35, 130);
            this.lblCAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCAD.Name = "lblCAD";
            this.lblCAD.Size = new System.Drawing.Size(43, 20);
            this.lblCAD.TabIndex = 1;
            this.lblCAD.Text = "CAD";
            // 
            // lblGBP
            // 
            this.lblGBP.AutoSize = true;
            this.lblGBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGBP.Location = new System.Drawing.Point(35, 201);
            this.lblGBP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGBP.Name = "lblGBP";
            this.lblGBP.Size = new System.Drawing.Size(43, 20);
            this.lblGBP.TabIndex = 2;
            this.lblGBP.Text = "GBP";
            // 
            // lblEUR
            // 
            this.lblEUR.AutoSize = true;
            this.lblEUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblEUR.Location = new System.Drawing.Point(35, 272);
            this.lblEUR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEUR.Name = "lblEUR";
            this.lblEUR.Size = new System.Drawing.Size(44, 20);
            this.lblEUR.TabIndex = 3;
            this.lblEUR.Text = "EUR";
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblNIS.Location = new System.Drawing.Point(35, 343);
            this.lblNIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(36, 20);
            this.lblNIS.TabIndex = 4;
            this.lblNIS.Text = "NIS";
            // 
            // lblJPY
            // 
            this.lblJPY.AutoSize = true;
            this.lblJPY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblJPY.Location = new System.Drawing.Point(35, 414);
            this.lblJPY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJPY.Name = "lblJPY";
            this.lblJPY.Size = new System.Drawing.Size(38, 20);
            this.lblJPY.TabIndex = 5;
            this.lblJPY.Text = "JPY";
            this.lblJPY.Click += new System.EventHandler(this.lblJPY_Click);
            // 
            // lblAUD
            // 
            this.lblAUD.AutoSize = true;
            this.lblAUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAUD.Location = new System.Drawing.Point(35, 485);
            this.lblAUD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAUD.Name = "lblAUD";
            this.lblAUD.Size = new System.Drawing.Size(44, 20);
            this.lblAUD.TabIndex = 6;
            this.lblAUD.Text = "AUD";
            // 
            // ratesGroup
            // 
            this.ratesGroup.Controls.Add(this.rateAUD);
            this.ratesGroup.Controls.Add(this.rateJPY);
            this.ratesGroup.Controls.Add(this.rateNIS);
            this.ratesGroup.Controls.Add(this.rateEUR);
            this.ratesGroup.Controls.Add(this.rateGBP);
            this.ratesGroup.Controls.Add(this.rateCAD);
            this.ratesGroup.Location = new System.Drawing.Point(324, 26);
            this.ratesGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratesGroup.Name = "ratesGroup";
            this.ratesGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratesGroup.Size = new System.Drawing.Size(231, 513);
            this.ratesGroup.TabIndex = 8;
            this.ratesGroup.TabStop = false;
            this.ratesGroup.Text = "Exchange Rates to USD";
            // 
            // rateAUD
            // 
            this.rateAUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rateAUD.Location = new System.Drawing.Point(83, 454);
            this.rateAUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateAUD.Name = "rateAUD";
            this.rateAUD.Size = new System.Drawing.Size(58, 26);
            this.rateAUD.TabIndex = 13;
            this.rateAUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateAUD_Enter);
            // 
            // rateJPY
            // 
            this.rateJPY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rateJPY.Location = new System.Drawing.Point(83, 382);
            this.rateJPY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateJPY.Name = "rateJPY";
            this.rateJPY.Size = new System.Drawing.Size(58, 26);
            this.rateJPY.TabIndex = 12;
            this.rateJPY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateJPY_Enter);
            // 
            // rateNIS
            // 
            this.rateNIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rateNIS.Location = new System.Drawing.Point(83, 311);
            this.rateNIS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateNIS.Name = "rateNIS";
            this.rateNIS.Size = new System.Drawing.Size(58, 26);
            this.rateNIS.TabIndex = 11;
            this.rateNIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateNIS_Enter);
            // 
            // rateEUR
            // 
            this.rateEUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rateEUR.Location = new System.Drawing.Point(83, 240);
            this.rateEUR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateEUR.Name = "rateEUR";
            this.rateEUR.Size = new System.Drawing.Size(58, 26);
            this.rateEUR.TabIndex = 10;
            this.rateEUR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateEUR_Enter);
            // 
            // rateGBP
            // 
            this.rateGBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rateGBP.Location = new System.Drawing.Point(83, 169);
            this.rateGBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateGBP.Name = "rateGBP";
            this.rateGBP.Size = new System.Drawing.Size(58, 26);
            this.rateGBP.TabIndex = 9;
            this.rateGBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateGBP_Enter);
            // 
            // rateCAD
            // 
            this.rateCAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rateCAD.Location = new System.Drawing.Point(83, 98);
            this.rateCAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rateCAD.Name = "rateCAD";
            this.rateCAD.Size = new System.Drawing.Size(58, 26);
            this.rateCAD.TabIndex = 8;
            this.rateCAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateCAD_Enter);
            // 
            // quantityUSD
            // 
            this.quantityUSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quantityUSD.Location = new System.Drawing.Point(37, 33);
            this.quantityUSD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityUSD.Name = "quantityUSD";
            this.quantityUSD.Size = new System.Drawing.Size(61, 26);
            this.quantityUSD.TabIndex = 9;
            this.quantityUSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityUSD_Enter);
            // 
            // quantityCAD
            // 
            this.quantityCAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quantityCAD.Location = new System.Drawing.Point(37, 101);
            this.quantityCAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityCAD.Name = "quantityCAD";
            this.quantityCAD.Size = new System.Drawing.Size(61, 26);
            this.quantityCAD.TabIndex = 10;
            this.quantityCAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityCAD_Enter);
            // 
            // quantityNIS
            // 
            this.quantityNIS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantityNIS.Location = new System.Drawing.Point(37, 311);
            this.quantityNIS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityNIS.Name = "quantityNIS";
            this.quantityNIS.Size = new System.Drawing.Size(61, 26);
            this.quantityNIS.TabIndex = 11;
            this.quantityNIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityNIS_Enter);
            // 
            // quantitiesGroup
            // 
            this.quantitiesGroup.Controls.Add(this.quantityAUD);
            this.quantitiesGroup.Controls.Add(this.quantityJPY);
            this.quantitiesGroup.Controls.Add(this.quantityEUR);
            this.quantitiesGroup.Controls.Add(this.quantityGBP);
            this.quantitiesGroup.Controls.Add(this.quantityUSD);
            this.quantitiesGroup.Controls.Add(this.quantityNIS);
            this.quantitiesGroup.Controls.Add(this.quantityCAD);
            this.quantitiesGroup.Location = new System.Drawing.Point(172, 26);
            this.quantitiesGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantitiesGroup.Name = "quantitiesGroup";
            this.quantitiesGroup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantitiesGroup.Size = new System.Drawing.Size(136, 513);
            this.quantitiesGroup.TabIndex = 12;
            this.quantitiesGroup.TabStop = false;
            this.quantitiesGroup.Text = "Quantities";
            // 
            // quantityAUD
            // 
            this.quantityAUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.quantityAUD.Location = new System.Drawing.Point(37, 453);
            this.quantityAUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityAUD.Name = "quantityAUD";
            this.quantityAUD.Size = new System.Drawing.Size(61, 26);
            this.quantityAUD.TabIndex = 15;
            this.quantityAUD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityAUD_Enter);
            // 
            // quantityJPY
            // 
            this.quantityJPY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quantityJPY.Location = new System.Drawing.Point(37, 382);
            this.quantityJPY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityJPY.Name = "quantityJPY";
            this.quantityJPY.Size = new System.Drawing.Size(61, 26);
            this.quantityJPY.TabIndex = 14;
            this.quantityJPY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityJPY_Enter);
            // 
            // quantityEUR
            // 
            this.quantityEUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quantityEUR.Location = new System.Drawing.Point(37, 240);
            this.quantityEUR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityEUR.Name = "quantityEUR";
            this.quantityEUR.Size = new System.Drawing.Size(61, 26);
            this.quantityEUR.TabIndex = 13;
            this.quantityEUR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityEUR_Enter);
            // 
            // quantityGBP
            // 
            this.quantityGBP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quantityGBP.Location = new System.Drawing.Point(37, 172);
            this.quantityGBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityGBP.Name = "quantityGBP";
            this.quantityGBP.Size = new System.Drawing.Size(61, 26);
            this.quantityGBP.TabIndex = 12;
            this.quantityGBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityGBP_Enter);
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 553);
            this.Controls.Add(this.quantitiesGroup);
            this.Controls.Add(this.ratesGroup);
            this.Controls.Add(this.lblAUD);
            this.Controls.Add(this.lblJPY);
            this.Controls.Add(this.lblNIS);
            this.Controls.Add(this.lblEUR);
            this.Controls.Add(this.lblGBP);
            this.Controls.Add(this.lblCAD);
            this.Controls.Add(this.lblUSD);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCurrency";
            this.Text = "Currency Conveter";
            this.ratesGroup.ResumeLayout(false);
            this.ratesGroup.PerformLayout();
            this.quantitiesGroup.ResumeLayout(false);
            this.quantitiesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblCAD;
        private System.Windows.Forms.Label lblGBP;
        private System.Windows.Forms.Label lblEUR;
        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblJPY;
        private System.Windows.Forms.Label lblAUD;

        private System.Windows.Forms.GroupBox quantitiesGroup;
        private System.Windows.Forms.GroupBox ratesGroup;

        private System.Windows.Forms.TextBox quantityUSD;
        private System.Windows.Forms.TextBox quantityCAD;
        private System.Windows.Forms.TextBox quantityNIS;
        private System.Windows.Forms.TextBox quantityAUD;
        private System.Windows.Forms.TextBox quantityJPY;
        private System.Windows.Forms.TextBox quantityEUR;
        private System.Windows.Forms.TextBox quantityGBP;

        private System.Windows.Forms.TextBox rateCAD;
        private System.Windows.Forms.TextBox rateAUD;
        private System.Windows.Forms.TextBox rateJPY;
        private System.Windows.Forms.TextBox rateNIS;
        private System.Windows.Forms.TextBox rateEUR;
        private System.Windows.Forms.TextBox rateGBP;
    }
}

