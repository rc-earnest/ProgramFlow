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

        Do



            Console.WriteLine("Please enter your age: ")
            userInput = Console.ReadLine()
            Try
                var = CInt(userInput)
                Select Case var
                    Case 0 To 3
                        Console.WriteLine("Where are your parents?")
                    Case 4 To 10
                        Console.WriteLine("Sorry kid why don't you try the tea cups...")
                    Case 11 To 64
                        Console.WriteLine("Enjoy the Ride!")
                    Case 65 To 100
                        Console.WriteLine("Please sign this liability release form.")
                    Case > 100
                        Console.WriteLine("Someone misplaced their mama?!")
                    Case Else
                        Console.WriteLine("Well this is weird...")
                End Select

            Catch ex As Exception
                Console.WriteLine($"You entered {userInput}.")
            End Try

        Loop Until userInput = "Q"
        Console.WriteLine($"Have a nice day!")
    End Sub

End Module
