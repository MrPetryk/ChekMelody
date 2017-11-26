namespace ChekMeldy
{
    partial class optionsForm
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
            this.songsList = new System.Windows.Forms.ListBox();
            this.addSongsButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.checkFlderInside = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songsList
            // 
            this.songsList.FormattingEnabled = true;
            this.songsList.Location = new System.Drawing.Point(12, 12);
            this.songsList.Name = "songsList";
            this.songsList.Size = new System.Drawing.Size(446, 251);
            this.songsList.TabIndex = 0;
            // 
            // addSongsButton
            // 
            this.addSongsButton.Location = new System.Drawing.Point(12, 269);
            this.addSongsButton.Name = "addSongsButton";
            this.addSongsButton.Size = new System.Drawing.Size(75, 23);
            this.addSongsButton.TabIndex = 1;
            this.addSongsButton.Text = "Add Songs";
            this.addSongsButton.UseVisualStyleBackColor = true;
            this.addSongsButton.Click += new System.EventHandler(this.addSongsButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(114, 269);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(75, 23);
            this.clearListButton.TabIndex = 2;
            this.clearListButton.Text = "Clear All";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // checkFlderInside
            // 
            this.checkFlderInside.AutoSize = true;
            this.checkFlderInside.Location = new System.Drawing.Point(362, 273);
            this.checkFlderInside.Name = "checkFlderInside";
            this.checkFlderInside.Size = new System.Drawing.Size(96, 17);
            this.checkFlderInside.TabIndex = 3;
            this.checkFlderInside.Text = "Folders inside?";
            this.checkFlderInside.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(559, 358);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(445, 358);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 393);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkFlderInside);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.addSongsButton);
            this.Controls.Add(this.songsList);
            this.Name = "optionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.optionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox songsList;
        private System.Windows.Forms.Button addSongsButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.CheckBox checkFlderInside;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}