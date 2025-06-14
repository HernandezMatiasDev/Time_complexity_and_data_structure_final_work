[Enunciado Final.pdf](https://github.com/user-attachments/files/20114166/Enunciado.Final.pdf)

Informe:

Nombre: Matías Hernández  
D.N.I: 45327037  
Carrera: Ingeniería en Informática  
Materia: Complejidad Temporal, Estructuras de Datos y Algoritmos


El método CrearArbol: Este método construye un árbol de decisión de forma recursiva. Si el clasificador indica que se trata de una hoja, se crea un nodo hoja con la predicción. En caso contrario, se genera un nodo de decisión con la pregunta y se generan recursivamente sus hijos izquierdo y derecho.
Para realizar este método no hubo mayor complicaciones que entender como usar las clases ya creadas.


El método Consulta1: Este método recorre el árbol en forma recursiva para localizar todos los nodos hoja. Si el nodo actual es una hoja, devuelve la predicción como texto. En caso contrario, continúa el recorrido por los hijos izquierdo y derecho y concatena sus resultados.
La implementación de este método como tal fue bastante sencilla, sin embargo no me gustaba el resultado obtenido:

![image](https://github.com/user-attachments/assets/27f9fdd5-cd10-4ea4-a3f2-309671fb5e06)

ya que este resultado dice después de cada nombre un 100% y esto es incorrecto, por eso quise arreglarlo, y que el número que aparezca sea la probabilidad real.
No encontré forma de arreglarlo dentro de la recursión, por eso cree un _Consulta1 que es exactamente igual a lo que hasta ahora era consulta1, y consulta1 llama  _consulta1 y aplica una función que coloca los porcentajes reales. Para el uso de la funcion consulta1 no implica ningún cambio, sin embargo el resultado es este:

![image](https://github.com/user-attachments/assets/9ed8b6d5-dd55-4423-a1e4-37a849f98eb7)
![image](https://github.com/user-attachments/assets/bcfa1dd9-7881-4be2-b0c6-68bec3b8825b)

El resultado no es exacto, ya que solo muestra la parte entera, pero es mucho más representativo que el 100%.


Consulta2 Este método recorrera el árbol desde la raíz hasta cada hoja, registrando las preguntas en el recorrido. Al llegar a una hoja, muestra ese camino junto con la predicción correspondiente.
No supe como realizar este método sin usar parámetros, por esto use la misma técnica que antes, y cree un _consulta2 que resuelve el problema. Tambien aplique algunas modificaciones a los textos obtenidos por las preguntas para mayoer legibilidad. Este método fue el que mas me costo de los 3 ya que estuve mucho tiempo intentando resolver sin crear _consulta2 ni usar parámetros adicionales

![image](https://github.com/user-attachments/assets/cdfeb39e-8f05-46fc-a6c1-3fb1a303f97c)


Consulta3 Este método realizará un recorrido por niveles y agrupa los datos de los nodos según el nivel en el que se encuentran dentro del árbol.
Este fue bastante sencillo, es una búsqueda por niveles normal usando una cola, la unica particularidad es que tengo que mostrar los datos de manera ordenada. Pero no tuvo mayor complicación que un desafío lógico. 

![image](https://github.com/user-attachments/assets/1b90c4fa-bc89-4896-b013-0b47c0e34f3f)


UML : ![image](https://github.com/user-attachments/assets/4db9dd90-df15-4c22-88ff-2c402c995a37)


Como mejora propongo mejorar la eficiencia de búsqueda, haciendo que el arbol binario este balanceado, si el arbol esta balanceado cada pregunta divide la cantidad de nodos posibles a la mitad o lo más cercano posible. De esta manera conseguimos tanto un método de búsqueda mucho más eficiente, sino que en términos del juego, esta es la estrategia que matemáticamente asegura una victoria la mayoría de veces.

Actualmente estas son las personas que están cuando inicio el juego:

![image](https://github.com/user-attachments/assets/c3e85890-555c-4b7c-8c19-e6294535060f)

son 21 personas. y esto pasa si respondo que sí a la primer pregunta

![image](https://github.com/user-attachments/assets/6e80cb7d-668a-42f7-88cd-3e1efde86ec3)

solo quedan 3 personas, claramente el arbol no esta balanceado. 
Para balancear el árbol mi primer intento fue usar avl, para esto modifique levemente la clase de árbol binario y cree una clase con una función static que recibe como parámetro un árbol y te lo devuelve balanceado con avl. Si bien se escribe muy rápido realizar estos cambios y funciones al código me tomó mucho tiempo. Tuve más problemas realizando el avl que en todas las consultas juntas.
Si bien después de mucho tiempo logré balancear el árbol con avl, al terminar me di cuenta que esto no funcionaba ya que rompió la lógica interna del árbol. Después de pensarlo detenidamente no encontré forma posible de reestructurar el árbol para balancearse sin perder la lógica. o por lo menos no sin saber las características de cada hoja. Es decir, solo se me ocurrió realizar un árbol completamente nuevo a partir de las características de las hojas, utilizando el dataset. 


