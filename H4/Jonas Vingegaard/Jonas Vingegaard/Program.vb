Imports System

Class Wielrenner
    Public intleeftijd As Integer
    Public strgeboorteplaats As String
    Public dougewicht As Double
    Public booouderDan25 As Boolean
    Public doulengte As Double
    Public inttimetrialPoints As Integer

    Public Sub New(intleeftijd As Integer, strgeboorteplaats As String, dougewicht As Double, booouderDan25 As Boolean, doulengte As Double, inttimetrialPoints As Integer)
        Me.intleeftijd = intleeftijd
        Me.strgeboorteplaats = strgeboorteplaats
        Me.dougewicht = dougewicht
        Me.booouderDan25 = booouderDan25    ' <-- vergeten in jouw versie
        Me.doulengte = doulengte
        Me.inttimetrialPoints = inttimetrialPoints
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim JonasVingegaard As New Wielrenner(26, "Denemarken", 60.0, True, 187.0, 95)
        Console.WriteLine("Leeftijd: " & JonasVingegaard.intleeftijd)
        Console.WriteLine("Geboorteplaats: " & JonasVingegaard.strgeboorteplaats)
        Console.WriteLine("Gewicht: " & JonasVingegaard.dougewicht & " kg")
        Console.WriteLine("Ouder dan 25: " & JonasVingegaard.booouderDan25)
        Console.WriteLine("Lengte: " & JonasVingegaard.doulengte & " cm")
        Console.WriteLine("Timetrial Punten: " & JonasVingegaard.inttimetrialPoints)
    End Sub
End Module

