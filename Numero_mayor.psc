Algoritmo BuscarMayor
    Definir numeros, i, mayor, posicion ComoEntero
    Dimensionar numeros[8]
    
   
    Para i <- 1 Hasta 8 Con Paso 1 Hacer
        Escribir "Ingrese el numero entero ", i, ":"
        Leer numeros[i]
    FinPara
    
   
    mayor <- numeros[1]
    posicion <- 1
    
    
    Para i <- 2 Hasta 8 Con Paso 1 Hacer
        Si numeros[i] > mayor Entonces
            mayor <- numeros[i]
            posicion <- i
        FinSi
    FinPara
    
    Escribir "El numero mayor del arreglo es: ", mayor
    Escribir "Se encuentra en la posicion: ", posicion
FinAlgoritmo
