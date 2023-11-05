

namespace MyKalender
{
    public partial class KalenderForm : Form
    {
        public KalenderForm()
        {
            InitializeComponent();

            try
            {
                // Set the start position of the form to the center of the screen.
                // this.StartPosition = FormStartPosition.CenterScreen;

                this.StartPosition = FormStartPosition.Manual; // dem Programm sagen dass die Werte manuell kommen
                this.Location = new Point(Properties.Settings.Default.NumericUpDown1X, Properties.Settings.Default.NumericUpDown1Y); //Position setzen X und Y

                numericUpDown1X.Value = Properties.Settings.Default.NumericUpDown1X;// trage die Werte in die Nummernfelder ein
                numericUpDown1Y.Value = Properties.Settings.Default.NumericUpDown1Y;// trage die Werte in die Nummernfelder ein
            }
            catch
            {   // Falls keine Werte da sind, Zentriert und Werte setzen
                numericUpDown1X.Value = 400;
                numericUpDown1Y.Value = 300;
                this.StartPosition = FormStartPosition.CenterScreen;

            };

            FenstergroesseErmitteln(); // Programm starten
        }

        #region Fenster Gr��e ermitteln
        private void FenstergroesseErmitteln() // ermittelt die Fenstergr��e
        {
            int BildschrimWeite = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width; // Fenstergr��e Weite
            int BildschirmH�he = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height; // Fenstergr��e H�he

            label1Fenstergr��eX.Text = "max. Fensterbreite X: " + BildschrimWeite.ToString(); // zur Info damit man kein faalschen Werte eintr�gt
            label1Fenstergr��eY.Text = "max. Fensterh�he Y:  " + BildschirmH�he.ToString(); // zur Info damit man kein faalschen Werte eintr�gt

        }
        #endregion

        #region Mausposition
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            LabelIstPositionX.Text = Cursor.Position.X + " Aktuelle Mausposition X";
            LabelIstPositionY.Text = Cursor.Position.Y + " Aktuelle Mausposition Y";

        }
        #endregion

        # region Form Laden und Werte holen
        private void KalenderForm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.NumericUpDown1X = Convert.ToInt32(numericUpDown1X.Value);
            numericUpDown1X.Value = Properties.Settings.Default.NumericUpDown1X;
            // w�hrend des Ladens den Wert X holen

            Properties.Settings.Default.NumericUpDown1Y = Convert.ToInt32(numericUpDown1Y.Value);
            numericUpDown1Y.Value = Properties.Settings.Default.NumericUpDown1Y;
            // w�hrend des Ladens den Wert Y holen
        }
        #endregion

        #region Form schlie�en und Werte speichern
        private void KalenderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.NumericUpDown1X = Convert.ToInt32(numericUpDown1X.Value);
            // w�hrend des schlie�ens den Wert lesen
            Properties.Settings.Default.NumericUpDown1Y = Convert.ToInt32(numericUpDown1Y.Value);
            // w�hrend des schlie�ens den Wert lesen
            Properties.Settings.Default.Save(); // alles Speichern

        }
        #endregion

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }
        private void numericUpDown1X_ValueChanged(object sender, EventArgs e)
        {

        }
        private void numericUpDown1Y_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label1Fenstergr��eX_Click(object sender, EventArgs e)
        {

        }
        private void label1Fenstergr��eY_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void KalenderForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


    }
}