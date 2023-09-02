namespace Billiards_Club
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.ctrlBilliardTable3 = new Billiards_Club.ctrlBilliardTable();
            this.ctrlBilliardTable2 = new Billiards_Club.ctrlBilliardTable();
            this.ctrlBilliardTable1 = new Billiards_Club.ctrlBilliardTable();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "New Player:";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoEllipsis = true;
            this.btnAdd.Location = new System.Drawing.Point(368, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(482, 15);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 32);
            this.btnDetails.TabIndex = 10;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // ctrlBilliardTable3
            // 
            this.ctrlBilliardTable3.Location = new System.Drawing.Point(880, 96);
            this.ctrlBilliardTable3.Name = "ctrlBilliardTable3";
            this.ctrlBilliardTable3.Size = new System.Drawing.Size(400, 373);
            this.ctrlBilliardTable3.TabIndex = 13;
            this.ctrlBilliardTable3.Tag = "0";
            // 
            // ctrlBilliardTable2
            // 
            this.ctrlBilliardTable2.Location = new System.Drawing.Point(459, 96);
            this.ctrlBilliardTable2.Name = "ctrlBilliardTable2";
            this.ctrlBilliardTable2.Size = new System.Drawing.Size(400, 373);
            this.ctrlBilliardTable2.TabIndex = 12;
            this.ctrlBilliardTable2.Tag = "0";
            // 
            // ctrlBilliardTable1
            // 
            this.ctrlBilliardTable1.Location = new System.Drawing.Point(23, 96);
            this.ctrlBilliardTable1.Name = "ctrlBilliardTable1";
            this.ctrlBilliardTable1.Size = new System.Drawing.Size(400, 373);
            this.ctrlBilliardTable1.TabIndex = 11;
            this.ctrlBilliardTable1.Tag = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 751);
            this.Controls.Add(this.ctrlBilliardTable3);
            this.Controls.Add(this.ctrlBilliardTable2);
            this.Controls.Add(this.ctrlBilliardTable1);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDetails;
        private ctrlBilliardTable ctrlBilliardTable2;
        private ctrlBilliardTable ctrlBilliardTable3;
        private ctrlBilliardTable ctrlBilliardTable1;
    }
}