namespace Low_Latency_Image_Changes_Detection
{
    partial class MainForm
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
            this.firstSelectImageButton = new System.Windows.Forms.Button();
            this.secondSelectImageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstImageTextBox = new System.Windows.Forms.TextBox();
            this.secondImageTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LatencyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstSelectImageButton
            // 
            this.firstSelectImageButton.Location = new System.Drawing.Point(559, 22);
            this.firstSelectImageButton.Name = "firstSelectImageButton";
            this.firstSelectImageButton.Size = new System.Drawing.Size(33, 23);
            this.firstSelectImageButton.TabIndex = 0;
            this.firstSelectImageButton.Text = "...";
            this.firstSelectImageButton.UseVisualStyleBackColor = true;
            this.firstSelectImageButton.Click += new System.EventHandler(this.SelectImageButtons_Click);
            // 
            // secondSelectImageButton
            // 
            this.secondSelectImageButton.Location = new System.Drawing.Point(559, 64);
            this.secondSelectImageButton.Name = "secondSelectImageButton";
            this.secondSelectImageButton.Size = new System.Drawing.Size(33, 23);
            this.secondSelectImageButton.TabIndex = 1;
            this.secondSelectImageButton.Text = "...";
            this.secondSelectImageButton.UseVisualStyleBackColor = true;
            this.secondSelectImageButton.Click += new System.EventHandler(this.SelectImageButtons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1st Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2nd Image:";
            // 
            // firstImageTextBox
            // 
            this.firstImageTextBox.Location = new System.Drawing.Point(12, 24);
            this.firstImageTextBox.Name = "firstImageTextBox";
            this.firstImageTextBox.ReadOnly = true;
            this.firstImageTextBox.Size = new System.Drawing.Size(541, 20);
            this.firstImageTextBox.TabIndex = 4;
            // 
            // secondImageTextBox
            // 
            this.secondImageTextBox.Location = new System.Drawing.Point(12, 66);
            this.secondImageTextBox.Name = "secondImageTextBox";
            this.secondImageTextBox.ReadOnly = true;
            this.secondImageTextBox.Size = new System.Drawing.Size(541, 20);
            this.secondImageTextBox.TabIndex = 5;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(12, 92);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(577, 364);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 6;
            this.imagePictureBox.TabStop = false;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(12, 462);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(577, 32);
            this.compareButton.TabIndex = 8;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LatencyLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(598, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LatencyLabel
            // 
            this.LatencyLabel.Name = "LatencyLabel";
            this.LatencyLabel.Size = new System.Drawing.Size(79, 17);
            this.LatencyLabel.Text = "Latency: 0 ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 523);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.secondImageTextBox);
            this.Controls.Add(this.firstImageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondSelectImageButton);
            this.Controls.Add(this.firstSelectImageButton);
            this.Font = new System.Drawing.Font("Verdana", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstSelectImageButton;
        private System.Windows.Forms.Button secondSelectImageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstImageTextBox;
        private System.Windows.Forms.TextBox secondImageTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LatencyLabel;
    }
}