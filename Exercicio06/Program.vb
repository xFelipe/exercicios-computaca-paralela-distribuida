'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports System
Imports Funcoes
''' <summary>
''' 6) Considere um vetor com 20 n�meros naturais maiores do que 1 lidos pelo teclado. Fa�a um algoritmo
''' recursivo que organize este vetor de modo que os n�meros compostos fiquem nas primeiras posi��es e os
''' n�meros que n�o s�o compostos nas �ltimas posi��es.
''' Crie e utilize duas fun��es: uma para preencher o vetor e outra recursivo para realizar a organiza��o Do
''' mesmo.Crie e utilize tamb�m outra fun��o para retornar 1, se um n�mero natural For composto, ou retornar
''' 0, caso contr�rio.
''' Obs. 1: Um n�mero natural C � composto se ele tem mais de dois divisores naturais distintos;
''' Obs. 2: N�o � permitido utilizar qualquer estrutura de dados para auxiliar a organiza��o;
''' Obs. 3: N�o � permitido utilizar qualquer estrutura de repeti��o na fun��o recursiva.
''' 
''' Para realiz�-lo, basta dividir o n�mero composto pelo menor n�mero primo pelo qual ele � divis�vel,
''' tomar o resultado e repetir esse procedimento at� que o resultado final seja igual a 1.
''' Todos os n�meros que foram usados como divisores comp�em juntos a forma fatorada Do n�mero composto. Exemplo: 360.
''' </summary>

Module Program
    Sub Main(args As String())
        Dim qtdNumeros = 20 'Padr�o: 20'
        Dim numeros(qtdNumeros) As Integer

        Console.WriteLine("Insira um total de {0} numeros", qtdNumeros)

        For i As Integer = 0 To qtdNumeros - 1
            numeros(i) = Console.ReadLine()
        Next

        Console.WriteLine("-------------------------------")

        OrdenarVetor(numeros, 0, 1)

        For i As Integer = 0 To qtdNumeros
            If eDecomposto(numeros(i)) = 1 Then
                Console.WriteLine("O nomero {0} � decomposto", numeros(i))
            Else
                Console.WriteLine("O nomero {0} � N�o � decomposto", numeros(i))
            End If
        Next

    End Sub
End Module
