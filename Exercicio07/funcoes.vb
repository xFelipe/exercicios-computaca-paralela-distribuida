'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Module Funcoes
  Sub preencherVetor(ByRef v As Integer(), ByVal tam As Integer)
    Randomize()
    For i As Integer = 1 To tam
      v(i) = Int((100 * Rnd()) + 1)
    Next
  End Sub

  Function maiorValor(ByRef v As Integer(), ByVal tam As Integer, ByVal maior As Integer)
    If tam <=1  then
      If v(tam) < maior then
        Return maior
      Else
        Return v(tam)
      End If
    Else
      If v(tam) > maior then
        maior = v(tam)
      End If
      Return maiorValor(v,tam-1,maior)
    End If
  End Function
End Module