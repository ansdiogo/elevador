using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using elevador.Controller;
using elevador.View;

namespace elevador.Model
{
    internal class Elevador
    {   
        public int Andares { get; set; }
        public string Predio { get; set; }

        public static void entrar(int numeroPessoasEntrando, int totalPessoas)
        {
            if ( numeroPessoasEntrando <= totalPessoas )
            {
                numeroPessoasEntrando++;
            }
            else
            {
                ViewMenu.Lotado();
            }
        }
        public static void sair(int numeroPessoasSaindo, int totalPessoas)
        {
            numeroPessoasSaindo--;
        }
        public static void subir(int andar, int ultimoAndar)
        {
            if (andar < ultimoAndar)
            {
                andar++;
            }
        }
        public static void descer(int andar)
        {
            if (andar >= 0)
            {
                andar--;
            }
        }
    }
}
