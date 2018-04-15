namespace VkApi
{
    partial class SaveJsonForm
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
            this.frCountTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.frCntLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.jsonSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mainPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.helloLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frCountTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // frCountTrackBar
            // 
            this.frCountTrackBar.Location = new System.Drawing.Point(10, 269);
            this.frCountTrackBar.Minimum = 1;
            this.frCountTrackBar.Name = "frCountTrackBar";
            this.frCountTrackBar.Size = new System.Drawing.Size(442, 69);
            this.frCountTrackBar.TabIndex = 0;
            this.frCountTrackBar.Value = 1;
            this.frCountTrackBar.Scroll += new System.EventHandler(this.frCountTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите количество друзей для загрузки";
            // 
            // frCntLabel
            // 
            this.frCntLabel.AutoSize = true;
            this.frCntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frCntLabel.Location = new System.Drawing.Point(458, 269);
            this.frCntLabel.Name = "frCntLabel";
            this.frCntLabel.Size = new System.Drawing.Size(26, 29);
            this.frCntLabel.TabIndex = 2;
            this.frCntLabel.Text = "1";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveBtn.Location = new System.Drawing.Point(15, 328);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(289, 52);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Загрузить и сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.Save_Click);
            // 
            // jsonSaveFileDialog
            // 
            this.jsonSaveFileDialog.Filter = "JsonFile|*.json";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 386);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(514, 39);
            this.progressBar.TabIndex = 4;
            // 
            // mainPhotoPictureBox
            // 
            this.mainPhotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPhotoPictureBox.Name = "mainPhotoPictureBox";
            this.mainPhotoPictureBox.Size = new System.Drawing.Size(200, 200);
            this.mainPhotoPictureBox.TabIndex = 5;
            this.mainPhotoPictureBox.TabStop = false;
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helloLabel.Location = new System.Drawing.Point(218, 118);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(242, 29);
            this.helloLabel.TabIndex = 6;
            this.helloLabel.Text = "Здравтсвуйте, Иван";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(218, 12);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(259, 46);
            this.userLabel.TabIndex = 8;
            this.userLabel.Text = "Иван Иванов";
            // 
            // SaveJsonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 510);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.mainPhotoPictureBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.frCntLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frCountTrackBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveJsonForm";
            this.Text = "Загрузка друзей";
            this.Load += new System.EventHandler(this.SaveJsonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frCountTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar frCountTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frCntLabel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog jsonSaveFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox mainPhotoPictureBox;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label userLabel;
    }
}