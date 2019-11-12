﻿namespace GoodVision
{
    partial class SivtsevCheckingPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SivtsevCheckingPro));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LetterPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AnswerSivtsevButton = new ButtonRoundedCorners.RoundedCorners();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.SivtsevTimer = new CircularProgressBar.CircularProgressBar();
            this.EyeTestPanel = new System.Windows.Forms.Panel();
            this.EyeTextLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SivtsevInstrTextBox = new System.Windows.Forms.RichTextBox();
            this.BackToVisionCheckButton = new rbutton.CustRoundButton();
            this.StartButton = new ButtonRoundedCorners.RoundedCorners();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LetterPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerSivtsevButton)).BeginInit();
            this.EyeTestPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.panel2.Controls.Add(this.EyeTestPanel);
            this.panel2.Controls.Add(this.LetterPictureBox);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.SivtsevTimer);
            this.panel2.Location = new System.Drawing.Point(434, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 577);
            this.panel2.TabIndex = 0;
            // 
            // LetterPictureBox
            // 
            this.LetterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LetterPictureBox.Image")));
            this.LetterPictureBox.Location = new System.Drawing.Point(238, 133);
            this.LetterPictureBox.Name = "LetterPictureBox";
            this.LetterPictureBox.Size = new System.Drawing.Size(335, 266);
            this.LetterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LetterPictureBox.TabIndex = 0;
            this.LetterPictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AnswerSivtsevButton);
            this.panel3.Controls.Add(this.AnswerTextBox);
            this.panel3.Location = new System.Drawing.Point(100, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 116);
            this.panel3.TabIndex = 2;
            // 
            // AnswerSivtsevButton
            // 
            this.AnswerSivtsevButton.BackColor = System.Drawing.Color.Coral;
            this.AnswerSivtsevButton.ImageHover = null;
            this.AnswerSivtsevButton.ImageNormal = null;
            this.AnswerSivtsevButton.Location = new System.Drawing.Point(350, 29);
            this.AnswerSivtsevButton.Name = "AnswerSivtsevButton";
            this.AnswerSivtsevButton.Size = new System.Drawing.Size(149, 58);
            this.AnswerSivtsevButton.TabIndex = 1;
            this.AnswerSivtsevButton.TabStop = false;
            this.AnswerSivtsevButton.Click += new System.EventHandler(this.AnswerSivtsevButton_Click);
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AnswerTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.Location = new System.Drawing.Point(90, 33);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(158, 55);
            this.AnswerTextBox.TabIndex = 0;
            this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
            // 
            // SivtsevTimer
            // 
            this.SivtsevTimer.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("SivtsevTimer.AnimationFunction")));
            this.SivtsevTimer.AnimationSpeed = 500;
            this.SivtsevTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.SivtsevTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SivtsevTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SivtsevTimer.InnerColor = System.Drawing.Color.Transparent;
            this.SivtsevTimer.InnerMargin = 2;
            this.SivtsevTimer.InnerWidth = -1;
            this.SivtsevTimer.Location = new System.Drawing.Point(70, 28);
            this.SivtsevTimer.MarqueeAnimationSpeed = 2000;
            this.SivtsevTimer.Maximum = 50;
            this.SivtsevTimer.Name = "SivtsevTimer";
            this.SivtsevTimer.OuterColor = System.Drawing.Color.DimGray;
            this.SivtsevTimer.OuterMargin = -10;
            this.SivtsevTimer.OuterWidth = 10;
            this.SivtsevTimer.ProgressColor = System.Drawing.Color.Coral;
            this.SivtsevTimer.ProgressWidth = 20;
            this.SivtsevTimer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.SivtsevTimer.Size = new System.Drawing.Size(135, 128);
            this.SivtsevTimer.StartAngle = 270;
            this.SivtsevTimer.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SivtsevTimer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SivtsevTimer.SubscriptText = "";
            this.SivtsevTimer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SivtsevTimer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SivtsevTimer.SuperscriptText = "";
            this.SivtsevTimer.TabIndex = 1;
            this.SivtsevTimer.TextMargin = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.SivtsevTimer.Value = 50;
            // 
            // EyeTestPanel
            // 
            this.EyeTestPanel.BackColor = System.Drawing.Color.Transparent;
            this.EyeTestPanel.BackgroundImage = global::GoodVision.Properties.Resources.gjlkj_rf2;
            this.EyeTestPanel.Controls.Add(this.EyeTextLabel);
            this.EyeTestPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EyeTestPanel.Location = new System.Drawing.Point(0, 3);
            this.EyeTestPanel.Name = "EyeTestPanel";
            this.EyeTestPanel.Size = new System.Drawing.Size(694, 574);
            this.EyeTestPanel.TabIndex = 2;
            // 
            // EyeTextLabel
            // 
            this.EyeTextLabel.AutoSize = true;
            this.EyeTextLabel.Font = new System.Drawing.Font("18thCentury", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EyeTextLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EyeTextLabel.Location = new System.Drawing.Point(154, 159);
            this.EyeTextLabel.Name = "EyeTextLabel";
            this.EyeTextLabel.Size = new System.Drawing.Size(415, 40);
            this.EyeTextLabel.TabIndex = 0;
            this.EyeTextLabel.Text = "Тестируем правый глаз";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.SivtsevInstrTextBox);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 363);
            this.panel4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // SivtsevInstrTextBox
            // 
            this.SivtsevInstrTextBox.BackColor = System.Drawing.Color.Lavender;
            this.SivtsevInstrTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SivtsevInstrTextBox.Location = new System.Drawing.Point(17, 28);
            this.SivtsevInstrTextBox.Name = "SivtsevInstrTextBox";
            this.SivtsevInstrTextBox.ReadOnly = true;
            this.SivtsevInstrTextBox.Size = new System.Drawing.Size(378, 290);
            this.SivtsevInstrTextBox.TabIndex = 1;
            this.SivtsevInstrTextBox.Text = "Инструкция\nС другой стороны реализация намеченных плановых заданий представляет с" +
    "обой интересный эксперимент проверки соответствующий условий активизации. ";
            // 
            // BackToVisionCheckButton
            // 
            this.BackToVisionCheckButton.Image = ((System.Drawing.Image)(resources.GetObject("BackToVisionCheckButton.Image")));
            this.BackToVisionCheckButton.ImageHover = global::GoodVision.Properties.Resources._13Hover;
            this.BackToVisionCheckButton.ImageNormal = global::GoodVision.Properties.Resources._13;
            this.BackToVisionCheckButton.Location = new System.Drawing.Point(5, 408);
            this.BackToVisionCheckButton.Name = "BackToVisionCheckButton";
            this.BackToVisionCheckButton.Size = new System.Drawing.Size(218, 163);
            this.BackToVisionCheckButton.TabIndex = 6;
            this.BackToVisionCheckButton.UseVisualStyleBackColor = true;
            this.BackToVisionCheckButton.Click += new System.EventHandler(this.BackToVisionCheckButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageHover = null;
            this.StartButton.ImageNormal = null;
            this.StartButton.Location = new System.Drawing.Point(229, 381);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(199, 199);
            this.StartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartButton.TabIndex = 7;
            this.StartButton.TabStop = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SivtsevCheckingPro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::GoodVision.Properties.Resources.Регистр2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1140, 601);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.BackToVisionCheckButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Name = "SivtsevCheckingPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LetterPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerSivtsevButton)).EndInit();
            this.EyeTestPanel.ResumeLayout(false);
            this.EyeTestPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox LetterPictureBox;
        private CircularProgressBar.CircularProgressBar SivtsevTimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AnswerTextBox;
      //  private rbutton.CustRoundButton BackFromSivtsevButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox SivtsevInstrTextBox;
        private rbutton.CustRoundButton BackToVisionCheckButton;
        private ButtonRoundedCorners.RoundedCorners AnswerSivtsevButton;
        private ButtonRoundedCorners.RoundedCorners StartButton;
        private System.Windows.Forms.Panel EyeTestPanel;
        private System.Windows.Forms.Label EyeTextLabel;
        //   private RoundButtonTwo.MyRoundButton AnswerSivtsevButton;
        //private RoundButtonTwo.MyRoundButton StartButton;
    }
}