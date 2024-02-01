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
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TableTimer = new System.Windows.Forms.Timer(this.components);
            this.grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTable
            // 
            this.grpTable.BackColor = System.Drawing.Color.White;
            this.grpTable.Controls.Add(this.btnEnd);
            this.grpTable.Controls.Add(this.lblPlayerName);
            this.grpTable.Controls.Add(this.btnStartStop);
            this.grpTable.Controls.Add(this.lblTime1);
            this.grpTable.Controls.Add(this.pictureBox3);
            this.grpTable.Location = new System.Drawing.Point(13, 20);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(357, 258);
            this.grpTable.TabIndex = 2;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Table1";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnd.Location = new System.Drawing.Point(237, 203);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(90, 35);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(24, 67);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(78, 25);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player1";
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.Silver;
            this.btnStartStop.Location = new System.Drawing.Point(237, 161);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(90, 35);
            this.btnStartStop.TabIndex = 7;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(88, 188);
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
            // TableTimer
            // 
            this.TableTimer.Interval = 1000;
            this.TableTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlBilliardTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTable);
            this.Name = "ctrlBilliardTable";
            this.Size = new System.Drawing.Size(389, 313);
            this.Load += new System.EventHandler(this.ctrlBilliardTable_Load);
            this.grpTable.ResumeLayout(false);
            this.grpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer TableTimer;
        private System.Windows.Forms.Button btnEnd;
    }
}
