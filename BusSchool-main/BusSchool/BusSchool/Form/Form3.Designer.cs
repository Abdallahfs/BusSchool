
namespace BusSchool
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Boy = new System.Windows.Forms.RadioButton();
            this.Girl = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(354, 147);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(72, 28);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "Name";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(346, 188);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(83, 24);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(465, 147);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(53, 28);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age";
            // 
            // UserPhoto
            // 
            this.UserPhoto.Location = new System.Drawing.Point(591, 147);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(99, 79);
            this.UserPhoto.TabIndex = 4;
            this.UserPhoto.TabStop = false;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.Control;
            this.Save.Location = new System.Drawing.Point(458, 333);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 33);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.Control;
            this.Back.Location = new System.Drawing.Point(338, 333);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 33);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(459, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // Boy
            // 
            this.Boy.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.Boy.AutoSize = true;
            this.Boy.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boy.Location = new System.Drawing.Point(56, 7);
            this.Boy.Name = "Boy";
            this.Boy.Size = new System.Drawing.Size(59, 21);
            this.Boy.TabIndex = 8;
            this.Boy.TabStop = true;
            this.Boy.Text = "Boy";
            this.Boy.UseVisualStyleBackColor = true;
            this.Boy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Girl
            // 
            this.Girl.AutoSize = true;
            this.Girl.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Girl.Location = new System.Drawing.Point(147, 4);
            this.Girl.Name = "Girl";
            this.Girl.Size = new System.Drawing.Size(55, 21);
            this.Girl.TabIndex = 9;
            this.Girl.TabStop = true;
            this.Girl.Text = "Girl";
            this.Girl.UseVisualStyleBackColor = true;
            this.Girl.CheckedChanged += new System.EventHandler(this.Girl_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(316, 261);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(62, 16);
            this.Gender.TabIndex = 10;
            this.Gender.Text = "Gender :";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // Image
            // 
            this.Image.AutoSize = true;
            this.Image.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image.Location = new System.Drawing.Point(628, 229);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(48, 16);
            this.Image.TabIndex = 11;
            this.Image.Text = "Image";
            this.Image.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton1.Location = new System.Drawing.Point(389, 289);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 38);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "          ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton2.BackgroundImage")));
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton2.Location = new System.Drawing.Point(480, 289);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 38);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "          ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton3.BackgroundImage")));
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton3.Location = new System.Drawing.Point(579, 289);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 38);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "          ";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Theme :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Girl);
            this.groupBox1.Controls.Add(this.Boy);
            this.groupBox1.Location = new System.Drawing.Point(383, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 27);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.UserPhoto);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.PictureBox UserPhoto;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton Boy;
        private System.Windows.Forms.RadioButton Girl;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Image;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}