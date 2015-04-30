namespace ApplicationRelatedToFile
{
    partial class Form1
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
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.showNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(166, 168);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(186, 199);
            this.nameListBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(166, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(186, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(425, 56);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(75, 23);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(425, 168);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(75, 23);
            this.showNameButton.TabIndex = 3;
            this.showNameButton.Text = "Show";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showNameButton);
            this.Controls.Add(this.saveNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameListBox);
            this.Name = "Form1";
            this.Text = "File Application UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Label label1;
    }
}

