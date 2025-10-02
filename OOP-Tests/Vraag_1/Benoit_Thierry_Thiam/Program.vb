Imports System
Class Atleet
    Public geboorteplaats As String
    Public lengte As Integer
    Public gewicht As Double
    Private intLengte As Integer
    Private dblGewicht As Double
    Private strGeboorteplaats As String

    Public Sub New(geboorteplaats As String, lengte As Integer, gewicht As Double)
        Me.strGeboorteplaats = geboorteplaats
        Me.intLengte = lengte
        Me.dblGewicht = gewicht
    End Sub
    Public Sub New()
    End Sub

    Public Sub ZetGeboorteplaats(geboorteplaats As String)
        Me.strGeboorteplaats = geboorteplaats
    End Sub
    Public Function GeefGeboorteplaats() As String
        Return Me.strGeboorteplaats
    End Function
    Public Sub Zetlengte(lengte As Integer)
        Me.intLengte = lengte
    End Sub

    Public Function Geeflengte() As Integer
        Return Me.intLengte = lengte
    End Function

    Public Sub Zetgewicht(gewicht As Double)
        Me.dblGewicht = gewicht
    End Sub
    Public Function Geefgewicht() As Double
        Return Me.gewicht = gewicht
    End Function
End Class

Module Module1
        Sub Main()
            Dim MijnAtleet As New Atleet()
            MijnAtleet.ZetGeboorteplaats("Doel")
        MijnAtleet.Zetlengte(175)
        MijnAtleet.Zetgewicht(80)

        Console.WriteLine("Thiam is geboren in           :" & MijnAtleet.GeefGeboorteplaats())
            Console.WriteLine("Thiam haar lengte (in cm) is  : " & MijnAtleet.Geeflengte())
            Console.WriteLine("Thiam haar gewicht (in kg) is : " & MijnAtleet.Geefgewicht())

            Console.ReadLine()
        End Sub
    End Module