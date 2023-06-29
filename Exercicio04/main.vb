'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports System

Module Module1
    Sub Main()
        Dim vetor(29) As Integer ' Vetor para armazenar os números
        Console.WriteLine("Vetor antes da ordenação:")
        PreencherVetor(vetor) ' Preenche o vetor com números aleatórios
        ImprimirVetor(vetor) ' Imprime o vetor antes da ordenação

        OrdenarVetor(vetor) ' Ordena o vetor em ordem não-crescente

        Console.WriteLine("Vetor após a ordenação:")
        ImprimirVetor(vetor) ' Imprime o vetor após a ordenação

        Console.ReadLine()
    End Sub

End Module