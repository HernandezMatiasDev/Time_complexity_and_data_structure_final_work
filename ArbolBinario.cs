using System;

namespace tp2
{
	public class ArbolBinario<T>
	{
		
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;

		private ArbolBinario<T> padre = null;

		private int altura = 0;
		
		public ArbolBinario(T dato)
		{
			this.dato = dato;
		}
		public ArbolBinario<T> getPadre()
		{
			return this.padre;
		}

		public void setPadre(ArbolBinario<T> nuevoPadre)
		{
			this.padre = nuevoPadre;
		}

		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}

		public void agregarHijoIzquierdo(ArbolBinario<T> hijo)
		{
			this.hijoIzquierdo = hijo;
			if (hijo != null) 
			{
				hijo.padre = this;
				this.PropagarAltura();
			}
		}

		public void agregarHijoDerecho(ArbolBinario<T> hijo)
		{
			this.hijoDerecho = hijo;
			if (hijo != null) 
			{
				hijo.padre = this;
				this.PropagarAltura();
			}
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
		}
		
		public void preorden() {
		}
		
		public void postorden() {
		}
		
		public void recorridoPorNiveles() {
		}
	
		public int contarHojas() {
			return 0;
		}
		
        public int Altura
        {
            get { return altura; }
        }
		private int getAltura(ArbolBinario<T> nodo)
		{
			return nodo == null ? -1 : nodo.altura;
		}

		private void setAltura()
		{
			this.altura = Math.Max(getAltura(this.hijoIzquierdo), getAltura(this.hijoDerecho)) + 1;
		}

		
		private void PropagarAltura()
		{
			ArbolBinario<T> nodo = this;
			while (nodo != null)
			{
				nodo.setAltura();
				nodo = nodo.padre;
			}
		}

		public void recorridoEntreNiveles(int n, int m)
		{
		}
	}
}
