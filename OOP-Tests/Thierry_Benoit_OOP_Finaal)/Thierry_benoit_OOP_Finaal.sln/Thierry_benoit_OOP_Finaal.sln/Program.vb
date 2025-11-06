Imports System

Class Bestelling
    Protected strKlantNaam As String
    Protected dblTotaalBedrag As Double
    Protected intVerzendKosten As Integer

    Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, intVerzendKosten As Integer)
        Me.strKlantNaam = strKlantNaam
        Me.dblTotaalBedrag = dblTotaalBedrag
        Me.intVerzendKosten = intVerzendKosten
    End Sub

    Public Function ToonbestellingsDetails()
        Console.WriteLine("Klant met de naam: " & strKlantNaam)
        Console.WriteLine("Totaal bedrag van de bestelling: " & dblTotaalBedrag)
    End Function
End Class


Class SnelleLevering
    Inherits Bestelling
    Protected dblSpoedToeslag As Double

    Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, intVerzendKosten As Integer, dblSpoedToeslag As Double)
        MyBase.New(strKlantNaam, dblTotaalBedrag, intVerzendKosten)
        Me.dblSpoedToeslag = dblSpoedToeslag
    End Sub

    Public Function BerekenVerzendkosten()
        Return intVerzendKosten + dblSpoedToeslag
    End Function
End Class


Class InternationaleBestelling
    Inherits Bestelling
    Protected strLand As String

    Public Sub New(strKlantNaam As String, dblTotaalBedrag As Double, intVerzendKosten As Integer, strLand As String)
        MyBase.New(strKlantNaam, dblTotaalBedrag, intVerzendKosten)
        Me.strLand = strLand
    End Sub

    Public Function BerekenDouaneKosten()
        Return (dblTotaalBedrag / 100 * 10)
    End Function

    Public Function BerekenVerzendkosten()
        Return intVerzendKosten + BerekenDouaneKosten()
    End Function
End Class


Public Class Verzending
    Protected basisKosten As Integer = 3

    Public Overridable Function BerekenVerzendKosten() As Integer
        Return basisKosten
    End Function
End Class


Public Class PakketVerzending
    Inherits Verzending

    Protected strPakketGrootte As String

    Public Sub New(strPakketGrootte As String)
        Me.strPakketGrootte = strPakketGrootte
    End Sub

    Public Overrides Function BerekenVerzendKosten() As Integer
        Dim kosten As Integer = basisKosten

        If strPakketGrootte = "klein" Then
            kosten = basisKosten
        ElseIf strPakketGrootte = "middelgroot" Then
            kosten = basisKosten + 2
        ElseIf strPakketGrootte = "groot" Then
            kosten = basisKosten + 5
        End If

        Return kosten
    End Function
End Class


Class Luchtpost
    Inherits Verzending
    Private dblLuchttarief As Double

    Public Sub New(dblLuchttarief As Double)
        Me.dblLuchttarief = dblLuchttarief
    End Sub

    Public Overridable Function BerekenVerzendKosten() As Double
        Return basisKosten + dblLuchttarief
    End Function

End Class


Module Program
    Sub Main(args As String())
        ' 1. Snelle levering printen
        Dim objSnelleLevering As New SnelleLevering("Jansen", 100, 5, 10)
        objSnelleLevering.ToonbestellingsDetails()
        Console.WriteLine("Totale verzendkosten zijn " & objSnelleLevering.BerekenVerzendkosten)
        Console.WriteLine("---")

        ' 2. Internationale bestelling printen
        Dim objInternationaal As New InternationaleBestelling("Martinez", 200, 8, "Frankrijk")
        objInternationaal.ToonbestellingsDetails()
        Console.WriteLine("duanekosten zijn: " & objInternationaal.BerekenVerzendkosten())
        Console.WriteLine("Totale verzendkosten zijn: " & objInternationaal.BerekenVerzendkosten())
        Console.WriteLine("---")

        ' 3. Pakketverzending printen
        Dim objPakket As New PakketVerzending("middelgroot")
        Console.WriteLine("Pakketverzending kosten voor pakket met grootte: middelgroot is: " & objPakket.BerekenVerzendKosten() & " euro")
        Console.WriteLine("---")

        ' 4. Luchtpost printen
        Dim objLucht As New Luchtpost(15)
        Console.WriteLine("Verzendkosten voor luchtpakket zijn: " & objLucht.BerekenVerzendKosten() & "euro")
        Console.WriteLine("---")
    End Sub
End Module

