namespace AdapterPattern
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
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.outputTb = new System.Windows.Forms.TextBox();
            this.enemyTroopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enemyHealthLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerHealthLbl = new System.Windows.Forms.Label();
            this.shootBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.Location = new System.Drawing.Point(310, 44);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(129, 23);
            this.vehicleBtn.TabIndex = 0;
            this.vehicleBtn.Text = "Fight Enemy Vehicle";
            this.vehicleBtn.UseVisualStyleBackColor = true;
            this.vehicleBtn.Click += new System.EventHandler(this.vehicleBtn_Click);
            // 
            // outputTb
            // 
            this.outputTb.Enabled = false;
            this.outputTb.Location = new System.Drawing.Point(60, 139);
            this.outputTb.Multiline = true;
            this.outputTb.Name = "outputTb";
            this.outputTb.Size = new System.Drawing.Size(281, 111);
            this.outputTb.TabIndex = 1;
            this.outputTb.TextChanged += new System.EventHandler(this.outputTb_TextChanged);
            // 
            // enemyTroopBtn
            // 
            this.enemyTroopBtn.Location = new System.Drawing.Point(310, 92);
            this.enemyTroopBtn.Name = "enemyTroopBtn";
            this.enemyTroopBtn.Size = new System.Drawing.Size(129, 23);
            this.enemyTroopBtn.TabIndex = 2;
            this.enemyTroopBtn.Text = "Fight Enemy Trooper";
            this.enemyTroopBtn.UseVisualStyleBackColor = true;
            this.enemyTroopBtn.Click += new System.EventHandler(this.enemyTroopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enemy Health:";
            // 
            // enemyHealthLbl
            // 
            this.enemyHealthLbl.AutoSize = true;
            this.enemyHealthLbl.Location = new System.Drawing.Point(316, 18);
            this.enemyHealthLbl.Name = "enemyHealthLbl";
            this.enemyHealthLbl.Size = new System.Drawing.Size(25, 13);
            this.enemyHealthLbl.TabIndex = 4;
            this.enemyHealthLbl.Text = "Null";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Health: ";
            // 
            // playerHealthLbl
            // 
            this.playerHealthLbl.AutoSize = true;
            this.playerHealthLbl.Location = new System.Drawing.Point(87, 18);
            this.playerHealthLbl.Name = "playerHealthLbl";
            this.playerHealthLbl.Size = new System.Drawing.Size(25, 13);
            this.playerHealthLbl.TabIndex = 6;
            this.playerHealthLbl.Text = "Null";
            // 
            // shootBtn
            // 
            this.shootBtn.Location = new System.Drawing.Point(15, 65);
            this.shootBtn.Name = "shootBtn";
            this.shootBtn.Size = new System.Drawing.Size(97, 23);
            this.shootBtn.TabIndex = 7;
            this.shootBtn.Text = "Shoot Enemy";
            this.shootBtn.UseVisualStyleBackColor = true;
            this.shootBtn.Click += new System.EventHandler(this.shootBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(347, 184);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 56);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 262);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.shootBtn);
            this.Controls.Add(this.playerHealthLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemyHealthLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyTroopBtn);
            this.Controls.Add(this.outputTb);
            this.Controls.Add(this.vehicleBtn);
            this.Name = "Form1";
            this.Text = "Halo Fight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vehicleBtn;
        private System.Windows.Forms.TextBox outputTb;
        private System.Windows.Forms.Button enemyTroopBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyHealthLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerHealthLbl;
        private System.Windows.Forms.Button shootBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

