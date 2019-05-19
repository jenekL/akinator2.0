namespace Akinator2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(339, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Признак: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(340, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.Control;
            this.yesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("yesButton.BackgroundImage")));
            this.yesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yesButton.Location = new System.Drawing.Point(173, 242);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(150, 141);
            this.yesButton.TabIndex = 2;
            this.yesButton.UseVisualStyleBackColor = false;
            // 
            // NoButton
            // 
            this.NoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoButton.BackgroundImage")));
            this.NoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoButton.Location = new System.Drawing.Point(485, 242);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(151, 141);
            this.NoButton.TabIndex = 3;
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button NoButton;
    }
}

