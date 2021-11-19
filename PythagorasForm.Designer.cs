namespace PythagorasTriangle
{
    partial class PythagorasForm
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
            this.pythagorasPictureBox = new System.Windows.Forms.PictureBox();
            this.iterationsTrackBar = new System.Windows.Forms.TrackBar();
            this.sideLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pythagorasPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideLengthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pythagorasPictureBox
            // 
            this.pythagorasPictureBox.BackColor = System.Drawing.Color.Honeydew;
            this.pythagorasPictureBox.Location = new System.Drawing.Point(12, 12);
            this.pythagorasPictureBox.Name = "pythagorasPictureBox";
            this.pythagorasPictureBox.Size = new System.Drawing.Size(776, 370);
            this.pythagorasPictureBox.TabIndex = 0;
            this.pythagorasPictureBox.TabStop = false;
            this.pythagorasPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // iterationsTrackBar
            // 
            this.iterationsTrackBar.Location = new System.Drawing.Point(100, 388);
            this.iterationsTrackBar.Maximum = 13;
            this.iterationsTrackBar.Name = "iterationsTrackBar";
            this.iterationsTrackBar.Size = new System.Drawing.Size(217, 45);
            this.iterationsTrackBar.TabIndex = 1;
            this.iterationsTrackBar.Value = 1;
            this.iterationsTrackBar.ValueChanged += new System.EventHandler(this.iterationsTrackBar_ValueChanged);
            // 
            // sideLengthTrackBar
            // 
            this.sideLengthTrackBar.Location = new System.Drawing.Point(503, 388);
            this.sideLengthTrackBar.Maximum = 500;
            this.sideLengthTrackBar.Name = "sideLengthTrackBar";
            this.sideLengthTrackBar.Size = new System.Drawing.Size(217, 45);
            this.sideLengthTrackBar.TabIndex = 2;
            this.sideLengthTrackBar.Value = 100;
            this.sideLengthTrackBar.ValueChanged += new System.EventHandler(this.sideLengthTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adjust Iterations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adjust Side Length";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(323, 400);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw Tree";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(28, 446);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(34, 13);
            this.AngleLabel.TabIndex = 6;
            this.AngleLabel.Text = "Angle";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(68, 439);
            this.trackBar1.Maximum = 157;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(237, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 20;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start Animation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PythagorasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.AngleLabel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sideLengthTrackBar);
            this.Controls.Add(this.iterationsTrackBar);
            this.Controls.Add(this.pythagorasPictureBox);
            this.Name = "PythagorasForm";
            this.Text = "Pythagoreas";
            ((System.ComponentModel.ISupportInitialize)(this.pythagorasPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideLengthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pythagorasPictureBox;
        private System.Windows.Forms.TrackBar iterationsTrackBar;
        private System.Windows.Forms.TrackBar sideLengthTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Button button1;
    }
}

