
namespace Exercise1 {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRAL = new System.Windows.Forms.Button();
            this.btRL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 65);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(674, 421);
            this.tbOutput.TabIndex = 0;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(104, 47);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbKeyWord
            // 
            this.tbKeyWord.Location = new System.Drawing.Point(122, 40);
            this.tbKeyWord.Name = "tbKeyWord";
            this.tbKeyWord.Size = new System.Drawing.Size(100, 19);
            this.tbKeyWord.TabIndex = 2;
            this.tbKeyWord.TextChanged += new System.EventHandler(this.tbKeyWord_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "キーワード";
            // 
            // btRAL
            // 
            this.btRAL.Location = new System.Drawing.Point(228, 12);
            this.btRAL.Name = "btRAL";
            this.btRAL.Size = new System.Drawing.Size(104, 47);
            this.btRAL.TabIndex = 4;
            this.btRAL.Text = "ReadAllLines";
            this.btRAL.UseVisualStyleBackColor = true;
            this.btRAL.Click += new System.EventHandler(this.btRAL_Click);
            // 
            // btRL
            // 
            this.btRL.Location = new System.Drawing.Point(338, 12);
            this.btRL.Name = "btRL";
            this.btRL.Size = new System.Drawing.Size(104, 47);
            this.btRL.TabIndex = 5;
            this.btRL.Text = "ReadLines";
            this.btRL.UseVisualStyleBackColor = true;
            this.btRL.Click += new System.EventHandler(this.btRL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 498);
            this.Controls.Add(this.btRL);
            this.Controls.Add(this.btRAL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeyWord);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRAL;
        private System.Windows.Forms.Button btRL;
    }
}

