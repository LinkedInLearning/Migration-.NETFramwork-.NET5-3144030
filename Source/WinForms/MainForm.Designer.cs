
namespace MastermindWinForms
{
    partial class MainForm
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCheat = new System.Windows.Forms.CheckBox();
            this.palette = new MastermindWinForms.BallContainer();
            this.Row0 = new MastermindWinForms.BallContainer();
            this.Row6 = new MastermindWinForms.BallContainer();
            this.Row5 = new MastermindWinForms.BallContainer();
            this.Row4 = new MastermindWinForms.BallContainer();
            this.Row3 = new MastermindWinForms.BallContainer();
            this.Row2 = new MastermindWinForms.BallContainer();
            this.Row1 = new MastermindWinForms.BallContainer();
            this.initialColors = new MastermindWinForms.BallContainer();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(294, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(118, 60);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Vérifier";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Faites glisser les couleurs et appuyez sur [Vérifier]";
            // 
            // chkCheat
            // 
            this.chkCheat.AutoSize = true;
            this.chkCheat.Location = new System.Drawing.Point(303, 634);
            this.chkCheat.Name = "chkCheat";
            this.chkCheat.Size = new System.Drawing.Size(75, 21);
            this.chkCheat.TabIndex = 11;
            this.chkCheat.Text = "Tricher";
            this.chkCheat.UseVisualStyleBackColor = true;
            this.chkCheat.CheckedChanged += new System.EventHandler(this.chkCheat_CheckedChanged);
            // 
            // palette
            // 
            this.palette.BackColor = System.Drawing.Color.Transparent;
            this.palette.Bad = null;
            this.palette.Good = null;
            this.palette.Location = new System.Drawing.Point(12, 12);
            this.palette.MaximumSize = new System.Drawing.Size(260, 60);
            this.palette.MinimumSize = new System.Drawing.Size(260, 60);
            this.palette.Mode = MastermindWinForms.BallContainerMode.InitialColor;
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(260, 60);
            this.palette.TabIndex = 9;
            // 
            // Row0
            // 
            this.Row0.BackColor = System.Drawing.Color.Transparent;
            this.Row0.Bad = null;
            this.Row0.Good = null;
            this.Row0.Location = new System.Drawing.Point(12, 117);
            this.Row0.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row0.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row0.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row0.Name = "Row0";
            this.Row0.Size = new System.Drawing.Size(400, 60);
            this.Row0.TabIndex = 2;
            // 
            // Row6
            // 
            this.Row6.BackColor = System.Drawing.Color.Transparent;
            this.Row6.Bad = null;
            this.Row6.Good = null;
            this.Row6.Location = new System.Drawing.Point(12, 513);
            this.Row6.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row6.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row6.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row6.Name = "Row6";
            this.Row6.Size = new System.Drawing.Size(400, 60);
            this.Row6.TabIndex = 8;
            // 
            // Row5
            // 
            this.Row5.BackColor = System.Drawing.Color.Transparent;
            this.Row5.Bad = null;
            this.Row5.Good = null;
            this.Row5.Location = new System.Drawing.Point(12, 447);
            this.Row5.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row5.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row5.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row5.Name = "Row5";
            this.Row5.Size = new System.Drawing.Size(400, 60);
            this.Row5.TabIndex = 7;
            // 
            // Row4
            // 
            this.Row4.BackColor = System.Drawing.Color.Transparent;
            this.Row4.Bad = null;
            this.Row4.Good = null;
            this.Row4.Location = new System.Drawing.Point(12, 381);
            this.Row4.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row4.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row4.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row4.Name = "Row4";
            this.Row4.Size = new System.Drawing.Size(400, 60);
            this.Row4.TabIndex = 6;
            // 
            // Row3
            // 
            this.Row3.BackColor = System.Drawing.Color.Transparent;
            this.Row3.Bad = null;
            this.Row3.Good = null;
            this.Row3.Location = new System.Drawing.Point(12, 315);
            this.Row3.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row3.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row3.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row3.Name = "Row3";
            this.Row3.Size = new System.Drawing.Size(400, 60);
            this.Row3.TabIndex = 5;
            // 
            // Row2
            // 
            this.Row2.BackColor = System.Drawing.Color.Transparent;
            this.Row2.Bad = null;
            this.Row2.Good = null;
            this.Row2.Location = new System.Drawing.Point(12, 249);
            this.Row2.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row2.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row2.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row2.Name = "Row2";
            this.Row2.Size = new System.Drawing.Size(400, 60);
            this.Row2.TabIndex = 4;
            // 
            // Row1
            // 
            this.Row1.BackColor = System.Drawing.Color.Transparent;
            this.Row1.Bad = null;
            this.Row1.Good = null;
            this.Row1.Location = new System.Drawing.Point(12, 183);
            this.Row1.MaximumSize = new System.Drawing.Size(400, 60);
            this.Row1.MinimumSize = new System.Drawing.Size(260, 60);
            this.Row1.Mode = MastermindWinForms.BallContainerMode.Disabled;
            this.Row1.Name = "Row1";
            this.Row1.Size = new System.Drawing.Size(400, 60);
            this.Row1.TabIndex = 3;
            // 
            // initialColors
            // 
            this.initialColors.BackColor = System.Drawing.Color.Transparent;
            this.initialColors.Bad = null;
            this.initialColors.Good = null;
            this.initialColors.Location = new System.Drawing.Point(12, 612);
            this.initialColors.MaximumSize = new System.Drawing.Size(260, 60);
            this.initialColors.MinimumSize = new System.Drawing.Size(260, 60);
            this.initialColors.Mode = MastermindWinForms.BallContainerMode.InitialColor;
            this.initialColors.Name = "initialColors";
            this.initialColors.Size = new System.Drawing.Size(260, 60);
            this.initialColors.TabIndex = 0;
            this.initialColors.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 684);
            this.Controls.Add(this.chkCheat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.palette);
            this.Controls.Add(this.Row0);
            this.Controls.Add(this.Row6);
            this.Controls.Add(this.Row5);
            this.Controls.Add(this.Row4);
            this.Controls.Add(this.Row3);
            this.Controls.Add(this.Row2);
            this.Controls.Add(this.Row1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.initialColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mastermind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BallContainer initialColors;
        private System.Windows.Forms.Button btnPlay;
        private BallContainer Row1;
        private BallContainer Row2;
        private BallContainer Row3;
        private BallContainer Row4;
        private BallContainer Row5;
        private BallContainer Row6;
        private BallContainer Row0;
        private BallContainer palette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCheat;
    }
}

