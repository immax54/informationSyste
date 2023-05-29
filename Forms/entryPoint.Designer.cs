namespace informationSystemN.Forms
{
    partial class entryPoint
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
            this.authButton = new System.Windows.Forms.Button();
            this.branchesBox = new System.Windows.Forms.ComboBox();
            this.sortBranchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authButton
            // 
            this.authButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.authButton.Location = new System.Drawing.Point(1308, 12);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(150, 59);
            this.authButton.TabIndex = 0;
            this.authButton.Text = "Авторизоваться";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // branchesBox
            // 
            this.branchesBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.branchesBox.FormattingEnabled = true;
            this.branchesBox.Items.AddRange(new object[] {
            "Аналитика",
            "Биг Дата",
            "Дизайн",
            "Информационная безопасность",
            "ИТ"});
            this.branchesBox.Location = new System.Drawing.Point(1015, 47);
            this.branchesBox.Name = "branchesBox";
            this.branchesBox.Size = new System.Drawing.Size(189, 24);
            this.branchesBox.TabIndex = 1;
            this.branchesBox.SelectedIndexChanged += new System.EventHandler(this.branchesBox_SelectedIndexChanged);
            // 
            // sortBranchLabel
            // 
            this.sortBranchLabel.AutoSize = true;
            this.sortBranchLabel.Location = new System.Drawing.Point(1012, 12);
            this.sortBranchLabel.Name = "sortBranchLabel";
            this.sortBranchLabel.Size = new System.Drawing.Size(208, 16);
            this.sortBranchLabel.TabIndex = 2;
            this.sortBranchLabel.Text = "Сортировать по направлению:";
            // 
            // entryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1482, 663);
            this.Controls.Add(this.sortBranchLabel);
            this.Controls.Add(this.branchesBox);
            this.Controls.Add(this.authButton);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "entryPoint";
            this.Text = "entryPoint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.entryPoint_FormClosed);
            this.Load += new System.EventHandler(this.entryPoint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.ComboBox branchesBox;
        private System.Windows.Forms.Label sortBranchLabel;
    }
}