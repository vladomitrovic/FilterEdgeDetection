using System;

namespace FilterEdgeDetection
{
    partial class WinForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RB_BlackWhite = new System.Windows.Forms.RadioButton();
            this.RB_NightFilter = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RB_Prewitt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1409, 579);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(46, 703);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(285, 87);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1170, 703);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(285, 87);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltre.Location = new System.Drawing.Point(400, 646);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(137, 44);
            this.labelFiltre.TabIndex = 3;
            this.labelFiltre.Text = "Filtre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edge : ";
            // 
            // RB_BlackWhite
            // 
            this.RB_BlackWhite.AutoSize = true;
            this.RB_BlackWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_BlackWhite.Location = new System.Drawing.Point(423, 703);
            this.RB_BlackWhite.Name = "RB_BlackWhite";
            this.RB_BlackWhite.Size = new System.Drawing.Size(322, 48);
            this.RB_BlackWhite.TabIndex = 9;
            this.RB_BlackWhite.TabStop = true;
            this.RB_BlackWhite.Text = "Black and white";
            this.RB_BlackWhite.UseVisualStyleBackColor = true;
            // 
            // RB_NightFilter
            // 
            this.RB_NightFilter.AutoSize = true;
            this.RB_NightFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_NightFilter.Location = new System.Drawing.Point(423, 773);
            this.RB_NightFilter.Name = "RB_NightFilter";
            this.RB_NightFilter.Size = new System.Drawing.Size(242, 48);
            this.RB_NightFilter.TabIndex = 10;
            this.RB_NightFilter.TabStop = true;
            this.RB_NightFilter.Text = "Night Filter";
            this.RB_NightFilter.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(873, 773);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 48);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kirsch";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RB_Prewitt
            // 
            this.RB_Prewitt.AutoSize = true;
            this.RB_Prewitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Prewitt.Location = new System.Drawing.Point(873, 703);
            this.RB_Prewitt.Name = "RB_Prewitt";
            this.RB_Prewitt.Size = new System.Drawing.Size(174, 48);
            this.RB_Prewitt.TabIndex = 11;
            this.RB_Prewitt.TabStop = true;
            this.RB_Prewitt.Text = "Prewitt";
            this.RB_Prewitt.UseVisualStyleBackColor = true;
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 881);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RB_Prewitt);
            this.Controls.Add(this.RB_NightFilter);
            this.Controls.Add(this.RB_BlackWhite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFiltre);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WinForm";
            this.Text = "WinForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_BlackWhite;
        private System.Windows.Forms.RadioButton RB_NightFilter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RB_Prewitt;
    }
}