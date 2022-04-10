using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenhas
{
    public class Gerador : IDisposable
    {

        public Gerador() {}

        public async Task<string> GerarSenhaAleatoria()
        {
            string gerada = "";
            while (gerada.Length < 12)
            {
                switch (await DesvioCase())
                {
                    case 1:
                        gerada += await SimbolosEspeciais().DecodeAscii();
                        break;
                    case 2:
                        gerada += await LetraMaiuscula().DecodeAscii();
                        break;
                    case 3:
                        gerada += await LetraMinuscula().DecodeAscii();
                        break;
                    case 4:
                        gerada += await Numero().DecodeAscii();
                        break;
                }
            }

            return gerada;
        }

        private async Task<int> SimbolosEspeciais() => await GerarNumeroAsync.nextAsync(33, 38);                

        private async Task<int> LetraMaiuscula() => await GerarNumeroAsync.nextAsync(65, 91);       

        private async Task<int> LetraMinuscula() => await GerarNumeroAsync.nextAsync(97, 123);

        private async Task<int> Numero() => await GerarNumeroAsync.nextAsync(48, 58);

        private async Task<int> DesvioCase() => await GerarNumeroAsync.nextAsync(1, 5);       
        
        public void Dispose() { }
    }

}
