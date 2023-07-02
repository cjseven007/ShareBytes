Imports System.Linq

Public Class LinearRegressionModel
    Private ReadOnly distances As Double()
    Private ReadOnly fares As Double()
    Public Property Slope As Double
    Public Property Intercept As Double

    Public Sub New(distances As Double(), fares As Double())
        Me.distances = distances
        Me.fares = fares
    End Sub

    Public Sub Train()
        Dim n = distances.Length
        Dim sumX = distances.Sum()
        Dim sumY = fares.Sum()
        Dim sumXY = distances.Zip(fares, Function(x, y) x * y).Sum()
        Dim sumXX = distances.Sum(Function(x) x * x)

        Slope = (n * sumXY - sumX * sumY) / (n * sumXX - sumX * sumX)
        Intercept = (sumY - Slope * sumX) / n
    End Sub

    Public Function PredictFare(distance As Double) As Double
        Dim fare = Slope * distance + Intercept
        Return fare
    End Function
End Class