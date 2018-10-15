namespace OutputAnalogVoltage
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
            this.hscVoltageValue = new System.Windows.Forms.HScrollBar();
            this.lblScrollbarValue = new System.Windows.Forms.Label();
            this.cmbPhysicalChannel = new System.Windows.Forms.ComboBox();
            this.lblPhysicalChannel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hscVoltageValue
            // 
            this.hscVoltageValue.Location = new System.Drawing.Point(49, 119);
            this.hscVoltageValue.Maximum = 2009;
            this.hscVoltageValue.Name = "hscVoltageValue";
            this.hscVoltageValue.Size = new System.Drawing.Size(229, 27);
            this.hscVoltageValue.TabIndex = 0;
            this.hscVoltageValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscVoltageValue_Scroll);
            // 
            // lblScrollbarValue
            // 
            this.lblScrollbarValue.AutoSize = true;
            this.lblScrollbarValue.Location = new System.Drawing.Point(45, 103);
            this.lblScrollbarValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScrollbarValue.Name = "lblScrollbarValue";
            this.lblScrollbarValue.Size = new System.Drawing.Size(37, 17);
            this.lblScrollbarValue.TabIndex = 1;
            this.lblScrollbarValue.Text = "0.0V";
            // 
            // cmbPhysicalChannel
            // 
            this.cmbPhysicalChannel.FormattingEnabled = true;
            this.cmbPhysicalChannel.Location = new System.Drawing.Point(49, 26);
            this.cmbPhysicalChannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPhysicalChannel.Name = "cmbPhysicalChannel";
            this.cmbPhysicalChannel.Size = new System.Drawing.Size(160, 24);
            this.cmbPhysicalChannel.TabIndex = 2;
            // 
            // lblPhysicalChannel
            // 
            this.lblPhysicalChannel.AutoSize = true;
            this.lblPhysicalChannel.Location = new System.Drawing.Point(45, 6);
            this.lblPhysicalChannel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhysicalChannel.Name = "lblPhysicalChannel";
            this.lblPhysicalChannel.Size = new System.Drawing.Size(116, 17);
            this.lblPhysicalChannel.TabIndex = 3;
            this.lblPhysicalChannel.Text = "Physical Channel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lblPhysicalChannel);
            this.Controls.Add(this.cmbPhysicalChannel);
            this.Controls.Add(this.lblScrollbarValue);
            this.Controls.Add(this.hscVoltageValue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Analog Voltage Output";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hscVoltageValue;
        private System.Windows.Forms.Label lblScrollbarValue;
        private System.Windows.Forms.ComboBox cmbPhysicalChannel;
        private System.Windows.Forms.Label lblPhysicalChannel;
    }
}

