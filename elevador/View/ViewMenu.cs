using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevador.View
{
    internal class ViewMenu
    {
        public static void Predio()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine(" Vamos inicializar as configurações do seu prédio");
            Console.WriteLine("Quantos Andares possui o seu prédio?");

        }

        public static void CapacidadeElevador()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine(" Qual a capacidade do Elevador?");

        }
        internal static void Elevador()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine(" Você deseja entrar no Elevador?");
        }
        internal static void Andar()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine(" Você ir a qual andar?");
        }
        internal static void Lotado()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine(" Elevador Lotado!");
            Console.WriteLine("##################################################");
        }
    }
}
