namespace informationSystemN.ElementsUI
{
    partial class eventCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventPicture = new System.Windows.Forms.PictureBox();
            this.eventName = new System.Windows.Forms.Label();
            this.eventBranch = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // eventPicture
            // 
            this.eventPicture.Location = new System.Drawing.Point(4, 38);
            this.eventPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventPicture.Name = "eventPicture";
            this.eventPicture.Size = new System.Drawing.Size(210, 165);
            this.eventPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventPicture.TabIndex = 0;
            this.eventPicture.TabStop = false;
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(234, 41);
            this.eventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(208, 20);
            this.eventName.TabIndex = 1;
            this.eventName.Text = "Название мероприятия";
            // 
            // eventBranch
            // 
            this.eventBranch.AutoSize = true;
            this.eventBranch.Location = new System.Drawing.Point(234, 105);
            this.eventBranch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventBranch.Name = "eventBranch";
            this.eventBranch.Size = new System.Drawing.Size(236, 20);
            this.eventBranch.TabIndex = 2;
            this.eventBranch.Text = "направление мероприятия";
            // 
            // eventDate
            // 
            this.eventDate.AutoSize = true;
            this.eventDate.Location = new System.Drawing.Point(234, 174);
            this.eventDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(57, 20);
            this.eventDate.TabIndex = 3;
            this.eventDate.Text = "Дата:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название мероприятия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Направление мероприятия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата:";
            // 
            // eventCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.eventBranch);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.eventPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "eventCard";
            this.Size = new System.Drawing.Size(474, 207);
            ((System.ComponentModel.ISupportInitialize)(this.eventPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox eventPicture;
        public System.Windows.Forms.Label eventName;
        public System.Windows.Forms.Label eventBranch;
        public System.Windows.Forms.Label eventDate;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}
