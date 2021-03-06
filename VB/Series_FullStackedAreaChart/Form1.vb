﻿Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_FullStackedAreaChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim FullStackedAreaChart As New ChartControl()

            ' Create two full-stacked area series.
            Dim series1 As New Series("Series 1", ViewType.FullStackedArea)
            Dim series2 As New Series("Series 2", ViewType.FullStackedArea)

            ' Add points to them.
            series1.Points.Add(New SeriesPoint(1, 10))
            series1.Points.Add(New SeriesPoint(2, 12))
            series1.Points.Add(New SeriesPoint(3, 14))
            series1.Points.Add(New SeriesPoint(4, 17))

            series2.Points.Add(New SeriesPoint(1, 15))
            series2.Points.Add(New SeriesPoint(2, 18))
            series2.Points.Add(New SeriesPoint(3, 25))
            series2.Points.Add(New SeriesPoint(4, 33))

            ' Add both series to the chart.
            FullStackedAreaChart.Series.AddRange(New Series() { series1, series2 })

            ' Set the numerical argument scale types for the series,
            ' as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical
            series2.ArgumentScaleType = ScaleType.Numerical

            ' Access the view-type-specific options of the series.
            CType(series1.View, FullStackedAreaSeriesView).Transparency = 50
            CType(series2.View, FullStackedAreaSeriesView).Transparency = 50

            ' Access the type-specific options of the diagram.
            CType(FullStackedAreaChart.Diagram, XYDiagram).Rotated = True

            ' Hide the legend (if necessary).
            FullStackedAreaChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add the chart to the form.
            FullStackedAreaChart.Dock = DockStyle.Fill
            Me.Controls.Add(FullStackedAreaChart)
        End Sub

    End Class
End Namespace