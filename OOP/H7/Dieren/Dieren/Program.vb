Imports System
Public Class Dier
    Protected IntKleur As Integer
    Protected Inteet As Integer
    Protected intslaap As Integer

    Public Sub New(kleur As Integer, inthoeveelheideten As Integer, IntSlaap As Integer)
        Me.IntKleur = kleur
        Me.Inteet = inthoeveelheideten
        Me.intslaap = IntSlaap
    End Sub



End Class

Class Hond
    Inherits Dier
    Private strBaasje As String
    Public Sub New(IntKleur As Integer, Inteet As Integer, intslaap As Integer, strBaasje As String)
        MyBase.New(IntKleur, Inteet, intslaap)
        Me.strBaasje = strBaasje
    End Sub
    Public Sub zetNaamHond()
        Dim dierNaam As String
        dierNaam = "Hond"
    End Sub
    Public Sub blaf()
        Console.WriteLine("Woef")
    End Sub
    Public Sub slaaphond()
        Console.WriteLine("De hond slaapt")
    End Sub
    Public Sub eethond()
        Console.WriteLine("De hond eet")
    End Sub

End Class
Class Leeuw
    Inherits Dier
    Private intGrootte As Integer
    Private intBrul As Integer
    Public Sub New(IntKleur As Integer, Inteet As Integer, intslaap As Integer, intGrootte As Integer, intBrul As Integer)
        MyBase.New(IntKleur, Inteet, intslaap)
        Me.intGrootte = intGrootte
        Me.intBrul = intBrul

    End Sub
    Public Sub zetNaamLeeuw()
        Dim dierNaam As String
        dierNaam = "Leeuw"
    End Sub
    Public Sub brul()
        Console.WriteLine("ROAR")
    End Sub
    Public Sub slaaplueew()
        Console.WriteLine("De leeuw slaapt")
    End Sub
    Public Sub eetleeuw()
        Console.WriteLine("De leeuw eet")
    End Sub

End Class





Module Program
    Sub Main(args As String())
        Dim mijnHond As New Hond(1, 5, 8, "Buddy")
        mijnHond.blaf()
        mijnHond.eethond()
        mijnHond.slaaphond()
        Dim mijnLeeuw As New Leeuw(2, 10, 12, 300, 5)
        mijnLeeuw.brul()
        mijnLeeuw.eetleeuw()
        mijnLeeuw.slaaplueew()
    End Sub
End Module
