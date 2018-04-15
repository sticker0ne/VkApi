namespace VkApi
{
    partial class AffinityPropagationForm
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
            this.clusterLbl = new System.Windows.Forms.Label();
            this.clusterBar = new System.Windows.Forms.TrackBar();
            this.paintBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.ди1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iterationBar = new System.Windows.Forms.TrackBar();
            this.iterationLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clusterBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // clusterLbl
            // 
            this.clusterLbl.AutoSize = true;
            this.clusterLbl.Location = new System.Drawing.Point(431, 61);
            this.clusterLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.clusterLbl.Name = "clusterLbl";
            this.clusterLbl.Size = new System.Drawing.Size(40, 20);
            this.clusterLbl.TabIndex = 11;
            this.clusterLbl.Text = "1.00";
            // 
            // clusterBar
            // 
            this.clusterBar.LargeChange = 1;
            this.clusterBar.Location = new System.Drawing.Point(9, 61);
            this.clusterBar.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.clusterBar.Maximum = 200;
            this.clusterBar.Minimum = 1;
            this.clusterBar.Name = "clusterBar";
            this.clusterBar.Size = new System.Drawing.Size(384, 45);
            this.clusterBar.TabIndex = 10;
            this.clusterBar.Value = 100;
            this.clusterBar.ValueChanged += new System.EventHandler(this.clusterBar_ValueChanged);
            // 
            // paintBtn
            // 
            this.paintBtn.Location = new System.Drawing.Point(12, 229);
            this.paintBtn.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.paintBtn.Name = "paintBtn";
            this.paintBtn.Size = new System.Drawing.Size(155, 48);
            this.paintBtn.TabIndex = 8;
            this.paintBtn.Text = "Отрисовать";
            this.paintBtn.UseVisualStyleBackColor = true;
            this.paintBtn.Click += new System.EventHandler(this.paintBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(329, 229);
            this.okBtn.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(192, 48);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "Закрыть";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ди1
            // 
            this.ди1.AutoSize = true;
            this.ди1.Location = new System.Drawing.Point(11, 35);
            this.ди1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ди1.Name = "ди1";
            this.ди1.Size = new System.Drawing.Size(68, 20);
            this.ди1.TabIndex = 13;
            this.ди1.Text = "больше";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "меньше";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clusterBar);
            this.groupBox1.Controls.Add(this.clusterLbl);
            this.groupBox1.Controls.Add(this.ди1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 115);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество кластеров";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iterationBar);
            this.groupBox2.Controls.Add(this.iterationLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 90);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество итераций";
            // 
            // iterationBar
            // 
            this.iterationBar.LargeChange = 1;
            this.iterationBar.Location = new System.Drawing.Point(5, 36);
            this.iterationBar.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.iterationBar.Maximum = 100;
            this.iterationBar.Minimum = 1;
            this.iterationBar.Name = "iterationBar";
            this.iterationBar.Size = new System.Drawing.Size(384, 45);
            this.iterationBar.TabIndex = 10;
            this.iterationBar.Value = 10;
            this.iterationBar.ValueChanged += new System.EventHandler(this.iterationBar_ValueChanged);
            // 
            // iterationLbl
            // 
            this.iterationLbl.AutoSize = true;
            this.iterationLbl.Location = new System.Drawing.Point(431, 45);
            this.iterationLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.iterationLbl.Name = "iterationLbl";
            this.iterationLbl.Size = new System.Drawing.Size(58, 20);
            this.iterationLbl.TabIndex = 11;
            this.iterationLbl.Text = "10 000";
            // 
            // AffinityPropagationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paintBtn);
            this.Controls.Add(this.okBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AffinityPropagationForm";
            this.Text = "AffinityPropagationForm";
            this.Load += new System.EventHandler(this.AffinityPropagationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clusterBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clusterLbl;
        private System.Windows.Forms.TrackBar clusterBar;
        private System.Windows.Forms.Button paintBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label ди1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar iterationBar;
        private System.Windows.Forms.Label iterationLbl;
    }
}