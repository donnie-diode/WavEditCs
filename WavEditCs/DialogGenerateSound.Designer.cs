﻿
namespace WavEditCs
{
    partial class DialogGenerateSound
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxTimeInFrames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWaves = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFreqInHz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxUseBLEP = new System.Windows.Forms.CheckBox();
            this.checkBoxBitz = new System.Windows.Forms.CheckBox();
            this.textBoxBandLimiting = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(336, 255);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(228, 255);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxTimeInFrames
            // 
            this.textBoxTimeInFrames.Location = new System.Drawing.Point(235, 101);
            this.textBoxTimeInFrames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTimeInFrames.Name = "textBoxTimeInFrames";
            this.textBoxTimeInFrames.Size = new System.Drawing.Size(72, 22);
            this.textBoxTimeInFrames.TabIndex = 3;
            this.textBoxTimeInFrames.Text = "2.0";
            this.textBoxTimeInFrames.TextChanged += new System.EventHandler(this.textBoxDecimalScaler_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waveform";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(113, 101);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(72, 22);
            this.textBoxTime.TabIndex = 5;
            this.textBoxTime.Text = "3";
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxDbIncrease_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pitch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "s";
            // 
            // comboBoxWaves
            // 
            this.comboBoxWaves.FormattingEnabled = true;
            this.comboBoxWaves.Items.AddRange(new object[] {
            "Saw",
            "Ramp",
            "Sine",
            "Square",
            "Triangle",
            "Noise"});
            this.comboBoxWaves.Location = new System.Drawing.Point(113, 7);
            this.comboBoxWaves.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxWaves.Name = "comboBoxWaves";
            this.comboBoxWaves.Size = new System.Drawing.Size(95, 24);
            this.comboBoxWaves.TabIndex = 8;
            this.comboBoxWaves.SelectedIndexChanged += new System.EventHandler(this.comboBoxWaves_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hz";
            // 
            // textBoxFreqInHz
            // 
            this.textBoxFreqInHz.Location = new System.Drawing.Point(113, 53);
            this.textBoxFreqInHz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFreqInHz.Name = "textBoxFreqInHz";
            this.textBoxFreqInHz.Size = new System.Drawing.Size(75, 22);
            this.textBoxFreqInHz.TabIndex = 10;
            this.textBoxFreqInHz.Text = "440";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "frames";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fade In";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fade Out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "note";
            // 
            // checkBoxUseBLEP
            // 
            this.checkBoxUseBLEP.AutoSize = true;
            this.checkBoxUseBLEP.Location = new System.Drawing.Point(213, 6);
            this.checkBoxUseBLEP.Name = "checkBoxUseBLEP";
            this.checkBoxUseBLEP.Size = new System.Drawing.Size(100, 17);
            this.checkBoxUseBLEP.TabIndex = 16;
            this.checkBoxUseBLEP.Text = "Use PolyBLEPs";
            this.checkBoxUseBLEP.UseVisualStyleBackColor = true;
            // 
            // checkBoxBitz
            // 
            this.checkBoxBitz.AutoSize = true;
            this.checkBoxBitz.Location = new System.Drawing.Point(38, 170);
            this.checkBoxBitz.Name = "checkBoxBitz";
            this.checkBoxBitz.Size = new System.Drawing.Size(119, 17);
            this.checkBoxBitz.TabIndex = 17;
            this.checkBoxBitz.Text = "24bit (16b is defaut(";
            this.checkBoxBitz.UseVisualStyleBackColor = true;
            // 
            // textBoxBandLimiting
            // 
            this.textBoxBandLimiting.Location = new System.Drawing.Point(35, 207);
            this.textBoxBandLimiting.Name = "textBoxBandLimiting";
            this.textBoxBandLimiting.Size = new System.Drawing.Size(100, 20);
            this.textBoxBandLimiting.TabIndex = 18;
            this.textBoxBandLimiting.Text = "-1";
            // 
            // Dialog_GenerateSound
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(339, 242);
            this.Controls.Add(this.textBoxBandLimiting);
            this.Controls.Add(this.checkBoxBitz);
            this.Controls.Add(this.checkBoxUseBLEP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFreqInHz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWaves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimeInFrames);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog_GenerateSound";
            this.Text = "Generate Sound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxTimeInFrames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWaves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFreqInHz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxUseBLEP;
        private System.Windows.Forms.CheckBox checkBoxBitz;
        private System.Windows.Forms.TextBox textBoxBandLimiting;
    }
}