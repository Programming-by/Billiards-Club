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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ctrlBilliardTable3 = new Billiards_Club.ctrlBilliardTable();
            this.ctrlBilliardTable2 = new Billiards_Club.ctrlBilliardTable();
            this.ctrlBilliardTable1 = new Billiards_Club.ctrlBilliardTable();
            this.SuspendLayout();
            // 
            // ctrlBilliardTable3
            // 
            this.ctrlBilliardTable3.HourlyRate = 10F;
            this.ctrlBilliardTable3.Location = new System.Drawing.Point(949, 68);
            this.ctrlBilliardTable3.Name = "ctrlBilliardTable3";
            this.ctrlBilliardTable3.Size = new System.Drawing.Size(389, 313);
            this.ctrlBilliardTable3.TabIndex = 2;
            this.ctrlBilliardTable3.TablePlayer = "Player";
            this.ctrlBilliardTable3.TableTitle = "Table";
            this.ctrlBilliardTable3.OnTableComplete += new System.EventHandler<Billiards_Club.ctrlBilliardTable.TableCompletedEventArgs>(this.ctrlBilliardTable1_OnTableComplete);
            // 
            // ctrlBilliardTable2
            // 
            this.ctrlBilliardTable2.HourlyRate = 10F;
            this.ctrlBilliardTable2.Location = new System.Drawing.Point(500, 68);
            this.ctrlBilliardTable2.Name = "ctrlBilliardTable2";
            this.ctrlBilliardTable2.Size = new System.Drawing.Size(389, 313);
            this.ctrlBilliardTable2.TabIndex = 1;
            this.ctrlBilliardTable2.TablePlayer = "Player";
            this.ctrlBilliardTable2.TableTitle = "Table";
            this.ctrlBilliardTable2.OnTableComplete += new System.EventHandler<Billiards_Club.ctrlBilliardTable.TableCompletedEventArgs>(this.ctrlBilliardTable1_OnTableComplete);
            // 
            // ctrlBilliardTable1
            // 
            this.ctrlBilliardTable1.HourlyRate = 10F;
            this.ctrlBilliardTable1.Location = new System.Drawing.Point(48, 68);
            this.ctrlBilliardTable1.Name = "ctrlBilliardTable1";
            this.ctrlBilliardTable1.Size = new System.Drawing.Size(389, 313);
            this.ctrlBilliardTable1.TabIndex = 0;
            this.ctrlBilliardTable1.TablePlayer = "Player";
            this.ctrlBilliardTable1.TableTitle = "Table";
            this.ctrlBilliardTable1.OnTableComplete += new System.EventHandler<Billiards_Club.ctrlBilliardTable.TableCompletedEventArgs>(this.ctrlBilliardTable1_OnTableComplete);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 751);
            this.Controls.Add(this.ctrlBilliardTable3);
            this.Controls.Add(this.ctrlBilliardTable2);
            this.Controls.Add(this.ctrlBilliardTable1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ctrlBilliardTable ctrlBilliardTable1;
        private ctrlBilliardTable ctrlBilliardTable2;
        private ctrlBilliardTable ctrlBilliardTable3;
    }
}