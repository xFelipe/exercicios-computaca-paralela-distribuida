'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports Funcoes

Module Exercicio07
	Sub Main()
      Dim maior As Integer = 0
      Dim tam As Integer = 50
			Dim v(tam) As Integer
      preencherVetor(v,tam)
      Dim mValor As Integer = maiorValor(v,tam,maior)
      For i As Integer = 1 To tam
        Console.WriteLine(v(i))
      Next
      Console.WriteLine("O maior valor encontrado no Vetor é: " + mValor.ToString())
	End Sub

End Module