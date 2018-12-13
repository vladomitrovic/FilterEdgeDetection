namespace FilterEdgeDetection
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_save = new System.Windows.Forms.Button();
            this.label_filter = new System.Windows.Forms.Label();
            this.CheckBox_blackwhite = new System.Windows.Forms.CheckBox();
            this.checkBox_night = new System.Windows.Forms.CheckBox();
            this.checkBox_kirsh = new System.Windows.Forms.CheckBox();
            this.checkBox_prewitt = new System.Windows.Forms.CheckBox();
            this.label_edge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictureBox.Location = new System.Drawing.Point(34, 38);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1575, 695);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_load
            // 
            this.Btn_load.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_load.Location = new System.Drawing.Point(34, 838);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(335, 100);
            this.Btn_load.TabIndex = 1;
            this.Btn_load.Text = "Load";
            this.Btn_load.UseVisualStyleBackColor = false;
            this.Btn_load.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_save
            // 
            this.Btn_save.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.Location = new System.Drawing.Point(1274, 838);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(335, 100);
            this.Btn_save.TabIndex = 2;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = false;
            // 
            // label_filter
            // 
            this.label_filter.AutoSize = true;
            this.label_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filter.Location = new System.Drawing.Point(498, 795);
            this.label_filter.Name = "label_filter";
            this.label_filter.Size = new System.Drawing.Size(135, 44);
            this.label_filter.TabIndex = 3;
            this.label_filter.Text = "Filter :";
            this.label_filter.Click += new System.EventHandler(this.label1_Click);
            // 
            // CheckBox_blackwhite
            // 
            this.CheckBox_blackwhite.AutoSize = true;
            this.CheckBox_blackwhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_blackwhite.Location = new System.Drawing.Point(526, 858);
            this.CheckBox_blackwhite.Name = "CheckBox_blackwhite";
            this.CheckBox_blackwhite.Size = new System.Drawing.Size(294, 43);
            this.CheckBox_blackwhite.TabIndex = 4;
            this.CheckBox_blackwhite.Text = "Black and white";
            this.CheckBox_blackwhite.UseVisualStyleBackColor = true;
            // 
            // checkBox_night
            // 
            this.checkBox_night.AutoSize = true;
            this.checkBox_night.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_night.Location = new System.Drawing.Point(526, 916);
            this.checkBox_night.Name = "checkBox_night";
            this.checkBox_night.Size = new System.Drawing.Size(208, 43);
            this.checkBox_night.TabIndex = 5;
            this.checkBox_night.Text = "Night filter";
            this.checkBox_night.UseVisualStyleBackColor = true;
            this.checkBox_night.CheckedChanged += new System.EventHandler(this.checkBox__CheckedChanged);
            // 
            // checkBox_kirsh
            // 
            this.checkBox_kirsh.AutoSize = true;
            this.checkBox_kirsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_kirsh.Location = new System.Drawing.Point(983, 916);
            this.checkBox_kirsh.Name = "checkBox_kirsh";
            this.checkBox_kirsh.Size = new System.Drawing.Size(150, 43);
            this.checkBox_kirsh.TabIndex = 8;
            this.checkBox_kirsh.Text = "Kirsch";
            this.checkBox_kirsh.UseVisualStyleBackColor = true;
            // 
            // checkBox_prewitt
            // 
            this.checkBox_prewitt.AutoSize = true;
            this.checkBox_prewitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_prewitt.Location = new System.Drawing.Point(983, 858);
            this.checkBox_prewitt.Name = "checkBox_prewitt";
            this.checkBox_prewitt.Size = new System.Drawing.Size(159, 43);
            this.checkBox_prewitt.TabIndex = 7;
            this.checkBox_prewitt.Text = "Prewitt";
            this.checkBox_prewitt.UseVisualStyleBackColor = true;
            // 
            // label_edge
            // 
            this.label_edge.AutoSize = true;
            this.label_edge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_edge.Location = new System.Drawing.Point(952, 795);
            this.label_edge.Name = "label_edge";
            this.label_edge.Size = new System.Drawing.Size(135, 44);
            this.label_edge.TabIndex = 6;
            this.label_edge.Text = "Edge :";
            this.label_edge.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 1047);
            this.Controls.Add(this.checkBox_kirsh);
            this.Controls.Add(this.checkBox_prewitt);
            this.Controls.Add(this.label_edge);
            this.Controls.Add(this.checkBox_night);
            this.Controls.Add(this.CheckBox_blackwhite);
            this.Controls.Add(this.label_filter);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Btn_load);
            this.Controls.Add(this.PictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.Label label_filter;
        private System.Windows.Forms.CheckBox CheckBox_blackwhite;
        private System.Windows.Forms.CheckBox checkBox_night;
        private System.Windows.Forms.CheckBox checkBox_kirsh;
        private System.Windows.Forms.CheckBox checkBox_prewitt;
        private System.Windows.Forms.Label label_edge;
    }
}