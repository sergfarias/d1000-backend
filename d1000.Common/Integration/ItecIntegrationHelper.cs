using System;
using System.Collections.Generic;
using System.Text;

namespace d1000.Common.Integration
{

    /// <summary>
    /// Provê funções auxiliares de integração com o Itec
    /// </summary>
    public static class ItecIntegrationHelper
    {
        /// <summary>
        /// Criptografa um texto utilizando o algoritmo de cifragem do Itec.
        /// </summary>
        /// <param name="Texto">Texto a ser cifrado.</param>
        /// <returns></returns>
        public static string Cifrar(string Texto)
        {
            Texto = Texto.ToUpper();

            int[] Constantes = new int[] { -4, 6, 1, 7, 0, 2 };
            string Cifrado = "";
            int ix = 0;

            for (int i = 0; i < Texto.Length; i++, ix++)
            {
                int c = Encoding.ASCII.GetBytes(new char[] { Texto[i] })[0];
                Cifrado += ((char)(c + Constantes[ix])).ToString();

                if (ix == Constantes.Length - 1)
                    ix = -1;
            }

            return Cifrado;
        }

        /// <summary>
        /// Descriptografa um texto utilizando o algoritmo de cifragem do Itec.
        /// </summary>
        /// <param name="Texto">Texto a ser decifrado.</param>
        /// <returns></returns>
        public static string Decifrar(string Texto)
        {
            int[] Constantes = new int[] { -4, 6, 1, 7, 0, 2 };
            string Cifrado = "";
            int ix = 0;

            for (int i = 0; i < Texto.Length; i++, ix++)
            {
                int c = Encoding.ASCII.GetBytes(new char[] { Texto[i] })[0];
                Cifrado += ((char)(c - Constantes[ix])).ToString();

                if (ix == Constantes.Length - 1)
                    ix = -1;
            }

            return Cifrado;
        }

    }
}
