namespace MonsterRacing20203
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBets = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.UDB = new System.Windows.Forms.NumericUpDown();
            this.rbGeorge = new System.Windows.Forms.RadioButton();
            this.rbSophie = new System.Windows.Forms.RadioButton();
            this.rbPeter = new System.Windows.Forms.RadioButton();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblSam = new System.Windows.Forms.Label();
            this.lblJohn = new System.Windows.Forms.Label();
            this.lblSarah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDB)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Image = global::MonsterRacing20203.Properties.Resources.Charlotte1;
            this.pb1.Location = new System.Drawing.Point(12, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(148, 134);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::MonsterRacing20203.Properties.Resources.Sophie1;
            this.pb4.Location = new System.Drawing.Point(12, 410);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(133, 97);
            this.pb4.TabIndex = 1;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::MonsterRacing20203.Properties.Resources.Peter1;
            this.pb3.Location = new System.Drawing.Point(12, 295);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(133, 90);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::MonsterRacing20203.Properties.Resources.George1;
            this.pb2.Location = new System.Drawing.Point(12, 163);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(148, 110);
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(183, 576);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 44);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(370, 576);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(102, 44);
            this.btnBets.TabIndex = 6;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(85, 576);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 44);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // UDB
            // 
            this.UDB.Location = new System.Drawing.Point(743, 614);
            this.UDB.Name = "UDB";
            this.UDB.Size = new System.Drawing.Size(120, 22);
            this.UDB.TabIndex = 8;
            // 
            // rbGeorge
            // 
            this.rbGeorge.AutoSize = true;
            this.rbGeorge.Location = new System.Drawing.Point(594, 576);
            this.rbGeorge.Name = "rbGeorge";
            this.rbGeorge.Size = new System.Drawing.Size(96, 26);
            this.rbGeorge.TabIndex = 9;
            this.rbGeorge.TabStop = true;
            this.rbGeorge.Text = "George";
            this.rbGeorge.UseVisualStyleBackColor = true;
            this.rbGeorge.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbSophie
            // 
            this.rbSophie.AutoSize = true;
            this.rbSophie.Location = new System.Drawing.Point(594, 614);
            this.rbSophie.Name = "rbSophie";
            this.rbSophie.Size = new System.Drawing.Size(91, 26);
            this.rbSophie.TabIndex = 11;
            this.rbSophie.TabStop = true;
            this.rbSophie.Text = "Sophie";
            this.rbSophie.UseVisualStyleBackColor = true;
            this.rbSophie.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // rbPeter
            // 
            this.rbPeter.AutoSize = true;
            this.rbPeter.Location = new System.Drawing.Point(594, 652);
            this.rbPeter.Name = "rbPeter";
            this.rbPeter.Size = new System.Drawing.Size(79, 26);
            this.rbPeter.TabIndex = 12;
            this.rbPeter.TabStop = true;
            this.rbPeter.Text = "Peter";
            this.rbPeter.UseVisualStyleBackColor = true;
            this.rbPeter.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWinner.Location = new System.Drawing.Point(278, 664);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(135, 60);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "Winner";
            // 
            // lblSam
            // 
            this.lblSam.Location = new System.Drawing.Point(922, 616);
            this.lblSam.Name = "lblSam";
            this.lblSam.Size = new System.Drawing.Size(306, 29);
            this.lblSam.TabIndex = 14;
            this.lblSam.Text = "label1";
            // 
            // lblJohn
            // 
            this.lblJohn.Location = new System.Drawing.Point(922, 530);
            this.lblJohn.Name = "lblJohn";
            this.lblJohn.Size = new System.Drawing.Size(306, 29);
            this.lblJohn.TabIndex = 15;
            this.lblJohn.Text = "label2";
            // 
            // lblSarah
            // 
            this.lblSarah.Location = new System.Drawing.Point(922, 568);
            this.lblSarah.Name = "lblSarah";
            this.lblSarah.Size = new System.Drawing.Size(306, 29);
            this.lblSarah.TabIndex = 16;
            this.lblSarah.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonsterRacing20203.Properties.Resources.horse_track;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1615, 763);
            this.Controls.Add(this.lblSarah);
            this.Controls.Add(this.lblJohn);
            this.Controls.Add(this.lblSam);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.rbPeter);
            this.Controls.Add(this.rbSophie);
            this.Controls.Add(this.rbGeorge);
            this.Controls.Add(this.UDB);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBets);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown UDB;
        private System.Windows.Forms.RadioButton rbGeorge;
        private System.Windows.Forms.RadioButton rbSophie;
        private System.Windows.Forms.RadioButton rbPeter;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblSam;
        private System.Windows.Forms.Label lblJohn;
        private System.Windows.Forms.Label lblSarah;
    }
}

