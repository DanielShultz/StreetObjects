
namespace StreetObjects
{
    partial class Test1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test1));
            this.okButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(253, 259);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(508, 39);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Visible = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(253, 214);
            this.comboBox.Name = "comboBox";
            this.comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox.Size = new System.Drawing.Size(508, 39);
            this.comboBox.Sorted = true;
            this.comboBox.TabIndex = 3;
            this.comboBox.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(253, 170);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(508, 38);
            this.textBox.TabIndex = 4;
            this.textBox.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::StreetObjects.Properties.Resources._1;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(998, 497);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(253, 125);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(508, 39);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Закрыть";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            // 
            // hideButton
            // 
            this.hideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hideButton.Location = new System.Drawing.Point(868, 12);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(142, 39);
            this.hideButton.TabIndex = 6;
            this.hideButton.Text = "Скрыть";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Visible = false;
            this.hideButton.Click += new System.EventHandler(this.Hide_Click);
            // 
            // Test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 518);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test1";
            this.RightToLeftLayout = true;
            this.Text = "Тест на память";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button hideButton;
    }
}