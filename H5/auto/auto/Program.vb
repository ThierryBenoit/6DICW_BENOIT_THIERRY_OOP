Imports System

Public Class Auto
    Private bandenspanning As Double

    Public Sub New()
        bandenspanning = 5.0
        Console.WriteLine("Ik maak een nieuwe auto met banden van 5.0 bar!")
    End Sub

    Public Sub GaOpVakantie()
        Console.WriteLine("Lekker op vakantie in Puglia!")
        bandenspanning -= 1.0
    End Sub

    Public Sub PompBandenOp()
        Console.WriteLine("Pompen maar tot 5 bar opnieuw!")
        bandenspanning = 5.0
    End Sub

    Public Sub GeefStaatWagenWeer()
        Console.WriteLine("Bandendruk is (bar): " & bandenspanning.ToString("0"))
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim mijnAuto As New Auto()

        mijnAuto.GeefStaatWagenWeer()
        mijnAuto.GaOpVakantie()
        mijnAuto.GeefStaatWagenWeer()
        mijnAuto.PompBandenOp()
        mijnAuto.GeefStaatWagenWeer()

        Console.ReadLine()
    End Sub
End Module
