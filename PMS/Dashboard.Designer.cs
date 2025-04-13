namespace PMS
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip3 = new MenuStrip();
            vIEWALLITEMSToolStripMenuItem = new ToolStripMenuItem();
            vIEWALLSALESToolStripMenuItem = new ToolStripMenuItem();
            aDDNEWITEMToolStripMenuItem = new ToolStripMenuItem();
            aDDNEWSALEToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip3
            // 
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { vIEWALLITEMSToolStripMenuItem, vIEWALLSALESToolStripMenuItem, aDDNEWITEMToolStripMenuItem, aDDNEWSALEToolStripMenuItem });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(1499, 28);
            menuStrip3.TabIndex = 3;
            menuStrip3.Text = "menuStrip3";
            // 
            // vIEWALLITEMSToolStripMenuItem
            // 
            vIEWALLITEMSToolStripMenuItem.Name = "vIEWALLITEMSToolStripMenuItem";
            vIEWALLITEMSToolStripMenuItem.Size = new Size(131, 24);
            vIEWALLITEMSToolStripMenuItem.Text = "VIEW ALL ITEMS";
            vIEWALLITEMSToolStripMenuItem.Click += vIEWALLITEMSToolStripMenuItem_Click;
            // 
            // vIEWALLSALESToolStripMenuItem
            // 
            vIEWALLSALESToolStripMenuItem.Name = "vIEWALLSALESToolStripMenuItem";
            vIEWALLSALESToolStripMenuItem.Size = new Size(131, 24);
            vIEWALLSALESToolStripMenuItem.Text = "VIEW ALL SALES";
            vIEWALLSALESToolStripMenuItem.Click += vIEWALLSALESToolStripMenuItem_Click;
            // 
            // aDDNEWITEMToolStripMenuItem
            // 
            aDDNEWITEMToolStripMenuItem.Name = "aDDNEWITEMToolStripMenuItem";
            aDDNEWITEMToolStripMenuItem.Size = new Size(129, 24);
            aDDNEWITEMToolStripMenuItem.Text = "ADD NEW ITEM";
            aDDNEWITEMToolStripMenuItem.Click += aDDNEWITEMToolStripMenuItem_Click;
            // 
            // aDDNEWSALEToolStripMenuItem
            // 
            aDDNEWSALEToolStripMenuItem.Name = "aDDNEWSALEToolStripMenuItem";
            aDDNEWSALEToolStripMenuItem.Size = new Size(129, 24);
            aDDNEWSALEToolStripMenuItem.Text = "ADD NEW SALE";
            aDDNEWSALEToolStripMenuItem.Click += aDDNEWSALEToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 31);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1499, 916);
            mainPanel.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 944);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip3);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem vIEWALLITEMSToolStripMenuItem;
        private ToolStripMenuItem vIEWALLSALESToolStripMenuItem;
        private ToolStripMenuItem aDDNEWITEMToolStripMenuItem;
        private ToolStripMenuItem aDDNEWSALEToolStripMenuItem;
        private static Panel mainPanel;
    }
}