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
            this.checkBox_blackwhite = new System.Windows.Forms.CheckBox();
            this.checkBox_night = new System.Windows.Forms.CheckBox();
            this.checkBox_kirsch = new System.Windows.Forms.CheckBox();
            this.checkBox_prewitt = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // checkBox_blackwhite
            // 
            this.checkBox_blackwhite.AutoSize = true;
            this.checkBox_blackwhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_blackwhite.Location = new System.Drawing.Point(428, 713);
            this.checkBox_blackwhite.Name = "checkBox_blackwhite";
            this.checkBox_blackwhite.Size = new System.Drawing.Size(301, 43);
            this.checkBox_blackwhite.TabIndex = 4;
            this.checkBox_blackwhite.Text = "Black and White";
            this.checkBox_blackwhite.UseVisualStyleBackColor = true;
            // 
            // checkBox_night
            // 
            this.checkBox_night.AutoSize = true;
            this.checkBox_night.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_night.Location = new System.Drawing.Point(428, 778);
            this.checkBox_night.Name = "checkBox_night";
            this.checkBox_night.Size = new System.Drawing.Size(135, 43);
            this.checkBox_night.TabIndex = 5;
            this.checkBox_night.Text = "Night";
            this.checkBox_night.UseVisualStyleBackColor = true;
            // 
            // checkBox_kirsch
            // 
            this.checkBox_kirsch.AutoSize = true;
            this.checkBox_kirsch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_kirsch.Location = new System.Drawing.Point(867, 778);
            this.checkBox_kirsch.Name = "checkBox_kirsch";
            this.checkBox_kirsch.Size = new System.Drawing.Size(150, 43);
            this.checkBox_kirsch.TabIndex = 8;
            this.checkBox_kirsch.Text = "Kirsch";
            this.checkBox_kirsch.UseVisualStyleBackColor = true;
            // 
            // checkBox_prewitt
            // 
            this.checkBox_prewitt.AutoSize = true;
            this.checkBox_prewitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_prewitt.Location = new System.Drawing.Point(867, 713);
            this.checkBox_prewitt.Name = "checkBox_prewitt";
            this.checkBox_prewitt.Size = new System.Drawing.Size(159, 43);
            this.checkBox_prewitt.TabIndex = 7;
            this.checkBox_prewitt.Text = "Prewitt";
            this.checkBox_prewitt.UseVisualStyleBackColor = true;
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
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 881);
            this.Controls.Add(this.checkBox_kirsch);
            this.Controls.Add(this.checkBox_prewitt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_night);
            this.Controls.Add(this.checkBox_blackwhite);
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

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.CheckBox checkBox_blackwhite;
        private System.Windows.Forms.CheckBox checkBox_night;
        private System.Windows.Forms.CheckBox checkBox_kirsch;
        private System.Windows.Forms.CheckBox checkBox_prewitt;
        private System.Windows.Forms.Label label1;
    }
}