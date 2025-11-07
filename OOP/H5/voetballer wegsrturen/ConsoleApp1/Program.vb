Imports System

Class Voetballer
    Private aantalkaarten As Integer

    Public Sub New()
        aantalkaarten = 0
        Console.WriteLine("Moet ik naar de kleedkamer: SPELEN")
    End Sub

    Public Sub eersteKaart()
        aantalkaarten += 1
        Console.WriteLine("Ik geef een kaart")
    End Sub

    Public Sub tweedeKaart()
        aantalkaarten += 1
        Console.WriteLine("Ik geef nog een kaart")
    End Sub

    Public Sub kleedkamer()
        aantalkaarten = 2
        Console.WriteLine("Ik moet naar de kleedkamer: KLEEDKAMER")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim speler As New Voetballer()
        speler.eersteKaart()
        speler.tweedeKaart()
        speler.kleedkamer()

        Console.ReadLine()
    End Sub
End Module
