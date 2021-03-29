namespace WindowsFormsApp0328_Part2
{
    partial class Form1
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
            this.FigureCmbbx = new System.Windows.Forms.ComboBox();
            this.widthLbl = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WidthTxtb = new System.Windows.Forms.TextBox();
            this.HeightTxtb = new System.Windows.Forms.TextBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.FillRdbtn = new System.Windows.Forms.RadioButton();
            this.EmptyRdbtn = new System.Windows.Forms.RadioButton();
            this.ManualRdbtn = new System.Windows.Forms.RadioButton();
            this.AutomaticRdbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureCmbbx
            // 
            this.FigureCmbbx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureCmbbx.FormattingEnabled = true;
            this.FigureCmbbx.Location = new System.Drawing.Point(8, 18);
            this.FigureCmbbx.Margin = new System.Windows.Forms.Padding(4);
            this.FigureCmbbx.Name = "FigureCmbbx";
            this.FigureCmbbx.Size = new System.Drawing.Size(160, 36);
            this.FigureCmbbx.TabIndex = 0;
            this.FigureCmbbx.SelectedIndexChanged += new System.EventHandler(this.FigureCmbbx_SelectedIndexChanged);
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLbl.Location = new System.Drawing.Point(192, 24);
            this.widthLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(56, 23);
            this.widthLbl.TabIndex = 1;
            this.widthLbl.Text = "Width";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLbl.Location = new System.Drawing.Point(437, 24);
            this.HeightLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(62, 23);
            this.HeightLbl.TabIndex = 2;
            this.HeightLbl.Text = "Height";
            // 
            // WidthTxtb
            // 
            this.WidthTxtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTxtb.Location = new System.Drawing.Point(271, 21);
            this.WidthTxtb.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTxtb.Name = "WidthTxtb";
            this.WidthTxtb.Size = new System.Drawing.Size(132, 29);
            this.WidthTxtb.TabIndex = 3;
            this.WidthTxtb.Text = "100";
            // 
            // HeightTxtb
            // 
            this.HeightTxtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightTxtb.Location = new System.Drawing.Point(520, 20);
            this.HeightTxtb.Margin = new System.Windows.Forms.Padding(4);
            this.HeightTxtb.Name = "HeightTxtb";
            this.HeightTxtb.Size = new System.Drawing.Size(132, 29);
            this.HeightTxtb.TabIndex = 4;
            this.HeightTxtb.Text = "100";
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSize = true;
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBtn.Location = new System.Drawing.Point(763, 17);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(100, 33);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLbl.Location = new System.Drawing.Point(672, 23);
            this.ColorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(51, 23);
            this.ColorLbl.TabIndex = 6;
            this.ColorLbl.Text = "Color";
            // 
            // FillRdbtn
            // 
            this.FillRdbtn.AutoSize = true;
            this.FillRdbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillRdbtn.Location = new System.Drawing.Point(935, 21);
            this.FillRdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.FillRdbtn.Name = "FillRdbtn";
            this.FillRdbtn.Size = new System.Drawing.Size(52, 27);
            this.FillRdbtn.TabIndex = 7;
            this.FillRdbtn.TabStop = true;
            this.FillRdbtn.Text = "Fill";
            this.FillRdbtn.UseVisualStyleBackColor = true;
            // 
            // EmptyRdbtn
            // 
            this.EmptyRdbtn.AutoSize = true;
            this.EmptyRdbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyRdbtn.Location = new System.Drawing.Point(999, 21);
            this.EmptyRdbtn.Margin = new System.Windows.Forms.Padding(4);
            this.EmptyRdbtn.Name = "EmptyRdbtn";
            this.EmptyRdbtn.Size = new System.Drawing.Size(80, 27);
            this.EmptyRdbtn.TabIndex = 8;
            this.EmptyRdbtn.TabStop = true;
            this.EmptyRdbtn.Text = "Empty";
            this.EmptyRdbtn.UseVisualStyleBackColor = true;
            // 
            // ManualRdbtn
            // 
            this.ManualRdbtn.AutoSize = true;
            this.ManualRdbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualRdbtn.Location = new System.Drawing.Point(0, 54);
            this.ManualRdbtn.Name = "ManualRdbtn";
            this.ManualRdbtn.Size = new System.Drawing.Size(147, 27);
            this.ManualRdbtn.TabIndex = 9;
            this.ManualRdbtn.TabStop = true;
            this.ManualRdbtn.Text = "Draw Manually";
            this.ManualRdbtn.UseVisualStyleBackColor = true;
            // 
            // AutomaticRdbtn
            // 
            this.AutomaticRdbtn.AutoSize = true;
            this.AutomaticRdbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutomaticRdbtn.Location = new System.Drawing.Point(0, 21);
            this.AutomaticRdbtn.Name = "AutomaticRdbtn";
            this.AutomaticRdbtn.Size = new System.Drawing.Size(181, 27);
            this.AutomaticRdbtn.TabIndex = 10;
            this.AutomaticRdbtn.TabStop = true;
            this.AutomaticRdbtn.Text = "Draw Automatically";
            this.AutomaticRdbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AutomaticRdbtn);
            this.groupBox1.Controls.Add(this.ManualRdbtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which one you would draw ?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FigureCmbbx);
            this.panel1.Controls.Add(this.widthLbl);
            this.panel1.Controls.Add(this.EmptyRdbtn);
            this.panel1.Controls.Add(this.HeightLbl);
            this.panel1.Controls.Add(this.FillRdbtn);
            this.panel1.Controls.Add(this.WidthTxtb);
            this.panel1.Controls.Add(this.ColorLbl);
            this.panel1.Controls.Add(this.HeightTxtb);
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Location = new System.Drawing.Point(217, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 81);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1339, 781);
            this.MinimumSize = new System.Drawing.Size(1339, 781);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FigureCmbbx;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.TextBox WidthTxtb;
        private System.Windows.Forms.TextBox HeightTxtb;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label ColorLbl;
        private System.Windows.Forms.RadioButton FillRdbtn;
        private System.Windows.Forms.RadioButton EmptyRdbtn;
        private System.Windows.Forms.RadioButton ManualRdbtn;
        private System.Windows.Forms.RadioButton AutomaticRdbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

