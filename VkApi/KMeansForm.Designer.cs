namespace VkApi
{
    partial class KMeansForm
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
            this.countLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countBar = new System.Windows.Forms.TrackBar();
            this.paintBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countBar)).BeginInit();
            this.SuspendLayout();
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(545, 111);
            this.countLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(79, 29);
            this.countLbl.TabIndex = 6;
            this.countLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите количество кластеров \r\nдля окрашивания k-means";
            // 
            // countBar
            // 
            this.countBar.LargeChange = 1;
            this.countBar.Location = new System.Drawing.Point(14, 111);
            this.countBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.countBar.Name = "countBar";
            this.countBar.Size = new System.Drawing.Size(521, 69);
            this.countBar.TabIndex = 5;
            this.countBar.ValueChanged += new System.EventHandler(this.countBar_ValueChanged);
            // 
            // paintBtn
            // 
            this.paintBtn.Location = new System.Drawing.Point(22, 221);
            this.paintBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.paintBtn.Name = "paintBtn";
            this.paintBtn.Size = new System.Drawing.Size(282, 75);
            this.paintBtn.TabIndex = 3;
            this.paintBtn.Text = "Отрисовать";
            this.paintBtn.UseVisualStyleBackColor = true;
            this.paintBtn.Click += new System.EventHandler(this.paintBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(364, 221);
            this.okBtn.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(282, 75);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Закрыть";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // KMeansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 338);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countBar);
            this.Controls.Add(this.paintBtn);
            this.Controls.Add(this.okBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KMeansForm";
            this.Text = "KMeansForm";
            this.Load += new System.EventHandler(this.KMeansForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar countBar;
        private System.Windows.Forms.Button paintBtn;
        private System.Windows.Forms.Button okBtn;
    }
}