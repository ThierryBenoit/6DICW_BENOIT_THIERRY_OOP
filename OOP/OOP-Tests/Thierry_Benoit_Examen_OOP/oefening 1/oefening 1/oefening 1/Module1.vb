Imports System.Runtime.InteropServices.WindowsRuntime

Module Module1
    'Maakt de klasse Deck aan
    Public Class Deck
        'Maakt de velden aan
        Private intaantalGepaseerdeKaarten As Integer
        Dim suits As String() = {"Harten", "Ruiten", "Schoppen", "Klaveren"}
        Private intHuidigeKaart As Integer
        Private intWelkeSuit As Integer
        'Constructor
        Public Sub New()
            intHuidigeKaart = 2
            intWelkeSuit = 1
            intaantalGepaseerdeKaarten = 0
        End Sub
        'Functie die returned wat er af geprint moet worden
        Private Function incrementCard() As String
            'Als intHuidigekaart groter is dan 1 en kleiner dan 11 returnt hij het nummer en de suits
            If intHuidigekaart > 1 And intHuidigekaart < 11 Then
                Return intHuidigekaart & " van " & suits(intWelkeSuit)
                'Als intHuidigekaart 11 is dan returnt hij boer van en de suits
            ElseIf intHuidigeKaart = 11 Then
                Return "Boer van " & suits(intWelkeSuit)
                'ALs intHuidigekaart 12 is dan returnt hij dame van de suits
            ElseIf intHuidigeKaart = 12 Then
                Return "Dame van " & suits(intWelkeSuit)
                'ALs intHuidigekaart 13 is dan returnt hij heer van de suits
            ElseIf intHuidigeKaart = 13 Then
                Return "Heer van " & suits(intWelkeSuit)
                'ALs intHuidigekaart 1 is dan returnt hij aas van de suits
            ElseIf intHuidigeKaart = 1 Then
                Return "Aas van " & suits(intWelkeSuit)

            End If
        End Function
        'Sub die zorgt wat er gereturnt is in incrementCard afgeprint word
        'doet huidigeKaart altijd 1 omhoog
        'doet intaantalgepaseerdeKaarten altijd 1 omhoog
        'Doet suit 1 omhoog als huidigekaart hoger is dan 13
        'print dat er geen kaarten meer zijn als er 64 kaarten zijn gepasseerd
        Public Sub ShowNextCard()
            Console.WriteLine(incrementCard)
            intHuidigeKaart = intHuidigeKaart + 1
            intaantalGepaseerdeKaarten = intaantalGepaseerdeKaarten + 1
            If intHuidigeKaart = 14 Then
                intHuidigeKaart = 1
                intWelkeSuit = intWelkeSuit + 1
            End If
            If intaantalGepaseerdeKaarten = 64 Then
                Console.WriteLine("Geen kaarten meer in deck!")
            End If
        End Sub
    End Class

    Sub Main()
        'Maakt een deck aan
        Dim MyDeck As New Deck()
        'Doet ShownextCard 15 keer
        For i As Integer = 1 To 15
            MyDeck.ShowNextCard()
        Next

    End Sub

End Module
