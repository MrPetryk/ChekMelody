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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.musicTime = new System.Windows.Forms.ComboBox();
            this.answerTime = new System.Windows.Forms.ComboBox();
            this.chekPosition = new System.Windows.Forms.CheckBox();
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
            this.cancelButton.Location = new System.Drawing.Point(589, 425);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(486, 425);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 5;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Music Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tome for answer";
            // 
            // musicTime
            // 
            this.musicTime.FormattingEnabled = true;
            this.musicTime.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.musicTime.Location = new System.Drawing.Point(114, 317);
            this.musicTime.Name = "musicTime";
            this.musicTime.Size = new System.Drawing.Size(97, 21);
            this.musicTime.TabIndex = 8;
            this.musicTime.Text = "10";
            // 
            // answerTime
            // 
            this.answerTime.FormattingEnabled = true;
            this.answerTime.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.answerTime.Location = new System.Drawing.Point(114, 343);
            this.answerTime.Name = "answerTime";
            this.answerTime.Size = new System.Drawing.Size(97, 21);
            this.answerTime.TabIndex = 9;
            this.answerTime.Text = "10";
            // 
            // chekPosition
            // 
            this.chekPosition.AutoSize = true;
            this.chekPosition.Location = new System.Drawing.Point(12, 396);
            this.chekPosition.Name = "chekPosition";
            this.chekPosition.Size = new System.Drawing.Size(105, 17);
            this.chekPosition.TabIndex = 10;
            this.chekPosition.Text = "Random position";
            this.chekPosition.UseVisualStyleBackColor = true;
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 460);
            this.Controls.Add(this.chekPosition);
            this.Controls.Add(this.answerTime);
            this.Controls.Add(this.musicTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox musicTime;
        private System.Windows.Forms.ComboBox answerTime;
        private System.Windows.Forms.CheckBox chekPosition;
    }
}