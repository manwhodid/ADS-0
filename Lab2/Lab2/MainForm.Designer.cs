namespace Lab2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            menuClock = new ToolStripMenuItem();
            menuStart = new ToolStripMenuItem();
            menuStop = new ToolStripMenuItem();
            menuSeparator = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            menuLanguage = new ToolStripMenuItem();
            menuRussian = new ToolStripMenuItem();
            menuEnglish = new ToolStripMenuItem();
            tableLayoutPanel = new TableLayoutPanel();
            labelMoscow = new Label();
            labelLondon = new Label();
            labelVladivostok = new Label();
            textBoxMoscow = new TextBox();
            textBoxLondon = new TextBox();
            textBoxVladivostok = new TextBox();
            menuStrip.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip
            //
            menuStrip.Items.AddRange(new ToolStripItem[] { menuClock, menuLanguage });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(484, 24);
            menuStrip.TabIndex = 0;
            //
            // menuClock
            //
            menuClock.DropDownItems.AddRange(new ToolStripItem[] { menuStart, menuStop, menuSeparator, menuExit });
            menuClock.Name = "menuClock";
            resources.ApplyResources(menuClock, "menuClock");
            //
            // menuStart
            //
            menuStart.Name = "menuStart";
            menuStart.ShortcutKeys = Keys.Control | Keys.S;
            resources.ApplyResources(menuStart, "menuStart");
            menuStart.Click += menuStart_Click;
            //
            // menuStop
            //
            menuStop.Name = "menuStop";
            menuStop.ShortcutKeys = Keys.Control | Keys.T;
            resources.ApplyResources(menuStop, "menuStop");
            menuStop.Click += menuStop_Click;
            //
            // menuSeparator
            //
            menuSeparator.Name = "menuSeparator";
            //
            // menuExit
            //
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            resources.ApplyResources(menuExit, "menuExit");
            menuExit.Click += menuExit_Click;
            //
            // menuLanguage
            //
            menuLanguage.DropDownItems.AddRange(new ToolStripItem[] { menuRussian, menuEnglish });
            menuLanguage.Name = "menuLanguage";
            resources.ApplyResources(menuLanguage, "menuLanguage");
            //
            // menuRussian
            //
            menuRussian.Name = "menuRussian";
            menuRussian.Text = "&Русский";
            menuRussian.Click += menuRussian_Click;
            //
            // menuEnglish
            //
            menuEnglish.Name = "menuEnglish";
            menuEnglish.Text = "&English";
            menuEnglish.Click += menuEnglish_Click;
            //
            // tableLayoutPanel
            //
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelMoscow, 0, 0);
            tableLayoutPanel.Controls.Add(textBoxMoscow, 1, 0);
            tableLayoutPanel.Controls.Add(labelLondon, 0, 1);
            tableLayoutPanel.Controls.Add(textBoxLondon, 1, 1);
            tableLayoutPanel.Controls.Add(labelVladivostok, 0, 2);
            tableLayoutPanel.Controls.Add(textBoxVladivostok, 1, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 24);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(6);
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            tableLayoutPanel.Size = new Size(484, 237);
            tableLayoutPanel.TabIndex = 1;
            //
            // labelMoscow
            //
            labelMoscow.Anchor = AnchorStyles.Left;
            labelMoscow.AutoSize = true;
            labelMoscow.Font = new Font("Segoe UI", 12F);
            labelMoscow.Name = "labelMoscow";
            resources.ApplyResources(labelMoscow, "labelMoscow");
            //
            // labelLondon
            //
            labelLondon.Anchor = AnchorStyles.Left;
            labelLondon.AutoSize = true;
            labelLondon.Font = new Font("Segoe UI", 12F);
            labelLondon.Name = "labelLondon";
            resources.ApplyResources(labelLondon, "labelLondon");
            //
            // labelVladivostok
            //
            labelVladivostok.Anchor = AnchorStyles.Left;
            labelVladivostok.AutoSize = true;
            labelVladivostok.Font = new Font("Segoe UI", 12F);
            labelVladivostok.Name = "labelVladivostok";
            resources.ApplyResources(labelVladivostok, "labelVladivostok");
            //
            // textBoxMoscow
            //
            textBoxMoscow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMoscow.Font = new Font("Consolas", 20F);
            textBoxMoscow.Multiline = true;
            textBoxMoscow.Name = "textBoxMoscow";
            textBoxMoscow.ReadOnly = true;
            textBoxMoscow.TabIndex = 0;
            textBoxMoscow.TextAlign = HorizontalAlignment.Center;
            //
            // textBoxLondon
            //
            textBoxLondon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLondon.Font = new Font("Consolas", 20F);
            textBoxLondon.Multiline = true;
            textBoxLondon.Name = "textBoxLondon";
            textBoxLondon.ReadOnly = true;
            textBoxLondon.TabIndex = 1;
            textBoxLondon.TextAlign = HorizontalAlignment.Center;
            //
            // textBoxVladivostok
            //
            textBoxVladivostok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxVladivostok.Font = new Font("Consolas", 20F);
            textBoxVladivostok.Multiline = true;
            textBoxVladivostok.Name = "textBoxVladivostok";
            textBoxVladivostok.ReadOnly = true;
            textBoxVladivostok.TabIndex = 2;
            textBoxVladivostok.TextAlign = HorizontalAlignment.Center;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(tableLayoutPanel);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(360, 220);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            resources.ApplyResources(this, "$this");
            FormClosed += MainForm_FormClosed;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menuClock;
        private ToolStripMenuItem menuStart;
        private ToolStripMenuItem menuStop;
        private ToolStripSeparator menuSeparator;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem menuLanguage;
        private ToolStripMenuItem menuRussian;
        private ToolStripMenuItem menuEnglish;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelMoscow;
        private Label labelLondon;
        private Label labelVladivostok;
        private TextBox textBoxMoscow;
        private TextBox textBoxLondon;
        private TextBox textBoxVladivostok;
    }
}
