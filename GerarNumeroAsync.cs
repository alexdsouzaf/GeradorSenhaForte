using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenhas
{
    public static class GerarNumeroAsync
    {
        private static readonly Random rand = new Random();
        public static async Task<int> nextAsync(int inicio, int fim) => await Task.Run(() => rand.Next(inicio, fim));
    }
}
