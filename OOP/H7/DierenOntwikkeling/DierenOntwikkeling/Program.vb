Imports System
Imports System.Security.Cryptography.X509Certificates

Class Salamander
    Protected intAantalPoten As Integer
    Protected intStaartlengteInCm As Integer
    Protected dblLongCapaciteiten As Double

    Public Sub New()
        Me.intAantalPoten = 4
        Me.intStaartlengteInCm = 6
        Me.dblLongCapaciteiten = 0.5
    End Sub
    Public Function GeefAantalPoten()
        Return intAantalPoten
    End Function
    Public Function GeefLongCapaciteit()
        Return dblLongCapaciteiten
    End Function
End Class

Class Tijger
    Inherits Salamander
    Protected strHaarKleur As String
    Public Sub New()
        MyBase.New()
        Me.intAantalPoten = 4
        Me.strHaarKleur = "Zwart"
    End Sub
    Public Function geefHaarKleur()
        Return strHaarKleur
    End Function
End Class

Class Mens
    Inherits Tijger
    Protected intAantalBenen As Integer
    Protected IntAantalArmen As Integer
    Public Sub New(intAantalArmen As Integer, intAantalBenen As Integer, strHaarkleur As String)
        MyBase.New()
        Me.intAantalPoten = 0
        Me.intStaartlengteInCm = 0
        Me.dblLongCapaciteiten = 7
        Me.intAantalBenen = intAantalBenen
        Me.IntAantalArmen = intAantalArmen
    End Sub
    Public Function GeefAantalArmenEnBenen()
        Return intAantalBenen
        Return IntAantalArmen
    End Function
End Class


Module Program
    Sub Main(args As String())
        Dim objSalamander As New Salamander
        Dim objTijger As New Tijger
        Dim ObjMens As New Mens(2, 2, "oranje")
        Console.WriteLine($"De salamander heeft {objSalamander.GeefAantalPoten()} poten")
        Console.WriteLine($"De Tijger heeft {objTijger.GeefAantalPoten()} poten")
        Console.WriteLine($"De Mens heeft {ObjMens.GeefAantalPoten()} poten")
        Console.WriteLine("")
        Console.WriteLine($"De Tijger heeft {objTijger.geefHaarKleur()} als haarkleur")
        Console.WriteLine($"De Mens heeft {ObjMens.geefHaarKleur()} als haarkleur")
        Console.WriteLine("")
        Console.WriteLine($"De Salamander heeft {objSalamander.GeefLongCapaciteit()} als longcapaciteit")
        Console.WriteLine($"De Tijger heeft {objTijger.GeefLongCapaciteit()} als longcapaciteit")
        Console.WriteLine($"De Mens heeft {ObjMens.GeefLongCapaciteit()} als longcapaciteit")
    End Sub
End Module
