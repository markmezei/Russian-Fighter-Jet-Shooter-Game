namespace FighterJet
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.text = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.putin_jet = new System.Windows.Forms.PictureBox();
            this.missile = new System.Windows.Forms.PictureBox();
            this.russian_jet = new System.Windows.Forms.PictureBox();
            this.nato_jet = new System.Windows.Forms.PictureBox();
            this.jet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.putin_jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.russian_jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nato_jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.gameplay);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(467, 299);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(45, 46);
            this.text.TabIndex = 5;
            this.text.Text = "0";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(368, 44);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(0, 46);
            this.end.TabIndex = 6;
            // 
            // putin_jet
            // 
            this.putin_jet.Image = global::FighterJet.Properties.Resources.putin_jet;
            this.putin_jet.Location = new System.Drawing.Point(350, -300);
            this.putin_jet.Name = "putin_jet";
            this.putin_jet.Size = new System.Drawing.Size(277, 294);
            this.putin_jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.putin_jet.TabIndex = 7;
            this.putin_jet.TabStop = false;
            // 
            // missile
            // 
            this.missile.Image = global::FighterJet.Properties.Resources.bullet;
            this.missile.Location = new System.Drawing.Point(656, 606);
            this.missile.Name = "missile";
            this.missile.Size = new System.Drawing.Size(10, 33);
            this.missile.TabIndex = 3;
            this.missile.TabStop = false;
            // 
            // russian_jet
            // 
            this.russian_jet.Image = global::FighterJet.Properties.Resources.russian_jet;
            this.russian_jet.Location = new System.Drawing.Point(67, 12);
            this.russian_jet.Name = "russian_jet";
            this.russian_jet.Size = new System.Drawing.Size(229, 171);
            this.russian_jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.russian_jet.TabIndex = 2;
            this.russian_jet.TabStop = false;
            // 
            // nato_jet
            // 
            this.nato_jet.Image = global::FighterJet.Properties.Resources.nato_jet;
            this.nato_jet.Location = new System.Drawing.Point(694, 12);
            this.nato_jet.Name = "nato_jet";
            this.nato_jet.Size = new System.Drawing.Size(222, 171);
            this.nato_jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nato_jet.TabIndex = 1;
            this.nato_jet.TabStop = false;
            // 
            // jet
            // 
            this.jet.Image = global::FighterJet.Properties.Resources._942346;
            this.jet.Location = new System.Drawing.Point(614, 728);
            this.jet.Name = "jet";
            this.jet.Size = new System.Drawing.Size(129, 133);
            this.jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jet.TabIndex = 0;
            this.jet.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(982, 887);
            this.Controls.Add(this.putin_jet);
            this.Controls.Add(this.end);
            this.Controls.Add(this.text);
            this.Controls.Add(this.missile);
            this.Controls.Add(this.russian_jet);
            this.Controls.Add(this.nato_jet);
            this.Controls.Add(this.jet);
            this.Name = "Form1";
            this.Text = "Fighter Jet Shooter Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jetIsMoving);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.jetIsntMoving);
            ((System.ComponentModel.ISupportInitialize)(this.putin_jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.russian_jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nato_jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jet;
        private System.Windows.Forms.PictureBox nato_jet;
        private System.Windows.Forms.PictureBox russian_jet;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox missile;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.PictureBox putin_jet;
    }
}

