using System;
using System.Collections.Generic;
using tp1;
using tp2;

namespace tpfinal
{

	class Estrategia
	{

	public String Consulta1(ArbolBinario<DecisionData> arbol)
		{
			if(arbol.esHoja())
			{
				return arbol.getDatoRaiz().ToString() + "\n"; 
			}

			string izquierdo = Consulta1(arbol.getHijoIzquierdo());
			string derecho = Consulta1(arbol.getHijoDerecho());

			return izquierdo + derecho;
		}

		public String Consulta2(ArbolBinario<DecisionData> arbol)
		{
			return "Implementar";
		}



		public String Consulta3(ArbolBinario<DecisionData> arbol)
		{
			string result = "Implementar";
			return result;
		}

		public ArbolBinario<DecisionData> CrearArbol(Clasificador clasificador)
		{

			if (clasificador.crearHoja())
			{
				return new ArbolBinario<DecisionData>(new DecisionData(clasificador.obtenerDatoHoja()));
			}

			ArbolBinario<DecisionData> nuevoArbol = new ArbolBinario<DecisionData>(new DecisionData(clasificador.obtenerPregunta()));
			nuevoArbol.agregarHijoIzquierdo(CrearArbol(clasificador.obtenerClasificadorIzquierdo()));
			nuevoArbol.agregarHijoDerecho(CrearArbol(clasificador.obtenerClasificadorDerecho()));
			return nuevoArbol;
		}

	}
}