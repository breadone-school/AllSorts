Module bubblesort
    Sub Main()
        ShowTitleScreen()
    End Sub


    Function GenerateRandomInt(ByRef bound As Integer) As Integer
        Dim rint As New Random
        Randomize()

        Return rint.Next

    End Function

    Sub ShowTitleScreen()
        Dim selection As Integer


        Dim bound, array(50) As Integer


        Console.Write("what be the bound for random nums: ")
        bound = Console.ReadLine

        For i As Integer = 0 To 50
            array(i) = GenerateRandomInt(bound)
            Console.Write(GenerateRandomInt(array(i) & ", "))
        Next

        Console.WriteLine()

        Console.WriteLine("1. efficient buble")
        Console.WriteLine("2. inefficiant bubbel (literally why)")
        Console.WriteLine("3. insert sort")

        Console.Write("what method of sorting would u like: ")
        selection = Console.ReadLine.ToString

        Select Case selection
            Case 1
                Call EfficientBubbleSort(array)
            Case 2
                Call InefficiantBubbleSort(array)
            Case 3
                Call insertsort(array)
                'Case 5
                'Call BinarySearch()
        End Select
    End Sub

    Sub EfficientBubbleSort(ByRef array() As Integer)
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

        If BSearch() = True Then
            Call BinarySearch(array)
        End If
    End Sub

    Sub InefficiantBubbleSort(ByRef array() As Integer)
        Dim rint As New Random
        Dim temp As Integer


        For i As Integer = 0 To 20
            If array(i) > array(i + 1) Then
                temp = array(i + 1)
                array(i + 1) = array(i)
            End If
        Next

        If BSearch() = True Then
            Call BinarySearch(array)
        End If
    End Sub

    Sub insertsort(ByRef array() As Integer)
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

        If BSearch() = True Then
            Call BinarySearch(array)
        End If
    End Sub

    Sub BinarySearch(ByVal array() As Integer)




    End Sub

    Function BSearch() As Boolean
        Console.Write("do u want to search or not (y/n): ")
        If Console.ReadLine = "y" Then
            Return True
        ElseIf Console.ReadLine = "n" Then
            Return False
        Else
            Console.Write("bruh")
            Return False
        End If
    End Function




End Module
