using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MastermindCommon
{
    public class DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DbContext> _logger;

        /// <summary>
        /// Dossier d'enregistrement des fichiers.
        /// !!! Il doit exister et le terminer pas un "\".
        /// </summary>
        private readonly string GAME_PATH;

        public DbContext(IConfiguration configuration, ILogger<DbContext> logger)
        {
            _configuration = configuration;
            _logger = logger;
            GAME_PATH = this.GetGamePath();
        }

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

        private string GetGamePath()
        {
            // Utilisation du fichier AppSettings.json 
            // à la place de la Registry, propre à Windows.
            var value = _configuration.GetSection("AppSettings:GamePath")?.Value ?? "";
            _logger.LogWarning("L'enregistrement des traces est dans le dossier " + value);

            //var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Mastermind");
            //var value = Convert.ToString(key?.GetValue("GamePath") ?? @"C:\Temp\");
            //key?.Close();

            return value;
        }

    }
}
