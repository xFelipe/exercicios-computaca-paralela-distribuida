'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports System
Imports Funcoes

Module Module1
    Sub Main()
        Dim vetor(19) As Integer ' Vetor para armazenar os números
        Console.WriteLine("Digite 10 números pares e 10 números ímpares, em qualquer ordem:")

        PreencherVetor(vetor) ' Preenche o vetor lendo os números do teclado

        OrganizarVetor(vetor) ' Organiza o vetor

        Console.WriteLine("Vetor organizado:")
        For i As Integer = 0 To 19
            Console.WriteLine(vetor(i))
        Next

        Console.ReadLine()
    End Sub

    
End Module