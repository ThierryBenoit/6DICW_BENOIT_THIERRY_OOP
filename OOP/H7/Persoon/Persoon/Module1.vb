Module Module1
    Public Class Persoon
        Protected dblGewicht As Double
        Protected dblLengte As Double

        Public Sub New(dblGewicht As Double, dblLengte As Double)
            Me.dblGewicht = dblGewicht
            Me.dblLengte = dblLengte
        End Sub
    End Class

    Public Class Voetballer
        Inherits Persoon
        Private intAantalGoalsFinale As Integer
        Public Overridable Sub SpeelVoetbal()
            Console.WriteLine("Ik speel de bal maar wat rond.")
        End Sub
    End Class

    Class Aanvaller
        Inherits Voetballer
        Public Sub New(dblGewicht As Double, dblLengte As Double, intAantalGoalsFinale As Integer)
            MyBase.New(intAantalGoalsFinale, dblLengte, dblGewicht)
        End Sub

        Public Overrides Sub SpeelVoetbal()
            Console.WriteLine("Ik probeer echt wel een goal te maken!")
        End Sub
    End Class

    Class Verdediger
        Inherits Voetballer
        Public Sub New(dblGewicht As Double, dblLengte As Double, intAantalGoalsFinale As Integer)
            MyBase.New(intAantalGoalsFinale, dblLengte, dblGewicht)
        End Sub

        Public Overrides Sub SpeelVoetbal()
            Console.WriteLine("Deze keer raak je me niet voorbij")
        End Sub
    End Class

    Sub Main()
        Dim objMessi As New Aanvaller(65.33, 165.3, 56)
        objMessi.SpeelVoetbal()
        Dim objVanDijk As New Verdediger(80.23, 185.3, 2)
        objVanDijk.SpeelVoetbal()
    End Sub


End Module
