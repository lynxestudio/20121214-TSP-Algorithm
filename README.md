# Algoritmo Genético para el TSP (Traveling Salesman Problem) con C#

<p align="justify">
La computación evolutiva es una parte de la inteligencia artificial donde se agrupan diferentes técnicas adaptativas enfocadas a encontrar las mejores soluciones para resolver problemas de optimización, estas técnicas parten de una de las principales ideas que existen en la teoría de la evolución biológica propuesta por Charles Darwin, la selección natural es el proceso histórico de transformación de unas especies en otras especies descendientes e incluye la extinción de la gran mayoría de las especies que han existido, lo que es sin duda un problema de optimización además de que muchos de los términos que utiliza la computación evolutiva son tomados de la biología, con la advertencia de que se son usados para representar más o menos la misma idea biológica lo que no equivale a que sean iguales.
</p>
<p align="justify">
La computación evolutiva se compone por las siguientes técnicas:
<ol>
<li><b>Programación evolutiva:</b> Son una estrategia de optimización estocástica hacen un énfasis específico en los operadores genéticos tal y como se observan en la naturaleza.</li>
<li><b>Estrategias evolutivas:</b> Esta técnica esta básicamente enfocada hacia la optimización. En esencia son métodos estocásticos con paso adaptativo, que permiten resolver problemas. A este método se le han agregado procedimientos propios de la computación evolutiva, que lo han convertido en un paradigma más de dicha metodología.</li>
<li><b>Algoritmos genéticos:</b> Usan métodos que tienen analogía en la selección natural y la evolución.</li>
</ol>
Entre los usos de la computación evolutiva se encuentran la planificación, el diseño de sistemas, la simulación, el reconocimiento de patrones, el control y la clasificación de datos.</p>
<p align="justify">
La alternativa para una solución de problemas de planificación y de optimización donde la mayoría están se ubican dentro de la categoría de los problemas NP los cuales no pueden ser resueltos usando las técnicas convencionales y solo pueden ser atacados desde las técnicas de computación evolutiva donde el dominio de esos problemas le corresponden a los algoritmos genéticos <i>(John H. Holland, 1975)</i>
</p>
<p>
Como ejemplo de este tipo de aplicaciones me encontré en este <a href="http://www.heatonresearch.com">web site (http://www.heatonresearch.com)</a> un <a href="http://www.heatonresearch.com/articles/65/page1.html">Applet Java</a>, que utiliza algoritmos genéticos para obtener una solución optima al problema del agente viajero (Traveling Salesman Problem),  en el mismo web site el autor nos hace un resumen del problema.
</p>
<div>
<IMG src="images/fig0.png">
</div>
<p align="justify">
Pues bien como un ejercicio de aprendizaje, traduje el código del applet de Java  a  C# como un proyecto de  Monodevelop utilizando Winforms, a continuación algunas screenshots y el código fuente del proyecto. He de aclarar que debido a la falta de tiempo hice casi copia tal cuál del código, modificando las partes de Java que el compilador me marcaba como errores.i
</p>
<p>Inicio de la aplicación</p>
<div>
<IMG src="images/fig2.png">
</div>
<p>Aplicación en ejecucción</p>
<div>
<IMG src="images/fig3.png">
</div>
<p>Resultado de la aplicación</p>
<div>
<IMG src="images/fig4.png">
</div>
<p>En su <a href="http://www.heatonresearch.com/">web site</a> el autor <i>Jeff Heaton</i> además del código fuente del applet,  ofrece libros acerca de  inteligencia artificial y de programación con Java y C#.</p>
