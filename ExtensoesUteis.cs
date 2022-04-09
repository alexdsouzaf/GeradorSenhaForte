using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenhas
{
    public static class ExtensoesUteis
    {
        public static async Task<char> DecodeAscii(this Task<int> i) => await Task.Run(async () => Convert.ToChar(await i));
    }
}
