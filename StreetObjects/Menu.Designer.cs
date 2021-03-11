
namespace StreetObjects
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Start = new System.Windows.Forms.Button();
            this.Start2 = new System.Windows.Forms.Button();
            this.log2 = new System.Windows.Forms.TextBox();
            this.log1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(698, 55);
            this.Start.TabIndex = 0;
            this.Start.Text = "Старт (задержка 10 секунд)";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Start2
            // 
            this.Start2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start2.Location = new System.Drawing.Point(12, 117);
            this.Start2.Name = "Start2";
            this.Start2.Size = new System.Drawing.Size(698, 55);
            this.Start2.TabIndex = 2;
            this.Start2.Text = "Старт (задержка 5 секуд)";
            this.Start2.UseVisualStyleBackColor = true;
            this.Start2.Click += new System.EventHandler(this.Start2_Click);
            // 
            // log2
            // 
            this.log2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log2.Location = new System.Drawing.Point(12, 178);
            this.log2.Name = "log2";
            this.log2.ReadOnly = true;
            this.log2.Size = new System.Drawing.Size(698, 38);
            this.log2.TabIndex = 4;
            this.log2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // log1
            // 
            this.log1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log1.Location = new System.Drawing.Point(12, 73);
            this.log1.Name = "log1";
            this.log1.ReadOnly = true;
            this.log1.Size = new System.Drawing.Size(698, 38);
            this.log1.TabIndex = 5;
            this.log1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 232);
            this.Controls.Add(this.log1);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.Start2);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Start2;
        private System.Windows.Forms.TextBox log2;
        private System.Windows.Forms.TextBox log1;
    }
}

