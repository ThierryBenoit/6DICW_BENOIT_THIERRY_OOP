Module Program
    'Stelt de velden in voor de hoofdklasse
    Public Class Wielrenner
        Protected StrPloeg As String
        Protected intLeeftijd As Integer
        'Constructor
        Public Sub New(StrPloeg As String, intLeeftijd As Integer)
            Me.StrPloeg = StrPloeg
            Me.intLeeftijd = intLeeftijd
        End Sub
        Public Overridable Sub rij()
            Console.WriteLine("Ik ben een wielrenner zonder specialisatie")
        End Sub
    End Class

    Public Class Veldrijder
        Inherits Wielrenner
        Private StrFavorieteOndergrond As String
        Private intAantalOverwinningen As Integer
        Public Sub New(StrFavorieteOndergrond As String, intAantalOverwinningen As Integer, StrPloeg As String, intLeeftijd As Integer)
            MyBase.New(StrPloeg, intLeeftijd)
            Me.intAantalOverwinningen = intAantalOverwinningen
            Me.StrFavorieteOndergrond = StrFavorieteOndergrond
        End Sub
        Public Overrides Sub rij()
            Console.WriteLine("Mijn favoriete ondergrond is " & StrFavorieteOndergrond & ".")
            Console.WriteLine("Ik ben " & intLeeftijd & " jaar oud en ik rij bij " & StrPloeg & ".")
        End Sub
    End Class

    Public Class Wegrenner
        Inherits Wielrenner
        Private intAantalOverwinningenOpDeWeg As Integer
        Private StrFavorieteGroteRonde As String
        Public Sub New(intAantalOverwinningenOpDeWeg As Integer, StrFavorieteGroteRonde As String, StrPloeg As String, intLeeftijd As Integer)
            MyBase.New(StrPloeg, intLeeftijd)
            Me.StrFavorieteGroteRonde = StrFavorieteGroteRonde
            Me.intAantalOverwinningenOpDeWeg = intAantalOverwinningenOpDeWeg
        End Sub
        Public Overrides Sub rij()
            Console.WriteLine("Mijn favoriete grote ronde is " & StrFavorieteGroteRonde & ".")
            Console.WriteLine("Ik ben " & intLeeftijd & " jaar oud en ik rij bij " & StrPloeg & ".")
        End Sub
    End Class
    Sub Main()
        Dim objWielrenner As New Wielrenner("Jumbo Visma", 33)
        Dim objVeldrijder As New Veldrijder("ijs", 122, "Jumbo Visma", 33)
        Dim objWegrenner As New Wegrenner(22, "Tour De France", "Jumbo Visma", 22)
        objWielrenner.rij()
        objVeldrijder.rij()
        objWegrenner.rij()


    End Sub
End Module
