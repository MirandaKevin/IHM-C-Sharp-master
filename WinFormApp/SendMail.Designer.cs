﻿using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class SendMail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.expLabel = new System.Windows.Forms.Label();
            this.checkBoxLabel = new System.Windows.Forms.Label();
            this.objLabel = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.expInput = new System.Windows.Forms.TextBox();
            this.objInput = new System.Windows.Forms.TextBox();
            this.msgInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(31, 21);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(346, 67);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Envoie d\'email";
            // 
            // expLabel
            // 
            this.expLabel.AutoSize = true;
            this.expLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expLabel.Location = new System.Drawing.Point(16, 120);
            this.expLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expLabel.Name = "expLabel";
            this.expLabel.Size = new System.Drawing.Size(110, 23);
            this.expLabel.TabIndex = 0;
            this.expLabel.Text = "Destinataire :";
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxLabel.Location = new System.Drawing.Point(400, 120);
            this.checkBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(198, 23);
            this.checkBoxLabel.TabIndex = 0;
            this.checkBoxLabel.Text = "Envoyer à tout le monde";
            // 
            // objLabel
            // 
            this.objLabel.AutoSize = true;
            this.objLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objLabel.Location = new System.Drawing.Point(16, 160);
            this.objLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.objLabel.Name = "objLabel";
            this.objLabel.Size = new System.Drawing.Size(61, 23);
            this.objLabel.TabIndex = 0;
            this.objLabel.Text = "Objet :";
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgLabel.Location = new System.Drawing.Point(16, 200);
            this.msgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(63, 23);
            this.msgLabel.TabIndex = 0;
            this.msgLabel.Text = "Corps :";
            // 
            // expInput
            // 
            this.expInput.Location = new System.Drawing.Point(136, 120);
            this.expInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expInput.Name = "expInput";
            this.expInput.Size = new System.Drawing.Size(241, 27);
            this.expInput.TabIndex = 1;
            // 
            // objInput
            // 
            this.objInput.Location = new System.Drawing.Point(136, 160);
            this.objInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.objInput.Name = "objInput";
            this.objInput.Size = new System.Drawing.Size(241, 27);
            this.objInput.TabIndex = 1;
            // 
            // msgInput
            // 
            this.msgInput.Location = new System.Drawing.Point(136, 200);
            this.msgInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.msgInput.Multiline = true;
            this.msgInput.Name = "msgInput";
            this.msgInput.Size = new System.Drawing.Size(641, 161);
            this.msgInput.TabIndex = 1;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(616, 400);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(160, 32);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Envoyer";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // allCheckBox
            // 
            this.allCheckBox.Location = new System.Drawing.Point(640, 120);
            this.allCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(160, 32);
            this.allCheckBox.TabIndex = 3;
            this.allCheckBox.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 481);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.expLabel);
            this.Controls.Add(this.checkBoxLabel);
            this.Controls.Add(this.objLabel);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.expInput);
            this.Controls.Add(this.objInput);
            this.Controls.Add(this.msgInput);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.allCheckBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SendMail";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label expLabel;
        private System.Windows.Forms.Label checkBoxLabel;
        private System.Windows.Forms.Label objLabel;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.TextBox expInput;
        private System.Windows.Forms.TextBox objInput;
        private System.Windows.Forms.TextBox msgInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.CheckBox allCheckBox;
    }
}

