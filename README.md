[Enunciado Final.pdf](https://github.com/user-attachments/files/20114166/Enunciado.Final.pdf)

Informe:
Nombre: Matías Hernández
D.N.I: 45327037
Carrera: Ingeniería en Informática
Materia: Complejidad Temporal, Estructuras de Datos y Algoritmos



El método CrearArbol:
Este método construye un árbol de decisión de forma recursiva. Si el clasificador indica que se trata de una hoja, se crea un nodo hoja con la predicción. En caso contrario, se genera un nodo de decisión con la pregunta y se generan recursivamente sus hijos izquierdo y derecho.

 
El método Consulta1:
Este método recorre el árbol en forma recursiva para localizar todos los nodos hoja. Si el nodo actual es una hoja, devuelve la predicción como texto. En caso contrario, continúa el recorrido por los hijos izquierdo y derecho y concatena sus resultados.

Consulta2
Este método recorrera el árbol desde la raíz hasta cada hoja, registrando las preguntas en el recorrido. Al llegar a una hoja, muestra ese camino junto con la predicción correspondiente.

Consulta3
Este método realizara un recorrido por niveles y agrupa los datos de los nodos según el nivel en el que se encuentran dentro del árbol.


UML : ![image](https://github.com/user-attachments/assets/4db9dd90-df15-4c22-88ff-2c402c995a37)


Para mejorar el sistema cambiaría el orden en que el bot hace las preguntas para que no siempre siga la misma lógica. Se podría agregar un sistema de dificultad donde el usuario elija entre niveles fácil, medio o difícil, y en base a eso usar distintos tipos de árboles, algunos más y otros menos eficientes para encontrar el personaje.
	
