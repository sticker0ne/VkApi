namespace VkApi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.fileCreateBtn = new System.Windows.Forms.Button();
            this.fileOpenBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splittedGraphBtn = new System.Windows.Forms.Button();
            this.kmBtn = new System.Windows.Forms.Button();
            this.fullGraphBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.apBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileNameLbl);
            this.groupBox1.Controls.Add(this.fileCreateBtn);
            this.groupBox1.Controls.Add(this.fileOpenBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(227, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(82, 25);
            this.fileNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(45, 17);
            this.fileNameLbl.TabIndex = 1;
            this.fileNameLbl.Text = "Файл";
            // 
            // fileCreateBtn
            // 
            this.fileCreateBtn.Location = new System.Drawing.Point(5, 50);
            this.fileCreateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileCreateBtn.Name = "fileCreateBtn";
            this.fileCreateBtn.Size = new System.Drawing.Size(73, 27);
            this.fileCreateBtn.TabIndex = 0;
            this.fileCreateBtn.Text = "Создать";
            this.fileCreateBtn.UseVisualStyleBackColor = true;
            this.fileCreateBtn.Click += new System.EventHandler(this.fileCreateBtn_Click);
            // 
            // fileOpenBtn
            // 
            this.fileOpenBtn.Location = new System.Drawing.Point(5, 19);
            this.fileOpenBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileOpenBtn.Name = "fileOpenBtn";
            this.fileOpenBtn.Size = new System.Drawing.Size(73, 27);
            this.fileOpenBtn.TabIndex = 0;
            this.fileOpenBtn.Text = "Открыть";
            this.fileOpenBtn.UseVisualStyleBackColor = true;
            this.fileOpenBtn.Click += new System.EventHandler(this.fileOpenBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JsonFile|*.json";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.apBtn);
            this.groupBox2.Controls.Add(this.splittedGraphBtn);
            this.groupBox2.Controls.Add(this.kmBtn);
            this.groupBox2.Controls.Add(this.fullGraphBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(246, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(446, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кластеризация";
            // 
            // splittedGraphBtn
            // 
            this.splittedGraphBtn.Location = new System.Drawing.Point(112, 19);
            this.splittedGraphBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splittedGraphBtn.Name = "splittedGraphBtn";
            this.splittedGraphBtn.Size = new System.Drawing.Size(104, 58);
            this.splittedGraphBtn.TabIndex = 0;
            this.splittedGraphBtn.Text = "Разбить и отрисовать";
            this.splittedGraphBtn.UseVisualStyleBackColor = true;
            this.splittedGraphBtn.Click += new System.EventHandler(this.splittedGraphBtn_Click);
            // 
            // kmBtn
            // 
            this.kmBtn.Location = new System.Drawing.Point(220, 19);
            this.kmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kmBtn.Name = "kmBtn";
            this.kmBtn.Size = new System.Drawing.Size(110, 58);
            this.kmBtn.TabIndex = 0;
            this.kmBtn.Text = "Использовать K-Means";
            this.kmBtn.UseVisualStyleBackColor = true;
            this.kmBtn.Click += new System.EventHandler(this.kmBtn_Click);
            // 
            // fullGraphBtn
            // 
            this.fullGraphBtn.Location = new System.Drawing.Point(4, 19);
            this.fullGraphBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullGraphBtn.Name = "fullGraphBtn";
            this.fullGraphBtn.Size = new System.Drawing.Size(104, 58);
            this.fullGraphBtn.TabIndex = 0;
            this.fullGraphBtn.Text = "Отрисовать полный граф";
            this.fullGraphBtn.UseVisualStyleBackColor = true;
            this.fullGraphBtn.Click += new System.EventHandler(this.fullGraphBtn_Click);
            // 
            // apBtn
            // 
            this.apBtn.Location = new System.Drawing.Point(334, 19);
            this.apBtn.Margin = new System.Windows.Forms.Padding(2);
            this.apBtn.Name = "apBtn";
            this.apBtn.Size = new System.Drawing.Size(110, 58);
            this.apBtn.TabIndex = 1;
            this.apBtn.Text = "Affinity propagation";
            this.apBtn.UseVisualStyleBackColor = true;
            this.apBtn.Click += new System.EventHandler(this.apBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 110);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.Button fileCreateBtn;
        private System.Windows.Forms.Button fileOpenBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fullGraphBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button splittedGraphBtn;
        private System.Windows.Forms.Button kmBtn;
        private System.Windows.Forms.Button apBtn;
    }
}