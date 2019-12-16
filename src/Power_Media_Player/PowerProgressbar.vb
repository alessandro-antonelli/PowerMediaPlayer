Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace Power_Media_Player
    <DesignerGenerated> _
    Public Class PowerProgressbar
        Inherits UserControl
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Power_Progressbar_Load)
            Me.InitializeComponent
            Me.p_Minimum = 0
            Me.p_Maximum = 100
            Me.p_Value = 0
            Me.p_BarColor = BarColors.Green
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.SuspendLayout
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.White
            Dim size As New Size(20, 5)
            Me.MinimumSize = size
            Me.Name = "PowerProgressbar"
            size = New Size(300, 20)
            Me.Size = size
            Me.ResumeLayout(False)
        End Sub

        Private Sub Power_Progressbar_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim rect As New Rectangle(1, 1, (Me.Width - 1), (Me.Height - 1))
            Me.CreateGraphics.DrawRectangle(Pens.Black, rect)
        End Sub


        ' Properties
        Public Property Value As Long
            Get
                Return Me.p_Value
            End Get
            Set(ByVal Value As Long)
                If Not ((Value >= Me.p_Minimum) And (Value <= Me.p_Maximum)) Then
                    Throw New ArgumentOutOfRangeException
                End If
                Me.p_Value = Value
                Dim num2 As Double = (CDbl((Me.p_Value - Me.p_Minimum)) / CDbl((Me.p_Maximum - Me.p_Minimum)))
                Dim width As Short = CShort(Math.Round(CDbl((Me.Width * num2))))
                Me.CreateGraphics.Clear(Color.White)
                Dim rect As New Rectangle(0, 1, width, CInt(Math.Round(CDbl((CDbl((Me.Height - 2)) / 3)))))
                Dim rectangle As New Rectangle(0, CInt(Math.Round(CDbl((CDbl((Me.Height + 2)) / 3)))), width, CInt(Math.Round(CDbl(((CDbl((Me.Height - 2)) / 3) * 2)))))
                Select Case Me.p_BarColor
                    Case BarColors.Yellow
                        Me.CreateGraphics.FillRectangle(Brushes.Yellow, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.Gold, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.Yellow, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.Gold, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Orange
                        Me.CreateGraphics.FillRectangle(Brushes.Orange, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.DarkOrange, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.Orange, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.DarkOrange, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Red
                        Me.CreateGraphics.FillRectangle(Brushes.Red, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.Crimson, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.Red, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.Crimson, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Violet
                        Me.CreateGraphics.FillRectangle(Brushes.DarkOrchid, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.Purple, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.DarkOrchid, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.Purple, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Brown
                        Me.CreateGraphics.FillRectangle(Brushes.Peru, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.DarkGoldenrod, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.Peru, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.DarkGoldenrod, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Blue
                        Me.CreateGraphics.FillRectangle(Brushes.CornflowerBlue, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.RoyalBlue, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.CornflowerBlue, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.RoyalBlue, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Green
                        Me.CreateGraphics.FillRectangle(Brushes.Chartreuse, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.Lime, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.Chartreuse, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.Lime, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case BarColors.Black
                        Me.CreateGraphics.FillRectangle(Brushes.DimGray, rect)
                        Me.CreateGraphics.FillRectangle(Brushes.Black, rectangle)
                        Me.CreateGraphics.DrawLine(Pens.DimGray, 1, 0, (width - 2), 0)
                        Me.CreateGraphics.DrawLine(Pens.Black, 1, (Me.Height - 1), (width - 2), (Me.Height - 1))
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            End Set
        End Property

        Public Property Minimum As Long
            Get
                Return Me.p_Minimum
            End Get
            Set(ByVal Value As Long)
                If (Value < 0) Then
                    Throw New ArgumentOutOfRangeException
                End If
                Me.p_Minimum = Value
                If (Me.p_Minimum > Me.p_Maximum) Then
                    Me.p_Maximum = (Me.p_Minimum + 1)
                End If
            End Set
        End Property

        Public Property Maximum As Long
            Get
                Return Me.p_Maximum
            End Get
            Set(ByVal Value As Long)
                If (Value < 0) Then
                    Throw New ArgumentOutOfRangeException
                End If
                Me.p_Maximum = Value
                If (Me.p_Maximum < Me.p_Minimum) Then
                    Me.p_Minimum = (Me.p_Maximum - 1)
                End If
            End Set
        End Property

        Public Property BarColor As BarColors
            Get
                Return Me.p_BarColor
            End Get
            Set(ByVal Value As BarColors)
                Me.p_BarColor = Value
            End Set
        End Property


        ' Fields
        Private components As IContainer
        Private p_Value As Long
        Private p_Minimum As Long
        Private p_Maximum As Long
        Private p_BarColor As BarColors

        ' Nested Types
        Public Enum BarColors
            ' Fields
            Yellow = 0
            Orange = 1
            Red = 2
            Violet = 3
            Brown = 4
            Blue = 5
            Green = 6
            Black = 7
        End Enum
    End Class
End Namespace

