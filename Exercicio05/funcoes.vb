'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Module Funcoes
  Function funcaoRecursiva(ByVal a As Integer, ByVal b As Integer) As Integer
    If b >= 1 Then
      return a * funcaoRecursiva(a,b-1)
    Else
      return 1
    End If
  End Function
End Module