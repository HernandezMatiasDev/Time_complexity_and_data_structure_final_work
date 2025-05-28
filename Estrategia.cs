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
			string camino = "";
			string lista_camino = "";

			return _Consulta2(arbol, camino, lista_camino);
		}
		public string _Consulta2(ArbolBinario<DecisionData> _arbol, string _camino, string _lista_camino)
		{
			_camino += _arbol.getDatoRaiz().ToString();

			if (_arbol.esHoja())
			{
				_lista_camino += _camino + "\n";
			}
			else
			{
				_lista_camino = _Consulta2(_arbol.getHijoIzquierdo(), _camino+ " → no → ", _lista_camino);
				_lista_camino = _Consulta2(_arbol.getHijoDerecho(), _camino+ " → Si → ", _lista_camino);
				_camino = _camino.Replace(_arbol.getDatoRaiz().ToString(),"");
			}
			return _lista_camino;
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