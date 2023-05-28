namespace CodeThermo
{
    partial class CodeThermo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeThermo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MinutesLeftLabel = new System.Windows.Forms.Label();
            this.SecondsLeftLabel = new System.Windows.Forms.Label();
            this.AlertPic01 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.AlertPic02 = new System.Windows.Forms.PictureBox();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.MinuteSetter = new System.Windows.Forms.NumericUpDown();
            this.SecondsSetter = new System.Windows.Forms.NumericUpDown();
            this.MainMenuMinuteAmmount = new System.Windows.Forms.Label();
            this.MainMenuSecondsAmmount = new System.Windows.Forms.Label();
            this.MainMenuSetTimeAmmountLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TimeAdder = new System.Windows.Forms.NumericUpDown();
            this.AddLabel01 = new System.Windows.Forms.Label();
            this.AddLabel02 = new System.Windows.Forms.Label();
            this.AddTimeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPic02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeAdder)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MinutesLeftLabel
            // 
            this.MinutesLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MinutesLeftLabel.AutoSize = true;
            this.MinutesLeftLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.MinutesLeftLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinutesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinutesLeftLabel.Location = new System.Drawing.Point(341, 150);
            this.MinutesLeftLabel.Name = "MinutesLeftLabel";
            this.MinutesLeftLabel.Size = new System.Drawing.Size(47, 20);
            this.MinutesLeftLabel.TabIndex = 0;
            this.MinutesLeftLabel.Text = "0 min";
            this.MinutesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondsLeftLabel
            // 
            this.SecondsLeftLabel.AutoSize = true;
            this.SecondsLeftLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.SecondsLeftLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondsLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SecondsLeftLabel.Location = new System.Drawing.Point(402, 150);
            this.SecondsLeftLabel.Name = "SecondsLeftLabel";
            this.SecondsLeftLabel.Size = new System.Drawing.Size(47, 20);
            this.SecondsLeftLabel.TabIndex = 1;
            this.SecondsLeftLabel.Text = "0 sec";
            this.SecondsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertPic01
            // 
            this.AlertPic01.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlertPic01.BackgroundImage")));
            this.AlertPic01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlertPic01.Location = new System.Drawing.Point(345, 400);
            this.AlertPic01.Name = "AlertPic01";
            this.AlertPic01.Size = new System.Drawing.Size(49, 50);
            this.AlertPic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AlertPic01.TabIndex = 2;
            this.AlertPic01.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 380;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AlertPic02
            // 
            this.AlertPic02.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlertPic02.BackgroundImage")));
            this.AlertPic02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlertPic02.Location = new System.Drawing.Point(400, 400);
            this.AlertPic02.Name = "AlertPic02";
            this.AlertPic02.Size = new System.Drawing.Size(49, 50);
            this.AlertPic02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AlertPic02.TabIndex = 3;
            this.AlertPic02.TabStop = false;
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TimeLeftLabel.Location = new System.Drawing.Point(342, 92);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(107, 29);
            this.TimeLeftLabel.TabIndex = 4;
            this.TimeLeftLabel.Text = "Time left";
            // 
            // MinuteSetter
            // 
            this.MinuteSetter.BackColor = System.Drawing.Color.White;
            this.MinuteSetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MinuteSetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MinuteSetter.Location = new System.Drawing.Point(345, 197);
            this.MinuteSetter.Name = "MinuteSetter";
            this.MinuteSetter.Size = new System.Drawing.Size(45, 22);
            this.MinuteSetter.TabIndex = 5;
            this.MinuteSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SecondsSetter
            // 
            this.SecondsSetter.BackColor = System.Drawing.Color.White;
            this.SecondsSetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondsSetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SecondsSetter.Location = new System.Drawing.Point(404, 197);
            this.SecondsSetter.Name = "SecondsSetter";
            this.SecondsSetter.Size = new System.Drawing.Size(45, 22);
            this.SecondsSetter.TabIndex = 6;
            this.SecondsSetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainMenuMinuteAmmount
            // 
            this.MainMenuMinuteAmmount.AutoSize = true;
            this.MainMenuMinuteAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuMinuteAmmount.ForeColor = System.Drawing.Color.Gold;
            this.MainMenuMinuteAmmount.Location = new System.Drawing.Point(329, 170);
            this.MainMenuMinuteAmmount.Name = "MainMenuMinuteAmmount";
            this.MainMenuMinuteAmmount.Size = new System.Drawing.Size(65, 20);
            this.MainMenuMinuteAmmount.TabIndex = 7;
            this.MainMenuMinuteAmmount.Text = "Minutes";
            // 
            // MainMenuSecondsAmmount
            // 
            this.MainMenuSecondsAmmount.AutoSize = true;
            this.MainMenuSecondsAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuSecondsAmmount.ForeColor = System.Drawing.Color.Gold;
            this.MainMenuSecondsAmmount.Location = new System.Drawing.Point(396, 170);
            this.MainMenuSecondsAmmount.Name = "MainMenuSecondsAmmount";
            this.MainMenuSecondsAmmount.Size = new System.Drawing.Size(72, 20);
            this.MainMenuSecondsAmmount.TabIndex = 8;
            this.MainMenuSecondsAmmount.Text = "Seconds";
            // 
            // MainMenuSetTimeAmmountLabel
            // 
            this.MainMenuSetTimeAmmountLabel.AutoSize = true;
            this.MainMenuSetTimeAmmountLabel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MainMenuSetTimeAmmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuSetTimeAmmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.MainMenuSetTimeAmmountLabel.ForeColor = System.Drawing.Color.Crimson;
            this.MainMenuSetTimeAmmountLabel.Location = new System.Drawing.Point(315, 126);
            this.MainMenuSetTimeAmmountLabel.Name = "MainMenuSetTimeAmmountLabel";
            this.MainMenuSetTimeAmmountLabel.Size = new System.Drawing.Size(161, 24);
            this.MainMenuSetTimeAmmountLabel.TabIndex = 9;
            this.MainMenuSetTimeAmmountLabel.Text = "Set time ammount";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.CadetBlue;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StartButton.Location = new System.Drawing.Point(362, 284);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 30);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.CadetBlue;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StopButton.Location = new System.Drawing.Point(362, 474);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 30);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Stop";
            this.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitButton.BackgroundImage")));
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Location = new System.Drawing.Point(738, 12);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(50, 50);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TimeAdder
            // 
            this.TimeAdder.BackColor = System.Drawing.Color.White;
            this.TimeAdder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TimeAdder.Location = new System.Drawing.Point(377, 312);
            this.TimeAdder.Name = "TimeAdder";
            this.TimeAdder.Size = new System.Drawing.Size(45, 22);
            this.TimeAdder.TabIndex = 14;
            this.TimeAdder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeAdder.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AddLabel01
            // 
            this.AddLabel01.AutoSize = true;
            this.AddLabel01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLabel01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddLabel01.ForeColor = System.Drawing.Color.Crimson;
            this.AddLabel01.Location = new System.Drawing.Point(329, 314);
            this.AddLabel01.Name = "AddLabel01";
            this.AddLabel01.Size = new System.Drawing.Size(38, 20);
            this.AddLabel01.TabIndex = 15;
            this.AddLabel01.Text = "Add";
            // 
            // AddLabel02
            // 
            this.AddLabel02.AutoSize = true;
            this.AddLabel02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLabel02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddLabel02.ForeColor = System.Drawing.Color.Crimson;
            this.AddLabel02.Location = new System.Drawing.Point(434, 314);
            this.AddLabel02.Name = "AddLabel02";
            this.AddLabel02.Size = new System.Drawing.Size(34, 20);
            this.AddLabel02.TabIndex = 16;
            this.AddLabel02.Text = "min";
            // 
            // AddTimeButton
            // 
            this.AddTimeButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.AddTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddTimeButton.Location = new System.Drawing.Point(362, 353);
            this.AddTimeButton.Name = "AddTimeButton";
            this.AddTimeButton.Size = new System.Drawing.Size(75, 29);
            this.AddTimeButton.TabIndex = 17;
            this.AddTimeButton.Text = "Add";
            this.AddTimeButton.UseVisualStyleBackColor = false;
            this.AddTimeButton.Click += new System.EventHandler(this.AddTimeButton_Click);
            // 
            // CodeThermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.AddTimeButton);
            this.Controls.Add(this.AddLabel02);
            this.Controls.Add(this.AddLabel01);
            this.Controls.Add(this.TimeAdder);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MainMenuSetTimeAmmountLabel);
            this.Controls.Add(this.MainMenuSecondsAmmount);
            this.Controls.Add(this.MainMenuMinuteAmmount);
            this.Controls.Add(this.SecondsSetter);
            this.Controls.Add(this.MinuteSetter);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.AlertPic02);
            this.Controls.Add(this.AlertPic01);
            this.Controls.Add(this.SecondsLeftLabel);
            this.Controls.Add(this.MinutesLeftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeThermo";
            this.Text = "CodeThermo";
            ((System.ComponentModel.ISupportInitialize)(this.AlertPic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertPic02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeAdder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label MinutesLeftLabel;
        private System.Windows.Forms.Label SecondsLeftLabel;
        private System.Windows.Forms.PictureBox AlertPic01;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox AlertPic02;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.NumericUpDown MinuteSetter;
        private System.Windows.Forms.NumericUpDown SecondsSetter;
        private System.Windows.Forms.Label MainMenuMinuteAmmount;
        private System.Windows.Forms.Label MainMenuSecondsAmmount;
        private System.Windows.Forms.Label MainMenuSetTimeAmmountLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.NumericUpDown TimeAdder;
        private System.Windows.Forms.Label AddLabel01;
        private System.Windows.Forms.Label AddLabel02;
        private System.Windows.Forms.Button AddTimeButton;
    }
}

