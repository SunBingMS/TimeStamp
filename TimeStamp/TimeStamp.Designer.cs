namespace TimeStamp
{
    partial class TimeStamp
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeStamp));
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnTarget = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.fbdTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdOriginal = new System.Windows.Forms.FolderBrowserDialog();
            this.staInfo = new System.Windows.Forms.StatusStrip();
            this.tsslFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.staInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarget
            // 
            this.txtTarget.BackColor = System.Drawing.Color.LightGreen;
            this.txtTarget.Location = new System.Drawing.Point(90, 6);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(314, 19);
            this.txtTarget.TabIndex = 0;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(12, 9);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(72, 12);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "変更ターゲット";
            // 
            // btnTarget
            // 
            this.btnTarget.Location = new System.Drawing.Point(410, 5);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(75, 21);
            this.btnTarget.TabIndex = 2;
            this.btnTarget.Text = "参照...";
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(410, 40);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 21);
            this.btnOriginal.TabIndex = 5;
            this.btnOriginal.Text = "参照...";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(25, 44);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(41, 12);
            this.lblOriginal.TabIndex = 4;
            this.lblOriginal.Text = "参照元";
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtOriginal.Location = new System.Drawing.Point(90, 41);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(314, 19);
            this.txtOriginal.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(168, 76);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(170, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "タイムスタンプ変更開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fbdTarget
            // 
            this.fbdTarget.Description = "変更先のフォルダを選択してください。";
            this.fbdTarget.ShowNewFolderButton = false;
            // 
            // fbdOriginal
            // 
            this.fbdOriginal.Description = "参照元のフォルダを選択してください。";
            this.fbdOriginal.ShowNewFolderButton = false;
            // 
            // staInfo
            // 
            this.staInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFile});
            this.staInfo.Location = new System.Drawing.Point(0, 126);
            this.staInfo.Name = "staInfo";
            this.staInfo.Size = new System.Drawing.Size(496, 22);
            this.staInfo.TabIndex = 7;
            this.staInfo.Text = "statusStrip1";
            // 
            // tsslFile
            // 
            this.tsslFile.Name = "tsslFile";
            this.tsslFile.Size = new System.Drawing.Size(0, 17);
            // 
            // TimeStamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 148);
            this.Controls.Add(this.staInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnTarget);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.txtTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeStamp";
            this.Text = "対象フォルダのタイムスタンプ変更ツール";
            this.staInfo.ResumeLayout(false);
            this.staInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog fbdTarget;
        private System.Windows.Forms.FolderBrowserDialog fbdOriginal;
        private System.Windows.Forms.StatusStrip staInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslFile;
    }
}

