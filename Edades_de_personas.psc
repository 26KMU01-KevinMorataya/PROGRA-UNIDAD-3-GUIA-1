Algoritmo MayoresDeEdad
    Definir edades, i, contador ComoEntero
    Dimensionar edades[7]
    contador <- 0
    
    
    Para i <- 1 Hasta 7 Con Paso 1 Hacer
        Escribir "Ingrese la edad de la persona ", i, ":"
        Leer edades[i]
    FinPara
    
    
    Para i <- 1 Hasta 7 Con Paso 1 Hacer
        Si edades[i] >= 18 Entonces
            contador <- contador + 1
        FinSi
    FinPara
    
    Escribir "La cantidad de personas mayores de edad es: ", contador
FinAlgoritmo
