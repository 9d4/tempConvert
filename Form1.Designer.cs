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
            this.fromCelcius = new System.Windows.Forms.RadioButton();
            this.fromFahrn = new System.Windows.Forms.RadioButton();
            this.fromReamur = new System.Windows.Forms.RadioButton();
            this.fromKelvin = new System.Windows.Forms.RadioButton();
            this.inputTemp = new System.Windows.Forms.TextBox();
            this.outCelcius = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromKelvin);
            this.groupBox1.Controls.Add(this.fromReamur);
            this.groupBox1.Controls.Add(this.fromFahrn);
            this.groupBox1.Controls.Add(this.fromCelcius);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // fromCelcius
            // 
            this.fromCelcius.AutoSize = true;
            this.fromCelcius.Location = new System.Drawing.Point(6, 24);
            this.fromCelcius.Name = "fromCelcius";
            this.fromCelcius.Size = new System.Drawing.Size(36, 24);
            this.fromCelcius.TabIndex = 0;
            this.fromCelcius.TabStop = true;
            this.fromCelcius.Text = "C";
            this.fromCelcius.UseVisualStyleBackColor = true;
            // 
            // fromFahrn
            // 
            this.fromFahrn.AutoSize = true;
            this.fromFahrn.Location = new System.Drawing.Point(48, 24);
            this.fromFahrn.Name = "fromFahrn";
            this.fromFahrn.Size = new System.Drawing.Size(35, 24);
            this.fromFahrn.TabIndex = 1;
            this.fromFahrn.TabStop = true;
            this.fromFahrn.Text = "F";
            this.fromFahrn.UseVisualStyleBackColor = true;
            // 
            // fromReamur
            // 
            this.fromReamur.AutoSize = true;
            this.fromReamur.Location = new System.Drawing.Point(6, 43);
            this.fromReamur.Name = "fromReamur";
            this.fromReamur.Size = new System.Drawing.Size(36, 24);
            this.fromReamur.TabIndex = 2;
            this.fromReamur.TabStop = true;
            this.fromReamur.Text = "R";
            this.fromReamur.UseVisualStyleBackColor = true;
            // 
            // fromKelvin
            // 
            this.fromKelvin.AutoSize = true;
            this.fromKelvin.Location = new System.Drawing.Point(48, 43);
            this.fromKelvin.Name = "fromKelvin";
            this.fromKelvin.Size = new System.Drawing.Size(36, 24);
            this.fromKelvin.TabIndex = 3;
            this.fromKelvin.TabStop = true;
            this.fromKelvin.Text = "K";
            this.fromKelvin.UseVisualStyleBackColor = true;
            // 
            // inputTemp
            // 
            this.inputTemp.Location = new System.Drawing.Point(104, 21);
            this.inputTemp.Name = "inputTemp";
            this.inputTemp.Size = new System.Drawing.Size(100, 25);
            this.inputTemp.TabIndex = 1;
            this.inputTemp.TextChanged += new System.EventHandler(this.inputTemp_TextChanged);
            // 
            // outCelcius
            // 
            this.outCelcius.Location = new System.Drawing.Point(242, 21);
            this.outCelcius.Name = "outCelcius";
            this.outCelcius.Size = new System.Drawing.Size(100, 25);
            this.outCelcius.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 97);
            this.Controls.Add(this.outCelcius);
            this.Controls.Add(this.inputTemp);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox outCelcius;
    }
}

