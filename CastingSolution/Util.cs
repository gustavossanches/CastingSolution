using System.Text.RegularExpressions;

namespace CastingSolution
{
    public static class Util
    {
        public static string SanitizarNomePasta(string nomePromotor)
        {
            string resultado = "";
            if (string.IsNullOrWhiteSpace(nomePromotor))
            {
                return "Promotor_sem_nome";
            }

            // 1. Remove acentos (preservando maiúsculas/minúsculas do original)
            resultado = Regex.Replace(nomePromotor, @"[áàãâä]", "a");
            resultado = Regex.Replace(resultado, @"[ÁÀÃÂÄ]", "A");
            resultado = Regex.Replace(resultado, @"[éèêë]", "e");
            resultado = Regex.Replace(resultado, @"[ÉÈÊË]", "E");
            resultado = Regex.Replace(resultado, @"[íìîï]", "i");
            resultado = Regex.Replace(resultado, @"[ÍÌÎÏ]", "I");
            resultado = Regex.Replace(resultado, @"[óòõôö]", "o");
            resultado = Regex.Replace(resultado, @"[ÓÒÕÔÖ]", "O");
            resultado = Regex.Replace(resultado, @"[úùûü]", "u");
            resultado = Regex.Replace(resultado, @"[ÚÙÛÜ]", "U");
            resultado = Regex.Replace(resultado, @"[ç]", "c");
            resultado = Regex.Replace(resultado, @"[Ç]", "C");
            resultado = Regex.Replace(resultado, @"[ñ]", "n");
            resultado = Regex.Replace(resultado, @"[Ñ]", "N");

            // 2. Troca espaços por underscore
            resultado = Regex.Replace(resultado, @"\s+", "_");

            // 3. Remove TUDO que não seja letra (A-Z, a-z) ou underline
            resultado = Regex.Replace(resultado, @"[^A-Za-z_]", "");

            // 4. Remove underlines duplos ou no início/fim
            resultado = Regex.Replace(resultado, @"_+", "_");
            resultado = resultado.Trim('_');

            // 5. Capitaliza cada palavra (Gustavo_Sanches)
            var textoInfo = new System.Globalization.CultureInfo("pt-BR").TextInfo;
            resultado = textoInfo.ToTitleCase(resultado.ToLower());

            return resultado;
        }

        public static void CriarDiretorio(string caminho)
        {   
            Directory.CreateDirectory(caminho);
        }
    }
}
