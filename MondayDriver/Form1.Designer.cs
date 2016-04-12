namespace MondayDriver
{
    partial class MondayDrivesForm
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
            this.driveLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.driveComboBox = new System.Windows.Forms.ComboBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // driveLabel
            // 
            this.driveLabel.AutoSize = true;
            this.driveLabel.Location = new System.Drawing.Point(9, 15);
            this.driveLabel.Name = "driveLabel";
            this.driveLabel.Size = new System.Drawing.Size(32, 13);
            this.driveLabel.TabIndex = 0;
            this.driveLabel.Text = "Drive";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 46);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path";
            // 
            // driveComboBox
            // 
            this.driveComboBox.FormattingEnabled = true;
            this.driveComboBox.Location = new System.Drawing.Point(47, 12);
            this.driveComboBox.Name = "driveComboBox";
            this.driveComboBox.Size = new System.Drawing.Size(439, 21);
            this.driveComboBox.TabIndex = 2;
            this.driveComboBox.SelectedIndexChanged += new System.EventHandler(this.driveComboBox_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(47, 43);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(439, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(46, 346);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 27);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(127, 346);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 27);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 264);
            this.listBox1.TabIndex = 6;
            // 
            // MondayDrivesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 385);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.driveComboBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.driveLabel);
            this.Name = "MondayDrivesForm";
            this.Text = "Monday Drives";
            this.Load += new System.EventHandler(this.MondayDrivesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label driveLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ComboBox driveComboBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

