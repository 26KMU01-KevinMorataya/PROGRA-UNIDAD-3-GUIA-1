Algoritmo Ejemplo2_ARREGLOS
	//Problema solicitar 6 notas a un estudiante x de IVC del curso de programación
	Definir notas Como Entero
    dimension notas[6]
	
	Para i=1 Hasta 6 Con Paso 1 Hacer
		Escribir Sin Saltar "Dame la nota 1: ",i , ": "
		Leer notas[i]
	Fin Para
	
	//Mostrar los valores del arreglo
	Para i=1 Hasta 6 Con Paso 1 Hacer
		Escribir Sin Saltar notas[i], " - "
	Fin Para
	
	
FinAlgoritmo
