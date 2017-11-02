using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Aula02
{
    /// <summary>
    /// mru ovo
    /// </summary>
    //[RoutePrefix("api/palindromo")]
    public class PalindromoController : ApiController
    {
        /// <summary>
        /// teste do controler do rodrigão
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Get/IsPalindromo/{texto}")]
        public bool GetIsPalindromo(string texto)
        {
            var palindromoService = new PalindromoService();

            return palindromoService.IsPalindromo(texto);
        }

        /// <summary>
        /// teste
        /// </summary>
        /// <param name="listaTexto"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Get/GetListarPalindromo")]
        //
        public List<string> GetListarPalindromo([FromUri]string[] listaTexto)
        {
            var palindromoService = new PalindromoService();

            if (listaTexto != null)
                return palindromoService.ListarPalindromo(listaTexto.ToList());
            else return null;
        }
    }
}