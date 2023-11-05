namespace MyKalender
{
    partial class KalenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KalenderForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            monthCalendar1 = new MonthCalendar();
            tabPage2 = new TabPage();
            LabelIstPositionY = new Label();
            LabelIstPositionX = new Label();
            label1FenstergrößeY = new Label();
            label1FenstergrößeX = new Label();
            label1Y = new Label();
            label1X = new Label();
            numericUpDown1Y = new NumericUpDown();
            numericUpDown1X = new NumericUpDown();
            helpProvider1 = new HelpProvider();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Y).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1X).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            helpProvider1.SetHelpKeyword(tabControl1, resources.GetString("tabControl1.HelpKeyword"));
            helpProvider1.SetHelpNavigator(tabControl1, (HelpNavigator)resources.GetObject("tabControl1.HelpNavigator"));
            helpProvider1.SetHelpString(tabControl1, resources.GetString("tabControl1.HelpString"));
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            helpProvider1.SetShowHelp(tabControl1, (bool)resources.GetObject("tabControl1.ShowHelp"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Controls.Add(monthCalendar1);
            helpProvider1.SetHelpKeyword(tabPage1, resources.GetString("tabPage1.HelpKeyword"));
            helpProvider1.SetHelpNavigator(tabPage1, (HelpNavigator)resources.GetObject("tabPage1.HelpNavigator"));
            helpProvider1.SetHelpString(tabPage1, resources.GetString("tabPage1.HelpString"));
            tabPage1.Name = "tabPage1";
            helpProvider1.SetShowHelp(tabPage1, (bool)resources.GetObject("tabPage1.ShowHelp"));
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(monthCalendar1, "monthCalendar1");
            helpProvider1.SetHelpKeyword(monthCalendar1, resources.GetString("monthCalendar1.HelpKeyword"));
            helpProvider1.SetHelpNavigator(monthCalendar1, (HelpNavigator)resources.GetObject("monthCalendar1.HelpNavigator"));
            helpProvider1.SetHelpString(monthCalendar1, resources.GetString("monthCalendar1.HelpString"));
            monthCalendar1.Name = "monthCalendar1";
            helpProvider1.SetShowHelp(monthCalendar1, (bool)resources.GetObject("monthCalendar1.ShowHelp"));
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Controls.Add(LabelIstPositionY);
            tabPage2.Controls.Add(LabelIstPositionX);
            tabPage2.Controls.Add(label1FenstergrößeY);
            tabPage2.Controls.Add(label1FenstergrößeX);
            tabPage2.Controls.Add(label1Y);
            tabPage2.Controls.Add(label1X);
            tabPage2.Controls.Add(numericUpDown1Y);
            tabPage2.Controls.Add(numericUpDown1X);
            helpProvider1.SetHelpKeyword(tabPage2, resources.GetString("tabPage2.HelpKeyword"));
            helpProvider1.SetHelpNavigator(tabPage2, (HelpNavigator)resources.GetObject("tabPage2.HelpNavigator"));
            helpProvider1.SetHelpString(tabPage2, resources.GetString("tabPage2.HelpString"));
            tabPage2.Name = "tabPage2";
            helpProvider1.SetShowHelp(tabPage2, (bool)resources.GetObject("tabPage2.ShowHelp"));
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // LabelIstPositionY
            // 
            resources.ApplyResources(LabelIstPositionY, "LabelIstPositionY");
            helpProvider1.SetHelpKeyword(LabelIstPositionY, resources.GetString("LabelIstPositionY.HelpKeyword"));
            helpProvider1.SetHelpNavigator(LabelIstPositionY, (HelpNavigator)resources.GetObject("LabelIstPositionY.HelpNavigator"));
            helpProvider1.SetHelpString(LabelIstPositionY, resources.GetString("LabelIstPositionY.HelpString"));
            LabelIstPositionY.Name = "LabelIstPositionY";
            helpProvider1.SetShowHelp(LabelIstPositionY, (bool)resources.GetObject("LabelIstPositionY.ShowHelp"));
            // 
            // LabelIstPositionX
            // 
            resources.ApplyResources(LabelIstPositionX, "LabelIstPositionX");
            helpProvider1.SetHelpKeyword(LabelIstPositionX, resources.GetString("LabelIstPositionX.HelpKeyword"));
            helpProvider1.SetHelpNavigator(LabelIstPositionX, (HelpNavigator)resources.GetObject("LabelIstPositionX.HelpNavigator"));
            helpProvider1.SetHelpString(LabelIstPositionX, resources.GetString("LabelIstPositionX.HelpString"));
            LabelIstPositionX.Name = "LabelIstPositionX";
            helpProvider1.SetShowHelp(LabelIstPositionX, (bool)resources.GetObject("LabelIstPositionX.ShowHelp"));
            // 
            // label1FenstergrößeY
            // 
            resources.ApplyResources(label1FenstergrößeY, "label1FenstergrößeY");
            helpProvider1.SetHelpKeyword(label1FenstergrößeY, resources.GetString("label1FenstergrößeY.HelpKeyword"));
            helpProvider1.SetHelpNavigator(label1FenstergrößeY, (HelpNavigator)resources.GetObject("label1FenstergrößeY.HelpNavigator"));
            helpProvider1.SetHelpString(label1FenstergrößeY, resources.GetString("label1FenstergrößeY.HelpString"));
            label1FenstergrößeY.Name = "label1FenstergrößeY";
            helpProvider1.SetShowHelp(label1FenstergrößeY, (bool)resources.GetObject("label1FenstergrößeY.ShowHelp"));
            label1FenstergrößeY.Click += label1FenstergrößeY_Click;
            // 
            // label1FenstergrößeX
            // 
            resources.ApplyResources(label1FenstergrößeX, "label1FenstergrößeX");
            helpProvider1.SetHelpKeyword(label1FenstergrößeX, resources.GetString("label1FenstergrößeX.HelpKeyword"));
            helpProvider1.SetHelpNavigator(label1FenstergrößeX, (HelpNavigator)resources.GetObject("label1FenstergrößeX.HelpNavigator"));
            helpProvider1.SetHelpString(label1FenstergrößeX, resources.GetString("label1FenstergrößeX.HelpString"));
            label1FenstergrößeX.Name = "label1FenstergrößeX";
            helpProvider1.SetShowHelp(label1FenstergrößeX, (bool)resources.GetObject("label1FenstergrößeX.ShowHelp"));
            label1FenstergrößeX.Click += label1FenstergrößeX_Click;
            // 
            // label1Y
            // 
            resources.ApplyResources(label1Y, "label1Y");
            helpProvider1.SetHelpKeyword(label1Y, resources.GetString("label1Y.HelpKeyword"));
            helpProvider1.SetHelpNavigator(label1Y, (HelpNavigator)resources.GetObject("label1Y.HelpNavigator"));
            helpProvider1.SetHelpString(label1Y, resources.GetString("label1Y.HelpString"));
            label1Y.Name = "label1Y";
            helpProvider1.SetShowHelp(label1Y, (bool)resources.GetObject("label1Y.ShowHelp"));
            // 
            // label1X
            // 
            resources.ApplyResources(label1X, "label1X");
            helpProvider1.SetHelpKeyword(label1X, resources.GetString("label1X.HelpKeyword"));
            helpProvider1.SetHelpNavigator(label1X, (HelpNavigator)resources.GetObject("label1X.HelpNavigator"));
            helpProvider1.SetHelpString(label1X, resources.GetString("label1X.HelpString"));
            label1X.Name = "label1X";
            helpProvider1.SetShowHelp(label1X, (bool)resources.GetObject("label1X.ShowHelp"));
            // 
            // numericUpDown1Y
            // 
            resources.ApplyResources(numericUpDown1Y, "numericUpDown1Y");
            helpProvider1.SetHelpKeyword(numericUpDown1Y, resources.GetString("numericUpDown1Y.HelpKeyword"));
            helpProvider1.SetHelpNavigator(numericUpDown1Y, (HelpNavigator)resources.GetObject("numericUpDown1Y.HelpNavigator"));
            helpProvider1.SetHelpString(numericUpDown1Y, resources.GetString("numericUpDown1Y.HelpString"));
            numericUpDown1Y.Maximum = new decimal(new int[] { 800, 0, 0, 0 });
            numericUpDown1Y.Name = "numericUpDown1Y";
            helpProvider1.SetShowHelp(numericUpDown1Y, (bool)resources.GetObject("numericUpDown1Y.ShowHelp"));
            numericUpDown1Y.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // numericUpDown1X
            // 
            resources.ApplyResources(numericUpDown1X, "numericUpDown1X");
            helpProvider1.SetHelpKeyword(numericUpDown1X, resources.GetString("numericUpDown1X.HelpKeyword"));
            helpProvider1.SetHelpNavigator(numericUpDown1X, (HelpNavigator)resources.GetObject("numericUpDown1X.HelpNavigator"));
            helpProvider1.SetHelpString(numericUpDown1X, resources.GetString("numericUpDown1X.HelpString"));
            numericUpDown1X.Maximum = new decimal(new int[] { 1700, 0, 0, 0 });
            numericUpDown1X.Name = "numericUpDown1X";
            helpProvider1.SetShowHelp(numericUpDown1X, (bool)resources.GetObject("numericUpDown1X.ShowHelp"));
            numericUpDown1X.Value = new decimal(new int[] { 400, 0, 0, 0 });
            // 
            // helpProvider1
            // 
            resources.ApplyResources(helpProvider1, "helpProvider1");
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // KalenderForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            helpProvider1.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
            helpProvider1.SetHelpNavigator(this, (HelpNavigator)resources.GetObject("$this.HelpNavigator"));
            helpProvider1.SetHelpString(this, resources.GetString("$this.HelpString"));
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KalenderForm";
            helpProvider1.SetShowHelp(this, (bool)resources.GetObject("$this.ShowHelp"));
            HelpButtonClicked += KalenderForm_HelpButtonClicked;
            FormClosed += KalenderForm_FormClosed;
            Load += KalenderForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Y).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1X).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1X;
        private Label label1FenstergrößeY;
        private Label label1FenstergrößeX;
        private Label label1Y;
        private Label label1X;
        private NumericUpDown numericUpDown1Y;
        protected HelpProvider helpProvider1;
        private Label LabelIstPositionY;
        private Label LabelIstPositionX;
        private System.Windows.Forms.Timer timer1;
    }
}