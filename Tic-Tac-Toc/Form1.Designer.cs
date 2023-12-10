namespace Tic_Tac_Toc
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btmRestartGame = new System.Windows.Forms.Button();
            this.btm1 = new System.Windows.Forms.Button();
            this.btm4 = new System.Windows.Forms.Button();
            this.btm7 = new System.Windows.Forms.Button();
            this.btm2 = new System.Windows.Forms.Button();
            this.btm5 = new System.Windows.Forms.Button();
            this.btm8 = new System.Windows.Forms.Button();
            this.btm3 = new System.Windows.Forms.Button();
            this.btm6 = new System.Windows.Forms.Button();
            this.btm9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(373, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Turn";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPlayerTurn.Location = new System.Drawing.Point(72, 155);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(115, 34);
            this.lblPlayerTurn.TabIndex = 11;
            this.lblPlayerTurn.Text = "player x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(72, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(72, 245);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(155, 34);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "In Progress";
            // 
            // btmRestartGame
            // 
            this.btmRestartGame.BackColor = System.Drawing.Color.Black;
            this.btmRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRestartGame.ForeColor = System.Drawing.Color.White;
            this.btmRestartGame.Location = new System.Drawing.Point(77, 295);
            this.btmRestartGame.Name = "btmRestartGame";
            this.btmRestartGame.Size = new System.Drawing.Size(137, 38);
            this.btmRestartGame.TabIndex = 14;
            this.btmRestartGame.Text = "Restart Game";
            this.btmRestartGame.UseVisualStyleBackColor = false;
            this.btmRestartGame.Click += new System.EventHandler(this.btmRestartGame_Click);
            // 
            // btm1
            // 
            this.btm1.BackColor = System.Drawing.Color.Transparent;
            this.btm1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm1.Image = ((System.Drawing.Image)(resources.GetObject("btm1.Image")));
            this.btm1.Location = new System.Drawing.Point(310, 95);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(84, 88);
            this.btm1.TabIndex = 15;
            this.btm1.Tag = "?";
            this.btm1.UseVisualStyleBackColor = false;
            this.btm1.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm4
            // 
            this.btm4.BackColor = System.Drawing.Color.Transparent;
            this.btm4.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm4.Image = ((System.Drawing.Image)(resources.GetObject("btm4.Image")));
            this.btm4.Location = new System.Drawing.Point(310, 199);
            this.btm4.Name = "btm4";
            this.btm4.Size = new System.Drawing.Size(84, 88);
            this.btm4.TabIndex = 16;
            this.btm4.Tag = "?";
            this.btm4.UseVisualStyleBackColor = false;
            this.btm4.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm7
            // 
            this.btm7.BackColor = System.Drawing.Color.Transparent;
            this.btm7.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm7.Image = ((System.Drawing.Image)(resources.GetObject("btm7.Image")));
            this.btm7.Location = new System.Drawing.Point(310, 305);
            this.btm7.Name = "btm7";
            this.btm7.Size = new System.Drawing.Size(84, 88);
            this.btm7.TabIndex = 17;
            this.btm7.Tag = "?";
            this.btm7.UseVisualStyleBackColor = false;
            this.btm7.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm2
            // 
            this.btm2.BackColor = System.Drawing.Color.Transparent;
            this.btm2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm2.Image = ((System.Drawing.Image)(resources.GetObject("btm2.Image")));
            this.btm2.Location = new System.Drawing.Point(466, 95);
            this.btm2.Name = "btm2";
            this.btm2.Size = new System.Drawing.Size(84, 88);
            this.btm2.TabIndex = 18;
            this.btm2.Tag = "?";
            this.btm2.UseVisualStyleBackColor = false;
            this.btm2.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm5
            // 
            this.btm5.BackColor = System.Drawing.Color.Transparent;
            this.btm5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm5.Image = ((System.Drawing.Image)(resources.GetObject("btm5.Image")));
            this.btm5.Location = new System.Drawing.Point(466, 204);
            this.btm5.Name = "btm5";
            this.btm5.Size = new System.Drawing.Size(84, 88);
            this.btm5.TabIndex = 19;
            this.btm5.Tag = "?";
            this.btm5.UseVisualStyleBackColor = false;
            this.btm5.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm8
            // 
            this.btm8.BackColor = System.Drawing.Color.Transparent;
            this.btm8.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm8.Image = ((System.Drawing.Image)(resources.GetObject("btm8.Image")));
            this.btm8.Location = new System.Drawing.Point(466, 305);
            this.btm8.Name = "btm8";
            this.btm8.Size = new System.Drawing.Size(84, 88);
            this.btm8.TabIndex = 20;
            this.btm8.Tag = "?";
            this.btm8.UseVisualStyleBackColor = false;
            this.btm8.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm3
            // 
            this.btm3.BackColor = System.Drawing.Color.Transparent;
            this.btm3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm3.Image = ((System.Drawing.Image)(resources.GetObject("btm3.Image")));
            this.btm3.Location = new System.Drawing.Point(631, 95);
            this.btm3.Name = "btm3";
            this.btm3.Size = new System.Drawing.Size(84, 88);
            this.btm3.TabIndex = 21;
            this.btm3.Tag = "?";
            this.btm3.UseVisualStyleBackColor = false;
            this.btm3.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm6
            // 
            this.btm6.BackColor = System.Drawing.Color.Transparent;
            this.btm6.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm6.Image = ((System.Drawing.Image)(resources.GetObject("btm6.Image")));
            this.btm6.Location = new System.Drawing.Point(631, 204);
            this.btm6.Name = "btm6";
            this.btm6.Size = new System.Drawing.Size(84, 88);
            this.btm6.TabIndex = 22;
            this.btm6.Tag = "?";
            this.btm6.UseVisualStyleBackColor = false;
            this.btm6.Click += new System.EventHandler(this.buttom_Click);
            // 
            // btm9
            // 
            this.btm9.BackColor = System.Drawing.Color.Transparent;
            this.btm9.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btm9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm9.Image = ((System.Drawing.Image)(resources.GetObject("btm9.Image")));
            this.btm9.Location = new System.Drawing.Point(631, 305);
            this.btm9.Name = "btm9";
            this.btm9.Size = new System.Drawing.Size(84, 88);
            this.btm9.TabIndex = 23;
            this.btm9.Tag = "?";
            this.btm9.UseVisualStyleBackColor = false;
            this.btm9.Click += new System.EventHandler(this.buttom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btm9);
            this.Controls.Add(this.btm6);
            this.Controls.Add(this.btm3);
            this.Controls.Add(this.btm8);
            this.Controls.Add(this.btm5);
            this.Controls.Add(this.btm2);
            this.Controls.Add(this.btm7);
            this.Controls.Add(this.btm4);
            this.Controls.Add(this.btm1);
            this.Controls.Add(this.btmRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btmRestartGame;
        private System.Windows.Forms.Button btm1;
        private System.Windows.Forms.Button btm4;
        private System.Windows.Forms.Button btm7;
        private System.Windows.Forms.Button btm2;
        private System.Windows.Forms.Button btm5;
        private System.Windows.Forms.Button btm8;
        private System.Windows.Forms.Button btm3;
        private System.Windows.Forms.Button btm6;
        private System.Windows.Forms.Button btm9;
    }
}

