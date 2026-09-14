namespace MainContextMenu
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
            components = new System.ComponentModel.Container();
            mnuMainMenu = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuFormatColor = new ToolStripMenuItem();
            mnuFormatAllColors = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuFormatColorBlack = new ToolStripMenuItem();
            mnuFormatColorBlue = new ToolStripMenuItem();
            mnuFormatColorGreen = new ToolStripMenuItem();
            mnuFormatColorRed = new ToolStripMenuItem();
            mnuFormatFont = new ToolStripMenuItem();
            mnuFormatFontAllFonts = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuFormatFontBold = new ToolStripMenuItem();
            mnuFormatFontItalic = new ToolStripMenuItem();
            mnuFormatFontUnderline = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            mnuHelpAbout = new ToolStripMenuItem();
            dlgOpenFile = new OpenFileDialog();
            dlgSaveFile = new SaveFileDialog();
            dlgFont = new FontDialog();
            dlgColor = new ColorDialog();
            mnuContext = new ContextMenuStrip(components);
            mnuContextCut = new ToolStripMenuItem();
            mnuContextCopy = new ToolStripMenuItem();
            mnuContextPaste = new ToolStripMenuItem();
            pnlContainer = new Panel();
            rtbText = new RichTextBox();
            mnuMainMenu.SuspendLayout();
            mnuContext.SuspendLayout();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMainMenu
            // 
            mnuMainMenu.ImageScalingSize = new Size(20, 20);
            mnuMainMenu.Items.AddRange(new ToolStripItem[] { mnuFile, mnuFormat, mnuHelp });
            mnuMainMenu.Location = new Point(0, 0);
            mnuMainMenu.Name = "mnuMainMenu";
            mnuMainMenu.Padding = new Padding(7, 3, 0, 3);
            mnuMainMenu.Size = new Size(553, 30);
            mnuMainMenu.TabIndex = 0;
            mnuMainMenu.Text = "mnuMainMenu";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSaveAs, toolStripSeparator1, mnuFileExit });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 24);
            mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuFileNew.Size = new Size(224, 26);
            mnuFileNew.Text = "&New";
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuFileOpen.Size = new Size(224, 26);
            mnuFileOpen.Text = "&Open...";
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.ShortcutKeys = Keys.Control | Keys.S;
            mnuFileSaveAs.Size = new Size(224, 26);
            mnuFileSaveAs.Text = "Save &As...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.Size = new Size(224, 26);
            mnuFileExit.Text = "E&xit";
            // 
            // mnuFormat
            // 
            mnuFormat.DropDownItems.AddRange(new ToolStripItem[] { mnuFormatColor, mnuFormatFont });
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(70, 24);
            mnuFormat.Text = "F&ormat";
            // 
            // mnuFormatColor
            // 
            mnuFormatColor.DropDownItems.AddRange(new ToolStripItem[] { mnuFormatAllColors, toolStripSeparator2, mnuFormatColorBlack, mnuFormatColorBlue, mnuFormatColorGreen, mnuFormatColorRed });
            mnuFormatColor.Name = "mnuFormatColor";
            mnuFormatColor.Size = new Size(224, 26);
            mnuFormatColor.Text = "&Color";
            // 
            // mnuFormatAllColors
            // 
            mnuFormatAllColors.Name = "mnuFormatAllColors";
            mnuFormatAllColors.Size = new Size(224, 26);
            mnuFormatAllColors.Text = "&All Colors...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // mnuFormatColorBlack
            // 
            mnuFormatColorBlack.CheckOnClick = true;
            mnuFormatColorBlack.Name = "mnuFormatColorBlack";
            mnuFormatColorBlack.ShortcutKeys = Keys.Control | Keys.Shift | Keys.B;
            mnuFormatColorBlack.Size = new Size(224, 26);
            mnuFormatColorBlack.Text = "&Black";
            // 
            // mnuFormatColorBlue
            // 
            mnuFormatColorBlue.CheckOnClick = true;
            mnuFormatColorBlue.Name = "mnuFormatColorBlue";
            mnuFormatColorBlue.ShortcutKeys = Keys.Control | Keys.Shift | Keys.U;
            mnuFormatColorBlue.Size = new Size(224, 26);
            mnuFormatColorBlue.Text = "Bl&ue";
            // 
            // mnuFormatColorGreen
            // 
            mnuFormatColorGreen.CheckOnClick = true;
            mnuFormatColorGreen.Name = "mnuFormatColorGreen";
            mnuFormatColorGreen.ShortcutKeys = Keys.Control | Keys.Shift | Keys.G;
            mnuFormatColorGreen.Size = new Size(224, 26);
            mnuFormatColorGreen.Text = "&Green";
            // 
            // mnuFormatColorRed
            // 
            mnuFormatColorRed.CheckOnClick = true;
            mnuFormatColorRed.Name = "mnuFormatColorRed";
            mnuFormatColorRed.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            mnuFormatColorRed.Size = new Size(224, 26);
            mnuFormatColorRed.Text = "&Red";
            // 
            // mnuFormatFont
            // 
            mnuFormatFont.DropDownItems.AddRange(new ToolStripItem[] { mnuFormatFontAllFonts, toolStripSeparator3, mnuFormatFontBold, mnuFormatFontItalic, mnuFormatFontUnderline });
            mnuFormatFont.Name = "mnuFormatFont";
            mnuFormatFont.Size = new Size(224, 26);
            mnuFormatFont.Text = "&Font";
            // 
            // mnuFormatFontAllFonts
            // 
            mnuFormatFontAllFonts.Name = "mnuFormatFontAllFonts";
            mnuFormatFontAllFonts.Size = new Size(224, 26);
            mnuFormatFontAllFonts.Text = "&All Fonts...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(221, 6);
            // 
            // mnuFormatFontBold
            // 
            mnuFormatFontBold.CheckOnClick = true;
            mnuFormatFontBold.Name = "mnuFormatFontBold";
            mnuFormatFontBold.ShortcutKeys = Keys.Control | Keys.B;
            mnuFormatFontBold.Size = new Size(224, 26);
            mnuFormatFontBold.Text = "&Bold";
            // 
            // mnuFormatFontItalic
            // 
            mnuFormatFontItalic.CheckOnClick = true;
            mnuFormatFontItalic.Name = "mnuFormatFontItalic";
            mnuFormatFontItalic.ShortcutKeys = Keys.Control | Keys.I;
            mnuFormatFontItalic.Size = new Size(224, 26);
            mnuFormatFontItalic.Text = "&Italic";
            // 
            // mnuFormatFontUnderline
            // 
            mnuFormatFontUnderline.CheckOnClick = true;
            mnuFormatFontUnderline.Name = "mnuFormatFontUnderline";
            mnuFormatFontUnderline.ShortcutKeys = Keys.Control | Keys.U;
            mnuFormatFontUnderline.Size = new Size(224, 26);
            mnuFormatFontUnderline.Text = "&Underline";
            // 
            // mnuHelp
            // 
            mnuHelp.DropDownItems.AddRange(new ToolStripItem[] { mnuHelpAbout });
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(55, 24);
            mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            mnuHelpAbout.Name = "mnuHelpAbout";
            mnuHelpAbout.Size = new Size(224, 26);
            mnuHelpAbout.Text = "&About";
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.FileName = "openFileDialog1";
            // 
            // mnuContext
            // 
            mnuContext.ImageScalingSize = new Size(20, 20);
            mnuContext.Items.AddRange(new ToolStripItem[] { mnuContextCut, mnuContextCopy, mnuContextPaste });
            mnuContext.Name = "mnuContext";
            mnuContext.Size = new Size(164, 76);
            // 
            // mnuContextCut
            // 
            mnuContextCut.Name = "mnuContextCut";
            mnuContextCut.ShortcutKeys = Keys.Control | Keys.X;
            mnuContextCut.Size = new Size(163, 24);
            mnuContextCut.Text = "Cu&t";
            // 
            // mnuContextCopy
            // 
            mnuContextCopy.Name = "mnuContextCopy";
            mnuContextCopy.ShortcutKeys = Keys.Control | Keys.C;
            mnuContextCopy.Size = new Size(163, 24);
            mnuContextCopy.Text = "&Copy";
            // 
            // mnuContextPaste
            // 
            mnuContextPaste.Name = "mnuContextPaste";
            mnuContextPaste.ShortcutKeys = Keys.Control | Keys.V;
            mnuContextPaste.Size = new Size(163, 24);
            mnuContextPaste.Text = "&Paste";
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.Controls.Add(rtbText);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 30);
            pnlContainer.Margin = new Padding(3, 4, 3, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(553, 451);
            pnlContainer.TabIndex = 1;
            // 
            // rtbText
            // 
            rtbText.ContextMenuStrip = mnuContext;
            rtbText.Dock = DockStyle.Fill;
            rtbText.Location = new Point(0, 0);
            rtbText.Margin = new Padding(3, 4, 3, 4);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(553, 451);
            rtbText.TabIndex = 0;
            rtbText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 481);
            Controls.Add(pnlContainer);
            Controls.Add(mnuMainMenu);
            MainMenuStrip = mnuMainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_19";
            mnuMainMenu.ResumeLayout(false);
            mnuMainMenu.PerformLayout();
            mnuContext.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMainMenu;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem mnuFormat;
        private ToolStripMenuItem mnuFormatColor;
        private ToolStripMenuItem mnuFormatAllColors;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuFormatColorBlack;
        private ToolStripMenuItem mnuFormatColorBlue;
        private ToolStripMenuItem mnuFormatColorGreen;
        private ToolStripMenuItem mnuFormatColorRed;
        private ToolStripMenuItem mnuFormatFont;
        private ToolStripMenuItem mnuFormatFontAllFonts;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuFormatFontBold;
        private ToolStripMenuItem mnuFormatFontItalic;
        private ToolStripMenuItem mnuFormatFontUnderline;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem mnuHelpAbout;
        private OpenFileDialog dlgOpenFile;
        private SaveFileDialog dlgSaveFile;
        private FontDialog dlgFont;
        private ColorDialog dlgColor;
        private ContextMenuStrip mnuContext;
        private ToolStripMenuItem mnuContextCut;
        private ToolStripMenuItem mnuContextCopy;
        private ToolStripMenuItem mnuContextPaste;
        private Panel pnlContainer;
        private RichTextBox rtbText;
    }
}
