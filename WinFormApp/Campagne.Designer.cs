using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class Campagne
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
            this.campagneLabel = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.campagneLabelName = new System.Windows.Forms.Label();
            this.addCampagneBtn = new System.Windows.Forms.Button();
            this.listBoxEmailCampagne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(11, 20);
            this.campagneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(371, 67);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Les Campagnes";
            this.campagneLabel.Click += new System.EventHandler(this.campagneLabel_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(240, 116);
            this.inputName.Margin = new System.Windows.Forms.Padding(2);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(161, 27);
            this.inputName.TabIndex = 1;
            // 
            // campagneLabelName
            // 
            this.campagneLabelName.AutoSize = true;
            this.campagneLabelName.Location = new System.Drawing.Point(16, 120);
            this.campagneLabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campagneLabelName.Name = "campagneLabelName";
            this.campagneLabelName.Size = new System.Drawing.Size(189, 20);
            this.campagneLabelName.TabIndex = 2;
            this.campagneLabelName.Text = "Nommer votre Campagne :";
            this.campagneLabelName.Click += new System.EventHandler(this.campagneLabelName_Click);
            // 
            // addCampagneBtn
            // 
            this.addCampagneBtn.Location = new System.Drawing.Point(416, 112);
            this.addCampagneBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCampagneBtn.Name = "addCampagneBtn";
            this.addCampagneBtn.Size = new System.Drawing.Size(160, 32);
            this.addCampagneBtn.TabIndex = 3;
            this.addCampagneBtn.Text = "Add";
            this.addCampagneBtn.UseVisualStyleBackColor = true;
            this.addCampagneBtn.Click += new System.EventHandler(this.AddCampagne_Click);
            // 
            // listBoxEmailCampagne
            // 
            this.listBoxEmailCampagne.FormattingEnabled = true;
            this.listBoxEmailCampagne.ItemHeight = 20;
            this.listBoxEmailCampagne.Location = new System.Drawing.Point(16, 160);
            this.listBoxEmailCampagne.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEmailCampagne.Name = "listBoxEmailCampagne";
            this.listBoxEmailCampagne.Size = new System.Drawing.Size(841, 304);
            this.listBoxEmailCampagne.TabIndex = 4;
            this.listBoxEmailCampagne.Click += new System.EventHandler(this.OpenIHMCampagne_Click);
            // 
            // Campagne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 481);
            this.Controls.Add(this.listBoxEmailCampagne);
            this.Controls.Add(this.addCampagneBtn);
            this.Controls.Add(this.campagneLabelName);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.campagneLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Campagne";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label campagneLabelName;
        private System.Windows.Forms.Button addCampagneBtn;
        private System.Windows.Forms.ListBox listBoxEmailCampagne;
    }
}

