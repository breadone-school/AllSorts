Module Module1

    Dim array(50) As Integer

    Sub Main()
        Call ShowTitleScreen()
    End Sub


    Function GenerateRandomInt(ByRef bound As Integer) As Integer
        Dim rint As New Random
        Dim rrint As Integer
        Randomize()

        Return Int(Rnd() * bound) + 1

    End Function

    Sub ShowTitleScreen()
        Dim selection As Integer
        Dim bound As Integer

        Console.Write("what be the bound for random nums: ")
        bound = Console.ReadLine

        For i As Integer = 0 To 50
            array(i) = GenerateRandomInt(bound)
            Console.Write(GenerateRandomInt(array(i)) & ", ")
        Next

        Console.WriteLine()

        Console.WriteLine("1. efficient buble")
        Console.WriteLine("2. inefficient bubble")
        Console.WriteLine("3. insert")

        Console.Write("what method of sorting would u like: ")
        selection = Console.ReadLine.ToString

        Select Case selection
            Case 1
                Call EfficientBubbleSort()
            Case 2
                Call InefficiantBubbleSort()
            Case 3
                Call insertsort()
        End Select
    End Sub

    Sub EfficientBubbleSort()
        Dim rint As New Random
        Dim sorted As Boolean = True
        Dim temp As Integer

        Do
            For i As Integer = 0 To 20
                sorted = True
                If array(i) > array(i + 1) Then
                    sorted = False
                    temp = array(i + 1)
                    array(i + 1) = array(i)
                End If
            Next
        Loop While sorted = False

        Call BSearch()
    End Sub

    Sub InefficiantBubbleSort()
        Dim rint As New Random
        Dim temp As Integer


        For i As Integer = 0 To 20
            If array(i) > array(i + 1) Then
                temp = array(i + 1)
                array(i + 1) = array(i)
            End If
        Next
        Call BSearch()
    End Sub

    Sub insertsort()
        Dim toInsert, currentitem As Integer


        For i As Integer = 2 To array.Length
            toInsert = array(i)
            currentitem = i - 1

            While array(currentitem) > toInsert And currentitem > 0
                array(currentitem + 1) = array(currentitem)
                currentitem -= 1
            End While

            array(currentitem + 1) = toInsert
        Next
        Call BSearch()
    End Sub

    Sub BinarySearch(ByRef searchitem As String)
        Dim found As Boolean = False
        Dim searchFailed As Boolean = False

        Dim first As Integer = 0
        Dim middle As Integer
        Dim last As Integer = array.Length

        While found = False And searchFailed = False
            middle = (first + last) / 2
            If array(middle) = searchitem Then
                found = True
            ElseIf first >= last Then
                searchFailed = True
            ElseIf array(middle) > searchitem Then
                last = middle - 1
            Else
                first = middle + 1
            End If
        End While

        If found = True Then
            Console.Write(middle)
            Console.ReadKey()
        Else
            Console.Write("oops")
            Console.ReadKey()
        End If

    End Sub

    Sub BSearch()
        Console.Write("do u want to search or not (y/n): ")
        If Console.ReadLine = "y" Then
            Console.Write("what to search: ")
            Dim search As String = Console.ReadLine

            Call BinarySearch(search)
        End If
    End Sub




End Module
