'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Imports System.Numerics

Module Funcoes

    Function eDecomposto(ByVal num As Integer) As Integer
        For divisor As Integer = 2 To num - 1
            If (num Mod divisor) = 0 Then
                'Console.WriteLine("Mod: {0}", (num Mod divisor))
                Return 1
            End If
        Next
        Return 0
    End Function


    Sub OrdenarVetor(ByRef vetor() As Integer, ByRef startPosition As Integer, ByRef endPosition As Integer)
        If startPosition > vetor.Length Or endPosition >= vetor.Length Then
            Return
        End If
        If eDecomposto(vetor(startPosition)) < eDecomposto(vetor(endPosition)) Then ' Compara os elementos adjacentes e realiza a troca se necessário
            Dim temp As Integer = vetor(startPosition)
            vetor(startPosition) = vetor(endPosition)
            vetor(endPosition) = temp
            OrdenarVetor(vetor, startPosition + 1, startPosition + 2)
            Return
        ElseIf eDecomposto(vetor(startPosition)) = 0 And eDecomposto(vetor(endPosition)) = 0 Then
            OrdenarVetor(vetor, startPosition, endPosition + 1)
            Return
        Else
            OrdenarVetor(vetor, startPosition + 1, startPosition + 2)
            Return
        End If
    End Sub

End Module