namespace tempConvert
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromKelvin = new System.Windows.Forms.RadioButton();
            this.fromReamur = new System.Windows.Forms.RadioButton();
            this.fromFahrn = new System.Windows.Forms.RadioButton();
            this.fromCelcius = new System.Windows.Forms.RadioButton();
            this.inputTemp = new System.Windows.Forms.TextBox();
            this.outC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.outK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromKelvin);
            this.groupBox1.Controls.Add(this.fromReamur);
            this.groupBox1.Controls.Add(this.fromFahrn);
            this.groupBox1.Controls.Add(this.fromCelcius);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.groupBox1.Size = new System.Drawing.Size(76, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // fromKelvin
            // 
            this.fromKelvin.AutoSize = true;
            this.fromKelvin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fromKelvin.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromKelvin.Location = new System.Drawing.Point(3, 93);
            this.fromKelvin.Name = "fromKelvin";
            this.fromKelvin.Size = new System.Drawing.Size(70, 24);
            this.fromKelvin.TabIndex = 3;
            this.fromKelvin.Text = "K";
            this.fromKelvin.UseVisualStyleBackColor = true;
            this.fromKelvin.CheckedChanged += new System.EventHandler(this.fromKelvin_CheckedChanged);
            // 
            // fromReamur
            // 
            this.fromReamur.AutoSize = true;
            this.fromReamur.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fromReamur.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromReamur.Location = new System.Drawing.Point(3, 69);
            this.fromReamur.Name = "fromReamur";
            this.fromReamur.Size = new System.Drawing.Size(70, 24);
            this.fromReamur.TabIndex = 2;
            this.fromReamur.Text = "R";
            this.fromReamur.UseVisualStyleBackColor = true;
            this.fromReamur.CheckedChanged += new System.EventHandler(this.fromReamur_CheckedChanged);
            // 
            // fromFahrn
            // 
            this.fromFahrn.AutoSize = true;
            this.fromFahrn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fromFahrn.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromFahrn.Location = new System.Drawing.Point(3, 45);
            this.fromFahrn.Name = "fromFahrn";
            this.fromFahrn.Size = new System.Drawing.Size(70, 24);
            this.fromFahrn.TabIndex = 1;
            this.fromFahrn.Text = "F";
            this.fromFahrn.UseVisualStyleBackColor = true;
            this.fromFahrn.CheckedChanged += new System.EventHandler(this.fromFahrn_CheckedChanged);
            // 
            // fromCelcius
            // 
            this.fromCelcius.AutoSize = true;
            this.fromCelcius.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fromCelcius.Checked = true;
            this.fromCelcius.Dock = System.Windows.Forms.DockStyle.Top;
            this.fromCelcius.Location = new System.Drawing.Point(3, 21);
            this.fromCelcius.Name = "fromCelcius";
            this.fromCelcius.Size = new System.Drawing.Size(70, 24);
            this.fromCelcius.TabIndex = 0;
            this.fromCelcius.TabStop = true;
            this.fromCelcius.Text = "C";
            this.fromCelcius.UseVisualStyleBackColor = true;
            this.fromCelcius.CheckedChanged += new System.EventHandler(this.fromCelcius_CheckedChanged);
            // 
            // inputTemp
            // 
            this.inputTemp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTemp.Font = new System.Drawing.Font("Anonymous Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTemp.Location = new System.Drawing.Point(82, 43);
            this.inputTemp.Name = "inputTemp";
            this.inputTemp.Size = new System.Drawing.Size(132, 26);
            this.inputTemp.TabIndex = 1;
            this.inputTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputTemp.WordWrap = false;
            this.inputTemp.TextChanged += new System.EventHandler(this.inputTemp_TextChanged);
            // 
            // outC
            // 
            this.outC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outC.Font = new System.Drawing.Font("Anonymous Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outC.Location = new System.Drawing.Point(29, 28);
            this.outC.Name = "outC";
            this.outC.ReadOnly = true;
            this.outC.Size = new System.Drawing.Size(100, 26);
            this.outC.TabIndex = 3;
            this.outC.Text = "0";
            this.outC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outC.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "C";
            // 
            // pnlOut
            // 
            this.pnlOut.Controls.Add(this.outK);
            this.pnlOut.Controls.Add(this.label4);
            this.pnlOut.Controls.Add(this.outR);
            this.pnlOut.Controls.Add(this.label3);
            this.pnlOut.Controls.Add(this.outF);
            this.pnlOut.Controls.Add(this.label2);
            this.pnlOut.Controls.Add(this.outC);
            this.pnlOut.Controls.Add(this.label1);
            this.pnlOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOut.Location = new System.Drawing.Point(220, 0);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(296, 124);
            this.pnlOut.TabIndex = 5;
            // 
            // outK
            // 
            this.outK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outK.Font = new System.Drawing.Font("Anonymous Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outK.Location = new System.Drawing.Point(184, 75);
            this.outK.Name = "outK";
            this.outK.ReadOnly = true;
            this.outK.Size = new System.Drawing.Size(100, 26);
            this.outK.TabIndex = 9;
            this.outK.Text = "0";
            this.outK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outK.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(160, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "K";
            // 
            // outR
            // 
            this.outR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outR.Font = new System.Drawing.Font("Anonymous Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outR.Location = new System.Drawing.Point(29, 77);
            this.outR.Name = "outR";
            this.outR.ReadOnly = true;
            this.outR.Size = new System.Drawing.Size(100, 26);
            this.outR.TabIndex = 7;
            this.outR.Text = "0";
            this.outR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outR.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "R";
            // 
            // outF
            // 
            this.outF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.outF.Font = new System.Drawing.Font("Anonymous Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outF.Location = new System.Drawing.Point(184, 28);
            this.outF.Name = "outF";
            this.outF.ReadOnly = true;
            this.outF.Size = new System.Drawing.Size(100, 26);
            this.outF.TabIndex = 5;
            this.outF.Text = "0";
            this.outF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outF.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "F";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(82, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 32);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 124);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.inputTemp);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.pnlOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fromKelvin;
        private System.Windows.Forms.RadioButton fromReamur;
        private System.Windows.Forms.RadioButton fromFahrn;
        private System.Windows.Forms.RadioButton fromCelcius;
        private System.Windows.Forms.TextBox inputTemp;
        private System.Windows.Forms.TextBox outC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.TextBox outK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
    }
}

