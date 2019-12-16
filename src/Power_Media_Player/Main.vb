Imports Microsoft.DirectX.AudioVideoPlayback
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.FileIO
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
    Public Class Main
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Principale_Load)
            Me.Status = 0
            Me.InitializeComponent
        End Sub

        Private Sub AddButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApriDial.ShowDialog
        End Sub

        Private Sub Apri_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim item As New ListViewItem
            item.Text = Me.ApriDial.FileName.Remove(0, (Me.ApriDial.FileName.LastIndexOf("\") + 1))
            item.Name = Me.ApriDial.FileName
            item.ImageIndex = 2
            item.ForeColor = MySettingsProperty.Settings.FontColor
            Me.PlaylistView.Items.Add(item)
            Me.IsVideo = (Me.ApriDial.FilterIndex <> 1)
            Me.Play(Me.ApriDial.FileName)
        End Sub

        Private Sub ApriButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.ApriDial.ShowDialog
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try 
                If (disposing AndAlso (Not Me.components Is Nothing)) Then
                    Me.components.Dispose
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Public Function GetDuration(ByVal Time As Integer) As String
            Dim num As Short
            Dim num2 As Short = CShort(Time)
            If num2.ToString.Contains(",") Then
                Dim startIndex As Short = CShort(num2.ToString.LastIndexOf(","))
                num2 = Conversions.ToShort(num2.ToString.Remove(startIndex, (num2.ToString.Length - startIndex)))
            End If
            If (num2 > &H3B) Then
                num = CShort((num2 / 60))
                num2 = CShort((num2 - (60 * num)))
            End If
            Return If((num2.ToString.Length <> Conversions.ToDouble("1")), (Conversions.ToString(CInt(num)) & ":" & Conversions.ToString(CInt(num2))), (Conversions.ToString(CInt(num)) & ":0" & Conversions.ToString(CInt(num2))))
        End Function

        Public Function GetTime(ByVal MaxValue As Integer, ByVal MaxPixel As Integer, ByVal Pixel As Integer) As String
            Return Conversions.ToString(CDbl((CDbl((MaxValue * Pixel)) / CDbl(MaxPixel))))
        End Function

        Private Sub InfoButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.FileInfo.LoadInfo(Me.FilePath)
            MyProject.Forms.FileInfo.Show
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(Main))
            Me.ApriDial = New OpenFileDialog
            Me.Timer = New Timer(Me.components)
            Me.TimeToolTip = New ToolTip(Me.components)
            Me.PlaylistView = New ListView
            Me.PlaylistImgList = New ImageList(Me.components)
            Me.PlaylistTool = New ToolStrip
            Me.ToolStripButton2 = New ToolStripButton
            Me.ToolStripButton3 = New ToolStripButton
            Me.ToolStripSeparator1 = New ToolStripSeparator
            Me.AddButt = New ToolStripButton
            Me.RemoveButt = New ToolStripButton
            Me.UpButt = New ToolStripButton
            Me.DownButt = New ToolStripButton
            Me.SplitContainer1 = New SplitContainer
            Me.VideoPan = New Panel
            Me.AddDial = New OpenFileDialog
            Me.PlayerTool = New ToolStrip
            Me.PlayPauseButt = New ToolStripButton
            Me.StopButt = New ToolStripButton
            Me.PrevButt = New ToolStripButton
            Me.NextButt = New ToolStripButton
            Me.ElapsedTime = New ToolStripLabel
            Me.OfLabel = New ToolStripLabel
            Me.TotalTime = New ToolStripLabel
            Me.InfoButt = New ToolStripButton
            Me.VolumeButt = New ToolStripButton
            Me.VolumeProg = New ToolStripProgressBar
            Me.MainTool = New ToolStrip
            Me.ApriButt = New ToolStripButton
            Me.ToolStripSeparator2 = New ToolStripSeparator
            Me.ToolStripButton1 = New ToolStripButton
            Me.ToolStripButton7 = New ToolStripButton
            Me.ToolStripButton6 = New ToolStripButton
            Me.InfoLab = New ToolStripLabel
            Me.ProgressBar = New PowerProgressbar
            Me.ColumnHeader1 = New ColumnHeader
            Me.PlaylistTool.SuspendLayout
            Me.SplitContainer1.Panel1.SuspendLayout
            Me.SplitContainer1.Panel2.SuspendLayout
            Me.SplitContainer1.SuspendLayout
            Me.PlayerTool.SuspendLayout
            Me.MainTool.SuspendLayout
            Me.SuspendLayout
            manager.ApplyResources(Me.ApriDial, "ApriDial")
            Me.ApriDial.RestoreDirectory = True
            Me.Timer.Interval = 200
            Me.TimeToolTip.AutoPopDelay = &HC350
            Me.TimeToolTip.InitialDelay = 0
            Me.TimeToolTip.ReshowDelay = 0
            Me.TimeToolTip.ShowAlways = True
            Me.PlaylistView.AllowColumnReorder = True
            manager.ApplyResources(Me.PlaylistView, "PlaylistView")
            Me.PlaylistView.BackColor = MySettings.Default.Color
            Me.PlaylistView.BorderStyle = BorderStyle.None
            Dim values As ColumnHeader() = New ColumnHeader() { Me.ColumnHeader1 }
            Me.PlaylistView.Columns.AddRange(values)
            Me.PlaylistView.DataBindings.Add(New Binding("BackColor", MySettings.Default, "Color", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.PlaylistView.DataBindings.Add(New Binding("ForeColor", MySettings.Default, "FontColor", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.PlaylistView.ForeColor = MySettings.Default.FontColor
            Me.PlaylistView.FullRowSelect = True
            Me.PlaylistView.HeaderStyle = ColumnHeaderStyle.None
            Me.PlaylistView.MultiSelect = False
            Me.PlaylistView.Name = "PlaylistView"
            Me.PlaylistView.ShowGroups = False
            Me.PlaylistView.SmallImageList = Me.PlaylistImgList
            Me.PlaylistView.UseCompatibleStateImageBehavior = False
            Me.PlaylistView.View = View.Details
            Me.PlaylistImgList.ImageStream = DirectCast(manager.GetObject("PlaylistImgList.ImageStream"), ImageListStreamer)
            Me.PlaylistImgList.TransparentColor = Color.Transparent
            Me.PlaylistImgList.Images.SetKeyName(0, "midi.png")
            Me.PlaylistImgList.Images.SetKeyName(1, "sound.png")
            Me.PlaylistImgList.Images.SetKeyName(2, "krec_fileplay.png")
            manager.ApplyResources(Me.PlaylistTool, "PlaylistTool")
            Me.PlaylistTool.BackColor = MySettings.Default.Color
            Me.PlaylistTool.DataBindings.Add(New Binding("BackColor", MySettings.Default, "Color", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.PlaylistTool.GripStyle = ToolStripGripStyle.Hidden
            Dim toolStripItems As ToolStripItem() = New ToolStripItem() { Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.AddButt, Me.RemoveButt, Me.UpButt, Me.DownButt }
            Me.PlaylistTool.Items.AddRange(toolStripItems)
            Me.PlaylistTool.Name = "PlaylistTool"
            Me.ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton2.Image = Resources._3floppy_unmount
            manager.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
            Me.ToolStripButton2.Name = "ToolStripButton2"
            Me.ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton3.Image = Resources.folder_yellow1
            manager.ApplyResources(Me.ToolStripButton3, "ToolStripButton3")
            Me.ToolStripButton3.Name = "ToolStripButton3"
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            manager.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
            Me.AddButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.AddButt.Image = Resources.edit_add
            manager.ApplyResources(Me.AddButt, "AddButt")
            Me.AddButt.Name = "AddButt"
            Me.RemoveButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.RemoveButt.Image = Resources.edit_remove
            manager.ApplyResources(Me.RemoveButt, "RemoveButt")
            Me.RemoveButt.Name = "RemoveButt"
            Me.UpButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.UpButt.Image = Resources.up
            manager.ApplyResources(Me.UpButt, "UpButt")
            Me.UpButt.Name = "UpButt"
            Me.DownButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.DownButt.Image = Resources.down
            manager.ApplyResources(Me.DownButt, "DownButt")
            Me.DownButt.Name = "DownButt"
            manager.ApplyResources(Me.SplitContainer1, "SplitContainer1")
            Me.SplitContainer1.BackColor = MySettings.Default.Color
            Me.SplitContainer1.DataBindings.Add(New Binding("BackColor", MySettings.Default, "Color", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.SplitContainer1.ForeColor = Color.Black
            Me.SplitContainer1.Name = "SplitContainer1"
            Me.SplitContainer1.Panel1.Controls.Add(Me.VideoPan)
            Me.SplitContainer1.Panel2.BackColor = Color.Transparent
            Me.SplitContainer1.Panel2.Controls.Add(Me.PlaylistTool)
            Me.SplitContainer1.Panel2.Controls.Add(Me.PlaylistView)
            Me.SplitContainer1.Panel2.ForeColor = Color.Black
            Me.SplitContainer1.TabStop = False
            Me.VideoPan.BackColor = Color.Black
            manager.ApplyResources(Me.VideoPan, "VideoPan")
            Me.VideoPan.ForeColor = SystemColors.ControlText
            Me.VideoPan.Name = "VideoPan"
            manager.ApplyResources(Me.AddDial, "AddDial")
            Me.AddDial.Multiselect = True
            Me.AddDial.RestoreDirectory = True
            Me.PlayerTool.BackgroundImage = Resources.Blue_39
            manager.ApplyResources(Me.PlayerTool, "PlayerTool")
            Me.PlayerTool.GripStyle = ToolStripGripStyle.Hidden
            Dim size As New Size(&H20, &H20)
            Me.PlayerTool.ImageScalingSize = size
            toolStripItems = New ToolStripItem() { Me.PlayPauseButt, Me.StopButt, Me.PrevButt, Me.NextButt, Me.ElapsedTime, Me.OfLabel, Me.TotalTime, Me.InfoButt, Me.VolumeButt }
            toolStripItems(9) = Me.VolumeProg
            Me.PlayerTool.Items.AddRange(toolStripItems)
            Me.PlayerTool.Name = "PlayerTool"
            Me.PlayPauseButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PlayPauseButt.Image = Resources.player_play
            manager.ApplyResources(Me.PlayPauseButt, "PlayPauseButt")
            Me.PlayPauseButt.Name = "PlayPauseButt"
            Me.StopButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.StopButt.Image = Resources.player_stop
            manager.ApplyResources(Me.StopButt, "StopButt")
            Me.StopButt.Name = "StopButt"
            Me.PrevButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.PrevButt.Image = Resources.player_rew
            manager.ApplyResources(Me.PrevButt, "PrevButt")
            Me.PrevButt.Name = "PrevButt"
            Me.NextButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.NextButt.Image = Resources.player_fwd
            manager.ApplyResources(Me.NextButt, "NextButt")
            Me.NextButt.Name = "NextButt"
            Me.ElapsedTime.ForeColor = MySettings.Default.FontColor
            Me.ElapsedTime.Name = "ElapsedTime"
            manager.ApplyResources(Me.ElapsedTime, "ElapsedTime")
            Me.OfLabel.ForeColor = MySettings.Default.FontColor
            Me.OfLabel.Name = "OfLabel"
            manager.ApplyResources(Me.OfLabel, "OfLabel")
            Me.TotalTime.ForeColor = MySettings.Default.FontColor
            Me.TotalTime.Name = "TotalTime"
            manager.ApplyResources(Me.TotalTime, "TotalTime")
            Me.InfoButt.Alignment = ToolStripItemAlignment.Right
            Me.InfoButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.InfoButt.Image = Resources.messagebox_info
            manager.ApplyResources(Me.InfoButt, "InfoButt")
            Me.InfoButt.Name = "InfoButt"
            manager.ApplyResources(Me.VolumeButt, "VolumeButt")
            Me.VolumeButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.VolumeButt.Image = Resources.amarok
            Dim padding As New Padding(15, 1, 0, 2)
            Me.VolumeButt.Margin = padding
            Me.VolumeButt.Name = "VolumeButt"
            manager.ApplyResources(Me.VolumeProg, "VolumeProg")
            Me.VolumeProg.Maximum = &H2710
            Me.VolumeProg.Name = "VolumeProg"
            Me.VolumeProg.Style = ProgressBarStyle.Continuous
            Me.VolumeProg.Value = MySettings.Default.Volume
            Me.MainTool.BackgroundImage = Resources.Blue_31
            Me.MainTool.CanOverflow = False
            Me.MainTool.GripStyle = ToolStripGripStyle.Hidden
            size = New Size(&H18, &H18)
            Me.MainTool.ImageScalingSize = size
            toolStripItems = New ToolStripItem() { Me.ApriButt, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripButton7, Me.ToolStripButton6, Me.InfoLab }
            Me.MainTool.Items.AddRange(toolStripItems)
            manager.ApplyResources(Me.MainTool, "MainTool")
            Me.MainTool.Name = "MainTool"
            Me.ApriButt.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ApriButt.Image = Resources.folder_yellow
            manager.ApplyResources(Me.ApriButt, "ApriButt")
            Me.ApriButt.Name = "ApriButt"
            Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
            manager.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
            Me.ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton1.Image = Resources.configure
            manager.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton7.Image = Resources.download_manager
            manager.ApplyResources(Me.ToolStripButton7, "ToolStripButton7")
            Me.ToolStripButton7.Name = "ToolStripButton7"
            Me.ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image
            Me.ToolStripButton6.Image = Resources.messagebox_info
            manager.ApplyResources(Me.ToolStripButton6, "ToolStripButton6")
            Me.ToolStripButton6.Name = "ToolStripButton6"
            manager.ApplyResources(Me.InfoLab, "InfoLab")
            Me.InfoLab.ForeColor = MySettings.Default.FontColor
            Me.InfoLab.Name = "InfoLab"
            manager.ApplyResources(Me.ProgressBar, "ProgressBar")
            Me.ProgressBar.BackColor = Color.White
            Me.ProgressBar.BarColor = BarColors.Blue
            Me.ProgressBar.Cursor = Cursors.VSplit
            Me.ProgressBar.Maximum = 1
            Me.ProgressBar.Minimum = 0
            size = New Size(20, 5)
            Me.ProgressBar.MinimumSize = size
            Me.ProgressBar.Name = "ProgressBar"
            Me.ProgressBar.Value = 0
            manager.ApplyResources(Me.ColumnHeader1, "ColumnHeader1")
            manager.ApplyResources(Me, "$this")
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = MySettings.Default.Color
            Me.Controls.Add(Me.ProgressBar)
            Me.Controls.Add(Me.SplitContainer1)
            Me.Controls.Add(Me.PlayerTool)
            Me.Controls.Add(Me.MainTool)
            Me.DataBindings.Add(New Binding("BackColor", MySettings.Default, "Color", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.Name = "Main"
            Me.PlaylistTool.ResumeLayout(False)
            Me.PlaylistTool.PerformLayout
            Me.SplitContainer1.Panel1.ResumeLayout(False)
            Me.SplitContainer1.Panel2.ResumeLayout(False)
            Me.SplitContainer1.ResumeLayout(False)
            Me.PlayerTool.ResumeLayout(False)
            Me.PlayerTool.PerformLayout
            Me.MainTool.ResumeLayout(False)
            Me.MainTool.PerformLayout
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Public Sub LoadSettings()
            Dim color As Color = MySettingsProperty.Settings.Color
            If (color = Color.CornflowerBlue) Then
                Me.MainTool.BackgroundImage = Resources.Blue_31
                Me.PlayerTool.BackgroundImage = Resources.Blue_39
                Me.ProgressBar.BarColor = BarColors.Blue
            ElseIf (color = Color.DeepSkyBlue) Then
                Me.MainTool.BackgroundImage = Resources.lightblue_31
                Me.PlayerTool.BackgroundImage = Resources.lightblue_39
                Me.ProgressBar.BarColor = BarColors.Blue
            ElseIf (color = Color.GreenYellow) Then
                Me.MainTool.BackgroundImage = Resources.green_31
                Me.PlayerTool.BackgroundImage = Resources.green_39
                Me.ProgressBar.BarColor = BarColors.Green
            ElseIf (color = Color.Yellow) Then
                Me.MainTool.BackgroundImage = Resources.yellow_31
                Me.PlayerTool.BackgroundImage = Resources.yellow_39
                Me.ProgressBar.BarColor = BarColors.Yellow
            ElseIf (color = Color.Orange) Then
                Me.MainTool.BackgroundImage = Resources.orange_31
                Me.PlayerTool.BackgroundImage = Resources.orange_39
                Me.ProgressBar.BarColor = BarColors.Orange
            ElseIf (color = Color.Firebrick) Then
                Me.MainTool.BackgroundImage = Resources.red_31
                Me.PlayerTool.BackgroundImage = Resources.red_39
                Me.ProgressBar.BarColor = BarColors.Red
            ElseIf (color = Color.Violet) Then
                Me.MainTool.BackgroundImage = Resources.violet_31
                Me.PlayerTool.BackgroundImage = Resources.violet_39
                Me.ProgressBar.BarColor = BarColors.Violet
            ElseIf (color = Color.Gray) Then
                Me.MainTool.BackgroundImage = Resources.gray_31
                Me.PlayerTool.BackgroundImage = Resources.gray_39
                Me.ProgressBar.BarColor = BarColors.Black
            ElseIf (color = Color.Black) Then
                Me.MainTool.BackgroundImage = Resources.black_31
                Me.PlayerTool.BackgroundImage = Resources.black_39
                Me.ProgressBar.BarColor = BarColors.Black
            End If
        End Sub

        Private Sub NextButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.IsVideo Then
                Dim num As Integer = CInt(Math.Round(CDbl((Conversions.ToDouble(Me.AudioFile.CurrentPosition.ToString.Remove(Me.AudioFile.CurrentPosition.ToString.LastIndexOf(","), (Me.AudioFile.CurrentPosition.ToString.Length - Me.AudioFile.CurrentPosition.ToString.LastIndexOf(",")))) + 10))))
                Me.AudioFile.CurrentPosition = If((num >= 0), CDbl(num), 0)
            Else
                Dim num2 As Integer = CInt(Math.Round(CDbl((Conversions.ToDouble(Me.VideoFile.CurrentPosition.ToString.Remove(Me.VideoFile.CurrentPosition.ToString.LastIndexOf(","), (Me.VideoFile.CurrentPosition.ToString.Length - Me.VideoFile.CurrentPosition.ToString.LastIndexOf(",")))) + 10))))
                If (num2 < 0) Then
                    Me.AudioFile.CurrentPosition = 0
                Else
                    Me.VideoFile.CurrentPosition = num2
                End If
            End If
        End Sub

        Public Sub Play(ByVal File As String)
            If (Me.Status = 1) Then
                If Not Me.IsVideo Then
                    Me.AudioFile.Stop
                Else
                    Me.VideoFile.Stop
                End If
            End If
            Try 
                If Not Me.IsVideo Then
                    Me.AudioFile = Audio.FromFile(File, True)
                    Me.AudioFile.Volume = If(Not MySettingsProperty.Settings.VolumeOn, Conversions.ToInteger("-10000"), (MySettingsProperty.Settings.Volume - &H2710))
                    Me.AudioFile.Balance = (MySettingsProperty.Settings.Balance - &H1770)
                Else
                    Me.VideoFile = Video.FromFile(File, True)
                    Me.VideoFile.Owner = Me.VideoPan
                    Me.VideoFile.Audio.Volume = If(Not MySettingsProperty.Settings.VolumeOn, Conversions.ToInteger("-10000"), (MySettingsProperty.Settings.Volume - &H2710))
                    Me.VideoFile.Audio.Balance = (MySettingsProperty.Settings.Balance - &H1770)
                End If
                Me.FilePath = File
                Me.InfoLab.Text = MyProject.Computer.FileSystem.GetFileInfo(File).Name
                Me.Status = 1
                Me.Timer.Enabled = True
            Catch exception1 As Exception
                Dim ex As Exception = exception1
                ProjectData.SetProjectError(ex)
                Dim exception As Exception = ex
                MessageBox.Show("Impossibile aprire il file specificato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                ProjectData.ClearProjectError
                Return
            End Try
            If Not Me.IsVideo Then
                Me.ProgressBar.Maximum = CLng(Math.Round(Me.AudioFile.Duration))
                Me.TotalTime.Text = Me.GetDuration(CInt(Math.Round(Me.AudioFile.Duration)))
            Else
                Me.ProgressBar.Maximum = CLng(Math.Round(Me.VideoFile.Duration))
                Me.TotalTime.Text = Me.GetDuration(CInt(Math.Round(Me.VideoFile.Duration)))
            End If
            Me.PlayerTool.Enabled = True
            Me.PlayPauseButt.Image = Resources.player_pause
        End Sub

        Private Sub PlaylistView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.Play(Me.PlaylistView.SelectedItems(0).Name)
        End Sub

        Private Sub PlayPausa_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.IsVideo Then
                Select Case Me.Status
                    Case 0
                        Me.Play(Me.FilePath)
                        Me.PlayPauseButt.Image = Resources.player_play
                        Exit Select
                    Case 1
                        Me.AudioFile.Pause
                        Me.Status = 2
                        Me.PlayPauseButt.Image = Resources.player_play
                        Exit Select
                    Case 2
                        Me.AudioFile.Play
                        Me.Status = 1
                        Me.PlayPauseButt.Image = Resources.player_pause
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            Else
                Select Case Me.Status
                    Case 0
                        Me.Play(Me.FilePath)
                        Me.PlayPauseButt.Image = Resources.player_play
                        Exit Select
                    Case 1
                        Me.VideoFile.Pause
                        Me.Status = 2
                        Me.PlayPauseButt.Image = Resources.player_play
                        Exit Select
                    Case 2
                        Me.VideoFile.Play
                        Me.Status = 1
                        Me.PlayPauseButt.Image = Resources.player_pause
                        Exit Select
                    Case Else
                        Exit Select
                End Select
            End If
        End Sub

        Private Sub PrevButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.IsVideo Then
                Dim num As Integer = CInt(Math.Round(CDbl((Conversions.ToDouble(Me.AudioFile.CurrentPosition.ToString.Remove(Me.AudioFile.CurrentPosition.ToString.LastIndexOf(","), (Me.AudioFile.CurrentPosition.ToString.Length - Me.AudioFile.CurrentPosition.ToString.LastIndexOf(",")))) - 10))))
                Me.AudioFile.CurrentPosition = If((num >= 0), CDbl(num), 0)
            Else
                Dim num2 As Integer = CInt(Math.Round(CDbl((Conversions.ToDouble(Me.VideoFile.CurrentPosition.ToString.Remove(Me.VideoFile.CurrentPosition.ToString.LastIndexOf(","), (Me.VideoFile.CurrentPosition.ToString.Length - Me.VideoFile.CurrentPosition.ToString.LastIndexOf(",")))) - 10))))
                If (num2 < 0) Then
                    Me.AudioFile.CurrentPosition = 0
                Else
                    Me.VideoFile.CurrentPosition = num2
                End If
            End If
        End Sub

        Private Sub Principale_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.LoadSettings
            If MySettingsProperty.Settings.Updates Then
                Process.Start((Application.StartupPath & "Update.exe"))
                MySettingsProperty.Settings.Updates = False
                Application.Exit
            ElseIf MyProject.Computer.FileSystem.FileExists((Application.StartupPath & "Update.exe")) Then
                MyProject.Computer.FileSystem.DeleteFile((Application.StartupPath & "Update.exe"), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently)
            End If
        End Sub

        Private Sub ProgressBar_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.Status <> 0) Then
                If Not Me.IsVideo Then
                    Me.AudioFile.CurrentPosition = Conversions.ToDouble(Me.GetTime(CInt(Me.ProgressBar.Maximum), Me.ProgressBar.Width, (Control.MousePosition.X - Me.Location.X)))
                Else
                    Me.VideoFile.CurrentPosition = Conversions.ToDouble(Me.GetTime(CInt(Me.ProgressBar.Maximum), Me.ProgressBar.Width, (Control.MousePosition.X - Me.Location.X)))
                End If
            End If
        End Sub

        Private Sub ProgressBar_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim time As Integer = Conversions.ToInteger(Me.GetTime(CInt(Me.ProgressBar.Maximum), Me.ProgressBar.Width, (Control.MousePosition.X - Me.Location.X)))
            Me.TimeToolTip.Show(Me.GetDuration(time), Me.ProgressBar, (Control.MousePosition.X - Me.Location.X), Conversions.ToInteger("30"), Conversions.ToInteger("1000"))
        End Sub

        Private Sub RemoveButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.PlaylistView.SelectedItems.Count <> 0) Then
                Me.PlaylistView.SelectedItems(0).Remove
            End If
        End Sub

        Private Sub Stopp_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.IsVideo Then
                Me.AudioFile.Stop
            Else
                Me.VideoFile.Stop
            End If
            Me.PlayPauseButt.Image = Resources.player_play
            Me.Timer.Enabled = False
            Me.Status = 0
        End Sub

        Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.IsVideo Then
                Me.ProgressBar.Value = CLng(Math.Round(Me.AudioFile.CurrentPosition))
                Me.ElapsedTime.Text = Me.GetDuration(CInt(Math.Round(Me.AudioFile.CurrentPosition)))
                Me.AudioFile.Balance = (MySettingsProperty.Settings.Balance - &H1770)
                Me.AudioFile.Volume = If(Not MySettingsProperty.Settings.VolumeOn, Conversions.ToInteger("-10000"), (MySettingsProperty.Settings.Volume - &H2710))
            Else
                Me.ProgressBar.Value = CLng(Math.Round(Me.VideoFile.CurrentPosition))
                Me.ElapsedTime.Text = Me.GetDuration(CInt(Math.Round(Me.VideoFile.CurrentPosition)))
                Me.VideoFile.Audio.Volume = If(Not MySettingsProperty.Settings.VolumeOn, Conversions.ToInteger("-10000"), (MySettingsProperty.Settings.Volume - &H2710))
                Me.VideoFile.Audio.Balance = (MySettingsProperty.Settings.Balance - &H1770)
            End If
        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Settings.Show
        End Sub

        Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.About.Show
        End Sub

        Private Sub ToolStripButton7_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.Updates.Show
        End Sub

        Private Sub VideoPan_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            If Me.IsVideo Then
                Me.VideoFile.Fullscreen = Not Me.VideoFile.Fullscreen
            End If
        End Sub

        Private Sub VolumeProg_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.VolumeProg.Value = Conversions.ToInteger(Me.GetTime(Me.VolumeProg.Maximum, Me.VolumeProg.Width, ((Control.MousePosition.X - Me.Location.X) - &H10F)))
        End Sub


        ' Properties
        Friend Overridable Property MainTool As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._MainTool
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._MainTool = WithEventsValue
            End Set
        End Property

        Friend Overridable Property InfoLab As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoLab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._InfoLab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ApriDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._ApriDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                If (Not Me._ApriDial Is Nothing) Then
                    RemoveHandler Me._ApriDial.FileOk, New CancelEventHandler(AddressOf Me.Apri_FileOk)
                End If
                Me._ApriDial = WithEventsValue
                If (Not Me._ApriDial Is Nothing) Then
                    AddHandler Me._ApriDial.FileOk, New CancelEventHandler(AddressOf Me.Apri_FileOk)
                End If
            End Set
        End Property

        Friend Overridable Property ApriButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ApriButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ApriButt Is Nothing) Then
                    RemoveHandler Me._ApriButt.Click, New EventHandler(AddressOf Me.ApriButt_Click)
                End If
                Me._ApriButt = WithEventsValue
                If (Not Me._ApriButt Is Nothing) Then
                    AddHandler Me._ApriButt.Click, New EventHandler(AddressOf Me.ApriButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PlayerTool As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._PlayerTool
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._PlayerTool = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PlayPauseButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PlayPauseButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._PlayPauseButt Is Nothing) Then
                    RemoveHandler Me._PlayPauseButt.Click, New EventHandler(AddressOf Me.PlayPausa_Click)
                End If
                Me._PlayPauseButt = WithEventsValue
                If (Not Me._PlayPauseButt Is Nothing) Then
                    AddHandler Me._PlayPauseButt.Click, New EventHandler(AddressOf Me.PlayPausa_Click)
                End If
            End Set
        End Property

        Friend Overridable Property StopButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._StopButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._StopButt Is Nothing) Then
                    RemoveHandler Me._StopButt.Click, New EventHandler(AddressOf Me.Stopp_Click)
                End If
                Me._StopButt = WithEventsValue
                If (Not Me._StopButt Is Nothing) Then
                    AddHandler Me._StopButt.Click, New EventHandler(AddressOf Me.Stopp_Click)
                End If
            End Set
        End Property

        Friend Overridable Property PrevButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._PrevButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._PrevButt Is Nothing) Then
                    RemoveHandler Me._PrevButt.Click, New EventHandler(AddressOf Me.PrevButt_Click)
                End If
                Me._PrevButt = WithEventsValue
                If (Not Me._PrevButt Is Nothing) Then
                    AddHandler Me._PrevButt.Click, New EventHandler(AddressOf Me.PrevButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property NextButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._NextButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._NextButt Is Nothing) Then
                    RemoveHandler Me._NextButt.Click, New EventHandler(AddressOf Me.NextButt_Click)
                End If
                Me._NextButt = WithEventsValue
                If (Not Me._NextButt Is Nothing) Then
                    AddHandler Me._NextButt.Click, New EventHandler(AddressOf Me.NextButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OfLabel As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._OfLabel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._OfLabel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TotalTime As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._TotalTime
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._TotalTime = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripButton1 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton1 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton1.Click, New EventHandler(AddressOf Me.ToolStripButton1_Click)
                End If
                Me._ToolStripButton1 = WithEventsValue
                If (Not Me._ToolStripButton1 Is Nothing) Then
                    AddHandler Me._ToolStripButton1.Click, New EventHandler(AddressOf Me.ToolStripButton1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripButton6 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton6 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton6.Click, New EventHandler(AddressOf Me.ToolStripButton6_Click)
                End If
                Me._ToolStripButton6 = WithEventsValue
                If (Not Me._ToolStripButton6 Is Nothing) Then
                    AddHandler Me._ToolStripButton6.Click, New EventHandler(AddressOf Me.ToolStripButton6_Click)
                End If
            End Set
        End Property

        Friend Overridable Property InfoButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._InfoButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._InfoButt Is Nothing) Then
                    RemoveHandler Me._InfoButt.Click, New EventHandler(AddressOf Me.InfoButt_Click)
                End If
                Me._InfoButt = WithEventsValue
                If (Not Me._InfoButt Is Nothing) Then
                    AddHandler Me._InfoButt.Click, New EventHandler(AddressOf Me.InfoButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property Timer As Timer
            <DebuggerNonUserCode> _
            Get
                Return Me._Timer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._Timer Is Nothing) Then
                    RemoveHandler Me._Timer.Tick, New EventHandler(AddressOf Me.Timer_Tick)
                End If
                Me._Timer = WithEventsValue
                If (Not Me._Timer Is Nothing) Then
                    AddHandler Me._Timer.Tick, New EventHandler(AddressOf Me.Timer_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property ElapsedTime As ToolStripLabel
            <DebuggerNonUserCode> _
            Get
                Return Me._ElapsedTime
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripLabel)
                Me._ElapsedTime = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TimeToolTip As ToolTip
            <DebuggerNonUserCode> _
            Get
                Return Me._TimeToolTip
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolTip)
                Me._TimeToolTip = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripSeparator2 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripSeparator2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripSeparator2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PlaylistView As ListView
            <DebuggerNonUserCode> _
            Get
                Return Me._PlaylistView
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._PlaylistView Is Nothing) Then
                    RemoveHandler Me._PlaylistView.DoubleClick, New EventHandler(AddressOf Me.PlaylistView_DoubleClick)
                End If
                Me._PlaylistView = WithEventsValue
                If (Not Me._PlaylistView Is Nothing) Then
                    AddHandler Me._PlaylistView.DoubleClick, New EventHandler(AddressOf Me.PlaylistView_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property PlaylistTool As ToolStrip
            <DebuggerNonUserCode> _
            Get
                Return Me._PlaylistTool
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStrip)
                Me._PlaylistTool = WithEventsValue
            End Set
        End Property

        Friend Overridable Property AddButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._AddButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._AddButt Is Nothing) Then
                    RemoveHandler Me._AddButt.Click, New EventHandler(AddressOf Me.AddButt_Click)
                End If
                Me._AddButt = WithEventsValue
                If (Not Me._AddButt Is Nothing) Then
                    AddHandler Me._AddButt.Click, New EventHandler(AddressOf Me.AddButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property RemoveButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RemoveButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._RemoveButt Is Nothing) Then
                    RemoveHandler Me._RemoveButt.Click, New EventHandler(AddressOf Me.RemoveButt_Click)
                End If
                Me._RemoveButt = WithEventsValue
                If (Not Me._RemoveButt Is Nothing) Then
                    AddHandler Me._RemoveButt.Click, New EventHandler(AddressOf Me.RemoveButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property UpButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._UpButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._UpButt = WithEventsValue
            End Set
        End Property

        Friend Overridable Property DownButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._DownButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._DownButt = WithEventsValue
            End Set
        End Property

        Friend Overridable Property PlaylistImgList As ImageList
            <DebuggerNonUserCode> _
            Get
                Return Me._PlaylistImgList
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ImageList)
                Me._PlaylistImgList = WithEventsValue
            End Set
        End Property

        Friend Overridable Property SplitContainer1 As SplitContainer
            <DebuggerNonUserCode> _
            Get
                Return Me._SplitContainer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As SplitContainer)
                Me._SplitContainer1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VideoPan As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._VideoPan
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                If (Not Me._VideoPan Is Nothing) Then
                    RemoveHandler Me._VideoPan.MouseDoubleClick, New MouseEventHandler(AddressOf Me.VideoPan_MouseDoubleClick)
                End If
                Me._VideoPan = WithEventsValue
                If (Not Me._VideoPan Is Nothing) Then
                    AddHandler Me._VideoPan.MouseDoubleClick, New MouseEventHandler(AddressOf Me.VideoPan_MouseDoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripButton7 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton7
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                If (Not Me._ToolStripButton7 Is Nothing) Then
                    RemoveHandler Me._ToolStripButton7.Click, New EventHandler(AddressOf Me.ToolStripButton7_Click)
                End If
                Me._ToolStripButton7 = WithEventsValue
                If (Not Me._ToolStripButton7 Is Nothing) Then
                    AddHandler Me._ToolStripButton7.Click, New EventHandler(AddressOf Me.ToolStripButton7_Click)
                End If
            End Set
        End Property

        Friend Overridable Property AddDial As OpenFileDialog
            <DebuggerNonUserCode> _
            Get
                Return Me._AddDial
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As OpenFileDialog)
                Me._AddDial = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VolumeButt As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._VolumeButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._VolumeButt = WithEventsValue
            End Set
        End Property

        Friend Overridable Property VolumeProg As ToolStripProgressBar
            <DebuggerNonUserCode> _
            Get
                Return Me._VolumeProg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripProgressBar)
                If (Not Me._VolumeProg Is Nothing) Then
                    RemoveHandler Me._VolumeProg.Click, New EventHandler(AddressOf Me.VolumeProg_Click)
                End If
                Me._VolumeProg = WithEventsValue
                If (Not Me._VolumeProg Is Nothing) Then
                    AddHandler Me._VolumeProg.Click, New EventHandler(AddressOf Me.VolumeProg_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ToolStripButton2 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._ToolStripButton2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripButton3 As ToolStripButton
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripButton3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripButton)
                Me._ToolStripButton3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
            <DebuggerNonUserCode> _
            Get
                Return Me._ToolStripSeparator1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ToolStripSeparator)
                Me._ToolStripSeparator1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ProgressBar As PowerProgressbar
            <DebuggerNonUserCode> _
            Get
                Return Me._ProgressBar
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As PowerProgressbar)
                If (Not Me._ProgressBar Is Nothing) Then
                    RemoveHandler Me._ProgressBar.MouseMove, New MouseEventHandler(AddressOf Me.ProgressBar_MouseMove)
                    RemoveHandler Me._ProgressBar.Click, New EventHandler(AddressOf Me.ProgressBar_Click)
                End If
                Me._ProgressBar = WithEventsValue
                If (Not Me._ProgressBar Is Nothing) Then
                    AddHandler Me._ProgressBar.MouseMove, New MouseEventHandler(AddressOf Me.ProgressBar_MouseMove)
                    AddHandler Me._ProgressBar.Click, New EventHandler(AddressOf Me.ProgressBar_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ColumnHeader1 As ColumnHeader
            <DebuggerNonUserCode> _
            Get
                Return Me._ColumnHeader1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As ColumnHeader)
                Me._ColumnHeader1 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("MainTool")> _
        Private _MainTool As ToolStrip
        <AccessedThroughProperty("InfoLab")> _
        Private _InfoLab As ToolStripLabel
        <AccessedThroughProperty("ApriDial")> _
        Private _ApriDial As OpenFileDialog
        <AccessedThroughProperty("ApriButt")> _
        Private _ApriButt As ToolStripButton
        <AccessedThroughProperty("PlayerTool")> _
        Private _PlayerTool As ToolStrip
        <AccessedThroughProperty("PlayPauseButt")> _
        Private _PlayPauseButt As ToolStripButton
        <AccessedThroughProperty("StopButt")> _
        Private _StopButt As ToolStripButton
        <AccessedThroughProperty("PrevButt")> _
        Private _PrevButt As ToolStripButton
        <AccessedThroughProperty("NextButt")> _
        Private _NextButt As ToolStripButton
        <AccessedThroughProperty("OfLabel")> _
        Private _OfLabel As ToolStripLabel
        <AccessedThroughProperty("TotalTime")> _
        Private _TotalTime As ToolStripLabel
        <AccessedThroughProperty("ToolStripButton1")> _
        Private _ToolStripButton1 As ToolStripButton
        <AccessedThroughProperty("ToolStripButton6")> _
        Private _ToolStripButton6 As ToolStripButton
        <AccessedThroughProperty("InfoButt")> _
        Private _InfoButt As ToolStripButton
        <AccessedThroughProperty("Timer")> _
        Private _Timer As Timer
        <AccessedThroughProperty("ElapsedTime")> _
        Private _ElapsedTime As ToolStripLabel
        <AccessedThroughProperty("TimeToolTip")> _
        Private _TimeToolTip As ToolTip
        <AccessedThroughProperty("ToolStripSeparator2")> _
        Private _ToolStripSeparator2 As ToolStripSeparator
        <AccessedThroughProperty("PlaylistView")> _
        Private _PlaylistView As ListView
        <AccessedThroughProperty("PlaylistTool")> _
        Private _PlaylistTool As ToolStrip
        <AccessedThroughProperty("AddButt")> _
        Private _AddButt As ToolStripButton
        <AccessedThroughProperty("RemoveButt")> _
        Private _RemoveButt As ToolStripButton
        <AccessedThroughProperty("UpButt")> _
        Private _UpButt As ToolStripButton
        <AccessedThroughProperty("DownButt")> _
        Private _DownButt As ToolStripButton
        <AccessedThroughProperty("PlaylistImgList")> _
        Private _PlaylistImgList As ImageList
        <AccessedThroughProperty("SplitContainer1")> _
        Private _SplitContainer1 As SplitContainer
        <AccessedThroughProperty("VideoPan")> _
        Private _VideoPan As Panel
        <AccessedThroughProperty("ToolStripButton7")> _
        Private _ToolStripButton7 As ToolStripButton
        <AccessedThroughProperty("AddDial")> _
        Private _AddDial As OpenFileDialog
        <AccessedThroughProperty("VolumeButt")> _
        Private _VolumeButt As ToolStripButton
        <AccessedThroughProperty("VolumeProg")> _
        Private _VolumeProg As ToolStripProgressBar
        <AccessedThroughProperty("ToolStripButton2")> _
        Private _ToolStripButton2 As ToolStripButton
        <AccessedThroughProperty("ToolStripButton3")> _
        Private _ToolStripButton3 As ToolStripButton
        <AccessedThroughProperty("ToolStripSeparator1")> _
        Private _ToolStripSeparator1 As ToolStripSeparator
        <AccessedThroughProperty("ProgressBar")> _
        Private _ProgressBar As PowerProgressbar
        <AccessedThroughProperty("ColumnHeader1")> _
        Private _ColumnHeader1 As ColumnHeader
        Private Status As Byte
        Private AudioFile As Audio
        Private VideoFile As Video
        Private IsVideo As Boolean
        Private FilePath As String
    End Class
End Namespace

