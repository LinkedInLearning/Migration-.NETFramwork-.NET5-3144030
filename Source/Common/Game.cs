using System;

namespace MastermindCommon
{
    /// <summary>
    /// Description d'une partie de jeu à enregistrer.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Date et heure de la partie.
        /// </summary>
        public DateTime Recorded { get; set; } = DateTime.Now;

        /// <summary>
        /// Numéro de la partie en cours.
        /// </summary>
        public int NumberOfGame { get; set; } = 0;

        /// <summary>
        /// Nombre de bonnes couleurs trouvées.
        /// </summary>
        public int Good { get; set; } = 0;

        /// <summary>
        /// Nombre de mauvaises couleurs trouvées.
        /// </summary>
        public int Bad { get; set; } = 0;
    }
}
