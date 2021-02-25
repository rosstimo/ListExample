Option Compare Text
Option Strict On
Option Explicit On
Module ListExample

    Sub Main()

        Dim names As New List(Of String)

        names.Add("Tim")
        names.Add("Joe")
        names.Add("Mary")
        names.Add("Joe")

        'names.Sort()
        'Console.WriteLine(names.IndexOf("Joe"))
        'Console.WriteLine(names.Item(2))

        names.Add("Frank")  'adds to end
        names.Insert(2, "Bob") 'insert Bob into index 2

        names.Remove("Joe") 'remove first occurrence of Joe 
        'names.RemoveAt(3) 'remove whatever is at index 3

        For Each name In names
            Console.WriteLine($"{name} is at index {names.IndexOf(name)}")
        Next

        Console.WriteLine(names.Count)
        Console.Read()
    End Sub

End Module
