using MastermindWpf.Helpers;
using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace MastermindWpf
{
    /// <summary>
    /// Support contenant 4 boules
    /// </summary>
    public partial class BallContainer : UserControl
    {
        private int? _good = null;
        private int? _bad = null;
        private BallContainerMode _mode;

        public EventHandler<Color> ColorSelected;

        /// <summary>
        /// Initialise une nouvelle instance d'un support de jeu.
        /// </summary>
        public BallContainer()
        {
            InitializeComponent();

            this.Balls = new[] { ball1, ball2, ball3, ball4 };
            this.Mode = BallContainerMode.Disabled;
        }

        /// <summary>
        /// Liste des 4 boules présentes sur ce support (container).
        /// </summary>
        public Ball[] Balls { get; }

        /// <summary>
        /// Type de container : inactif, couleurs initiales ou choix de l'utilisateur.
        /// </summary>        
        public BallContainerMode Mode
        {
            get { return _mode; }
            set
            {
                switch (value)
                {
                    case BallContainerMode.InitialColor:
                        ball1.Color = Colors.Red;
                        ball2.Color = Colors.Blue;
                        ball3.Color = Colors.Yellow;
                        ball4.Color = Colors.Green;

                        foreach (var ball in this.Balls)
                        {
                            ball.DragDropTarget = DragDropTarget.Source;
                        }

                        break;

                    case BallContainerMode.Disabled:
                        foreach (var ball in this.Balls)
                        {
                            ball.DragDropTarget = DragDropTarget.Disabled;
                        }
                        break;

                    case BallContainerMode.Clean:
                        foreach (var ball in this.Balls)
                        {
                            ball.Color = Colors.White;
                            ball.DragDropTarget = DragDropTarget.Disabled;
                        }
                        break;

                    case BallContainerMode.UserChoice:
                        foreach (var ball in this.Balls)
                        {
                            ball.Color = Colors.White;
                            ball.DragDropTarget = DragDropTarget.Target;
                        }
                        break;
                }

                if (value == BallContainerMode.UserChoice)
                    this.Background = new SolidColorBrush(Colors.LightGray);
                else
                    this.Background = new SolidColorBrush(Colors.Transparent);

                if (value == BallContainerMode.Clean ||
                    value == BallContainerMode.InitialColor)
                {
                    this.Good = null;
                    this.Bad = null;
                }

                if (_mode != value)
                    this.Refresh();

                _mode = value;
            }
        }

        /// <summary>
        /// Nombre de couleurs bien placées.
        /// </summary>
        public int? Good
        {
            get { return _good; }
            set
            {
                _good = value;
                lblGood.Text = Convert.ToString(value);
            }
        }


        /// <summary>
        /// Nombre de couleurs existantes mais mal placées.
        /// </summary>
        public int? Bad
        {
            get { return _bad; }
            set
            {
                _bad = value;
                lblBad.Text = Convert.ToString(value);
            }
        }

        /// <summary>
        /// Mélange les couleurs des boules aléatoirement.
        /// </summary>
        public void MixBalls()
        {
            if (this.Mode != BallContainerMode.InitialColor)
                throw new ArgumentException("Cet objet n'est pas de type InitialColor");

            var rnd = new Random();
            var colors = this.Balls
                             .Select(ball => ball.Color)
                             .Randomize()
                             .ToArray();

            for (int i = 0; i < colors.Length; i++)
            {
                this.Balls[i].Color = colors[i];
            }

            this.Refresh();
        }

        /// <summary>
        /// Rafraichit les composants de l'interface graphique
        /// </summary>
        private void Refresh()
        {
            this.InvalidateVisual();
            foreach (var ball in this.Balls)
            {
                ball.InvalidateVisual();
            }
        }

    }

    /// <summary />
    public enum BallContainerMode
    {
        /// <summary />
        Clean,
        /// <summary />
        InitialColor,
        /// <summary />
        UserChoice,
        /// <summary />
        Disabled
    }
}
