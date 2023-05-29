namespace informationSystemN
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.fullNameHideLabel = new System.Windows.Forms.Label();
            this.DatabaseID = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.captchaPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(168, 383);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(181, 45);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.Location = new System.Drawing.Point(337, 162);
            this.showPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(116, 45);
            this.showPasswordButton.TabIndex = 2;
            this.showPasswordButton.Text = "Показать";
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(39, 180);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(239, 27);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(39, 104);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(239, 27);
            this.loginTextBox.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(35, 66);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 20);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(35, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 20);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Пароль";
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(135, 336);
            this.captchaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(239, 27);
            this.captchaTextBox.TabIndex = 3;
            // 
            // fullNameHideLabel
            // 
            this.fullNameHideLabel.AutoSize = true;
            this.fullNameHideLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fullNameHideLabel.Location = new System.Drawing.Point(400, 24);
            this.fullNameHideLabel.Name = "fullNameHideLabel";
            this.fullNameHideLabel.Size = new System.Drawing.Size(53, 20);
            this.fullNameHideLabel.TabIndex = 8;
            this.fullNameHideLabel.Text = "label1";
            // 
            // DatabaseID
            // 
            this.DatabaseID.AutoSize = true;
            this.DatabaseID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DatabaseID.Location = new System.Drawing.Point(400, 66);
            this.DatabaseID.Name = "DatabaseID";
            this.DatabaseID.Size = new System.Drawing.Size(53, 20);
            this.DatabaseID.TabIndex = 9;
            this.DatabaseID.Text = "label1";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(13, 17);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 34);
            this.back.TabIndex = 10;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // captchaPicture
            // 
            this.captchaPicture.Image = global::informationSystemN.Properties.Resources.Снимок_экрана_2022_10_13_161858;
            this.captchaPicture.Location = new System.Drawing.Point(96, 240);
            this.captchaPicture.Name = "captchaPicture";
            this.captchaPicture.Size = new System.Drawing.Size(309, 69);
            this.captchaPicture.TabIndex = 6;
            this.captchaPicture.TabStop = false;
            this.captchaPicture.Click += new System.EventHandler(this.captchaPicture_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 441);
            this.Controls.Add(this.back);
            this.Controls.Add(this.DatabaseID);
            this.Controls.Add(this.fullNameHideLabel);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.captchaPicture);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.showPasswordButton);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 488);
            this.MinimumSize = new System.Drawing.Size(546, 488);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ООО \'\' ..\'\' - Окно авторизации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox captchaPicture;
        private System.Windows.Forms.TextBox captchaTextBox;
        public System.Windows.Forms.Label fullNameHideLabel;
        public System.Windows.Forms.Label DatabaseID;
        private System.Windows.Forms.Button back;
    }
}

