namespace AnghamiRPC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbRemember = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtError = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnSong = new Guna.UI2.WinForms.Guna2Panel();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.Label();
            this.pbSong = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CheckSong = new System.Windows.Forms.Timer(this.components);
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.pnSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationInterval = 2000;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(195)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AnghamiRPC.Properties.Resources.header_logo_colored;
            this.pictureBox1.Location = new System.Drawing.Point(495, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbClient
            // 
            this.tbClient.Animated = true;
            this.tbClient.BackColor = System.Drawing.Color.Transparent;
            this.tbClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbClient.BorderRadius = 23;
            this.tbClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClient.DefaultText = "";
            this.tbClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbClient.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.tbClient.ForeColor = System.Drawing.Color.Gray;
            this.tbClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tbClient.Location = new System.Drawing.Point(488, 212);
            this.tbClient.Name = "tbClient";
            this.tbClient.PasswordChar = '\0';
            this.tbClient.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbClient.PlaceholderText = "Enter your App/Client ID";
            this.tbClient.SelectedText = "";
            this.tbClient.Size = new System.Drawing.Size(262, 51);
            this.tbClient.TabIndex = 1;
            this.tbClient.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // cbRemember
            // 
            this.cbRemember.Animated = true;
            this.cbRemember.BackColor = System.Drawing.Color.Transparent;
            this.cbRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(195)))));
            this.cbRemember.CheckedState.BorderRadius = 5;
            this.cbRemember.CheckedState.BorderThickness = 0;
            this.cbRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(195)))));
            this.cbRemember.Location = new System.Drawing.Point(505, 272);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(20, 20);
            this.cbRemember.TabIndex = 4;
            this.cbRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbRemember.UncheckedState.BorderRadius = 5;
            this.cbRemember.UncheckedState.BorderThickness = 0;
            this.cbRemember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cbRemember.Click += new System.EventHandler(this.guna2CustomCheckBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(526, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remember Me";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 27;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(1)))), ((int)(((byte)(195)))));
            this.guna2Button1.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(538, 308);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 54);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Log in";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 7F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "AnghamiRPC is not affiliated with anghami. Secrets written on this form are only " +
    "optionally saved on your own device.";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Controls.Add(this.txtError);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.tbClient);
            this.guna2CustomGradientPanel1.Controls.Add(this.cbRemember);
            this.guna2CustomGradientPanel1.Controls.Add(this.pnSong);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-3, 1);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(803, 464);
            this.guna2CustomGradientPanel1.TabIndex = 8;
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.BackColor = System.Drawing.Color.Transparent;
            this.txtError.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.ForeColor = System.Drawing.Color.Red;
            this.txtError.Location = new System.Drawing.Point(38, 371);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(363, 32);
            this.txtError.TabIndex = 13;
            this.txtError.Text = "Seems like there\'s an issue displaying the song you\'re playing.\r\nNothing to worry" +
    " about, the next song should display!";
            this.txtError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtError.Visible = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(770, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.DarkGray;
            this.guna2ControlBox1.Size = new System.Drawing.Size(33, 27);
            this.guna2ControlBox1.TabIndex = 9;
            // 
            // pnSong
            // 
            this.pnSong.Controls.Add(this.lbArtist);
            this.pnSong.Controls.Add(this.lbSong);
            this.pnSong.Controls.Add(this.pbSong);
            this.pnSong.Location = new System.Drawing.Point(3, 96);
            this.pnSong.Name = "pnSong";
            this.pnSong.Size = new System.Drawing.Size(423, 272);
            this.pnSong.TabIndex = 12;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.BackColor = System.Drawing.Color.Transparent;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.ForeColor = System.Drawing.Color.Gray;
            this.lbArtist.Location = new System.Drawing.Point(181, 245);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(60, 17);
            this.lbArtist.TabIndex = 12;
            this.lbArtist.Text = "No Artist";
            // 
            // lbSong
            // 
            this.lbSong.AutoSize = true;
            this.lbSong.BackColor = System.Drawing.Color.Transparent;
            this.lbSong.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSong.ForeColor = System.Drawing.Color.Gray;
            this.lbSong.Location = new System.Drawing.Point(108, 212);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(206, 32);
            this.lbSong.TabIndex = 11;
            this.lbSong.Text = "No Current Song";
            // 
            // pbSong
            // 
            this.pbSong.BackColor = System.Drawing.Color.Transparent;
            this.pbSong.BorderRadius = 35;
            this.pbSong.ImageRotate = 0F;
            this.pbSong.Location = new System.Drawing.Point(116, 14);
            this.pbSong.Name = "pbSong";
            this.pbSong.ShadowDecoration.BorderRadius = 35;
            this.pbSong.ShadowDecoration.Depth = 40;
            this.pbSong.ShadowDecoration.Enabled = true;
            this.pbSong.Size = new System.Drawing.Size(191, 195);
            this.pbSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSong.TabIndex = 10;
            this.pbSong.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Oops";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog1.Text = "Looks like you haven\'t entered any App/Client ID.";
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.pnSong;
            this.guna2DragControl2.TransparentWhileDrag = false;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.pictureBox1;
            this.guna2DragControl3.TransparentWhileDrag = false;
            // 
            // CheckSong
            // 
            this.CheckSong.Enabled = true;
            this.CheckSong.Interval = 3000;
            this.CheckSong.Tick += new System.EventHandler(this.CheckSong_Tick);
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog2.Caption = "Oops";
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.guna2MessageDialog2.Parent = this;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog2.Text = "Looks like Anghami isn\'t open. Make sure Anghami is open and playing a song.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::AnghamiRPC.Properties.Resources.chase_atlantic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anghami RPC";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.pnSong.ResumeLayout(false);
            this.pnSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbClient;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbRemember;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Panel pnSong;
        private System.Windows.Forms.Label lbSong;
        private Guna.UI2.WinForms.Guna2PictureBox pbSong;
        private System.Windows.Forms.Label lbArtist;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.Timer CheckSong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label txtError;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
    }
}

