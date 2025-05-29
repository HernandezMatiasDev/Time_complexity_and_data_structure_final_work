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

			int count = 0;
			foreach (string character in (izquierdo + derecho))
			{
				if (character == "%")
				{
					count++;
				}
			}
			if (count == 0)
			{
				count = 1;
			}
			return (izquierdo + derecho).Replace("100% ", $"{100 / cont}%");
		}


		public String Consulta2(ArbolBinario<DecisionData> arbol) 
		{
			return _Consulta2(arbol, "", "").Replace("== no?", "").Replace("== si?", "").Replace("{0}? == ", "").Replace("{0} ", "").Replace(":100% ", "");
		}
		private string _Consulta2(ArbolBinario<DecisionData> _arbol, string _camino, string _lista_camino)
		{
			_camino += _arbol.getDatoRaiz().ToString();

			if (_arbol.esHoja())
			{
				_lista_camino += _camino + "\n";
			}
			else
			{
				_lista_camino = _Consulta2(_arbol.getHijoIzquierdo(), _camino+ " → si → ", _lista_camino);
				_lista_camino = _Consulta2(_arbol.getHijoDerecho(), _camino+ " → no → ", _lista_camino);
			}
			return _lista_camino;
		}

	public String Consulta3(ArbolBinario<DecisionData> arbol)
	{
		Cola<ArbolBinario<DecisionData>> cola = new Cola<ArbolBinario<DecisionData>>();
		string resultado = "";

		List<ArbolBinario<DecisionData>> list = new List<ArbolBinario<DecisionData>>();
		int cont = 1;

		cola.encolar(arbol);

		while (!cola.esVacia())
		{
			resultado += $"\n nivel {cont}: \n";
			cont++;
			while (!cola.esVacia())
			{
				list.Add(cola.desencolar());
			}

			foreach (ArbolBinario<DecisionData> a in list)
			{
			resultado += a.getDatoRaiz() + " | ";
				if (!a.esHoja())
				{
				cola.encolar(a.getHijoIzquierdo());
				cola.encolar(a.getHijoDerecho());
				}
			}
			list = new List<ArbolBinario<DecisionData>>();
		}

	return resultado.Replace("== no?", "").Replace("== si?", "").Replace("{0}? == ", "").Replace("{0} ", "").Replace(":100% ", "");
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