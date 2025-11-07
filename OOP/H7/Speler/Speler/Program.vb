Imports System

Class Speler
    Protected strNaam As String
    Protected intGetal As Integer
    Dim objRandom As New Random()

    Public Sub New(strNaam As String)
        Me.strNaam = strNaam
        Me.intGetal = objRandom.Next(0, 10)
    End Sub

    Public Overridable Sub TraptBal()
        Dim kans As Integer = objRandom.Next(0, 10)

        If kans > 5 Then
            Console.WriteLine(strNaam & " trapt... GOAAAL!")
        Else
            Console.WriteLine(strNaam & " trapt... mis.")
        End If
    End Sub
End Class

Class Aanvaller
    Inherits Speler
    Sub New(strNaam As String objRandom As Integer)
        MyBase.New(strNaam)
    End Sub
    Public Overrides Sub TraptBal()
        Dim kans As Integer = objRandom.Next(0, 10)

        If kans > 7 Then
            Console.WriteLine(strNaam & " trapt... GOAAAL!")
        Else
            Console.WriteLine(strNaam & " trapt... mis.")
        End If
    End Sub

End Class



Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
