'Seth Rasmussen
'RCET 265
'Spring 2022
'https://github.com/SethRas/SethRasm_Better_Calculator.git

Option Strict On
Option Explicit On
Option Compare Text

Module BetterCalculator

    Sub Main()

        Dim firstNumber As Double
        Dim input1 As Boolean = False
        Dim secondNumber As Double
        Dim input2 As Boolean = False
        Dim choice As Boolean = False
        Dim operationSelect As Double
        Dim userInput As String
        Dim exitt As Boolean = False

        Do Until exitt = True
            Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit.")
            Console.WriteLine("Choose a Number")

            Do While input1 = False
                Try
                    userInput = Console.ReadLine
                    firstNumber = CDbl(userInput)
                    Console.WriteLine("You entered" & firstNumber)
                    input1 = True

                Catch
                    If userInput = "Q" Then
                        input1 = True
                        exitt = True
                    Else
                        Console.WriteLine("You entered " & userInput)
                        Console.WriteLine("Please enter a Whole Number")
                        input1 = False
                    End If
                End Try
            Loop

            If exitt <> True Then
                Console.WriteLine("Choose a number.")
                Do While input2 = False
                    Try
                        userInput = Console.ReadLine()
                        secondNumber = CDbl(userInput)
                        Console.WriteLine("You entered " & secondNumber)
                        input2 = True
                    Catch
                        If userInput = "Q" Then
                            input2 = True
                            exitt = True
                        Else
                            Console.WriteLine("You entered " & userInput)
                            Console.WriteLine("Please enter a Whole Number")
                            input2 = False
                        End If
                    End Try
                Loop
                If exitt <> True Then
                    Console.WriteLine("Choose one of the following options:")
                    Console.WriteLine("1. Add")
                    Console.WriteLine("2. Subtract")
                    Console.WriteLine("3. Multiply")
                    Console.WriteLine("4. Divide")

                    Do While choice = False
                        Try
                            userInput = (Console.ReadLine())
                            operationSelect = CDbl(userInput)
                            If operationSelect = 1 Then
                                Console.WriteLine("You entered Add")
                                Console.WriteLine(firstNumber & "+" & secondNumber & "=" & firstNumber + secondNumber)
                                choice = True
                            ElseIf operationSelect = 2 Then
                                Console.WriteLine("You entered Subtract")
                                Console.WriteLine(firstNumber & "-" & secondNumber & "=" & firstNumber - secondNumber)
                                choice = True
                            ElseIf operationSelect = 3 Then
                                Console.WriteLine("You entered Multiply")
                                Console.WriteLine(firstNumber & "*" & secondNumber & "=" & firstNumber * secondNumber)
                                choice = True
                            ElseIf operationSelect = 4 Then
                                Console.WriteLine("You entered Divide")
                                Console.WriteLine(firstNumber & "/" & secondNumber & "=" & firstNumber / secondNumber)
                                choice = True
                            Else
                                choice = False
                                Console.WriteLine("Choose one of the following options:")
                                Console.WriteLine("1. Add")
                                Console.WriteLine("2. Subtract")
                                Console.WriteLine("3. Multiply")
                                Console.WriteLine("4. Divide")
                            End If

                        Catch ex As Exception
                            If userInput = "Q" Then
                                choice = True
                                exitt = True
                            Else
                                choice = False
                                Console.WriteLine("Choose one of the following options:")
                                Console.WriteLine("1. Add")
                                Console.WriteLine("2. Subtract")
                                Console.WriteLine("3. Multiply")
                                Console.WriteLine("4. Divide")
                            End If
                        End Try
                    Loop
                    input1 = False
                    input2 = False
                    choice = False
                End If
            End If
        Loop
        Console.WriteLine("You entered Q... Have a nice day")
        Console.WriteLine("Press Enter to close this window")
        Console.ReadLine()
    End Sub


End Module
