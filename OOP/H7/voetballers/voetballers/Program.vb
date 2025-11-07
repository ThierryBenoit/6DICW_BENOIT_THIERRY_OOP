Imports System

Class Voetballer
    Protected intNummer As Integer
    Protected intPostitie As Integer
    Protected strNaam As String
    Protected dblMassa As Double
    Public Sub New(intNummer As Integer, intPostitie As Integer, strNaam As String, dblMassa As Double)
        Me.intNummer = intNummer
        Me.intPostitie = intPostitie
        Me.strNaam = strNaam
        Me.dblMassa = dblMassa
    End Sub
    Public Overridable Sub Speel()
        Console.WriteLine("De voetballer speelt.")
    End Sub
End Class
Class Aanvaller
    Inherits Voetballer
    Public Sub New(strNaam As String, dblMassa As Double)
        MyBase.New(10, 10, strNaam, dblMassa)
    End Sub
    Public Overrides Sub Speel()
        Console.WriteLine("De aanvaller valt aan")
    End Sub
End Class
Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim objMessi As New Aanvaller("Lionel Messi", 72.0)
        objMessi.Speel()
    End Sub
End Module
