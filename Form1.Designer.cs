namespace PoolClubProject
{
    partial class Form1
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
            this.poolTable1 = new PoolClubProject.PoolTable();
            this.poolTable2 = new PoolClubProject.PoolTable();
            this.poolTable3 = new PoolClubProject.PoolTable();
            this.poolTable4 = new PoolClubProject.PoolTable();
            this.SuspendLayout();
            // 
            // poolTable1
            // 
            this.poolTable1.BackColor = System.Drawing.Color.Gold;
            this.poolTable1.HourlyRate = 10F;
            this.poolTable1.Location = new System.Drawing.Point(12, 12);
            this.poolTable1.Name = "poolTable1";
            this.poolTable1.PlayerName = "Wael";
            this.poolTable1.Size = new System.Drawing.Size(483, 330);
            this.poolTable1.TabIndex = 0;
            this.poolTable1.TableName = "Table 1";
            // 
            // poolTable2
            // 
            this.poolTable2.BackColor = System.Drawing.Color.Gold;
            this.poolTable2.HourlyRate = 10F;
            this.poolTable2.Location = new System.Drawing.Point(514, 12);
            this.poolTable2.Name = "poolTable2";
            this.poolTable2.PlayerName = "Osama";
            this.poolTable2.Size = new System.Drawing.Size(483, 330);
            this.poolTable2.TabIndex = 1;
            this.poolTable2.TableName = "Table 2";
            this.poolTable2.Load += new System.EventHandler(this.poolTable2_Load);
            // 
            // poolTable3
            // 
            this.poolTable3.BackColor = System.Drawing.Color.Gold;
            this.poolTable3.HourlyRate = 10F;
            this.poolTable3.Location = new System.Drawing.Point(12, 348);
            this.poolTable3.Name = "poolTable3";
            this.poolTable3.PlayerName = "Haitham";
            this.poolTable3.Size = new System.Drawing.Size(483, 330);
            this.poolTable3.TabIndex = 2;
            this.poolTable3.TableName = "Table 3";
            // 
            // poolTable4
            // 
            this.poolTable4.BackColor = System.Drawing.Color.Gold;
            this.poolTable4.HourlyRate = 50F;
            this.poolTable4.Location = new System.Drawing.Point(514, 348);
            this.poolTable4.Name = "poolTable4";
            this.poolTable4.PlayerName = "Chouaib";
            this.poolTable4.Size = new System.Drawing.Size(483, 330);
            this.poolTable4.TabIndex = 3;
            this.poolTable4.TableName = "Table 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 697);
            this.Controls.Add(this.poolTable4);
            this.Controls.Add(this.poolTable3);
            this.Controls.Add(this.poolTable2);
            this.Controls.Add(this.poolTable1);
            this.Name = "Form1";
            this.Text = "Pool club";
            this.ResumeLayout(false);

        }

        #endregion

        private PoolTable poolTable1;
        private PoolTable poolTable2;
        private PoolTable poolTable3;
        private PoolTable poolTable4;
    }
}

