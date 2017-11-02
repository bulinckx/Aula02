using System.Collections.Generic;

namespace Aula02
{
    /// <summary>
    /// meu ovo
    /// </summary>
    public class PalindromoService
    {
        /// <summary>
        /// teste do rodrigão
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public bool IsPalindromo(string texto)
        {
            return texto == texto.Reverter();
        }

        /// <summary>
        /// lista a bagaça
        /// </summary>
        /// <param name="listaTexto"></param>
        /// <returns></returns>
        public List<string> ListarPalindromo(List<string> listaTexto)
        {
            var retorno = new List<string>();

            foreach (var item in listaTexto)
            {
               if (IsPalindromo(item.Reverter()))
                  retorno.Add(item);
            }

            return retorno;
        }
    }
}