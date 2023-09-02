namespace Billiards_Club
{
    partial class ctrlBilliardTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBilliardTable));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnPause1 = new System.Windows.Forms.Button();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPlayer1);
            this.groupBox2.Controls.Add(this.btnStop1);
            this.groupBox2.Controls.Add(this.btnPause1);
            this.groupBox2.Controls.Add(this.btnStart1);
            this.groupBox2.Controls.Add(this.lblPrice1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTime1);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(6, 112);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(78, 25);
            this.lblPlayer1.TabIndex = 8;
            this.lblPlayer1.Text = "Player1";
            // 
            // btnStop1
            // 
            this.btnStop1.BackColor = System.Drawing.Color.Red;
            this.btnStop1.Location = new System.Drawing.Point(261, 162);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(90, 35);
            this.btnStop1.TabIndex = 7;
            this.btnStop1.Text = "Stop";
            this.btnStop1.UseVisualStyleBackColor = false;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnPause1
            // 
            this.btnPause1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPause1.Location = new System.Drawing.Point(144, 162);
            this.btnPause1.Name = "btnPause1";
            this.btnPause1.Size = new System.Drawing.Size(90, 35);
            this.btnPause1.TabIndex = 7;
            this.btnPause1.Text = "Pause";
            this.btnPause1.UseVisualStyleBackColor = false;
            this.btnPause1.Click += new System.EventHandler(this.btnPause1_Click);
            // 
            // btnStart1
            // 
            this.btnStart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart1.Location = new System.Drawing.Point(20, 162);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(90, 35);
            this.btnStart1.TabIndex = 7;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = false;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.Location = new System.Drawing.Point(62, 71);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(34, 25);
            this.lblPrice1.TabIndex = 7;
            this.lblPrice1.Text = "0$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Price:";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(6, 35);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(90, 25);
            this.lblTime1.TabIndex = 7;
            this.lblTime1.Text = "00:00:00";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(164, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlBilliardTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ctrlBilliardTable";
            this.Size = new System.Drawing.Size(610, 373);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnPause1;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}
