namespace VkApi
{
    partial class MultiplyForm
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
            this.paintBtn = new System.Windows.Forms.Button();
            this.multBar = new System.Windows.Forms.TrackBar();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.multValueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.multBar)).BeginInit();
            this.SuspendLayout();
            // 
            // paintBtn
            // 
            this.paintBtn.Location = new System.Drawing.Point(14, 154);
            this.paintBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.paintBtn.Name = "paintBtn";
            this.paintBtn.Size = new System.Drawing.Size(164, 53);
            this.paintBtn.TabIndex = 0;
            this.paintBtn.Text = "Отрисовать";
            this.paintBtn.UseVisualStyleBackColor = true;
            this.paintBtn.Click += new System.EventHandler(this.paintBtn_Click);
            // 
            // multBar
            // 
            this.multBar.LargeChange = 1;
            this.multBar.Location = new System.Drawing.Point(14, 86);
            this.multBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.multBar.Maximum = 5;
            this.multBar.Minimum = 1;
            this.multBar.Name = "multBar";
            this.multBar.Size = new System.Drawing.Size(368, 69);
            this.multBar.TabIndex = 1;
            this.multBar.Value = 1;
            this.multBar.ValueChanged += new System.EventHandler(this.multBar_ValueChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(307, 154);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(164, 53);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбирете коэффициент умножения \r\nкоординат";
            // 
            // multValueLbl
            // 
            this.multValueLbl.AutoSize = true;
            this.multValueLbl.Location = new System.Drawing.Point(419, 86);
            this.multValueLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.multValueLbl.Name = "multValueLbl";
            this.multValueLbl.Size = new System.Drawing.Size(26, 29);
            this.multValueLbl.TabIndex = 2;
            this.multValueLbl.Text = "5";
            // 
            // MultiplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 386);
            this.Controls.Add(this.multValueLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multBar);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.paintBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiplyForm";
            this.Text = "MultiplyForm";
            this.Load += new System.EventHandler(this.MultiplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.multBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paintBtn;
        private System.Windows.Forms.TrackBar multBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label multValueLbl;
    }
}