'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Module Funcoes
  
    Sub PreencherVetor(ByRef vetor() As Integer)
        Dim random As New Random()
        For i As Integer = 0 To 29
            vetor(i) = random.Next(1, 31) ' Gera um número aleatório entre 1 e 30
        Next
    End Sub

    Sub OrdenarVetor(ByRef vetor() As Integer)
        For i As Integer = 0 To vetor.Length - 1
            For j As Integer = i + 1 To vetor.Length - 1
                If vetor(j) > vetor(i) Then ' Compara os elementos adjacentes e realiza a troca se necessário
                    Dim temp As Integer = vetor(i)
                    vetor(i) = vetor(j)
                    vetor(j) = temp
                End If
            Next
        Next
    End Sub

    Sub ImprimirVetor(ByVal vetor() As Integer)
        For i As Integer = 0 To vetor.Length - 1
            Console.Write(vetor(i) & " ")
        Next
        Console.WriteLine()
    End Sub
End Module