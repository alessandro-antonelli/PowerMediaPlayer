Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Media_Player.My
Imports Power_Media_Player.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace Power_Media_Player
    <DesignerGenerated> _
    Public Class FileInfo
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub CloseButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Public Function ConvertLength(ByVal Weight As Long) As String
            Dim str As String = "0 KB"
            Dim num5 As Long = Weight
            If (num5 < &H400) Then
                str = (Conversions.ToString(Weight) & " B")
            ElseIf (num5 < &H100000) Then
                Dim str3 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1024)))
                If Not str3.Contains(",") Then
                    str = (str3 & " KB")
                Else
                    Dim startIndex As Short = CShort((str3.LastIndexOf(",") + 4))
                    If (str3.Length < startIndex) Then
                        startIndex = CShort(str3.LastIndexOf(","))
                    End If
                    str = (str3.Remove(startIndex, (str3.Length - startIndex)) & " KB")
                End If
            ElseIf (num5 < &H40000000) Then
                Dim str4 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1048576)))
                If Not str4.Contains(",") Then
                    str = (str4 & " MB")
                Else
                    Dim startIndex As Short = CShort((str4.LastIndexOf(",") + 4))
                    If (str4.Length < startIndex) Then
                        startIndex = CShort(str4.LastIndexOf(","))
                    End If
                    str = (str4.Remove(startIndex, (str4.Length - startIndex)) & " MB")
                End If
            ElseIf (num5 < &H10000000000) Then
                Dim str5 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1073741824)))
                If Not str5.Contains(",") Then
                    str = (str5 & " GB")
                Else
                    Dim startIndex As Short = CShort((str5.LastIndexOf(",") + 4))
                    If (str5.Length < startIndex) Then
                        startIndex = CShort(str5.LastIndexOf(","))
                    End If
                    str = (str5.Remove(startIndex, (str5.Length - startIndex)) & " GB")
                End If
            ElseIf (num5 < &H4000000000000) Then
                Dim str6 As String = Conversions.ToString(CDbl((CDbl(Weight) / 1099511627776)))
                If Not str6.Contains(",") Then
                    str = (str6 & " TB")
                Else
                    Dim startIndex As Short = CShort((str6.LastIndexOf(",") + 4))
                    If (str6.Length < startIndex) Then
                        startIndex = CShort(str6.LastIndexOf(","))
                    End If
                    str = (str6.Remove(startIndex, (str6.Length - startIndex)) & " TB")
                End If
            End If
            Return str
        End Function

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.TabControl = New TabControl
            Me.MainTab = New TabPage
            Me.TableLayoutPanel1 = New TableLayoutPanel
            Me.A1 = New Label
            Me.A2 = New Label
            Me.B1 = New Label
            Me.B2 = New Label
            Me.C1 = New Label
            Me.C2 = New Label
            Me.D1 = New Label
            Me.D2 = New Label
            Me.E1 = New Label
            Me.PictureBox1 = New PictureBox
            Me.MediaTab = New TabPage
            Me.CloseButt = New Button
            Me.AudioTab = New TabPage
            Me.VideoTab = New TabPage
            Me.Main2Lab = New Label
            Me.Main1Lab = New Label
            Me.F2 = New Label
            Me.E2 = New Label
            Me.F1 = New Label
            Me.TabControl.SuspendLayout
            Me.MainTab.SuspendLayout
            Me.TableLayoutPanel1.SuspendLayout
            DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.TabControl.Controls.Add(Me.MainTab)
            Me.TabControl.Controls.Add(Me.MediaTab)
            Me.TabControl.Controls.Add(Me.AudioTab)
            Me.TabControl.Controls.Add(Me.VideoTab)
            Dim point As New Point(12, 12)
            Me.TabControl.Location = point
            Me.TabControl.Name = "TabControl"
            Me.TabControl.SelectedIndex = 0
            Dim size As New Size(&H170, &HD5)
            Me.TabControl.Size = size
            Me.TabControl.TabIndex = 0
            Me.MainTab.Controls.Add(Me.TableLayoutPanel1)
            Me.MainTab.Controls.Add(Me.PictureBox1)
            point = New Point(4, &H16)
            Me.MainTab.Location = point
            Me.MainTab.Name = "MainTab"
            Dim padding As New Padding(3)
            Me.MainTab.Padding = padding
            size = New Size(360, &HBB)
            Me.MainTab.Size = size
            Me.MainTab.TabIndex = 0
            Me.MainTab.Text = "Generale"
            Me.MainTab.UseVisualStyleBackColor = True
            Me.TableLayoutPanel1.ColumnCount = 2
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle)
            Me.TableLayoutPanel1.Controls.Add(Me.F1, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.F2, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.E2, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.D2, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.E1, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.C2, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.D1, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.B2, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.C1, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.A2, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.B1, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.A1, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Main1Lab, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.Main2Lab, 1, 0)
            point = New Point(&H4C, 6)
            Me.TableLayoutPanel1.Location = point
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 7
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle)
            size = New Size(&H116, &HAF)
            Me.TableLayoutPanel1.Size = size
            Me.TableLayoutPanel1.TabIndex = 1
            Me.A1.AutoSize = True
            point = New Point(3, 13)
            Me.A1.Location = point
            Me.A1.Name = "A1"
            size = New Size(&H34, 13)
            Me.A1.Size = size
            Me.A1.TabIndex = 0
            Me.A1.Text = "Percorso:"
            Me.A2.AutoSize = True
            point = New Point(&H5B, 13)
            Me.A2.Location = point
            Me.A2.Name = "A2"
            size = New Size(0, 13)
            Me.A2.Size = size
            Me.A2.TabIndex = 1
            Me.B1.AutoSize = True
            point = New Point(3, &H1A)
            Me.B1.Location = point
            Me.B1.Name = "B1"
            size = New Size(&H3D, 13)
            Me.B1.Size = size
            Me.B1.TabIndex = 2
            Me.B1.Text = "Dimensioni:"
            Me.B2.AutoSize = True
            point = New Point(&H5B, &H1A)
            Me.B2.Location = point
            Me.B2.Name = "B2"
            size = New Size(0, 13)
            Me.B2.Size = size
            Me.B2.TabIndex = 3
            Me.C1.AutoSize = True
            point = New Point(3, &H27)
            Me.C1.Location = point
            Me.C1.Name = "C1"
            size = New Size(&H30, 13)
            Me.C1.Size = size
            Me.C1.TabIndex = 4
            Me.C1.Text = "Formato:"
            Me.C2.AutoSize = True
            point = New Point(&H5B, &H27)
            Me.C2.Location = point
            Me.C2.Name = "C2"
            size = New Size(0, 13)
            Me.C2.Size = size
            Me.C2.TabIndex = 5
            Me.D1.AutoSize = True
            point = New Point(3, &H34)
            Me.D1.Location = point
            Me.D1.Name = "D1"
            size = New Size(&H39, 13)
            Me.D1.Size = size
            Me.D1.TabIndex = 6
            Me.D1.Text = "Creazione:"
            Me.D2.AutoSize = True
            point = New Point(&H5B, &H34)
            Me.D2.Location = point
            Me.D2.Name = "D2"
            size = New Size(0, 13)
            Me.D2.Size = size
            Me.D2.TabIndex = 7
            Me.E1.AutoSize = True
            point = New Point(3, &H41)
            Me.E1.Location = point
            Me.E1.Name = "E1"
            size = New Size(&H51, 13)
            Me.E1.Size = size
            Me.E1.TabIndex = 8
            Me.E1.Text = "Ultima modifica:"
            Me.PictureBox1.Image = Resources.sound
            point = New Point(6, 6)
            Me.PictureBox1.Location = point
            Me.PictureBox1.Name = "PictureBox1"
            size = New Size(&H40, &H40)
            Me.PictureBox1.Size = size
            Me.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            point = New Point(4, &H16)
            Me.MediaTab.Location = point
            Me.MediaTab.Name = "MediaTab"
            padding = New Padding(3)
            Me.MediaTab.Padding = padding
            size = New Size(360, &HBB)
            Me.MediaTab.Size = size
            Me.MediaTab.TabIndex = 1
            Me.MediaTab.Text = "Multimedia"
            Me.MediaTab.UseVisualStyleBackColor = True
            point = New Point(&H131, &HE7)
            Me.CloseButt.Location = point
            Me.CloseButt.Name = "CloseButt"
            size = New Size(&H4B, &H17)
            Me.CloseButt.Size = size
            Me.CloseButt.TabIndex = 1
            Me.CloseButt.Text = "&Chiudi"
            Me.CloseButt.UseVisualStyleBackColor = True
            point = New Point(4, &H16)
            Me.AudioTab.Location = point
            Me.AudioTab.Name = "AudioTab"
            size = New Size(360, &HBB)
            Me.AudioTab.Size = size
            Me.AudioTab.TabIndex = 2
            Me.AudioTab.Text = "Audio"
            Me.AudioTab.UseVisualStyleBackColor = True
            point = New Point(4, &H16)
            Me.VideoTab.Location = point
            Me.VideoTab.Name = "VideoTab"
            size = New Size(360, &HBB)
            Me.VideoTab.Size = size
            Me.VideoTab.TabIndex = 3
            Me.VideoTab.Text = "Video"
            Me.VideoTab.UseVisualStyleBackColor = True
            Me.Main2Lab.AutoSize = True
            Me.Main2Lab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(&H5B, 0)
            Me.Main2Lab.Location = point
            Me.Main2Lab.Name = "Main2Lab"
            size = New Size(0, 13)
            Me.Main2Lab.Size = size
            Me.Main2Lab.TabIndex = 13
            Me.Main1Lab.AutoSize = True
            Me.Main1Lab.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(3, 0)
            Me.Main1Lab.Location = point
            Me.Main1Lab.Name = "Main1Lab"
            size = New Size(&H2B, 13)
            Me.Main1Lab.Size = size
            Me.Main1Lab.TabIndex = 12
            Me.Main1Lab.Text = "Nome:"
            Me.F2.AutoSize = True
            point = New Point(&H5B, &H4E)
            Me.F2.Location = point
            Me.F2.Name = "F2"
            size = New Size(0, 13)
            Me.F2.Size = size
            Me.F2.TabIndex = 14
            Me.E2.AutoSize = True
            point = New Point(&H5B, &H41)
            Me.E2.Location = point
            Me.E2.Name = "E2"
            size = New Size(0, 13)
            Me.E2.Size = size
            Me.E2.TabIndex = 9
            Me.F1.AutoSize = True
            point = New Point(3, &H4E)
            Me.F1.Location = point
            Me.F1.Name = "F1"
            size = New Size(&H52, 13)
            Me.F1.Size = size
            Me.F1.TabIndex = 15
            Me.F1.Text = "Ultimo accesso:"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H188, &H10A)
            Me.ClientSize = size
            Me.Controls.Add(Me.CloseButt)
            Me.Controls.Add(Me.TabControl)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "FileInfo"
            Me.Text = "Informazioni sul file"
            Me.TabControl.ResumeLayout(False)
            Me.MainTab.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout
            DirectCast(Me.PictureBox1, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadInfo(ByVal File As String)
            Me.Main2Lab.Text = MyProject.Computer.FileSystem.GetFileInfo(File).Name
            Me.A2.Text = MyProject.Computer.FileSystem.GetFileInfo(File).DirectoryName
            Me.B2.Text = Me.ConvertLength(MyProject.Computer.FileSystem.GetFileInfo(File).Length)
            Me.C2.Text = MyProject.Computer.FileSystem.GetFileInfo(File).Extension
            Me.D2.Text = Strings.Format(MyProject.Computer.FileSystem.GetFileInfo(File).CreationTime, "dd/MM/yyyy HH:mm:ss")
            Me.E2.Text = Strings.Format(MyProject.Computer.FileSystem.GetFileInfo(File).LastWriteTime, "dd/MM/yyyy HH:mm:ss")
            Me.F2.Text = Strings.Format(MyProject.Computer.FileSystem.GetFileInfo(File).LastAccessTime, "dd/MM/yyyy HH:mm:ss")
        End Sub


        ' Properties
        Friend Overridable Property TabControl As TabControl
            <DebuggerNonUserCode> _
            Get
                Return Me._TabControl
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabControl)
                Me._TabControl = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MainTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._MainTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._MainTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel1 As TableLayoutPanel
            <DebuggerNonUserCode> _
            Get
                Return Me._TableLayoutPanel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TableLayoutPanel)
                Me._TableLayoutPanel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PictureBox1 As PictureBox
            <DebuggerNonUserCode> _
            Get
                Return Me._PictureBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property MediaTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._MediaTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._MediaTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property A1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._A1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._A1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property A2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._A2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._A2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property B1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._B1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._B1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property B2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._B2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._B2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property C1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._C1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._C1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property D1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._D1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._D1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property D2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._D2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._D2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property E1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._E1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._E1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CloseButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CloseButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CloseButt Is Nothing) Then
                    RemoveHandler Me._CloseButt.Click, New EventHandler(AddressOf Me.CloseButt_Click)
                End If
                Me._CloseButt = WithEventsValue
                If (Not Me._CloseButt Is Nothing) Then
                    AddHandler Me._CloseButt.Click, New EventHandler(AddressOf Me.CloseButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property C2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._C2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._C2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AudioTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._AudioTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._AudioTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VideoTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._VideoTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._VideoTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Main1Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Main1Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Main1Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Main2Lab As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Main2Lab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Main2Lab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property F1 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._F1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._F1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property F2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._F2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._F2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property E2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._E2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._E2 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("TabControl")> _
        Private _TabControl As TabControl
        <AccessedThroughProperty("MainTab")> _
        Private _MainTab As TabPage
        <AccessedThroughProperty("TableLayoutPanel1")> _
        Private _TableLayoutPanel1 As TableLayoutPanel
        <AccessedThroughProperty("PictureBox1")> _
        Private _PictureBox1 As PictureBox
        <AccessedThroughProperty("MediaTab")> _
        Private _MediaTab As TabPage
        <AccessedThroughProperty("A1")> _
        Private _A1 As Label
        <AccessedThroughProperty("A2")> _
        Private _A2 As Label
        <AccessedThroughProperty("B1")> _
        Private _B1 As Label
        <AccessedThroughProperty("B2")> _
        Private _B2 As Label
        <AccessedThroughProperty("C1")> _
        Private _C1 As Label
        <AccessedThroughProperty("D1")> _
        Private _D1 As Label
        <AccessedThroughProperty("D2")> _
        Private _D2 As Label
        <AccessedThroughProperty("E1")> _
        Private _E1 As Label
        <AccessedThroughProperty("CloseButt")> _
        Private _CloseButt As Button
        <AccessedThroughProperty("C2")> _
        Private _C2 As Label
        <AccessedThroughProperty("AudioTab")> _
        Private _AudioTab As TabPage
        <AccessedThroughProperty("VideoTab")> _
        Private _VideoTab As TabPage
        <AccessedThroughProperty("Main1Lab")> _
        Private _Main1Lab As Label
        <AccessedThroughProperty("Main2Lab")> _
        Private _Main2Lab As Label
        <AccessedThroughProperty("F1")> _
        Private _F1 As Label
        <AccessedThroughProperty("F2")> _
        Private _F2 As Label
        <AccessedThroughProperty("E2")> _
        Private _E2 As Label
    End Class
End Namespace

