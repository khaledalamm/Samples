Imports System.Console
Module module1

    Sub main()

        Dim i As Double, l As Double
        Write("l=")
        l = ReadLine()
1:      i = i + 1
        Dim n = i, k As Double
        k = (n * (n + 1) / 2)
        Do Until n > l
            WriteLine(k & "   " & n)

            GoTo 1
        Loop

        ReadLine()
    End Sub
End Module