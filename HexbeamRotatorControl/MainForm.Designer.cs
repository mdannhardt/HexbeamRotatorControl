namespace HexbeamRotatorControl
{
    partial class MainDisplayForm
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
            this.tbCurrentBearing = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerGetCurrentBearing = new System.Windows.Forms.Timer(this.components);
            this.btnN = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnNW = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.btnSE = new System.Windows.Forms.Button();
            this.btnSW = new System.Windows.Forms.Button();
            this.numTargetBearing = new System.Windows.Forms.NumericUpDown();
            this.tbRotation = new System.Windows.Forms.TextBox();
            this.btnCfg = new System.Windows.Forms.Button();
            this.btnCalib = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetBearing)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCurrentBearing
            // 
            this.tbCurrentBearing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentBearing.Location = new System.Drawing.Point(96, 6);
            this.tbCurrentBearing.Margin = new System.Windows.Forms.Padding(4);
            this.tbCurrentBearing.Name = "tbCurrentBearing";
            this.tbCurrentBearing.ReadOnly = true;
            this.tbCurrentBearing.Size = new System.Drawing.Size(144, 46);
            this.tbCurrentBearing.TabIndex = 0;
            this.tbCurrentBearing.TabStop = false;
            this.tbCurrentBearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentBearing.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbCurrentBearing_MouseDoubleClick);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(15, 60);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(305, 102);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerGetCurrentBearing
            // 
            this.timerGetCurrentBearing.Interval = 1000;
            this.timerGetCurrentBearing.Tick += new System.EventHandler(this.timerGetCurrentBearing_Tick);
            // 
            // btnN
            // 
            this.btnN.Enabled = false;
            this.btnN.Location = new System.Drawing.Point(121, 66);
            this.btnN.Margin = new System.Windows.Forms.Padding(4);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(89, 28);
            this.btnN.TabIndex = 3;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnN_Click);
            // 
            // btnW
            // 
            this.btnW.Enabled = false;
            this.btnW.Location = new System.Drawing.Point(24, 98);
            this.btnW.Margin = new System.Windows.Forms.Padding(4);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(89, 28);
            this.btnW.TabIndex = 4;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnS
            // 
            this.btnS.Enabled = false;
            this.btnS.Location = new System.Drawing.Point(121, 130);
            this.btnS.Margin = new System.Windows.Forms.Padding(4);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(89, 28);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.Location = new System.Drawing.Point(217, 98);
            this.btnE.Margin = new System.Windows.Forms.Padding(4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(89, 28);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnNW
            // 
            this.btnNW.Enabled = false;
            this.btnNW.Location = new System.Drawing.Point(85, 78);
            this.btnNW.Margin = new System.Windows.Forms.Padding(4);
            this.btnNW.Name = "btnNW";
            this.btnNW.Size = new System.Drawing.Size(28, 16);
            this.btnNW.TabIndex = 7;
            this.btnNW.UseVisualStyleBackColor = true;
            this.btnNW.Click += new System.EventHandler(this.btnNW_Click);
            // 
            // btnNE
            // 
            this.btnNE.Enabled = false;
            this.btnNE.Location = new System.Drawing.Point(217, 78);
            this.btnNE.Margin = new System.Windows.Forms.Padding(4);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(28, 16);
            this.btnNE.TabIndex = 8;
            this.btnNE.UseVisualStyleBackColor = true;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // btnSE
            // 
            this.btnSE.Enabled = false;
            this.btnSE.Location = new System.Drawing.Point(217, 130);
            this.btnSE.Margin = new System.Windows.Forms.Padding(4);
            this.btnSE.Name = "btnSE";
            this.btnSE.Size = new System.Drawing.Size(28, 16);
            this.btnSE.TabIndex = 9;
            this.btnSE.UseVisualStyleBackColor = true;
            this.btnSE.Click += new System.EventHandler(this.btnSE_Click);
            // 
            // btnSW
            // 
            this.btnSW.Enabled = false;
            this.btnSW.Location = new System.Drawing.Point(85, 130);
            this.btnSW.Margin = new System.Windows.Forms.Padding(4);
            this.btnSW.Name = "btnSW";
            this.btnSW.Size = new System.Drawing.Size(28, 16);
            this.btnSW.TabIndex = 10;
            this.btnSW.UseVisualStyleBackColor = true;
            this.btnSW.Click += new System.EventHandler(this.btnSW_Click);
            // 
            // numTargetBearing
            // 
            this.numTargetBearing.Enabled = false;
            this.numTargetBearing.Location = new System.Drawing.Point(121, 102);
            this.numTargetBearing.Margin = new System.Windows.Forms.Padding(4);
            this.numTargetBearing.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numTargetBearing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numTargetBearing.Name = "numTargetBearing";
            this.numTargetBearing.Size = new System.Drawing.Size(89, 22);
            this.numTargetBearing.TabIndex = 2;
            this.numTargetBearing.ValueChanged += new System.EventHandler(this.numTargetBearing_ValueChanged);
            // 
            // tbRotation
            // 
            this.tbRotation.Location = new System.Drawing.Point(244, 29);
            this.tbRotation.Margin = new System.Windows.Forms.Padding(4);
            this.tbRotation.Name = "tbRotation";
            this.tbRotation.ReadOnly = true;
            this.tbRotation.Size = new System.Drawing.Size(75, 22);
            this.tbRotation.TabIndex = 11;
            // 
            // btnCfg
            // 
            this.btnCfg.Location = new System.Drawing.Point(15, 2);
            this.btnCfg.Margin = new System.Windows.Forms.Padding(4);
            this.btnCfg.Name = "btnCfg";
            this.btnCfg.Size = new System.Drawing.Size(73, 27);
            this.btnCfg.TabIndex = 12;
            this.btnCfg.Text = "Config.";
            this.btnCfg.UseVisualStyleBackColor = true;
            this.btnCfg.Click += new System.EventHandler(this.btnCfg_Click);
            // 
            // btnCalib
            // 
            this.btnCalib.Location = new System.Drawing.Point(15, 30);
            this.btnCalib.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(73, 27);
            this.btnCalib.TabIndex = 13;
            this.btnCalib.Text = "Calib.";
            this.btnCalib.UseVisualStyleBackColor = true;
            this.btnCalib.Click += new System.EventHandler(this.btnCalib_Click);
            // 
            // MainDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 167);
            this.Controls.Add(this.btnCalib);
            this.Controls.Add(this.btnCfg);
            this.Controls.Add(this.tbRotation);
            this.Controls.Add(this.btnSW);
            this.Controls.Add(this.btnSE);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnNW);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.numTargetBearing);
            this.Controls.Add(this.tbCurrentBearing);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDisplayForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hexbeam Rotator Control";
            this.DoubleClick += new System.EventHandler(this.btnToggleMin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numTargetBearing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrentBearing;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerGetCurrentBearing;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnNW;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Button btnSE;
        private System.Windows.Forms.Button btnSW;
        private System.Windows.Forms.NumericUpDown numTargetBearing;
        private System.Windows.Forms.TextBox tbRotation;
        private System.Windows.Forms.Button btnCfg;
        private System.Windows.Forms.Button btnCalib;
    }
}

