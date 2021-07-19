
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btOpen = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btChangeFile = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.tbTrance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 25);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(124, 48);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btChangeFile
            // 
            this.btChangeFile.Location = new System.Drawing.Point(142, 25);
            this.btChangeFile.Name = "btChangeFile";
            this.btChangeFile.Size = new System.Drawing.Size(124, 48);
            this.btChangeFile.TabIndex = 2;
            this.btChangeFile.Text = "保存先";
            this.btChangeFile.UseVisualStyleBackColor = true;
            this.btChangeFile.Click += new System.EventHandler(this.btChangeFile_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(272, 25);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(124, 48);
            this.btChange.TabIndex = 3;
            this.btChange.Text = "行番号追加";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click_1);
            // 
            // tbTrance
            // 
            this.tbTrance.Location = new System.Drawing.Point(35, 79);
            this.tbTrance.Multiline = true;
            this.tbTrance.Name = "tbTrance";
            this.tbTrance.Size = new System.Drawing.Size(351, 274);
            this.tbTrance.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 375);
            this.Controls.Add(this.tbTrance);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btChangeFile);
            this.Controls.Add(this.btOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.Button btChangeFile;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbTrance;
    }
}

