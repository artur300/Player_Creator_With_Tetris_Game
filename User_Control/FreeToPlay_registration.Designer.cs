
namespace Tetris_Game.User_Control
{
    partial class FreeToPlay_registration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.textage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textfamilyname = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Age";
            // 
            // textage
            // 
            this.textage.Location = new System.Drawing.Point(206, 211);
            this.textage.Name = "textage";
            this.textage.Size = new System.Drawing.Size(100, 26);
            this.textage.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.label7.Location = new System.Drawing.Point(58, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 34);
            this.label7.TabIndex = 37;
            this.label7.Text = "Free Payment_Player Register";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Tomato;
            this.Confirm.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirm.Location = new System.Drawing.Point(50, 491);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(256, 45);
            this.Confirm.TabIndex = 36;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Family Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name";
            // 
            // textfamilyname
            // 
            this.textfamilyname.Location = new System.Drawing.Point(206, 153);
            this.textfamilyname.Name = "textfamilyname";
            this.textfamilyname.Size = new System.Drawing.Size(100, 26);
            this.textfamilyname.TabIndex = 33;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(206, 94);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 26);
            this.textname.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.textBox1.Location = new System.Drawing.Point(50, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 108);
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = "As free to play player you get 3 points to game for more please buy coins";
            // 
            // FreeToPlay_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textfamilyname);
            this.Controls.Add(this.textname);
            this.Name = "FreeToPlay_registration";
            this.Size = new System.Drawing.Size(352, 565);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textfamilyname;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textBox1;
    }
}
