Imports System

Class Wielrenner
    ' Private velden
    Private intleeftijd As Integer
    Private strgeboorteplaats As String
    Private dougewicht As Double
    Private booouderDan25 As Boolean
    Private doulengte As Double
    Private inttimetrialPoints As Integer
    Public Sub New(intleeftijd As Integer, strgeboorteplaats As String, dougewicht As Double, booouderDan25 As Boolean, doulengte As Double, inttimetrialPoints As Integer)
        Me.intleeftijd = intleeftijd
        Me.strgeboorteplaats = strgeboorteplaats
        Me.dougewicht = dougewicht
        Me.booouderDan25 = booouderDan25
        Me.doulengte = doulengte
        Me.inttimetrialPoints = inttimetrialPoints
    End Sub
    Public Function GetLeeftijd() As Integer
        Return intleeftijd
    End Function

    Public Function GetGeboorteplaats() As String
        Return strgeboorteplaats
    End Function

    Public Function GetGewicht() As Double
        Return dougewicht
    End Function

    Public Function GetOuderDan25() As Boolean
        Return booouderDan25
    End Function

    Public Function GetLengte() As Double
        Return doulengte
    End Function

    Public Function GetTimetrialPoints() As Integer
        Return inttimetrialPoints
    End Function
End Class

Module Program
    Sub Main(args As String())
        Dim JonasVingegaard As New Wielrenner(26, "Denemarken", 60.0, True, 187.0, 95)
        Console.WriteLine("Leeftijd: " & JonasVingegaard.GetLeeftijd())
        Console.WriteLine("Geboorteplaats: " & JonasVingegaard.GetGeboorteplaats())
        Console.WriteLine("Gewicht: " & JonasVingegaard.GetGewicht() & " kg")
        Console.WriteLine("Ouder dan 25: " & JonasVingegaard.GetOuderDan25())
        Console.WriteLine("Lengte: " & JonasVingegaard.GetLengte() & " cm")
        Console.WriteLine("Timetrial Punten: " & JonasVingegaard.GetTimetrialPoints())
    End Sub
End Module


