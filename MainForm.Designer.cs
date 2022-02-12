namespace VsiteSeminar
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPingPeriod = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.pingPeriodTimer = new System.Windows.Forms.Timer(this.components);
            this.StopPingMeasurement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL / IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start ping measurement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonStartPingMeasurement_Click);
            // 
            // textBoxIPAdress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(156, 36);
            this.textBoxIPAddress.Name = "textBoxIPAdress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(275, 20);
            this.textBoxIPAddress.TabIndex = 2;
            this.textBoxIPAddress.TextChanged += new System.EventHandler(this.TextBoxIPAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ping period (s)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPingPeriod
            // 
            this.textBoxPingPeriod.Location = new System.Drawing.Point(156, 85);
            this.textBoxPingPeriod.Name = "textBoxPingPeriod";
            this.textBoxPingPeriod.Size = new System.Drawing.Size(275, 20);
            this.textBoxPingPeriod.TabIndex = 5;
            this.textBoxPingPeriod.TextChanged += new System.EventHandler(this.textBoxPingPeriod_TextChanged);
            // 
            // OutputTextBox
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(179, 228);
            this.textBoxOutput.Name = "OutputTextBox";
            this.textBoxOutput.Size = new System.Drawing.Size(153, 96);
            this.textBoxOutput.TabIndex = 6;
            this.textBoxOutput.Text = "";
            // 
            // pingPeriodTimer
            // 
            this.pingPeriodTimer.Interval = 1000;
            this.pingPeriodTimer.Tick += new System.EventHandler(this.timerPingPeriod_Tick);
            // 
            // StopPingMeasurement
            // 
            this.StopPingMeasurement.Location = new System.Drawing.Point(179, 178);
            this.StopPingMeasurement.Name = "StopPingMeasurement";
            this.StopPingMeasurement.Size = new System.Drawing.Size(153, 23);
            this.StopPingMeasurement.TabIndex = 7;
            this.StopPingMeasurement.Text = "Stop ping measurement";
            this.StopPingMeasurement.UseVisualStyleBackColor = true;
            this.StopPingMeasurement.Click += new System.EventHandler(this.buttonStopPingMeasurement_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StopPingMeasurement);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxPingPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Ping App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPingPeriod;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Timer pingPeriodTimer;
        private System.Windows.Forms.Button StopPingMeasurement;
        private System.Windows.Forms.Button button2;
    }
}

