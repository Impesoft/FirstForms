
namespace _20210112Dag1AdvandedC
{
    partial class HowOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowOld));
            this.Name = new System.Windows.Forms.TextBox();
            this.geslacht = new System.Windows.Forms.ListBox();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.NaamLabel = new System.Windows.Forms.Label();
            this.GeslachtLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.PictureBox();
            this.Female = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserGender = new System.Windows.Forms.Label();
            this.UserBirthday = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Male)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Female)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(101, 13);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(200, 23);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // geslacht
            // 
            this.geslacht.FormattingEnabled = true;
            this.geslacht.ItemHeight = 15;
            this.geslacht.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.geslacht.Location = new System.Drawing.Point(101, 43);
            this.geslacht.Name = "geslacht";
            this.geslacht.Size = new System.Drawing.Size(200, 34);
            this.geslacht.TabIndex = 1;
            this.geslacht.SelectedIndexChanged += new System.EventHandler(this.geslacht_SelectedIndexChanged);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(101, 83);
            this.DateOfBirth.MaxDate = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.DateOfBirth.TabIndex = 2;
            this.DateOfBirth.Value = new System.DateTime(2021, 1, 12, 0, 0, 0, 0);
            this.DateOfBirth.CloseUp += new System.EventHandler(this.DateOfBirth_CloseUp);
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Location = new System.Drawing.Point(51, 16);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.Size = new System.Drawing.Size(39, 15);
            this.NaamLabel.TabIndex = 3;
            this.NaamLabel.Text = "Naam";
            // 
            // GeslachtLabel
            // 
            this.GeslachtLabel.AutoSize = true;
            this.GeslachtLabel.Location = new System.Drawing.Point(38, 43);
            this.GeslachtLabel.Name = "GeslachtLabel";
            this.GeslachtLabel.Size = new System.Drawing.Size(52, 15);
            this.GeslachtLabel.TabIndex = 4;
            this.GeslachtLabel.Text = "Geslacht";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(-1, 89);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(91, 15);
            this.DateOfBirthLabel.TabIndex = 5;
            this.DateOfBirthLabel.Text = "Geboortedatum";
            // 
            // Male
            // 
            this.Male.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Male.BackgroundImage")));
            this.Male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Male.Location = new System.Drawing.Point(319, 13);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(128, 257);
            this.Male.TabIndex = 6;
            this.Male.TabStop = false;
            this.Male.Visible = false;
            // 
            // Female
            // 
            this.Female.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Female.BackgroundImage")));
            this.Female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Female.Location = new System.Drawing.Point(319, 13);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(128, 257);
            this.Female.TabIndex = 7;
            this.Female.TabStop = false;
            this.Female.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Userinfo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Birth";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(101, 161);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 15);
            this.UserName.TabIndex = 12;
            // 
            // UserGender
            // 
            this.UserGender.AutoSize = true;
            this.UserGender.Location = new System.Drawing.Point(101, 186);
            this.UserGender.Name = "UserGender";
            this.UserGender.Size = new System.Drawing.Size(0, 15);
            this.UserGender.TabIndex = 13;
            // 
            // UserBirthday
            // 
            this.UserBirthday.AutoSize = true;
            this.UserBirthday.Location = new System.Drawing.Point(101, 213);
            this.UserBirthday.Name = "UserBirthday";
            this.UserBirthday.Size = new System.Drawing.Size(0, 15);
            this.UserBirthday.TabIndex = 14;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 247);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(286, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // HowOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.UserBirthday);
            this.Controls.Add(this.UserGender);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.GeslachtLabel);
            this.Controls.Add(this.NaamLabel);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.geslacht);
            this.Controls.Add(this.Name);
            this.Text = "HowOld";
            this.Load += new System.EventHandler(this.HowOld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Male)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Female)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.ListBox geslacht;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Label NaamLabel;
        private System.Windows.Forms.Label GeslachtLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.PictureBox Male;
        private System.Windows.Forms.PictureBox Female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label UserGender;
        private System.Windows.Forms.Label UserBirthday;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}