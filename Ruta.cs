using System;
using tp1;
using tp2;
using System.Collections.Generic;

namespace tpfinal
{
    class Ruta
    {
        private List<(ArbolBinario<DecisionData> nodo, bool decision)> camino = new();
        private ArbolBinario<DecisionData> hoja;

        public List<(ArbolBinario<DecisionData> nodo, bool decision)> Camino
        {
            get => camino;
            set => camino = value;
        }

        public ArbolBinario<DecisionData> Hoja
        {
            get => hoja;
            set => hoja = value;
        }
    }

}