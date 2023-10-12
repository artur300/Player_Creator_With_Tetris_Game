
namespace Tetris_Game
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResigtrationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PickPlayertype = new System.Windows.Forms.ComboBox();
            this.Enter = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(60, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(725, 605);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // ResigtrationPanel
            // 
            this.ResigtrationPanel.BackColor = System.Drawing.Color.White;
            this.ResigtrationPanel.Location = new System.Drawing.Point(800, 86);
            this.ResigtrationPanel.Name = "ResigtrationPanel";
            this.ResigtrationPanel.Size = new System.Drawing.Size(352, 605);
            this.ResigtrationPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(644, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chose Registration";
            // 
            // PickPlayertype
            // 
            this.PickPlayertype.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PickPlayertype.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.PickPlayertype.FormattingEnabled = true;
            this.PickPlayertype.Location = new System.Drawing.Point(863, 20);
            this.PickPlayertype.Name = "PickPlayertype";
            this.PickPlayertype.Size = new System.Drawing.Size(289, 42);
            this.PickPlayertype.TabIndex = 5;
            this.PickPlayertype.SelectedIndexChanged += new System.EventHandler(this.PickPlayertype_SelectedIndexChanged);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Tomato;
            this.Enter.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter.Location = new System.Drawing.Point(60, 20);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(251, 44);
            this.Enter.TabIndex = 9;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.Tomato;
            this.View.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View.Location = new System.Drawing.Point(350, 20);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(251, 44);
            this.View.TabIndex = 10;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 711);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResigtrationPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PickPlayertype);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ResigtrationPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PickPlayertype;
        private new System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button View;
    }
}

