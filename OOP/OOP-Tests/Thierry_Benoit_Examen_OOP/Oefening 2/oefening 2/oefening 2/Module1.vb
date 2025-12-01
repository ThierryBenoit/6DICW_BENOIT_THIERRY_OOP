Module Module1
    'Maakt de hoofdklasse Organisme aan
    Public Class Organisme
        'Maakt velden aan voor de basis klasse Organisme
        Protected StrNaam As String
        Protected intLeeftijd As Integer
        'Constructor
        Public Sub New(StrNaam As String, intLeeftijd As Integer)
            Me.StrNaam = StrNaam
            Me.intLeeftijd = intLeeftijd
        End Sub
        'Sub die overschrijfbaar is door de Subklasses van Organisme
        Public Overridable Sub Groei()

        End Sub
    End Class
    'Maakt de subklasse Plant aan
    Public Class Plant
        'Erft de methodes en velden van Organismen aan en maakt nieuwe velden
        Inherits Organisme
        Protected dblLengte As Double
        'Constructor
        Public Sub New(strNaam As String, intLeeftijd As Integer, dblLengte As Double)
            MyBase.New(strNaam, intLeeftijd)
            Me.dblLengte = dblLengte
        End Sub
        Private Function Leeftijd() As String
            'Als de plant minder dan 7 dagen oud is dan returned hij "x dagen"
            If intLeeftijd < 7 Then
                Return intLeeftijd & " dagen"
                'Als de plant meer dan 7 dagen maar minder dan 365 dagen is dan returned hij "x weken"
            ElseIf intLeeftijd < 365 Then
                Return intLeeftijd / 7 & " weken"
                'Als de plant meer dan een jaar oud is dan returned hij "x jaren"
            Else
                Return intLeeftijd / 365 & "jaar"
            End If
        End Function
        'Sub die overschreven wordt over de hoofdklasse Organisme
        'Sub die de naam de lengte en de leeftijd afprint
        Public Overrides Sub Groei()
            dblLengte = dblLengte + 0.001
            Console.WriteLine(StrNaam & " is gegroeid, het is nu: " & dblLengte & " meter hoog.")
            Console.WriteLine("Plant is nu " & Leeftijd() & " soud.")
        End Sub
        'Sub die overschrijfbaar is door de Subklasses van Plant
        'Print af dat de plant aan fotosynthese doet
        Public Overridable Sub FotoSynthese()
            Console.WriteLine(StrNaam & " is bezig met fotosynthese!")
        End Sub
    End Class
    'Maakt de subklasse Boom aan
    Public Class Boom
        'Erft de methodes en velden van Plant aan en maakt nieuwe velden
        Inherits Plant
        Private StrTypeBlad As String
        'Constructor
        Public Sub New(strNaam As String, intLeeftijd As Integer, dblLengte As Double, StrTypeBlad As String)
            MyBase.New(strNaam, intLeeftijd, dblLengte)
            Me.StrTypeBlad = StrTypeBlad
        End Sub
        'Sub die overschreven wordt over de hoofdklasse Organisme
        'Print de naam het type blad de lengte en de leeftijd van de boom af
        Public Overrides Sub Groei()
            dblLengte = dblLengte + 0.002
            Console.WriteLine(StrNaam & " is gegroeid met type blad: " & StrTypeBlad)
            Console.WriteLine("De nieuwe hoogte van de boom is: " & dblLengte & " meter.")
            Console.WriteLine("Boom is zo oud (in jaar): " & intLeeftijd)
        End Sub
        'Sub die overschreven wordt over de hoofdklasse Plant
        'Print af dat de Boom aan fotosynthese doet
        Public Overrides Sub FotoSynthese()
            Console.WriteLine(StrNaam & " is bezig met fotosynthese!")

        End Sub
    End Class
    'Maakt de subklasse Dier aan
    Public Class Dier
        'Erft de methodes en velden van Organismen aan en maakt nieuwe velden
        Inherits Organisme
        Protected StrGeluid As String
        'Constructor
        Public Sub New(strNaam As String, intLeeftijd As Integer, StrGeluid As String)
            MyBase.New(strNaam, intLeeftijd)
            Me.StrGeluid = StrGeluid
        End Sub
        'Sub die overschreven wordt over de hoofdklasse Organisme
        'Print de naam van het Dier af
        Public Overrides Sub Groei()
            Console.WriteLine(StrNaam & " is gegroeid, op een unieke dierlijke manier.")
        End Sub
        'Sub die overschrijfbaar is door de Subklasses van Dier
        Public Overridable Sub MaakGeluid()

        End Sub
    End Class
    'Maakt de subklasse Vogel aan
    Public Class Vogel
        'Erft de methodes en velden van Dier aan en maakt nieuwe velden
        Inherits Dier
        Private intSpanwijdte As Integer
        'Constructor
        Public Sub New(strNaam As String, intLeeftijd As Integer, StrGeluid As String, intSpanwijdte As Integer)
            MyBase.New(strNaam, intLeeftijd, StrGeluid)
            Me.intSpanwijdte = intSpanwijdte
        End Sub
        'Sub die overschreven wordt over de hoofdklasse Organisme
        'Print de naam en de leeftijd van de vogel af
        Public Overrides Sub Groei()
            Console.WriteLine(StrNaam & " is gegroeid, op een unieke dierlijke manier.")
            Console.WriteLine("Dier is zo oud (in jaar): " & intLeeftijd)
        End Sub
        'Sub die overschreven wordt over de hoofdklasse Dier
        'Print de naam de Spanwijdte en het geluid van de Vogel
        Public Overrides Sub MaakGeluid()
            Console.WriteLine(StrNaam & " met vleugelspanwijdte: " & intSpanwijdte & " meter zingt: " & StrGeluid)
        End Sub
    End Class

    Sub Main()
        'Maakt een nieuw object Boom aan
        Dim objEik As New Boom("Eik", 50, 15, "eivormig")
        'Maakt een nieuw object Plant aan
        Dim objKorenBloem As New Plant("Blauwe korenbloem", 35, 0.05 / 100)
        'Maakt een nieuw object Vogel aan
        Dim objAdelaar As New Vogel("Zeearend", 5, "Krijs", 2)

        'Roept groei op voor de Boom
        objEik.Groei()
        'Roept FotoSynthese op voor de Boom
        objEik.FotoSynthese()
        Console.WriteLine("---")
        'Roept groei op voor de Plant
        objKorenBloem.Groei()
        'Roept FotoSynthese op voor de Plant
        objKorenBloem.FotoSynthese()
        Console.WriteLine("---")
        'Roept Groei op voor de Vogel
        objAdelaar.Groei()
        'Roept MaakGeluid op voor de Vogel
        objAdelaar.MaakGeluid()
        Console.WriteLine("---")

    End Sub

End Module