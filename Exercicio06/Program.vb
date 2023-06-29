'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports System
Imports Funcoes
''' <summary>
''' 6) Considere um vetor com 20 números naturais maiores do que 1 lidos pelo teclado. Faça um algoritmo
''' recursivo que organize este vetor de modo que os números compostos fiquem nas primeiras posições e os
''' números que não são compostos nas últimas posições.
''' Crie e utilize duas funções: uma para preencher o vetor e outra recursivo para realizar a organização Do
''' mesmo.Crie e utilize também outra função para retornar 1, se um número natural For composto, ou retornar
''' 0, caso contrário.
''' Obs. 1: Um número natural C é composto se ele tem mais de dois divisores naturais distintos;
''' Obs. 2: Não é permitido utilizar qualquer estrutura de dados para auxiliar a organização;
''' Obs. 3: Não é permitido utilizar qualquer estrutura de repetição na função recursiva.
''' 
''' Para realizá-lo, basta dividir o número composto pelo menor número primo pelo qual ele é divisível,
''' tomar o resultado e repetir esse procedimento até que o resultado final seja igual a 1.
''' Todos os números que foram usados como divisores compõem juntos a forma fatorada Do número composto. Exemplo: 360.
''' </summary>

Module Program
    Sub Main(args As String())
        Dim qtdNumeros = 20 'Padrão: 20'
        Dim numeros(qtdNumeros) As Integer

        Console.WriteLine("Insira um total de {0} numeros", qtdNumeros)

        For i As Integer = 0 To qtdNumeros - 1
            numeros(i) = Console.ReadLine()
        Next

        Console.WriteLine("-------------------------------")

        OrdenarVetor(numeros, 0, 1)

        For i As Integer = 0 To qtdNumeros
            If eDecomposto(numeros(i)) = 1 Then
                Console.WriteLine("O nomero {0} é decomposto", numeros(i))
            Else
                Console.WriteLine("O nomero {0} é Não é decomposto", numeros(i))
            End If
        Next

    End Sub
End Module
