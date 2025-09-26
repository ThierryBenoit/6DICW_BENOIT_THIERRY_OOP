Imports System

Class Pizza
    Public strToppings As String
    Public intDiameter As Integer
    Public dblPrijs As Double


    Public Sub New(toppings As String, diameter As Integer, prijs As Double)
        Me.strToppings = toppings
        Me.intDiameter = diameter
        Me.dblPrijs = prijs
    End Sub
    Public Sub New()
    End Sub

    Public Sub ZetToppings(toppings As String)
        Me.strToppings = toppings
    End Sub

    Public Function GeefToppings() As String
        Return Me.strToppings
    End Function

    Public Sub ZetDiameter(diameter As Integer)
        Me.intDiameter = diameter
    End Sub

    Public Function GeefDiameter() As Integer
        Return Me.intDiameter
    End Function

    Public Sub ZetPrijs(prijs As Double)
        Me.dblPrijs = prijs
    End Sub

    Public Function GeefPrijs() As Double
        Return Me.dblPrijs
    End Function
End Class

Module Module1
    Sub Main()
        Dim MijnPizza As New Pizza()
        MijnPizza.ZetToppings("kip")
        MijnPizza.ZetDiameter(30)
        MijnPizza.ZetPrijs(12.5)

        Console.WriteLine("Toppings: " & MijnPizza.GeefToppings())
        Console.WriteLine("Diameter: " & MijnPizza.GeefDiameter() & " cm")
        Console.WriteLine("Prijs: euro" & MijnPizza.GeefPrijs())

        Console.ReadLine()
    End Sub
End Module


