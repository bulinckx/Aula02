namespace Aula02
{
    public static class CustomExtension
    {
        public static string Reverter(this string texto)
        {
            var x = texto.ToCharArray();

            var retorno = string.Empty;

            for (int i = x.Length - 1; i >= 0; i--)
                retorno += x[i].ToString();

            return retorno;
        }
    }
}