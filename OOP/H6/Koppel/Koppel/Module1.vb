Module Module1

    Class Koppel
        Private dblLengtevrouw As Double
        Private dblLengteMan As Double
        Private strGeslacht As String
        Private dblLengteKind As Double

        Public Sub New(lengteVrouw As Double, lengteMan As Double, geslacht As String)
            Me.dblLengtevrouw = lengteVrouw
            Me.dblLengteMan = lengteMan
            Me.strGeslacht = geslacht
        End Sub

        Public Sub BerekenLengteKind()
            If strGeslacht.ToLower() = "jongen" Then
                dblLengteKind = (dblLengteMan + dblLengtevrouw + 13) / 2
            ElseIf strGeslacht.ToLower() = "meisje" Then
                dblLengteKind = (dblLengteMan + dblLengtevrouw - 13) / 2
            Else
                Console.WriteLine("Ongeldig geslacht ingevoerd.")
                Exit Sub
            End If
            Console.WriteLine($"De verwachte lengte van het kind is {dblLengteKind:F1} cm.")
        End Sub
    End Class

    Sub Main()
        Dim lengteVrouw As Double = 155
        Dim lengteMan As Double = 170
        Dim geslacht As String = "jongen"

        Dim koppel1 As New Koppel(lengteVrouw, lengteMan, geslacht)
        koppel1.BerekenLengteKind()
    End Sub

End Module
