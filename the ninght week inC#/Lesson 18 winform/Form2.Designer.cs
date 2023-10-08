namespace Lesson_18_winform
{
    partial class Form2
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
            menuStrip1 = new MenuStrip();
            form2ToolStripMenuItem = new ToolStripMenuItem();
            form1ToolStripMenuItem = new ToolStripMenuItem();
            yeniSehifeToolStripMenuItem = new ToolStripMenuItem();
            sonrakiSehifeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { form2ToolStripMenuItem, form1ToolStripMenuItem, yeniSehifeToolStripMenuItem, sonrakiSehifeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(472, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // form2ToolStripMenuItem
            // 
            form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            form2ToolStripMenuItem.Size = new Size(54, 20);
            form2ToolStripMenuItem.Text = "form 2";
            form2ToolStripMenuItem.Click += form2ToolStripMenuItem_Click;
            // 
            // form1ToolStripMenuItem
            // 
            form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            form1ToolStripMenuItem.Size = new Size(54, 20);
            form1ToolStripMenuItem.Text = "form 1";
            // 
            // yeniSehifeToolStripMenuItem
            // 
            yeniSehifeToolStripMenuItem.Name = "yeniSehifeToolStripMenuItem";
            yeniSehifeToolStripMenuItem.Size = new Size(88, 20);
            yeniSehifeToolStripMenuItem.Text = "onceki sehife";
            // 
            // sonrakiSehifeToolStripMenuItem
            // 
            sonrakiSehifeToolStripMenuItem.Name = "sonrakiSehifeToolStripMenuItem";
            sonrakiSehifeToolStripMenuItem.Size = new Size(91, 20);
            sonrakiSehifeToolStripMenuItem.Text = "sonraki sehife";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 343);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private ToolStripMenuItem form1ToolStripMenuItem;
        private ToolStripMenuItem yeniSehifeToolStripMenuItem;
        private ToolStripMenuItem sonrakiSehifeToolStripMenuItem;
    }
}