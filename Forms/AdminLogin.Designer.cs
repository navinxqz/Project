﻿namespace GameServer_Management.Forms
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.btnLogin = new CuoreUI.Controls.cuiButton();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumPurple;
            this.label4.Location = new System.Drawing.Point(1046, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(1039, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(812, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Please enter your username and password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(865, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Welcome Admin!";
            // 
            // txtUsername
            // 
            this.txtUsername.CornerRoundingRadius = 30F;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsername.Location = new System.Drawing.Point(816, 239);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(333, 51);
            this.txtUsername.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtUsername.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUsername.StateCommon.Border.Rounding = 30F;
            this.txtUsername.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.TabIndex = 17;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.CornerRoundingRadius = 30F;
            this.kryptonTextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonTextBox1.Location = new System.Drawing.Point(816, 344);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(333, 51);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 30F;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 18;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.CheckButton = false;
            this.btnLogin.Checked = false;
            this.btnLogin.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(163)))));
            this.btnLogin.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogin.CheckedOutline = System.Drawing.Color.White;
            this.btnLogin.Content = "Login";
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnLogin.HoveredImageTint = System.Drawing.Color.White;
            this.btnLogin.HoverOutline = System.Drawing.Color.Transparent;
            this.btnLogin.Image = null;
            this.btnLogin.ImageAutoCenter = true;
            this.btnLogin.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogin.ImageTint = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(816, 429);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.btnLogin.NormalOutline = System.Drawing.Color.Transparent;
            this.btnLogin.OutlineThickness = 1.6F;
            this.btnLogin.PressedBackground = System.Drawing.Color.Coral;
            this.btnLogin.PressedImageTint = System.Drawing.Color.White;
            this.btnLogin.PressedOutline = System.Drawing.Color.Empty;
            this.btnLogin.Rounding = new System.Windows.Forms.Padding(20);
            this.btnLogin.Size = new System.Drawing.Size(333, 50);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.MediumPurple;
            this.Logoutbtn.Image = ((System.Drawing.Image)(resources.GetObject("Logoutbtn.Image")));
            this.Logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.Location = new System.Drawing.Point(872, 496);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Logoutbtn.Size = new System.Drawing.Size(228, 76);
            this.Logoutbtn.TabIndex = 20;
            this.Logoutbtn.Text = "        Back to previous";
            this.Logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // cuiButton1
            // 
            this.cuiButton1.AutoSize = true;
            this.cuiButton1.BackColor = System.Drawing.Color.Transparent;
            this.cuiButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.Transparent;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Brown;
            this.cuiButton1.Content = "";
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Red;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.White;
            this.cuiButton1.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton1.Image")));
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(5, 5);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageTint = System.Drawing.Color.White;
            this.cuiButton1.Location = new System.Drawing.Point(1142, -1);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton1.OutlineThickness = 0F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.Cornsilk;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Coral;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(20);
            this.cuiButton1.Size = new System.Drawing.Size(40, 36);
            this.cuiButton1.TabIndex = 21;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1181, 665);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private CuoreUI.Controls.cuiButton btnLogin;
        private System.Windows.Forms.Button Logoutbtn;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}