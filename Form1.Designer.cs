namespace White_Day_Mod_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            nOPToolStripMenuItem = new ToolStripMenuItem();
            unpackToolStripMenuItem = new ToolStripMenuItem();
            repackToolStripMenuItem = new ToolStripMenuItem();
            wADToolStripMenuItem = new ToolStripMenuItem();
            extrasToolStripMenuItem = new ToolStripMenuItem();
            fontEditorToolStripMenuItem = new ToolStripMenuItem();
            mP3PlaylistEditorToolStripMenuItem = new ToolStripMenuItem();
            saveEditorToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, nOPToolStripMenuItem, wADToolStripMenuItem, extrasToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // nOPToolStripMenuItem
            // 
            resources.ApplyResources(nOPToolStripMenuItem, "nOPToolStripMenuItem");
            nOPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { unpackToolStripMenuItem, repackToolStripMenuItem });
            nOPToolStripMenuItem.Name = "nOPToolStripMenuItem";
            // 
            // unpackToolStripMenuItem
            // 
            resources.ApplyResources(unpackToolStripMenuItem, "unpackToolStripMenuItem");
            unpackToolStripMenuItem.Name = "unpackToolStripMenuItem";
            unpackToolStripMenuItem.Click += unpackToolStripMenuItem_Click;
            // 
            // repackToolStripMenuItem
            // 
            resources.ApplyResources(repackToolStripMenuItem, "repackToolStripMenuItem");
            repackToolStripMenuItem.Name = "repackToolStripMenuItem";
            repackToolStripMenuItem.Click += repackToolStripMenuItem_Click;
            // 
            // wADToolStripMenuItem
            // 
            resources.ApplyResources(wADToolStripMenuItem, "wADToolStripMenuItem");
            wADToolStripMenuItem.Name = "wADToolStripMenuItem";
            // 
            // extrasToolStripMenuItem
            // 
            resources.ApplyResources(extrasToolStripMenuItem, "extrasToolStripMenuItem");
            extrasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontEditorToolStripMenuItem, mP3PlaylistEditorToolStripMenuItem, saveEditorToolStripMenuItem });
            extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            // 
            // fontEditorToolStripMenuItem
            // 
            resources.ApplyResources(fontEditorToolStripMenuItem, "fontEditorToolStripMenuItem");
            fontEditorToolStripMenuItem.Name = "fontEditorToolStripMenuItem";
            fontEditorToolStripMenuItem.Click += fontEditorToolStripMenuItem_Click;
            // 
            // mP3PlaylistEditorToolStripMenuItem
            // 
            resources.ApplyResources(mP3PlaylistEditorToolStripMenuItem, "mP3PlaylistEditorToolStripMenuItem");
            mP3PlaylistEditorToolStripMenuItem.Name = "mP3PlaylistEditorToolStripMenuItem";
            // 
            // saveEditorToolStripMenuItem
            // 
            resources.ApplyResources(saveEditorToolStripMenuItem, "saveEditorToolStripMenuItem");
            saveEditorToolStripMenuItem.Name = "saveEditorToolStripMenuItem";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(exitToolStripMenuItem, "exitToolStripMenuItem");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            TransparencyKey = Color.Transparent;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nOPToolStripMenuItem;
        private ToolStripMenuItem unpackToolStripMenuItem;
        private ToolStripMenuItem repackToolStripMenuItem;
        private ToolStripMenuItem wADToolStripMenuItem;
        private ToolStripMenuItem extrasToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem fontEditorToolStripMenuItem;
        private ToolStripMenuItem mP3PlaylistEditorToolStripMenuItem;
        private ToolStripMenuItem saveEditorToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
