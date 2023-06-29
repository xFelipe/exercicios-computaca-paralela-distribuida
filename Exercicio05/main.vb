'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports Funcoes

Module Exercicio05
	Sub Main()
		Dim a,b As Integer
    Console.WriteLine("Digite o primeiro número:")
    a = Console.ReadLine()
    Console.WriteLine("Digite o segundo número:")
    b = Console.ReadLine()
    Dim result As Integer = funcaoRecursiva(a,b)
    Console.WriteLine("Resultado do primeiro número elevado ao segundo é: " + result.ToString())
	End Sub
End Module