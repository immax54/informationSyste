namespace informationSystemN.Forms
{
    partial class ownerForm
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
            this.userFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dayTimeLabel = new System.Windows.Forms.Label();
            this.eventButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            this.juryButton = new System.Windows.Forms.Button();
            this.myProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userFullName
            // 
            this.userFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userFullName.AutoSize = true;
            this.userFullName.Location = new System.Drawing.Point(538, 16);
            this.userFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userFullName.Name = "userFullName";
            this.userFullName.Size = new System.Drawing.Size(58, 22);
            this.userFullName.TabIndex = 0;
            this.userFullName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Location = new System.Drawing.Point(15, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dayTimeLabel
            // 
            this.dayTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dayTimeLabel.AutoSize = true;
            this.dayTimeLabel.Location = new System.Drawing.Point(538, 95);
            this.dayTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayTimeLabel.Name = "dayTimeLabel";
            this.dayTimeLabel.Size = new System.Drawing.Size(58, 22);
            this.dayTimeLabel.TabIndex = 2;
            this.dayTimeLabel.Text = "label1";
            // 
            // eventButton
            // 
            this.eventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.eventButton.Location = new System.Drawing.Point(395, 151);
            this.eventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventButton.Name = "eventButton";
            this.eventButton.Size = new System.Drawing.Size(356, 111);
            this.eventButton.TabIndex = 3;
            this.eventButton.Text = "Мероприятия";
            this.eventButton.UseVisualStyleBackColor = true;
            this.eventButton.Click += new System.EventHandler(this.eventButton_Click);
            // 
            // membersButton
            // 
            this.membersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.membersButton.Location = new System.Drawing.Point(395, 293);
            this.membersButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(356, 111);
            this.membersButton.TabIndex = 4;
            this.membersButton.Text = "Участники";
            this.membersButton.UseVisualStyleBackColor = true;
            // 
            // juryButton
            // 
            this.juryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.juryButton.Location = new System.Drawing.Point(395, 441);
            this.juryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.juryButton.Name = "juryButton";
            this.juryButton.Size = new System.Drawing.Size(356, 111);
            this.juryButton.TabIndex = 5;
            this.juryButton.Text = "Жюри";
            this.juryButton.UseVisualStyleBackColor = true;
            // 
            // myProfileButton
            // 
            this.myProfileButton.Location = new System.Drawing.Point(15, 530);
            this.myProfileButton.Margin = new System.Windows.Forms.Padding(4);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(276, 65);
            this.myProfileButton.TabIndex = 7;
            this.myProfileButton.Text = "Мой профиль";
            this.myProfileButton.UseVisualStyleBackColor = true;
            // 
            // ownerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.myProfileButton);
            this.Controls.Add(this.juryButton);
            this.Controls.Add(this.membersButton);
            this.Controls.Add(this.eventButton);
            this.Controls.Add(this.dayTimeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userFullName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ownerForm";
            this.Text = "Окно организатора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dayTimeLabel;
        private System.Windows.Forms.Button eventButton;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button juryButton;
        private System.Windows.Forms.Button myProfileButton;
    }
}