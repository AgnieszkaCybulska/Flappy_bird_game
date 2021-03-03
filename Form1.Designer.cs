
namespace Flappy_bird
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int gravity = 5;
        int pipeSpeed = 8;
        int score = 0;
        int xDistance;
        int yDistance;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.downPipe_pictureBox = new System.Windows.Forms.PictureBox();
            this.upPipe_pictureBox = new System.Windows.Forms.PictureBox();
            this.bird_pictureBox = new System.Windows.Forms.PictureBox();
            this.ground_pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score_label = new System.Windows.Forms.Label();
            this.end_pictureBox = new System.Windows.Forms.PictureBox();
            this.end_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.downPipe_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // downPipe_pictureBox
            // 
            this.downPipe_pictureBox.BackgroundImage = global::Flappy_bird.Properties.Resources.down_pipe;
            this.downPipe_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downPipe_pictureBox.Location = new System.Drawing.Point(253, 277);
            this.downPipe_pictureBox.Name = "downPipe_pictureBox";
            this.downPipe_pictureBox.Size = new System.Drawing.Size(100, 176);
            this.downPipe_pictureBox.TabIndex = 3;
            this.downPipe_pictureBox.TabStop = false;
            // 
            // upPipe_pictureBox
            // 
            this.upPipe_pictureBox.BackgroundImage = global::Flappy_bird.Properties.Resources.up_pipe;
            this.upPipe_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upPipe_pictureBox.Location = new System.Drawing.Point(174, -2);
            this.upPipe_pictureBox.Name = "upPipe_pictureBox";
            this.upPipe_pictureBox.Size = new System.Drawing.Size(100, 173);
            this.upPipe_pictureBox.TabIndex = 2;
            this.upPipe_pictureBox.TabStop = false;
            // 
            // bird_pictureBox
            // 
            this.bird_pictureBox.BackgroundImage = global::Flappy_bird.Properties.Resources.bird;
            this.bird_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird_pictureBox.Location = new System.Drawing.Point(12, 154);
            this.bird_pictureBox.Name = "bird_pictureBox";
            this.bird_pictureBox.Size = new System.Drawing.Size(83, 72);
            this.bird_pictureBox.TabIndex = 1;
            this.bird_pictureBox.TabStop = false;
            // 
            // ground_pictureBox
            // 
            this.ground_pictureBox.BackgroundImage = global::Flappy_bird.Properties.Resources.ground;
            this.ground_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground_pictureBox.Location = new System.Drawing.Point(-5, 451);
            this.ground_pictureBox.Name = "ground_pictureBox";
            this.ground_pictureBox.Size = new System.Drawing.Size(515, 99);
            this.ground_pictureBox.TabIndex = 0;
            this.ground_pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score_label
            // 
            this.score_label.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_label.Location = new System.Drawing.Point(170, 487);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(115, 34);
            this.score_label.TabIndex = 4;
            this.score_label.Text = "SCORE: ";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // end_pictureBox
            // 
            this.end_pictureBox.BackColor = System.Drawing.Color.Ivory;
            this.end_pictureBox.Enabled = false;
            this.end_pictureBox.Location = new System.Drawing.Point(101, 154);
            this.end_pictureBox.Name = "end_pictureBox";
            this.end_pictureBox.Size = new System.Drawing.Size(286, 169);
            this.end_pictureBox.TabIndex = 5;
            this.end_pictureBox.TabStop = false;
            this.end_pictureBox.Visible = false;
            // 
            // end_label
            // 
            this.end_label.BackColor = System.Drawing.Color.Ivory;
            this.end_label.Enabled = false;
            this.end_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.end_label.ForeColor = System.Drawing.Color.Black;
            this.end_label.Location = new System.Drawing.Point(146, 189);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(188, 96);
            this.end_label.TabIndex = 6;
            this.end_label.Text = "SCORE: ";
            this.end_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.end_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(508, 545);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.ground_pictureBox);
            this.Controls.Add(this.end_label);
            this.Controls.Add(this.end_pictureBox);
            this.Controls.Add(this.downPipe_pictureBox);
            this.Controls.Add(this.upPipe_pictureBox);
            this.Controls.Add(this.bird_pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.downPipe_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPipe_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground_pictureBox;
        private System.Windows.Forms.PictureBox bird_pictureBox;
        private System.Windows.Forms.PictureBox upPipe_pictureBox;
        private System.Windows.Forms.PictureBox downPipe_pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.PictureBox end_pictureBox;
        private System.Windows.Forms.Label end_label;
    }
}

