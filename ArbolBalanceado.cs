using System;
using tp1;
using tp2;
using System.Collections.Generic;

namespace tpfinal
{
    class ArbolBalanceado
    {
        private static int FactorBalance(ArbolBinario<DecisionData> nodo)
        {
            if (nodo == null) return 0;

            int alturaIzq = nodo.getHijoIzquierdo() != null ? nodo.getHijoIzquierdo().Altura : 0;
            int alturaDer = nodo.getHijoDerecho() != null ? nodo.getHijoDerecho().Altura : 0;

            return alturaIzq - alturaDer;
        }

        private static ArbolBinario<DecisionData> RotarDerecha(ArbolBinario<DecisionData> y)
        {
            ArbolBinario<DecisionData> x = y.getHijoIzquierdo();
            ArbolBinario<DecisionData> T2 = x.getHijoDerecho();
            ReemplazarPadre(y, x);
            x.agregarHijoDerecho(y);
            y.agregarHijoIzquierdo(T2);

            return x;
        }

        private static ArbolBinario<DecisionData> RotarIzquierda(ArbolBinario<DecisionData> x)
        {
            ArbolBinario<DecisionData> y = x.getHijoDerecho();
            ArbolBinario<DecisionData> T2 = y.getHijoIzquierdo();
            ReemplazarPadre(x, y);
            y.agregarHijoIzquierdo(x);
            x.agregarHijoDerecho(T2);

            return y;
        }

        private static ArbolBinario<DecisionData> Rebalancear(ArbolBinario<DecisionData> nodo)
        {
            if (nodo == null) return null;

            int balance = FactorBalance(nodo);

            // Caso izquierda-izquierda
            if (balance > 1 && FactorBalance(nodo.getHijoIzquierdo()) >= 0)
                return RotarDerecha(nodo);

            // Caso izquierda-derecha
            if (balance > 1 && FactorBalance(nodo.getHijoIzquierdo()) < 0)
            {
                nodo.agregarHijoIzquierdo(RotarIzquierda(nodo.getHijoIzquierdo()));
                return RotarDerecha(nodo);
            }

            // Caso derecha-derecha
            if (balance < -1 && FactorBalance(nodo.getHijoDerecho()) <= 0)
                return RotarIzquierda(nodo);

            // Caso derecha-izquierda
            if (balance < -1 && FactorBalance(nodo.getHijoDerecho()) > 0)
            {
                nodo.agregarHijoDerecho(RotarDerecha(nodo.getHijoDerecho()));
                return RotarIzquierda(nodo);
            }

            return nodo; // No requiere rotación
        }

        public static ArbolBinario<DecisionData> RebalancearRecursivo(ArbolBinario<DecisionData> nodo)
        {
            if (nodo == null)
            {
                return null;
            }

            nodo.agregarHijoIzquierdo(RebalancearRecursivo(nodo.getHijoIzquierdo()));
            nodo.agregarHijoDerecho(RebalancearRecursivo(nodo.getHijoDerecho()));

            return Rebalancear(nodo);
        }
        private static void ReemplazarPadre(ArbolBinario<DecisionData> antiguo, ArbolBinario<DecisionData> nuevo)
        {
            ArbolBinario<DecisionData> padre = antiguo.getPadre();
            if (padre != null)
            {
                if (padre.getHijoIzquierdo() == antiguo)
                {
                    padre.agregarHijoIzquierdo(nuevo);
                }
                else if (padre.getHijoDerecho() == antiguo)
                {
                    padre.agregarHijoDerecho(nuevo);
                }
            }
            else
            {
                // nuevo debe ser la nueva raíz
                nuevo.setPadre(null);
            }
        }

        
    }
}