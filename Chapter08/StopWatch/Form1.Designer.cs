
namespace StopWatch {
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
            this.components = new System.ComponentModel.Container();
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RapButton = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.ListBox();
            this.tmDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(50, 43);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(347, 60);
            this.lbTimerDisp.TabIndex = 0;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(50, 135);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 65);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "スタート";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StopButton.Location = new System.Drawing.Point(245, 135);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(152, 65);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "ストップ";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetButton.Location = new System.Drawing.Point(50, 234);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(152, 65);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RapButton
            // 
            this.RapButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RapButton.Location = new System.Drawing.Point(245, 234);
            this.RapButton.Name = "RapButton";
            this.RapButton.Size = new System.Drawing.Size(152, 65);
            this.RapButton.TabIndex = 4;
            this.RapButton.Text = "ラップ";
            this.RapButton.UseVisualStyleBackColor = true;
            this.RapButton.Click += new System.EventHandler(this.RapButton_Click);
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.ItemHeight = 12;
            this.Items.Location = new System.Drawing.Point(431, 31);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(117, 268);
            this.Items.TabIndex = 5;
            // 
            // tmDisp
            // 
            this.tmDisp.Tick += new System.EventHandler(this.tmDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(569, 316);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.RapButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.lbTimerDisp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RapButton;
        private System.Windows.Forms.ListBox Items;
        private System.Windows.Forms.Timer tmDisp;
    }
}

