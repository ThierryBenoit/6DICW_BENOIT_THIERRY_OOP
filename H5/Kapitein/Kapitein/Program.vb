Imports System

Module Module1

    Class Voetballer
        Public strNaam As String
        Public blnIsKapitein As Boolean
        Public Sub New(strNaam As String, blnIsKapitein As Boolean)
            Me.strNaam = strNaam
            Me.blnIsKapitein = False
        End Sub

        Public Sub Geefnaam()
            Console.WriteLine("Mijn naam is: " & Me.strNaam)
        End Sub

        Sub geefKapitein()
            If blnIsKapitein Then
                Console.WriteLine("Ik ben de kapitein van het team.")
            Else
                Console.WriteLine("Ik ben geen kapitein.")
            End If
        End Sub

        Public Sub Zetkapitein(blnIsKapitein As Boolean)
            Me.blnIsKapitein = blnIsKapitein
        End Sub
    End Class

    Sub Main(args As String())
        Console.WriteLine()

        Dim objMessi As New Voetballer("Messi", False)
        objMessi.Geefnaam()
        objMessi.Zetkapitein(True)
        objMessi.geefKapitein()
    End Sub


End Module

