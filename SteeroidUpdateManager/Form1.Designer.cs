namespace SteeroidUpdateManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picPlugin = new System.Windows.Forms.PictureBox();
            this.picUpdate = new System.Windows.Forms.PictureBox();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.picInstall = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlugin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstall)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picPlugin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picUpdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picInstall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 100);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 112);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(424, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Install";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plugin";
            // 
            // picPlugin
            // 
            this.picPlugin.Image = global::SteeroidUpdateManager.Properties.Resources.command_run_code;
            this.picPlugin.Location = new System.Drawing.Point(315, 12);
            this.picPlugin.Name = "picPlugin";
            this.picPlugin.Size = new System.Drawing.Size(81, 66);
            this.picPlugin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlugin.TabIndex = 6;
            this.picPlugin.TabStop = false;
            // 
            // picUpdate
            // 
            this.picUpdate.Image = global::SteeroidUpdateManager.Properties.Resources.command_web;
            this.picUpdate.Location = new System.Drawing.Point(214, 12);
            this.picUpdate.Name = "picUpdate";
            this.picUpdate.Size = new System.Drawing.Size(81, 66);
            this.picUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpdate.TabIndex = 4;
            this.picUpdate.TabStop = false;
            // 
            // picStart
            // 
            this.picStart.Image = global::SteeroidUpdateManager.Properties.Resources.action_bar_run;
            this.picStart.Location = new System.Drawing.Point(114, 12);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(81, 66);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 2;
            this.picStart.TabStop = false;
            // 
            // picInstall
            // 
            this.picInstall.Image = global::SteeroidUpdateManager.Properties.Resources.action_bar_save;
            this.picInstall.Location = new System.Drawing.Point(12, 12);
            this.picInstall.Name = "picInstall";
            this.picInstall.Size = new System.Drawing.Size(81, 66);
            this.picInstall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInstall.TabIndex = 0;
            this.picInstall.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 134);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Steeroid Update Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlugin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInstall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picInstall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picPlugin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picStart;
    }
}

