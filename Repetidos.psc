Algoritmo VerificarRepetido
    Definir numeros, i, j Como Entero
    Definir tieneRepetido Como Logico
    Dimension numeros[15]
    
    
    Para i <- 1 Hasta 15 Con Paso 1 Hacer
        Escribir "Ingrese el numero ", i, ":"
        Leer numeros[i]
    FinPara
    
    tieneRepetido <- Falso
    
    
    Para i <- 1 Hasta 14 Con Paso 1 Hacer
        Para j <- i + 1 Hasta 15 Con Paso 1 Hacer
            Si numeros[i] = numeros[j] Entonces
                tieneRepetido <- Verdadero
            FinSi
        FinPara
    FinPara
    
    
    Si tieneRepetido = Verdadero Entonces
        Escribir "Existe al menos un numero repetido."
    Sino
        Escribir "No hay numeros repetidos."
    FinSi
FinAlgoritmo
