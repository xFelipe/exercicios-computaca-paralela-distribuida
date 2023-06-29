
'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira
Module Funcoes
  Sub PreencherVetor(ByRef vetor() As Integer)
        For i As Integer = 0 To 19
            vetor(i) = Convert.ToInt32(Console.ReadLine())
        Next
    End Sub

    Sub OrganizarVetor(ByRef vetor() As Integer)
        For i As Integer = 0 To 19
            If i Mod 2 = 0 AndAlso vetor(i) Mod 2 = 0 Then ' Posição par com número par
                Continue For ' Pula para a próxima iteração
            ElseIf i Mod 2 = 1 AndAlso vetor(i) Mod 2 = 1 Then ' Posição ímpar com número ímpar
                Continue For ' Pula para a próxima iteração
            Else
                ' Encontra a próxima posição adequada para o número atual
                Dim proximaPosicao As Integer = ProximaPosicaoAdequada(vetor, i)
                If proximaPosicao <> -1 Then
                    ' Troca os números de posição
                    Dim temp As Integer = vetor(i)
                    vetor(i) = vetor(proximaPosicao)
                    vetor(proximaPosicao) = temp
                End If
            End If
        Next
    End Sub

    Function ProximaPosicaoAdequada(ByVal vetor() As Integer, ByVal posicaoAtual As Integer) As Integer
        Dim valorAtual As Integer = vetor(posicaoAtual)

        For i As Integer = posicaoAtual + 1 To 19
            If posicaoAtual Mod 2 = 0 AndAlso vetor(i) Mod 2 = 0 Then ' Posição par com número par
                Return i
            ElseIf posicaoAtual Mod 2 = 1 AndAlso vetor(i) Mod 2 = 1 Then ' Posição ímpar com número ímpar
                Return i
            End If
        Next

        Return -1 ' Não encontrou posição adequada
    End Function
End Module