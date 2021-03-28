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
            this.SuspendLayout();
            // 
            // FigureCmbbx
            // 
            this.FigureCmbbx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FigureCmbbx.FormattingEnabled = true;
            this.FigureCmbbx.Location = new System.Drawing.Point(12, 13);
            this.FigureCmbbx.Name = "FigureCmbbx";
            this.FigureCmbbx.Size = new System.Drawing.Size(121, 29);
            this.FigureCmbbx.TabIndex = 0;
            this.FigureCmbbx.SelectedIndexChanged += new System.EventHandler(this.FigureCmbbx_SelectedIndexChanged);
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLbl.Location = new System.Drawing.Point(205, 16);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(45, 17);
            this.widthLbl.TabIndex = 1;
            this.widthLbl.Text = "Width";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightLbl.Location = new System.Drawing.Point(398, 16);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(49, 17);
            this.HeightLbl.TabIndex = 2;
            this.HeightLbl.Text = "Height";
            // 
            // WidthTxtb
            // 
            this.WidthTxtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTxtb.Location = new System.Drawing.Point(267, 16);
            this.WidthTxtb.Name = "WidthTxtb";
            this.WidthTxtb.Size = new System.Drawing.Size(100, 25);
            this.WidthTxtb.TabIndex = 3;
            this.WidthTxtb.Text = "100";
            // 
            // HeightTxtb
            // 
            this.HeightTxtb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightTxtb.Location = new System.Drawing.Point(482, 16);
            this.HeightTxtb.Name = "HeightTxtb";
            this.HeightTxtb.Size = new System.Drawing.Size(100, 25);
            this.HeightTxtb.TabIndex = 4;
            this.HeightTxtb.Text = "100";
            // 
            // selectBtn
            // 
            this.selectBtn.AutoSize = true;
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectBtn.Location = new System.Drawing.Point(696, 14);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 27);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLbl.Location = new System.Drawing.Point(628, 19);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(40, 17);
            this.ColorLbl.TabIndex = 6;
            this.ColorLbl.Text = "Color";
            // 
            // FillRdbtn
            // 
            this.FillRdbtn.AutoSize = true;
            this.FillRdbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillRdbtn.Location = new System.Drawing.Point(825, 17);
            this.FillRdbtn.Name = "FillRdbtn";
            this.FillRdbtn.Size = new System.Drawing.Size(42, 21);
            this.FillRdbtn.TabIndex = 7;
            this.FillRdbtn.TabStop = true;
            this.FillRdbtn.Text = "Fill";
            this.FillRdbtn.UseVisualStyleBackColor = true;
            // 
            // EmptyRdbtn
            // 
            this.EmptyRdbtn.AutoSize = true;
            this.EmptyRdbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyRdbtn.Location = new System.Drawing.Point(873, 17);
            this.EmptyRdbtn.Name = "EmptyRdbtn";
            this.EmptyRdbtn.Size = new System.Drawing.Size(65, 21);
            this.EmptyRdbtn.TabIndex = 8;
            this.EmptyRdbtn.TabStop = true;
            this.EmptyRdbtn.Text = "Empty";
            this.EmptyRdbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 596);
            this.Controls.Add(this.EmptyRdbtn);
            this.Controls.Add(this.FillRdbtn);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.HeightTxtb);
            this.Controls.Add(this.WidthTxtb);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.FigureCmbbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

