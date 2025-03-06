namespace not_hibernating
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBoxAutoStartup = new System.Windows.Forms.CheckBox();
            this.openWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxSleepPrevention = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWindowsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 56);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "windows 防止休眠功能";
            this.notifyIcon1.Visible = true;
            // 
            // checkBoxAutoStartup
            // 
            this.checkBoxAutoStartup.AutoSize = true;
            this.checkBoxAutoStartup.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxAutoStartup.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxAutoStartup.Location = new System.Drawing.Point(25, 31);
            this.checkBoxAutoStartup.Name = "checkBoxAutoStartup";
            this.checkBoxAutoStartup.Size = new System.Drawing.Size(229, 25);
            this.checkBoxAutoStartup.TabIndex = 1;
            this.checkBoxAutoStartup.Text = "Self starting upon startup";
            this.checkBoxAutoStartup.UseVisualStyleBackColor = true;
            // 
            // openWindowsToolStripMenuItem
            // 
            this.openWindowsToolStripMenuItem.Image = global::not_hibernating.Properties.Resources.windows;
            this.openWindowsToolStripMenuItem.Name = "openWindowsToolStripMenuItem";
            this.openWindowsToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.openWindowsToolStripMenuItem.Text = "Open Windows";
            // 
            // checkBoxSleepPrevention
            // 
            this.checkBoxSleepPrevention.AutoSize = true;
            this.checkBoxSleepPrevention.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBoxSleepPrevention.ForeColor = System.Drawing.Color.Blue;
            this.checkBoxSleepPrevention.Location = new System.Drawing.Point(25, 83);
            this.checkBoxSleepPrevention.Name = "checkBoxSleepPrevention";
            this.checkBoxSleepPrevention.Size = new System.Drawing.Size(89, 25);
            this.checkBoxSleepPrevention.TabIndex = 2;
            this.checkBoxSleepPrevention.Text = "Enable ";
            this.checkBoxSleepPrevention.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSleepPrevention);
            this.Controls.Add(this.checkBoxAutoStartup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Windows sleep prevention feature";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBoxAutoStartup;
        private System.Windows.Forms.ToolStripMenuItem openWindowsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxSleepPrevention;
        private System.Windows.Forms.Label label1;
    }
}

