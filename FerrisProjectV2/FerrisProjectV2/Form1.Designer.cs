namespace FerrisProjectV2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ORA = new System.Windows.Forms.Label();
            this.MIN = new System.Windows.Forms.Label();
            this.SEC = new System.Windows.Forms.Label();
            this.DOT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setSvegliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ORA
            // 
            this.ORA.AutoSize = true;
            this.ORA.BackColor = System.Drawing.Color.Transparent;
            this.ORA.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORA.Location = new System.Drawing.Point(16, 26);
            this.ORA.Name = "ORA";
            this.ORA.Size = new System.Drawing.Size(191, 135);
            this.ORA.TabIndex = 0;
            this.ORA.Text = "00";
            this.ORA.Click += new System.EventHandler(this.ORA_Click);
            // 
            // MIN
            // 
            this.MIN.AutoSize = true;
            this.MIN.BackColor = System.Drawing.Color.Transparent;
            this.MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MIN.Location = new System.Drawing.Point(192, 26);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(191, 135);
            this.MIN.TabIndex = 1;
            this.MIN.Text = "00";
            this.MIN.Click += new System.EventHandler(this.MIN_Click);
            // 
            // SEC
            // 
            this.SEC.AutoSize = true;
            this.SEC.BackColor = System.Drawing.Color.Transparent;
            this.SEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEC.Location = new System.Drawing.Point(370, 26);
            this.SEC.Name = "SEC";
            this.SEC.Size = new System.Drawing.Size(191, 135);
            this.SEC.TabIndex = 2;
            this.SEC.Text = "00";
            this.SEC.Click += new System.EventHandler(this.SEC_Click);
            // 
            // DOT
            // 
            this.DOT.AutoSize = true;
            this.DOT.BackColor = System.Drawing.Color.Transparent;
            this.DOT.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOT.Location = new System.Drawing.Point(172, 53);
            this.DOT.Name = "DOT";
            this.DOT.Size = new System.Drawing.Size(47, 75);
            this.DOT.TabIndex = 3;
            this.DOT.Text = ":";
            this.DOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DOT.Click += new System.EventHandler(this.DOT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSvegliaToolStripMenuItem,
            this.setTimerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setSvegliaToolStripMenuItem
            // 
            this.setSvegliaToolStripMenuItem.Name = "setSvegliaToolStripMenuItem";
            this.setSvegliaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.setSvegliaToolStripMenuItem.Text = "Set Sveglia";
            this.setSvegliaToolStripMenuItem.Click += new System.EventHandler(this.setSvegliaToolStripMenuItem_Click);
            // 
            // setTimerToolStripMenuItem
            // 
            this.setTimerToolStripMenuItem.Name = "setTimerToolStripMenuItem";
            this.setTimerToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.setTimerToolStripMenuItem.Text = "Set Timer";
            this.setTimerToolStripMenuItem.Click += new System.EventHandler(this.setTimerToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sveglia non settata.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOT);
            this.Controls.Add(this.SEC);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.ORA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orologio Digitale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ORA;
        private System.Windows.Forms.Label MIN;
        private System.Windows.Forms.Label SEC;
        private System.Windows.Forms.Label DOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setSvegliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTimerToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

