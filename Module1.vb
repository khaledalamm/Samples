Imports System.Console
Module Module1
    Sub Main()
        Dim i As Integer, l As Integer
        Write("l=")
        l = readline()
1:      i = i + 1
        Do Until i > l
            WriteLine("i=" & i)
            GoTo 1
        Loop
        ReadLine()

    End Sub

End Module
