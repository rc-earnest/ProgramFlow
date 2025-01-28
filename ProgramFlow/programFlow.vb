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
        Dim userInput As String
        ''assign 5 to var
        'var = 5

        'If var > 6 Then
        '    Console.WriteLine(var > 6)
        'End If
        'If var > 3 Then
        '        Console.WriteLine(var > 3)
        '    End If
        'If var > 4 Then
        '    Console.WriteLine(var > 4)
        'End If

        'If var > 6 Then
        '    Console.WriteLine(var > 6)
        'ElseIf var > 3 Then
        '    Console.WriteLine(var > 3)
        'ElseIf var > 4 Then
        '    Console.WriteLine(var > 4)
        'End If

        'var -= 3

        'If var > 6 Then
        '    Console.WriteLine($"{var} is a big number")
        'ElseIf var > 3 Then
        '    Console.WriteLine($"sorry not tall enough")
        'ElseIf var > 4 Then
        '    Console.WriteLine($"who cares")
        'Else
        '    Console.WriteLine($"Not sure what happened")
        'End If


        Console.WriteLine("Please enter your age: ")
        userInput = Console.ReadLine()
        var = CInt(userInput)

        Select Case var
            Case 0 To 3

            Case 4 To 10

            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else

        End Select
    End Sub

End Module
