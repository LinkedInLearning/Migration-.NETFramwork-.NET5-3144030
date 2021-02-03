using System;
using System.Collections.Generic;
using System.Linq;

namespace MastermindWinForms.Helpers
{
    /// <summary>
    /// Methodes d'extension sur IEnumerable
    /// </summary>
    public static class Extensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(i => Guid.NewGuid());
        }
    }
}
