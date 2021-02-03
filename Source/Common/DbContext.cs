using Newtonsoft.Json;
using System;
using System.IO;

namespace MastermindCommon
{
    public class DbContext
    {
        /// <summary>
        /// Dossier d'enregistrement des fichiers.
        /// !!! Il doit exister et le terminer pas un "\".
        /// </summary>
        private readonly string GAME_PATH = @"C:\Temp\";

        /// <summary>
        /// Enregistrement des résultats d'une partie, 
        /// dans un fichier JSON.
        /// </summary>
        /// <param name="game"></param>
        public void SaveAsFile(Game game)
        {
            string json = JsonConvert.SerializeObject(game, Formatting.Indented);
            File.WriteAllText(GAME_PATH + $"{DateTime.Now:yyMMdd-HHmmss}-Mastermind.txt", json);
        }
    }
}
