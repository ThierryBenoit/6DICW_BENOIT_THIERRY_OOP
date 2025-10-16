Imports System

Class kasteel
    Private strName As String
    Private intRidders As Integer
    'zet de naam van de koning bij het aanmaken van een kasteel'
    Public Sub New()
        strName = VerkiesKoning()
    End Sub

    'Kiest de koning met de langste naam'
    'Zet een bepaald aantal ridders voor elke koning'
    Public Function VerkiesKoning() As String
        Dim strkoning1 = "Arthur"
        Dim strkoning2 = "Lancelot"
        If Len(strkoning1) > Len(strkoning2) Then
            setRidders(10)
            Return strkoning1
        Else
            setRidders(37)
            Return strkoning2

        End If
    End Function
    'geeft de koning een aantal ridders'
    Public Sub setRidders(intAantal As Integer)
        Me.intRidders = intAantal
    End Sub
    'geeft de naam van de koning'
    Public Function WieIsKoning() As String
        Return strName
    End Function
    'geeft het aantal ridders van de koning'
    Public Function GeefAantalRidders() As Integer
        Return intRidders
    End Function
End Class
Module Program
    Sub Main(args As String())
        Dim objkoning As New kasteel()
        Console.WriteLine(objkoning.WieIsKoning()) 'print de naam van de koning'
        Console.WriteLine(objkoning.GeefAantalRidders()) 'print het aantal ridders van de koning'
    End Sub
End Module
