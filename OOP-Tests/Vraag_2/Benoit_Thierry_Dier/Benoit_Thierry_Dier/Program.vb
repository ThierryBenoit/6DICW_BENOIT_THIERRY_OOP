Imports System

Public Class Dier
    Private naam As String
    Private leeftijd As Integer
    Private ziek As Boolean
    Private gewicht As Double
    Private aanwezig As Boolean

    Public Sub New(naam As String, leeftijd As Integer, ziek As Boolean, gewicht As Double)
        Me.naam = naam
        Me.leeftijd = leeftijd
        Me.ziek = ziek
        Me.gewicht = gewicht
        Me.aanwezig = False
    End Sub

    Public Sub ZetAanwezig(status As Boolean)
        aanwezig = status
    End Sub

    Public Function GeefAanwezig() As Boolean
        Return aanwezig
    End Function

    Public Function GeefNaam() As String
        Return naam
    End Function

    Public Function GeefLeeftijd() As Integer
        Return leeftijd
    End Function
End Class


Module Program
    Sub Main()
        Dim objDier As New Dier("Joske De Leeuw", 12, False, 280.2)

        objDier.ZetAanwezig(True)

        If objDier.GeefAanwezig() Then
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is aanwezig")
        Else
            Console.WriteLine("Dier met naam: " & objDier.GeefNaam() & " is niet aanwezig")
        End If

        Console.ReadLine()
    End Sub
End Module
