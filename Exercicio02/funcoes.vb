'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Module Funcoes
  Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
      Randomize()
      return  Int((max * Rnd()) + min)
  End Function
  
  Sub GerarMatrizAleatorios(ByRef M As Integer(,), ByVal qlinha As Integer, ByVal qcoluna As Integer)
      for i As Integer = 0 To qlinha
          for j As Integer = 0 To qcoluna
            M(i,j) = randInt(0,29)
          Next
      Next
      
  End Sub

  Sub GerarMatrizTransposta(ByRef M As Integer(,),ByRef Mt As Integer(,), ByVal qlinha As Integer, ByVal qcoluna As Integer)
    Dim i,j As Integer
  
    for i  = 0 To qlinha
        for j = 0 To qcoluna
          Mt(i,j) = M(j,i)
        Next
    Next
  End Sub

  Function MultiplicacaoDeMatrizes(ByRef M As Integer(,), ByRef Mt As Integer(,), ByVal qlinha As Integer, ByVal qcoluna As Integer)
        Dim matrizResultado(qlinha, qcoluna) As Integer

        For i As Integer = 0 To qlinha
            For j As Integer = 0 To qcoluna
                matrizResultado(i, j) = 0
                For k As Integer = 0 To qlinha
                    matrizResultado(i, j) += M(i, k) * Mt(k, j)
                Next
            Next
        Next

        Return matrizResultado
    End Function

  Function ValidacaoOrtogonal(ByRef MResultado As Integer(,), ByVal qlinha As Integer, ByVal qcoluna As Integer)
    For i As Integer = 0 To qlinha
      For j As Integer = 0 To qcoluna
        If (i = j AndAlso MResultado(i, j) <> 1) OrElse (i <> j AndAlso MResultado(i, j) <> 0) Then
         Return False ' A matriz não possui os elementos corretos para uma matriz identidade
        End If
      Next
    Next
        Return True ' A matriz é uma matriz identidade
  End Function


End Module