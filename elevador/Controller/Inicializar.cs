using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using elevador.View;

namespace elevador.Controller
{
    internal class Inicializar
    {
        public int andarInicial = 0;
        public int andarAtual;
        public int andarTotal;
        public int capacidadeElevador = 4;
        internal static void Predios()
        {
            throw new NotImplementedException();
        }
        public static void Predio()
        {
            ViewMenu.Predio();
            Console.ReadKey();
        }
        public static void Elevador()
        {
            ViewMenu.Elevador();
            Console.ReadKey();
        }

        public int setAndarAtual(int andar) { return andarAtual=andar; }
        public int getAndarAtual() { return andarAtual; } 

        public int setTotalAndar(int andar) { return andarTotal = andar; }
        public int getTotalAndarAtual() { return andarTotal; } 

        public int getCapacidadeElevador() { return capacidadeElevador; } 
        public int setCapacidadeElevador(int capacidade) { return capacidadeElevador=capacidade; }


    }

}
