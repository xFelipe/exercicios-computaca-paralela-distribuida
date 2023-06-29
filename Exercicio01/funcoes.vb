'Componentes do Grupo: Elias Junior / Felipe Duarte / Lucas Pereira / Lucas Vieira

Module Funcoes

  Function randInt(ByVal min As Integer, ByVal max As Integer) As Integer
    Randomize()
    return  Int((max * Rnd()) + min)
  End Function
  
  Sub GerarMatrizAleatorios(ByRef M As Integer(,), ByVal qlinha As Integer, ByVal qcoluna As Integer)
    for i As Integer = 0 To qlinha
      for j As Integer = 0 To qcoluna
        M(i,j) = randInt(1,20)
        Console.WriteLine("{0}",M(i,j))
      Next
    Next
  End Sub
  
  Function verificar(ByRef M As Integer(,), ByVal qlinha As Integer, ByVal qcoluna As Integer)
    dim aux As Integer = 0
    dim min As Integer = 10000
    dim max As Integer = 0
    
    
    for j As Integer = 0 To qcoluna
      for i As Integer = 0 To qlinha
         aux = aux + M(i,j)
      next
      if min > aux then 
        min = aux
      end if
      aux = 0
    next
    
    aux = 1
    for i As Integer = 0 To qlinha
      for j As Integer = 0 To qcoluna
         aux = aux * M(i,j)
      next
      if max < aux then 
        max = aux
        
      end if
      aux = 1
    next  
    
    'console.writeline("{0}",max) verificar valor resultante max
    'console.writeline("{0}",min) verificar valor resultante min
  
    if (min) <= (max) then
      return 1
    end if
    
    return 0
  End Function
  
  End Module
End Module