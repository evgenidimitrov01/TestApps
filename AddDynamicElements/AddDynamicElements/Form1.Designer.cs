namespace AddDynamicElements
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWaterMeterStart = new System.Windows.Forms.TextBox();
            this.txtWaterMeterEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Показания в началото";
            // 
            // txtWaterMeterStart
            // 
            this.txtWaterMeterStart.Location = new System.Drawing.Point(139, 6);
            this.txtWaterMeterStart.Name = "txtWaterMeterStart";
            this.txtWaterMeterStart.Size = new System.Drawing.Size(100, 20);
            this.txtWaterMeterStart.TabIndex = 1;
            // 
            // txtWaterMeterEnd
            // 
            this.txtWaterMeterEnd.Location = new System.Drawing.Point(139, 32);
            this.txtWaterMeterEnd.Name = "txtWaterMeterEnd";
            this.txtWaterMeterEnd.Size = new System.Drawing.Size(100, 20);
            this.txtWaterMeterEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Показания в края";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(139, 84);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 36);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Пресмятане за периода";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(139, 58);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Брой дни";
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp.Location = new System.Drawing.Point(245, 6);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(222, 302);
            this.flp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 320);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtWaterMeterEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWaterMeterStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Показания на водомер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWaterMeterStart;
        private System.Windows.Forms.TextBox txtWaterMeterEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}

