namespace MiniLauncher
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
            this.EditIP = new System.Windows.Forms.TextBox();
            this.ConnectToServer = new System.Windows.Forms.Button();
            this.HelperText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditIP
            // 
            this.EditIP.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditIP.Location = new System.Drawing.Point(12, 45);
            this.EditIP.Name = "EditIP";
            this.EditIP.Size = new System.Drawing.Size(230, 23);
            this.EditIP.TabIndex = 0;
            // 
            // ConnectToServer
            // 
            this.ConnectToServer.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectToServer.Location = new System.Drawing.Point(12, 88);
            this.ConnectToServer.Name = "ConnectToServer";
            this.ConnectToServer.Size = new System.Drawing.Size(230, 64);
            this.ConnectToServer.TabIndex = 1;
            this.ConnectToServer.Text = "Войти на сервер";
            this.ConnectToServer.UseVisualStyleBackColor = true;
            this.ConnectToServer.Click += new System.EventHandler(this.ConnectToServer_Click);
            // 
            // HelperText
            // 
            this.HelperText.AutoSize = true;
            this.HelperText.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelperText.Location = new System.Drawing.Point(12, 19);
            this.HelperText.Name = "HelperText";
            this.HelperText.Size = new System.Drawing.Size(132, 17);
            this.HelperText.TabIndex = 2;
            this.HelperText.Text = "Введите IP сервера";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 158);
            this.Controls.Add(this.HelperText);
            this.Controls.Add(this.ConnectToServer);
            this.Controls.Add(this.EditIP);
            this.Name = "Form1";
            this.Text = "Вход на сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditIP;
        private System.Windows.Forms.Button ConnectToServer;
        private System.Windows.Forms.Label HelperText;
    }
}

