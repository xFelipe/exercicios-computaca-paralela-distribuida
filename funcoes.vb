Module Funcoes


Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
    Randomize()
    return  Int((max * Rnd()) + min)
End Function

End Module