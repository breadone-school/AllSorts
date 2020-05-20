Module bubblesort
    Sub Main()
        ShowTitleScreen()
    End Sub


    Function GenerateRandomInt(ByRef bound As Integer) As Integer
        Dim rint As New Random
        Randomize()
        Return rint.Next(bound)
    End Function

    Sub ShowTitleScreen()
        Dim selection As Integer

        Console.WriteLine("1. generate random")
        Console.WriteLine("2. efficient buble")
        Console.WriteLine("3. inefficiant bubbel (literally why)")
        Console.WriteLine("4. insert sort")
        Console.WriteLine("5. VERY efficient sort")
        Console.Write("i canny bleive this")
        selection = Console.ReadLine.ToString

        Select Case selection
            Case 1
                Console.Write("what be the bound: ")
                Console.WriteLine(GenerateRandomInt(CInt(Console.ReadLine)))
            Case 2
                Call EfficientBubbleSort()
            Case 3
                Call InefficiantBubbleSort()
            Case 4
                Call insertsort()
            Case 5
                Call incrediblesort()
        End Select
    End Sub

    Sub EfficientBubbleSort()
        Dim intarr(20) As Integer
        Dim rint As New Random
        Dim sorted As Boolean = True
        Dim temp As Integer

        For i As Integer = 0 To 20
            intarr(i) = GenerateRandomInt(100)
        Next

        Do
            For i As Integer = 0 To 20
                sorted = True
                If intarr(i) > intarr(i + 1) Then
                    sorted = False
                    temp = intarr(i + 1)
                    intarr(i + 1) = intarr(i)
                End If
            Next
        Loop While sorted = False
    End Sub

    Sub InefficiantBubbleSort()
        Dim intarr(20) As Integer
        Dim rint As New Random
        Dim temp As Integer

        For i As Integer = 0 To 20
            intarr(i) = GenerateRandomInt(100)
        Next

        For i As Integer = 0 To 20
            If intarr(i) > intarr(i + 1) Then
                temp = intarr(i + 1)
                intarr(i + 1) = intarr(i)
            End If
        Next
    End Sub

    Sub insertsort()
        Dim intarr(20) As Integer
        Dim toInsert, currentitem As Integer

        For i As Integer = 1 To 21
            intarr(i) = GenerateRandomInt(100)
        Next

        For i As Integer = 2 To intarr.Length
            toInsert = intarr(i)
            currentitem = i - 1

            While intarr(currentitem) > toInsert And currentitem > 0
                intarr(currentitem + 1) = intarr(currentitem)
                currentitem -= 1
            End While

            intarr(currentitem + 1) = toInsert
        Next
    End Sub

    Sub incrediblesort()
        Dim array() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    End Sub






End Module
