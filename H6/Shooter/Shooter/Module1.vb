Module Module1

    Class Trapper
        Private chrvoorkeur As String
        Private rand As New Random()
        Private intrandom As Integer

        Public Sub New(chrvoorkeur As String)
            Me.chrvoorkeur = chrvoorkeur
        End Sub

        Public Function Zetvoorkeur(strvoorkeur As String) As String
            intrandom = rand.Next(1, 5)
            If intrandom = 1 Then
                Return "midden"
            ElseIf intrandom = 2 Or intrandom = 4 Then
                Return "rechts"
            Else
                Return "links"
            End If
        End Function
    End Class

    Sub Main()
        Dim objThierryBenoit As New Trapper("Thierry")
        Console.WriteLine(objThierryBenoit.Zetvoorkeur("rechts"))
    End Sub

End Module




