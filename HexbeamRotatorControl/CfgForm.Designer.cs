namespace HexbeamRotatorControl
{
    partial class CfgForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numUdpInboundPort = new System.Windows.Forms.NumericUpDown();
            this.numUdpOutboundPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.tbRotatorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUdpInboundPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUdpOutboundPort)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 152);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(231, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "UDP Inbound Port:";
            // 
            // numUdpInboundPort
            // 
            this.numUdpInboundPort.Location = new System.Drawing.Point(210, 16);
            this.numUdpInboundPort.Margin = new System.Windows.Forms.Padding(4);
            this.numUdpInboundPort.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numUdpInboundPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUdpInboundPort.Name = "numUdpInboundPort";
            this.numUdpInboundPort.Size = new System.Drawing.Size(114, 22);
            this.numUdpInboundPort.TabIndex = 1;
            this.numUdpInboundPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUdpOutboundPort
            // 
            this.numUdpOutboundPort.Location = new System.Drawing.Point(209, 50);
            this.numUdpOutboundPort.Margin = new System.Windows.Forms.Padding(4);
            this.numUdpOutboundPort.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numUdpOutboundPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUdpOutboundPort.Name = "numUdpOutboundPort";
            this.numUdpOutboundPort.Size = new System.Drawing.Size(114, 22);
            this.numUdpOutboundPort.TabIndex = 2;
            this.numUdpOutboundPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ESP8266 UDP Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ESP8266 Broadcast IP:";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(207, 114);
            this.tbIpAddress.MaxLength = 15;
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(137, 22);
            this.tbIpAddress.TabIndex = 4;
            this.tbIpAddress.TextChanged += new System.EventHandler(this.tbIpAddress_TextChanged);
            this.tbIpAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIpAddress_KeyPress);
            // 
            // tbRotatorName
            // 
            this.tbRotatorName.Location = new System.Drawing.Point(205, 82);
            this.tbRotatorName.MaxLength = 15;
            this.tbRotatorName.Name = "tbRotatorName";
            this.tbRotatorName.Size = new System.Drawing.Size(139, 22);
            this.tbRotatorName.TabIndex = 3;
            this.tbRotatorName.Text = "ESP-FFFFFF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rotator Name:";
            // 
            // CfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 193);
            this.Controls.Add(this.tbRotatorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUdpOutboundPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUdpInboundPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CfgForm";
            this.Text = "Configuration ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CfgForm_FormClosing);
            this.Load += new System.EventHandler(this.CfgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUdpInboundPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUdpOutboundPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUdpInboundPort;
        private System.Windows.Forms.NumericUpDown numUdpOutboundPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.TextBox tbRotatorName;
        private System.Windows.Forms.Label label4;
    }
}