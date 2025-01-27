'Rudy Earnest
'RCET 2265
'Spring 2025
'Program Flow
'github link
Option Explicit On
Option Strict On
Module programFlow

    Sub Main()
        Dim var As Integer

        'assign 5 to var
        var = 5

        If var > 6 Then
            Console.WriteLine(var > 6)
        End If
        If var > 3 Then
                Console.WriteLine(var > 3)
            End If
        If var > 4 Then
            Console.WriteLine(var > 4)
        End If

        If var > 6 Then
            Console.WriteLine(var > 6)
        ElseIf var > 3 Then
            Console.WriteLine(var > 3)
        ElseIf var > 4 Then
            Console.WriteLine(var > 4)
        End If

        var -= 3

        If var > 6 Then
            Console.WriteLine($"{var} is a big number")
        ElseIf var > 3 Then
            Console.WriteLine($"sorry not tall enough")
        ElseIf var > 4 Then
            Console.WriteLine($"who cares")
        Else
            Console.WriteLine($"Not sure what happened")
        End If

    End Sub

End Module
