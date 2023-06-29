'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports Funcoes

Module Exercicio01
  Dim qlinha  As Integer = 3
  Dim qcoluna As Integer = 4

	Sub Main()

  dim M(3,4) as Integer

  GerarMatrizAleatorios(M,qlinha,qcoluna)

  if verificar(M,qlinha,qcoluna) = 1 then
    Console.WriteLine("Condição Satisfeita!")
  else
    Console.WriteLine("Condição Não Satisfeita!")
  end if

  Console.ReadLine()
  
	End Sub
End Module