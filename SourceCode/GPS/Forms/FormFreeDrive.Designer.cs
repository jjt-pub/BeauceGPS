namespace AgOpenGPS.Forms
{
    partial class FormFreeDrive
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
            this.btnFreeDrive = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSteer = new System.Windows.Forms.TrackBar();
            this.btnResetSteerAngle = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.btnSteerAngleDown = new ProXoft.WinForms.RepeatButton();
            this.btnSteerAngleUp = new ProXoft.WinForms.RepeatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAccel = new System.Windows.Forms.TrackBar();
            this.btnDn = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnMach4 = new System.Windows.Forms.Button();
            this.btnMach3 = new System.Windows.Forms.Button();
            this.btnMach2 = new System.Windows.Forms.Button();
            this.btnMach1 = new System.Windows.Forms.Button();
            this.btnMach5 = new System.Windows.Forms.Button();
            this.btnMach6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFreeDrive
            // 
            this.btnFreeDrive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeDrive.Location = new System.Drawing.Point(6, 202);
            this.btnFreeDrive.Name = "btnFreeDrive";
            this.btnFreeDrive.Size = new System.Drawing.Size(81, 44);
            this.btnFreeDrive.TabIndex = 321;
            this.btnFreeDrive.Text = "Drive";
            this.btnFreeDrive.UseVisualStyleBackColor = true;
            this.btnFreeDrive.Click += new System.EventHandler(this.btnFreeDrive_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSteer);
            this.panel1.Controls.Add(this.btnResetSteerAngle);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnNeutral);
            this.panel1.Controls.Add(this.btnSteerAngleDown);
            this.panel1.Controls.Add(this.btnSteerAngleUp);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 195);
            this.panel1.TabIndex = 324;
            // 
            // tbSteer
            // 
            this.tbSteer.Enabled = false;
            this.tbSteer.Location = new System.Drawing.Point(2, 103);
            this.tbSteer.Maximum = 40;
            this.tbSteer.Minimum = -40;
            this.tbSteer.Name = "tbSteer";
            this.tbSteer.Size = new System.Drawing.Size(500, 45);
            this.tbSteer.TabIndex = 329;
            this.tbSteer.Scroll += new System.EventHandler(this.tbSteer_Scroll);
            // 
            // btnResetSteerAngle
            // 
            this.btnResetSteerAngle.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSteerAngle.Location = new System.Drawing.Point(209, 147);
            this.btnResetSteerAngle.Name = "btnResetSteerAngle";
            this.btnResetSteerAngle.Size = new System.Drawing.Size(87, 45);
            this.btnResetSteerAngle.TabIndex = 328;
            this.btnResetSteerAngle.Text = ">0<";
            this.btnResetSteerAngle.UseVisualStyleBackColor = true;
            this.btnResetSteerAngle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnResetSteerAngle_MouseDown);
            // 
            // btnForward
            // 
            this.btnForward.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnForward.Location = new System.Drawing.Point(209, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(87, 45);
            this.btnForward.TabIndex = 327;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            // 
            // btnNeutral
            // 
            this.btnNeutral.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnNeutral.Location = new System.Drawing.Point(209, 52);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(86, 45);
            this.btnNeutral.TabIndex = 326;
            this.btnNeutral.Text = "Neutral";
            this.btnNeutral.UseVisualStyleBackColor = true;
            this.btnNeutral.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNeutral_MouseDown);
            // 
            // btnSteerAngleDown
            // 
            this.btnSteerAngleDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleDown.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleDown.Image = global::AgOpenGPS.Properties.Resources.ArrowLeft;
            this.btnSteerAngleDown.Location = new System.Drawing.Point(2, 148);
            this.btnSteerAngleDown.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleDown.Name = "btnSteerAngleDown";
            this.btnSteerAngleDown.Size = new System.Drawing.Size(81, 45);
            this.btnSteerAngleDown.TabIndex = 324;
            this.btnSteerAngleDown.UseVisualStyleBackColor = true;
            this.btnSteerAngleDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleDown_MouseDown);
            // 
            // btnSteerAngleUp
            // 
            this.btnSteerAngleUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSteerAngleUp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSteerAngleUp.Image = global::AgOpenGPS.Properties.Resources.ArrowRight;
            this.btnSteerAngleUp.Location = new System.Drawing.Point(414, 148);
            this.btnSteerAngleUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSteerAngleUp.Name = "btnSteerAngleUp";
            this.btnSteerAngleUp.Size = new System.Drawing.Size(81, 45);
            this.btnSteerAngleUp.TabIndex = 325;
            this.btnSteerAngleUp.UseVisualStyleBackColor = true;
            this.btnSteerAngleUp.Click += new System.EventHandler(this.btnSteerAngleUp_Click);
            this.btnSteerAngleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSteerAngleUp_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbAccel);
            this.panel2.Controls.Add(this.btnDn);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Location = new System.Drawing.Point(514, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 257);
            this.panel2.TabIndex = 325;
            // 
            // tbAccel
            // 
            this.tbAccel.Enabled = false;
            this.tbAccel.Location = new System.Drawing.Point(3, 1);
            this.tbAccel.Maximum = 40;
            this.tbAccel.Name = "tbAccel";
            this.tbAccel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAccel.Size = new System.Drawing.Size(45, 253);
            this.tbAccel.TabIndex = 331;
            // 
            // btnDn
            // 
            this.btnDn.Image = global::AgOpenGPS.Properties.Resources.DnArrow64;
            this.btnDn.Location = new System.Drawing.Point(54, 203);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(87, 45);
            this.btnDn.TabIndex = 329;
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDn_MouseDown);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::AgOpenGPS.Properties.Resources.UpArrow64;
            this.btnUp.Location = new System.Drawing.Point(54, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(87, 45);
            this.btnUp.TabIndex = 328;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseDown);
            // 
            // btnMach4
            // 
            this.btnMach4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMach4.Location = new System.Drawing.Point(52, 305);
            this.btnMach4.Name = "btnMach4";
            this.btnMach4.Size = new System.Drawing.Size(120, 32);
            this.btnMach4.TabIndex = 326;
            this.btnMach4.Text = "Machine 4";
            this.btnMach4.UseVisualStyleBackColor = true;
            this.btnMach4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMach4_MouseDown);
            // 
            // btnMach3
            // 
            this.btnMach3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMach3.Location = new System.Drawing.Point(347, 267);
            this.btnMach3.Name = "btnMach3";
            this.btnMach3.Size = new System.Drawing.Size(120, 32);
            this.btnMach3.TabIndex = 327;
            this.btnMach3.Text = "Machine 3";
            this.btnMach3.UseVisualStyleBackColor = true;
            this.btnMach3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMach3_MouseDown);
            // 
            // btnMach2
            // 
            this.btnMach2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMach2.Location = new System.Drawing.Point(199, 267);
            this.btnMach2.Name = "btnMach2";
            this.btnMach2.Size = new System.Drawing.Size(120, 32);
            this.btnMach2.TabIndex = 328;
            this.btnMach2.Text = "Machine 2";
            this.btnMach2.UseVisualStyleBackColor = true;
            this.btnMach2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMach2_MouseDown);
            // 
            // btnMach1
            // 
            this.btnMach1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMach1.Location = new System.Drawing.Point(52, 267);
            this.btnMach1.Name = "btnMach1";
            this.btnMach1.Size = new System.Drawing.Size(120, 32);
            this.btnMach1.TabIndex = 329;
            this.btnMach1.Text = "Machine 1";
            this.btnMach1.UseVisualStyleBackColor = true;
            this.btnMach1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMach1_MouseDown);
            // 
            // btnMach5
            // 
            this.btnMach5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMach5.Location = new System.Drawing.Point(199, 305);
            this.btnMach5.Name = "btnMach5";
            this.btnMach5.Size = new System.Drawing.Size(120, 31);
            this.btnMach5.TabIndex = 330;
            this.btnMach5.Text = "Machine 5";
            this.btnMach5.UseVisualStyleBackColor = true;
            this.btnMach5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMach5_MouseDown);
            // 
            // btnMach6
            // 
            this.btnMach6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnMach6.Location = new System.Drawing.Point(347, 305);
            this.btnMach6.Name = "btnMach6";
            this.btnMach6.Size = new System.Drawing.Size(120, 31);
            this.btnMach6.TabIndex = 331;
            this.btnMach6.Text = "Machine 6";
            this.btnMach6.UseVisualStyleBackColor = true;
            this.btnMach6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMach6_MouseDown);
            // 
            // FormFreeDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 363);
            this.Controls.Add(this.btnMach6);
            this.Controls.Add(this.btnMach5);
            this.Controls.Add(this.btnMach1);
            this.Controls.Add(this.btnMach2);
            this.Controls.Add(this.btnMach3);
            this.Controls.Add(this.btnMach4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFreeDrive);
            this.Name = "FormFreeDrive";
            this.Text = "Conduite Mauelle";
            this.Load += new System.EventHandler(this.FormFreeDrive_Load);
            this.Leave += new System.EventHandler(this.FormFreeDrive_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAccel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFreeDrive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbSteer;
        private System.Windows.Forms.Button btnResetSteerAngle;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnNeutral;
        private ProXoft.WinForms.RepeatButton btnSteerAngleDown;
        private ProXoft.WinForms.RepeatButton btnSteerAngleUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TrackBar tbAccel;
        private System.Windows.Forms.Button btnMach4;
        private System.Windows.Forms.Button btnMach3;
        private System.Windows.Forms.Button btnMach2;
        private System.Windows.Forms.Button btnMach1;
        private System.Windows.Forms.Button btnMach5;
        private System.Windows.Forms.Button btnMach6;
    }
}