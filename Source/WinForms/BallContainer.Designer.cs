
namespace MastermindWinForms
{
    partial class BallContainer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ball1 = new MastermindWinForms.Ball();
            this.ball2 = new MastermindWinForms.Ball();
            this.ball3 = new MastermindWinForms.Ball();
            this.ball4 = new MastermindWinForms.Ball();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblBad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ball1
            // 
            this.ball1.Color = System.Drawing.Color.Red;
            this.ball1.Location = new System.Drawing.Point(0, 0);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(60, 60);
            this.ball1.TabIndex = 0;
            this.ball1.Text = "ball1";
            // 
            // ball2
            // 
            this.ball2.Color = System.Drawing.Color.Blue;
            this.ball2.Location = new System.Drawing.Point(66, 0);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(60, 60);
            this.ball2.TabIndex = 1;
            this.ball2.Text = "ball2";
            // 
            // ball3
            // 
            this.ball3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ball3.Location = new System.Drawing.Point(132, 0);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(60, 60);
            this.ball3.TabIndex = 2;
            this.ball3.Text = "ball3";
            // 
            // ball4
            // 
            this.ball4.Color = System.Drawing.Color.Yellow;
            this.ball4.Location = new System.Drawing.Point(198, 0);
            this.ball4.Name = "ball4";
            this.ball4.Size = new System.Drawing.Size(60, 60);
            this.ball4.TabIndex = 3;
            this.ball4.Text = "ball4";
            // 
            // lblGood
            // 
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGood.Location = new System.Drawing.Point(264, 0);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(60, 60);
            this.lblGood.TabIndex = 4;
            this.lblGood.Text = "0";
            this.lblGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBad
            // 
            this.lblBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBad.ForeColor = System.Drawing.Color.Red;
            this.lblBad.Location = new System.Drawing.Point(330, 0);
            this.lblBad.Name = "lblBad";
            this.lblBad.Size = new System.Drawing.Size(60, 60);
            this.lblBad.TabIndex = 5;
            this.lblBad.Text = "0";
            this.lblBad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BallContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBad);
            this.Controls.Add(this.lblGood);
            this.Controls.Add(this.ball4);
            this.Controls.Add(this.ball3);
            this.Controls.Add(this.ball2);
            this.Controls.Add(this.ball1);
            this.MaximumSize = new System.Drawing.Size(400, 60);
            this.MinimumSize = new System.Drawing.Size(260, 60);
            this.Name = "BallContainer";
            this.Size = new System.Drawing.Size(400, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private Ball ball1;
        private Ball ball2;
        private Ball ball3;
        private Ball ball4;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblBad;
    }
}
