﻿using System;

namespace WavEditCs
{
    partial class ChildForm
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMouseDown = new System.Windows.Forms.Label();
            this.labelMouseUp = new System.Windows.Forms.Label();
            this.labelMouseMove = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelZoomStatus = new System.Windows.Forms.Label();
            this.labelPixPerSam = new System.Windows.Forms.Label();
            this.labelSamplesPerP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 425);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(914, 20);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // labelMouseDown
            // 
            this.labelMouseDown.AutoSize = true;
            this.labelMouseDown.Location = new System.Drawing.Point(13, 26);
            this.labelMouseDown.Name = "labelMouseDown";
            this.labelMouseDown.Size = new System.Drawing.Size(89, 13);
            this.labelMouseDown.TabIndex = 2;
            this.labelMouseDown.Text = "labelMouseDown";
            // 
            // labelMouseUp
            // 
            this.labelMouseUp.AutoSize = true;
            this.labelMouseUp.Location = new System.Drawing.Point(13, 43);
            this.labelMouseUp.Name = "labelMouseUp";
            this.labelMouseUp.Size = new System.Drawing.Size(75, 13);
            this.labelMouseUp.TabIndex = 3;
            this.labelMouseUp.Text = "labelMouseUp";
            // 
            // labelMouseMove
            // 
            this.labelMouseMove.AutoSize = true;
            this.labelMouseMove.Location = new System.Drawing.Point(13, 60);
            this.labelMouseMove.Name = "labelMouseMove";
            this.labelMouseMove.Size = new System.Drawing.Size(88, 13);
            this.labelMouseMove.TabIndex = 4;
            this.labelMouseMove.Text = "labelMouseMove";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(879, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // labelZoomStatus
            // 
            this.labelZoomStatus.AutoSize = true;
            this.labelZoomStatus.Location = new System.Drawing.Point(12, 362);
            this.labelZoomStatus.Name = "labelZoomStatus";
            this.labelZoomStatus.Size = new System.Drawing.Size(35, 13);
            this.labelZoomStatus.TabIndex = 7;
            this.labelZoomStatus.Text = "label4";
            // 
            // labelPixPerSam
            // 
            this.labelPixPerSam.AutoSize = true;
            this.labelPixPerSam.Location = new System.Drawing.Point(12, 388);
            this.labelPixPerSam.Name = "labelPixPerSam";
            this.labelPixPerSam.Size = new System.Drawing.Size(66, 13);
            this.labelPixPerSam.TabIndex = 8;
            this.labelPixPerSam.Text = "labelPixPerS";
            // 
            // labelSamplesPerP
            // 
            this.labelSamplesPerP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSamplesPerP.AutoSize = true;
            this.labelSamplesPerP.Location = new System.Drawing.Point(12, 412);
            this.labelSamplesPerP.Name = "labelSamplesPerP";
            this.labelSamplesPerP.Size = new System.Drawing.Size(92, 13);
            this.labelSamplesPerP.TabIndex = 9;
            this.labelSamplesPerP.Text = "labelSamplesPerP";
            // 
            // MdiChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 445);
            this.Controls.Add(this.labelSamplesPerP);
            this.Controls.Add(this.labelPixPerSam);
            this.Controls.Add(this.labelZoomStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMouseMove);
            this.Controls.Add(this.labelMouseUp);
            this.Controls.Add(this.labelMouseDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "MdiChildForm";
            this.Text = "MdiChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MdiChildForm_FormClosing);
            this.Load += new System.EventHandler(this.MdiChildForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MdiChildForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MdiChildForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MdiChildForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMouseDown;
        private System.Windows.Forms.Label labelMouseUp;
        private System.Windows.Forms.Label labelMouseMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelZoomStatus;
        private System.Windows.Forms.Label labelPixPerSam;
        private System.Windows.Forms.Label labelSamplesPerP;
    }
}