Imports System

Class Veelhoek
    Protected intHoeken As Integer

    Public Sub New(inthoeken As Integer)
        Me.intHoeken = inthoeken
    End Sub

    Public Overridable Sub AantalHoeken()
        Console.WriteLine("Ik heb " & intHoeken & " hoeken")
    End Sub
End Class

Class Vierhoek
    Inherits Veelhoek

    Public Sub New()
        MyBase.New(4)
    End Sub

    Public Overrides Sub AantalHoeken()
        Console.WriteLine("Ik heb 4 hoeken")
    End Sub
End Class

Module Program
    Sub Main(args As String())
        Dim objVierkant As New Vierhoek()
        objVierkant.AantalHoeken()
    End Sub
End Module
