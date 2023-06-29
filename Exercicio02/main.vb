'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports Funcoes

Module Main

  Dim qlinha  As Integer = 2
  Dim qcoluna As Integer = 2

  Sub Main()
    
    Dim M(qlinha,qcoluna) As Integer
    Dim Mt(qlinha,qcoluna) As Integer
    Dim MResultado(qlinha,qcoluna) As Integer
    
    GerarMatrizAleatorios(M,qlinha,qcoluna)
    GerarMatrizTransposta(M,Mt,qlinha,qcoluna)
    'MResultado = {{1, 0, 0}, {0, 1, 0}, {0, 0, 1}}
    MResultado =  MultiplicacaoDeMatrizes(M,Mt,qlinha,qcoluna)
    if(ValidacaoOrtogonal(MResultado,qlinha,qcoluna))
      console.WriteLine("A Matriz e Ortogonal")
    else
      console.WriteLine("A Matriz nao e Ortogonal")
    End if
  
    for i As Integer = 0 To qlinha
      for j As Integer = 0 To qcoluna
        console.Write(M(i,j) & " ")
      Next
      console.WriteLine(" ")
    Next
  
    console.WriteLine("---------------------")
  
    for i As Integer = 0 To qlinha
      for j As Integer = 0 To qcoluna
        console.Write(Mt(i,j) & " ")
      Next
      console.WriteLine(" ")
    Next
  console.WriteLine("---------------------")
  for i As Integer = 0 To qlinha
      for j As Integer = 0 To qcoluna
        console.Write(MResultado(i,j) & " ")
      Next
      console.WriteLine(" ")
  Next

  
  End Sub

End Module