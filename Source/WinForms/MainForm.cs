using System;
using System.Linq;
using System.Windows.Forms;

namespace MastermindWinForms
{
    /// <summary>
    /// Plate-forme de jeu Mastermind.
    /// </summary>
    public partial class MainForm : Form
    {
        private MastermindCommon.DbContext _dbContext = new MastermindCommon.DbContext();

        /// <summary />
        public MainForm()
        {
            InitializeComponent();

            initialColors.Mode = BallContainerMode.InitialColor;

            this.Rows = new[] { Row0, Row1, Row2, Row3, Row4, Row5, Row6 };

            btnPlay_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Liste des 7 lignes de 4 couleurs.
        /// </summary>
        public BallContainer[] Rows { get; }

        /// <summary>
        /// Ligne de couleur en cours d'utilisation.
        /// -1 si le jeu n'a pas encore commencé.
        /// </summary>
        public int CurrentRow { get; set; } = -1;

        /// <summary>
        /// Démarrage du jeu ou vérification des 4 couleurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Tricher ?
            chkCheat_CheckedChanged(this, EventArgs.Empty);

            // Démarrage d'une nouvelle partie
            if (CurrentRow < 0)
            {
                btnPlay.Text = "Vérifier";
                initialColors.MixBalls();
                CurrentRow = 0;
                CleanAllRowsExceptFirstRow();
                return;
            }

            // Vérification des couleurs de la ligne en cours
            var result = CheckCurrentRowWithInitialColors();
            CurrentRow++;
            DisableAllRowsExcept(CurrentRow);

            // Fin de partie
            if (result.Good == 4)
            {
                MessageBox.Show("Félicitation, vous avez gagné.");
                CurrentRow = -1;    // Nouvelle partie
                btnPlay.Text = "Démarrer";
            }

            if (CurrentRow >= 7)
            {
                initialColors.Visible = true;
                MessageBox.Show("Désolé, vous avez perdu.");
                CurrentRow = -1;    // Nouvelle partie
                btnPlay.Text = "Démarrer";                
            }
        }

        /// <summary>
        /// Vérifie les couleurs initiales (choisies par l'ordinateur,
        /// avec les couleurs de l'utilisateur.
        /// </summary>
        private (int Good, int Bad) CheckCurrentRowWithInitialColors()
        {
            int good = 0;
            int bad = 0;

            var initial = initialColors.Balls.Select(ball => ball.Color).ToArray();
            var selected = Rows[CurrentRow].Balls.Select(ball => ball.Color).ToArray();

            // Calcule de la valeur Good
            for (int i = 0; i < selected.Length; i++)
            {
                if (selected[i] == initial[i])
                    good++;

                else if (selected.Contains(initial[i]))
                    bad++;
            }

            Rows[CurrentRow].Good = good;
            Rows[CurrentRow].Bad = bad;

            // Enregistrement d'une trace JSON avec les résultats trouvés.
            _dbContext.SaveAsFile(new MastermindCommon.Game()
            {
                Good = good,
                Bad = bad,
                NumberOfGame = CurrentRow
            });

            return (good, bad);
        }

        /// <summary>
        /// Désactive l'utilisation de toutes les lignes, 
        /// excepté la ligne active du jeu.
        /// </summary>
        /// <param name="rowIndex"></param>
        private void CleanAllRowsExceptFirstRow()
        {
            for (int i = 0; i < this.Rows.Length; i++)
            {
                this.Rows[i].Mode = BallContainerMode.Clean;
            }
            this.Rows[0].Mode = BallContainerMode.UserChoice;
        }

        /// <summary>
        /// Désactive l'utilisation de toutes les lignes, 
        /// excepté la ligne active du jeu.
        /// </summary>
        /// <param name="rowIndex"></param>
        private void DisableAllRowsExcept(int rowIndex)
        {
            for (int i = 0; i < this.Rows.Length; i++)
            {
                if (i == rowIndex)
                    this.Rows[i].Mode = BallContainerMode.UserChoice;
                else
                    this.Rows[i].Mode = BallContainerMode.Disabled;
            }
        }

        /// <summary>
        /// Active ou non la solution.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkCheat_CheckedChanged(object sender, EventArgs e)
        {
            initialColors.Visible = chkCheat.Checked;
        }
    }
}
