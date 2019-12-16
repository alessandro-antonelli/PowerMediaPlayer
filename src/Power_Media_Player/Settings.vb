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
    Public Class Settings
        Inherits Form
        ' Methods
        <DebuggerNonUserCode> _
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.Settings_Load)
            Me.InitializeComponent
        End Sub

        Public Sub Apply()
            If Me.BlueRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.CornflowerBlue
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.Blue_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.Blue_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Blue
            End If
            If Me.CyanRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.DeepSkyBlue
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.lightblue_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.lightblue_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Blue
            End If
            If Me.GreenRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.GreenYellow
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.green_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.green_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Green
            End If
            If Me.YellowRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.Yellow
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.yellow_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.yellow_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Yellow
            End If
            If Me.OrangeRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.Orange
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.orange_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.orange_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Orange
            End If
            If Me.RedRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.Firebrick
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.red_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.red_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Red
            End If
            If Me.VioletRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.Violet
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.violet_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.violet_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Violet
            End If
            If Me.GreyRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.Gray
                MySettingsProperty.Settings.FontColor = Color.Black
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.gray_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.gray_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Black
            End If
            If Me.BlackRadio.Checked Then
                MySettingsProperty.Settings.Color = Color.Black
                MySettingsProperty.Settings.FontColor = Color.Azure
                MyProject.Forms.Main.MainTool.BackgroundImage = Resources.black_31
                MyProject.Forms.Main.PlayerTool.BackgroundImage = Resources.black_39
                MyProject.Forms.Main.ProgressBar.BarColor = BarColors.Black
            End If
            MySettingsProperty.Settings.Save
        End Sub

        Private Sub ApplyButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Apply
        End Sub

        Private Sub BlackRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.BlackRadio.Checked Then
                Me.ColorPanel.BackColor = Color.Black
            End If
        End Sub

        Private Sub BlueRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.BlueRadio.Checked Then
                Me.ColorPanel.BackColor = Color.CornflowerBlue
            End If
        End Sub

        Private Sub CancelButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
        End Sub

        Private Sub CyanRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.CyanRadio.Checked Then
                Me.ColorPanel.BackColor = Color.DeepSkyBlue
            End If
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub GreenRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.GreenRadio.Checked Then
                Me.ColorPanel.BackColor = Color.GreenYellow
            End If
        End Sub

        Private Sub GreyRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.GreyRadio.Checked Then
                Me.ColorPanel.BackColor = Color.Gray
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(Settings))
            Me.ResetButt = New Button
            Me.CancelButt = New Button
            Me.ApplyButt = New Button
            Me.OKButt = New Button
            Me.SettingsTab = New TabControl
            Me.LookTab = New TabPage
            Me.GroupBox1 = New GroupBox
            Me.BlackRadio = New RadioButton
            Me.ColorPanel = New Panel
            Me.YellowRadio = New RadioButton
            Me.BlueRadio = New RadioButton
            Me.VioletRadio = New RadioButton
            Me.CyanRadio = New RadioButton
            Me.RedRadio = New RadioButton
            Me.GreenRadio = New RadioButton
            Me.OrangeRadio = New RadioButton
            Me.GreyRadio = New RadioButton
            Me.AudioTab = New TabPage
            Me.Label2 = New Label
            Me.Label4 = New Label
            Me.TrackBar2 = New TrackBar
            Me.CheckBox1 = New CheckBox
            Me.Label3 = New Label
            Me.TrackBar1 = New TrackBar
            Me.VideoTab = New TabPage
            Me.GroupBox2 = New GroupBox
            Me.RadioButton1 = New RadioButton
            Me.RadioButton3 = New RadioButton
            Me.RadioButton2 = New RadioButton
            Me.CheckBox2 = New CheckBox
            Me.SettingsTab.SuspendLayout
            Me.LookTab.SuspendLayout
            Me.GroupBox1.SuspendLayout
            Me.AudioTab.SuspendLayout
            Me.TrackBar2.BeginInit
            Me.TrackBar1.BeginInit
            Me.VideoTab.SuspendLayout
            Me.GroupBox2.SuspendLayout
            Me.SuspendLayout
            Me.ResetButt.Anchor = (AnchorStyles.Left Or AnchorStyles.Bottom)
            Dim point As New Point(12, &H14B)
            Me.ResetButt.Location = point
            Me.ResetButt.Name = "ResetButt"
            Dim size As New Size(&H4B, &H17)
            Me.ResetButt.Size = size
            Me.ResetButt.TabIndex = 9
            Me.ResetButt.Text = "&Reimposta"
            Me.ResetButt.UseVisualStyleBackColor = True
            Me.CancelButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&HF3, &H14B)
            Me.CancelButt.Location = point
            Me.CancelButt.Name = "CancelButt"
            size = New Size(&H4B, &H17)
            Me.CancelButt.Size = size
            Me.CancelButt.TabIndex = 8
            Me.CancelButt.Text = "&Annulla"
            Me.CancelButt.UseVisualStyleBackColor = True
            Me.ApplyButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H144, &H14B)
            Me.ApplyButt.Location = point
            Me.ApplyButt.Name = "ApplyButt"
            size = New Size(&H4B, &H17)
            Me.ApplyButt.Size = size
            Me.ApplyButt.TabIndex = 7
            Me.ApplyButt.Text = "A&pplica"
            Me.ApplyButt.UseVisualStyleBackColor = True
            Me.OKButt.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
            point = New Point(&H195, &H14B)
            Me.OKButt.Location = point
            Me.OKButt.Name = "OKButt"
            size = New Size(&H4B, &H17)
            Me.OKButt.Size = size
            Me.OKButt.TabIndex = 6
            Me.OKButt.Text = "&OK"
            Me.OKButt.UseVisualStyleBackColor = True
            Me.SettingsTab.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Me.SettingsTab.Controls.Add(Me.LookTab)
            Me.SettingsTab.Controls.Add(Me.AudioTab)
            Me.SettingsTab.Controls.Add(Me.VideoTab)
            point = New Point(12, 12)
            Me.SettingsTab.Location = point
            Me.SettingsTab.Name = "SettingsTab"
            Me.SettingsTab.SelectedIndex = 0
            size = New Size(&H1D4, &H139)
            Me.SettingsTab.Size = size
            Me.SettingsTab.TabIndex = 5
            Me.LookTab.Controls.Add(Me.GroupBox1)
            point = New Point(4, &H16)
            Me.LookTab.Location = point
            Me.LookTab.Name = "LookTab"
            Dim padding As New Padding(3)
            Me.LookTab.Padding = padding
            size = New Size(460, &H11F)
            Me.LookTab.Size = size
            Me.LookTab.TabIndex = 1
            Me.LookTab.Text = "Aspetto"
            Me.LookTab.UseVisualStyleBackColor = True
            Me.GroupBox1.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or AnchorStyles.Top))
            Me.GroupBox1.Controls.Add(Me.BlackRadio)
            Me.GroupBox1.Controls.Add(Me.ColorPanel)
            Me.GroupBox1.Controls.Add(Me.YellowRadio)
            Me.GroupBox1.Controls.Add(Me.BlueRadio)
            Me.GroupBox1.Controls.Add(Me.VioletRadio)
            Me.GroupBox1.Controls.Add(Me.CyanRadio)
            Me.GroupBox1.Controls.Add(Me.RedRadio)
            Me.GroupBox1.Controls.Add(Me.GreenRadio)
            Me.GroupBox1.Controls.Add(Me.OrangeRadio)
            Me.GroupBox1.Controls.Add(Me.GreyRadio)
            point = New Point(6, 6)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&H1C0, &H5B)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = 9
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Colore del player"
            Me.BlackRadio.AutoSize = True
            point = New Point(&HFB, &H42)
            Me.BlackRadio.Location = point
            Me.BlackRadio.Name = "BlackRadio"
            size = New Size(&H30, &H11)
            Me.BlackRadio.Size = size
            Me.BlackRadio.TabIndex = 11
            Me.BlackRadio.Text = "Nero"
            Me.BlackRadio.UseVisualStyleBackColor = True
            Me.ColorPanel.BackColor = Color.CornflowerBlue
            point = New Point(6, &H13)
            Me.ColorPanel.Location = point
            Me.ColorPanel.Name = "ColorPanel"
            size = New Size(&H40, &H40)
            Me.ColorPanel.Size = size
            Me.ColorPanel.TabIndex = 10
            Me.YellowRadio.AutoSize = True
            point = New Point(&HAC, &H13)
            Me.YellowRadio.Location = point
            Me.YellowRadio.Name = "YellowRadio"
            size = New Size(&H33, &H11)
            Me.YellowRadio.Size = size
            Me.YellowRadio.TabIndex = 8
            Me.YellowRadio.Text = "Giallo"
            Me.YellowRadio.UseVisualStyleBackColor = True
            Me.BlueRadio.AutoSize = True
            Me.BlueRadio.Checked = True
            point = New Point(&H4C, &H13)
            Me.BlueRadio.Location = point
            Me.BlueRadio.Name = "BlueRadio"
            size = New Size(40, &H11)
            Me.BlueRadio.Size = size
            Me.BlueRadio.TabIndex = 1
            Me.BlueRadio.TabStop = True
            Me.BlueRadio.Text = "Blu"
            Me.BlueRadio.UseVisualStyleBackColor = True
            Me.VioletRadio.AutoSize = True
            point = New Point(&HFB, &H13)
            Me.VioletRadio.Location = point
            Me.VioletRadio.Name = "VioletRadio"
            size = New Size(&H30, &H11)
            Me.VioletRadio.Size = size
            Me.VioletRadio.TabIndex = 7
            Me.VioletRadio.Text = "Viola"
            Me.VioletRadio.UseVisualStyleBackColor = True
            Me.CyanRadio.AutoSize = True
            point = New Point(&H4C, &H2A)
            Me.CyanRadio.Location = point
            Me.CyanRadio.Name = "CyanRadio"
            size = New Size(60, &H11)
            Me.CyanRadio.Size = size
            Me.CyanRadio.TabIndex = 2
            Me.CyanRadio.Text = "Celeste"
            Me.CyanRadio.UseVisualStyleBackColor = True
            Me.RedRadio.AutoSize = True
            point = New Point(&HAC, &H41)
            Me.RedRadio.Location = point
            Me.RedRadio.Name = "RedRadio"
            size = New Size(&H37, &H11)
            Me.RedRadio.Size = size
            Me.RedRadio.TabIndex = 6
            Me.RedRadio.Text = "Rosso"
            Me.RedRadio.UseVisualStyleBackColor = True
            Me.GreenRadio.AutoSize = True
            point = New Point(&H4C, &H41)
            Me.GreenRadio.Location = point
            Me.GreenRadio.Name = "GreenRadio"
            size = New Size(&H35, &H11)
            Me.GreenRadio.Size = size
            Me.GreenRadio.TabIndex = 3
            Me.GreenRadio.Text = "Verde"
            Me.GreenRadio.UseVisualStyleBackColor = True
            Me.OrangeRadio.AutoSize = True
            point = New Point(&HAC, &H2A)
            Me.OrangeRadio.Location = point
            Me.OrangeRadio.Name = "OrangeRadio"
            size = New Size(&H49, &H11)
            Me.OrangeRadio.Size = size
            Me.OrangeRadio.TabIndex = 5
            Me.OrangeRadio.Text = "Arancione"
            Me.OrangeRadio.UseVisualStyleBackColor = True
            Me.GreyRadio.AutoSize = True
            point = New Point(&HFB, &H2A)
            Me.GreyRadio.Location = point
            Me.GreyRadio.Name = "GreyRadio"
            size = New Size(&H34, &H11)
            Me.GreyRadio.Size = size
            Me.GreyRadio.TabIndex = 4
            Me.GreyRadio.Text = "Grigio"
            Me.GreyRadio.UseVisualStyleBackColor = True
            Me.AudioTab.Controls.Add(Me.Label2)
            Me.AudioTab.Controls.Add(Me.Label4)
            Me.AudioTab.Controls.Add(Me.TrackBar2)
            Me.AudioTab.Controls.Add(Me.CheckBox1)
            Me.AudioTab.Controls.Add(Me.Label3)
            Me.AudioTab.Controls.Add(Me.TrackBar1)
            point = New Point(4, &H16)
            Me.AudioTab.Location = point
            Me.AudioTab.Name = "AudioTab"
            padding = New Padding(3)
            Me.AudioTab.Padding = padding
            size = New Size(460, &H11F)
            Me.AudioTab.Size = size
            Me.AudioTab.TabIndex = 2
            Me.AudioTab.Text = "Audio"
            Me.AudioTab.UseVisualStyleBackColor = True
            Me.Label2.AutoSize = True
            Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(6, &H39)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H56, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 40
            Me.Label2.Text = "Bilanciamento"
            Me.Label4.AutoSize = True
            Me.Label4.ImeMode = ImeMode.NoControl
            point = New Point(&H23, &H4F)
            Me.Label4.Location = point
            Me.Label4.Name = "Label4"
            size = New Size(13, 13)
            Me.Label4.Size = size
            Me.Label4.TabIndex = &H27
            Me.Label4.Text = "0"
            Me.TrackBar2.Anchor = (AnchorStyles.Right Or AnchorStyles.Left)
            Me.TrackBar2.DataBindings.Add(New Binding("Value", MySettings.Default, "Balance", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TrackBar2.ImeMode = ImeMode.NoControl
            Me.TrackBar2.LargeChange = 400
            point = New Point(&H62, &H39)
            Me.TrackBar2.Location = point
            Me.TrackBar2.Maximum = &H2EE0
            Me.TrackBar2.Name = "TrackBar2"
            size = New Size(&H164, &H2D)
            Me.TrackBar2.Size = size
            Me.TrackBar2.SmallChange = 400
            Me.TrackBar2.TabIndex = &H24
            Me.TrackBar2.TickFrequency = 500
            Me.TrackBar2.TickStyle = TickStyle.Both
            Me.TrackBar2.Value = MySettings.Default.Balance
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Checked = MySettings.Default.VolumeOn
            Me.CheckBox1.CheckState = CheckState.Checked
            Me.CheckBox1.DataBindings.Add(New Binding("Checked", MySettings.Default, "VolumeOn", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.CheckBox1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(6, 6)
            Me.CheckBox1.Location = point
            Me.CheckBox1.Name = "CheckBox1"
            size = New Size(&H43, &H11)
            Me.CheckBox1.Size = size
            Me.CheckBox1.TabIndex = 6
            Me.CheckBox1.Text = "Volume"
            Me.CheckBox1.UseVisualStyleBackColor = True
            Me.Label3.AutoSize = True
            Me.Label3.DataBindings.Add(New Binding("Enabled", MySettings.Default, "VolumeOn", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.Label3.Enabled = MySettings.Default.VolumeOn
            point = New Point(&H1D, &H1B)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H19, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "100"
            Me.TrackBar1.Anchor = (AnchorStyles.Right Or AnchorStyles.Left)
            Me.TrackBar1.DataBindings.Add(New Binding("Enabled", MySettings.Default, "VolumeOn", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TrackBar1.DataBindings.Add(New Binding("Value", MySettings.Default, "Volume", True, DataSourceUpdateMode.OnPropertyChanged))
            Me.TrackBar1.Enabled = MySettings.Default.VolumeOn
            Me.TrackBar1.LargeChange = 500
            point = New Point(&H62, 6)
            Me.TrackBar1.Location = point
            Me.TrackBar1.Maximum = &H2710
            Me.TrackBar1.Name = "TrackBar1"
            size = New Size(&H164, &H2D)
            Me.TrackBar1.Size = size
            Me.TrackBar1.SmallChange = 250
            Me.TrackBar1.TabIndex = 0
            Me.TrackBar1.TickFrequency = 500
            Me.TrackBar1.TickStyle = TickStyle.Both
            Me.TrackBar1.Value = MySettings.Default.Volume
            Me.VideoTab.Controls.Add(Me.GroupBox2)
            Me.VideoTab.Controls.Add(Me.CheckBox2)
            point = New Point(4, &H16)
            Me.VideoTab.Location = point
            Me.VideoTab.Name = "VideoTab"
            padding = New Padding(3)
            Me.VideoTab.Padding = padding
            size = New Size(460, &H11F)
            Me.VideoTab.Size = size
            Me.VideoTab.TabIndex = 3
            Me.VideoTab.Text = "Video"
            Me.VideoTab.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.RadioButton1)
            Me.GroupBox2.Controls.Add(Me.RadioButton3)
            Me.GroupBox2.Controls.Add(Me.RadioButton2)
            point = New Point(&H15F, 6)
            Me.GroupBox2.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            size = New Size(&H67, 90)
            Me.GroupBox2.Size = size
            Me.GroupBox2.TabIndex = 4
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Colori"
            Me.RadioButton1.AutoSize = True
            Me.RadioButton1.Checked = True
            point = New Point(6, &H13)
            Me.RadioButton1.Location = point
            Me.RadioButton1.Name = "RadioButton1"
            size = New Size(&H33, &H11)
            Me.RadioButton1.Size = size
            Me.RadioButton1.TabIndex = 1
            Me.RadioButton1.TabStop = True
            Me.RadioButton1.Text = "Colori"
            Me.RadioButton1.UseVisualStyleBackColor = True
            Me.RadioButton3.AutoSize = True
            point = New Point(6, &H41)
            Me.RadioButton3.Location = point
            Me.RadioButton3.Name = "RadioButton3"
            size = New Size(&H5B, &H11)
            Me.RadioButton3.Size = size
            Me.RadioButton3.TabIndex = 3
            Me.RadioButton3.Text = "Bianco e nero"
            Me.RadioButton3.UseVisualStyleBackColor = True
            Me.RadioButton2.AutoSize = True
            point = New Point(6, &H2A)
            Me.RadioButton2.Location = point
            Me.RadioButton2.Name = "RadioButton2"
            size = New Size(&H55, &H11)
            Me.RadioButton2.Size = size
            Me.RadioButton2.TabIndex = 2
            Me.RadioButton2.Text = "Scala di grigi"
            Me.RadioButton2.UseVisualStyleBackColor = True
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Checked = True
            Me.CheckBox2.CheckState = CheckState.Checked
            point = New Point(6, 6)
            Me.CheckBox2.Location = point
            Me.CheckBox2.Name = "CheckBox2"
            size = New Size(310, &H11)
            Me.CheckBox2.Size = size
            Me.CheckBox2.TabIndex = 0
            Me.CheckBox2.Text = "Disablilita il salvaschermo durante la riproduzione di un video"
            Me.CheckBox2.UseVisualStyleBackColor = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1EC, &H16E)
            Me.ClientSize = size
            Me.Controls.Add(Me.ResetButt)
            Me.Controls.Add(Me.CancelButt)
            Me.Controls.Add(Me.ApplyButt)
            Me.Controls.Add(Me.OKButt)
            Me.Controls.Add(Me.SettingsTab)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "Settings"
            Me.Text = "Opzioni"
            Me.SettingsTab.ResumeLayout(False)
            Me.LookTab.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout
            Me.AudioTab.ResumeLayout(False)
            Me.AudioTab.PerformLayout
            Me.TrackBar2.EndInit
            Me.TrackBar1.EndInit
            Me.VideoTab.ResumeLayout(False)
            Me.VideoTab.PerformLayout
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Public Sub LoadSettings()
            If (MySettingsProperty.Settings.Color = Color.CornflowerBlue) Then
                Me.BlueRadio.Checked = True
                Me.ColorPanel.BackColor = Color.CornflowerBlue
            End If
            If (MySettingsProperty.Settings.Color = Color.DeepSkyBlue) Then
                Me.CyanRadio.Checked = True
                Me.ColorPanel.BackColor = Color.DeepSkyBlue
            End If
            If (MySettingsProperty.Settings.Color = Color.GreenYellow) Then
                Me.GreenRadio.Checked = True
                Me.ColorPanel.BackColor = Color.GreenYellow
            End If
            If (MySettingsProperty.Settings.Color = Color.Yellow) Then
                Me.YellowRadio.Checked = True
                Me.ColorPanel.BackColor = Color.Yellow
            End If
            If (MySettingsProperty.Settings.Color = Color.Orange) Then
                Me.OrangeRadio.Checked = True
                Me.ColorPanel.BackColor = Color.Orange
            End If
            If (MySettingsProperty.Settings.Color = Color.Firebrick) Then
                Me.RedRadio.Checked = True
                Me.ColorPanel.BackColor = Color.Firebrick
            End If
            If (MySettingsProperty.Settings.Color = Color.Violet) Then
                Me.VioletRadio.Checked = True
                Me.ColorPanel.BackColor = Color.Violet
            End If
            If (MySettingsProperty.Settings.Color = Color.Gray) Then
                Me.GreyRadio.Checked = True
                Me.ColorPanel.BackColor = Color.Gray
            End If
            If (MySettingsProperty.Settings.Color = Color.Black) Then
                Me.BlackRadio.Checked = True
                Me.ColorPanel.BackColor = Color.Black
            End If
        End Sub

        Private Sub OKButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Apply
            Me.Close
        End Sub

        Private Sub OrangeRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.OrangeRadio.Checked Then
                Me.ColorPanel.BackColor = Color.Orange
            End If
        End Sub

        Private Sub RedRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.RedRadio.Checked Then
                Me.ColorPanel.BackColor = Color.Firebrick
            End If
        End Sub

        Private Sub ResetButt_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (MessageBox.Show("Vuoi davvero ripristinare le impostazioni ai loro valori di default? Le impostazioni attuali saranno perse.", "Reimpostare le opzioni?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) <> DialogResult.No) Then
                MySettingsProperty.Settings.Reset
                Me.Apply
                MySettingsProperty.Settings.Save
                Me.LoadSettings
            End If
        End Sub

        Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.LoadSettings
        End Sub

        Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Label3.Text = Conversions.ToString(CDbl((CDbl(Me.TrackBar1.Value) / 100)))
        End Sub

        Private Sub TrackBar2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.Label4.Text = Conversions.ToString(CInt((Me.TrackBar2.Value - &H1770)))
        End Sub

        Private Sub VioletRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.VioletRadio.Checked Then
                Me.ColorPanel.BackColor = Color.Violet
            End If
        End Sub

        Private Sub YellowRadio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.YellowRadio.Checked Then
                Me.ColorPanel.BackColor = Color.Yellow
            End If
        End Sub


        ' Properties
        Friend Overridable Property ResetButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ResetButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ResetButt Is Nothing) Then
                    RemoveHandler Me._ResetButt.Click, New EventHandler(AddressOf Me.ResetButt_Click)
                End If
                Me._ResetButt = WithEventsValue
                If (Not Me._ResetButt Is Nothing) Then
                    AddHandler Me._ResetButt.Click, New EventHandler(AddressOf Me.ResetButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property CancelButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._CancelButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CancelButt Is Nothing) Then
                    RemoveHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.CancelButt_Click)
                End If
                Me._CancelButt = WithEventsValue
                If (Not Me._CancelButt Is Nothing) Then
                    AddHandler Me._CancelButt.Click, New EventHandler(AddressOf Me.CancelButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ApplyButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._ApplyButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._ApplyButt Is Nothing) Then
                    RemoveHandler Me._ApplyButt.Click, New EventHandler(AddressOf Me.ApplyButt_Click)
                End If
                Me._ApplyButt = WithEventsValue
                If (Not Me._ApplyButt Is Nothing) Then
                    AddHandler Me._ApplyButt.Click, New EventHandler(AddressOf Me.ApplyButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property OKButt As Button
            <DebuggerNonUserCode> _
            Get
                Return Me._OKButt
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._OKButt Is Nothing) Then
                    RemoveHandler Me._OKButt.Click, New EventHandler(AddressOf Me.OKButt_Click)
                End If
                Me._OKButt = WithEventsValue
                If (Not Me._OKButt Is Nothing) Then
                    AddHandler Me._OKButt.Click, New EventHandler(AddressOf Me.OKButt_Click)
                End If
            End Set
        End Property

        Friend Overridable Property SettingsTab As TabControl
            <DebuggerNonUserCode> _
            Get
                Return Me._SettingsTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabControl)
                Me._SettingsTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property LookTab As TabPage
            <DebuggerNonUserCode> _
            Get
                Return Me._LookTab
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TabPage)
                Me._LookTab = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._GroupBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property YellowRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._YellowRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._YellowRadio Is Nothing) Then
                    RemoveHandler Me._YellowRadio.CheckedChanged, New EventHandler(AddressOf Me.YellowRadio_CheckedChanged)
                End If
                Me._YellowRadio = WithEventsValue
                If (Not Me._YellowRadio Is Nothing) Then
                    AddHandler Me._YellowRadio.CheckedChanged, New EventHandler(AddressOf Me.YellowRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property BlueRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._BlueRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._BlueRadio Is Nothing) Then
                    RemoveHandler Me._BlueRadio.CheckedChanged, New EventHandler(AddressOf Me.BlueRadio_CheckedChanged)
                End If
                Me._BlueRadio = WithEventsValue
                If (Not Me._BlueRadio Is Nothing) Then
                    AddHandler Me._BlueRadio.CheckedChanged, New EventHandler(AddressOf Me.BlueRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property VioletRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._VioletRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._VioletRadio Is Nothing) Then
                    RemoveHandler Me._VioletRadio.CheckedChanged, New EventHandler(AddressOf Me.VioletRadio_CheckedChanged)
                End If
                Me._VioletRadio = WithEventsValue
                If (Not Me._VioletRadio Is Nothing) Then
                    AddHandler Me._VioletRadio.CheckedChanged, New EventHandler(AddressOf Me.VioletRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property CyanRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._CyanRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._CyanRadio Is Nothing) Then
                    RemoveHandler Me._CyanRadio.CheckedChanged, New EventHandler(AddressOf Me.CyanRadio_CheckedChanged)
                End If
                Me._CyanRadio = WithEventsValue
                If (Not Me._CyanRadio Is Nothing) Then
                    AddHandler Me._CyanRadio.CheckedChanged, New EventHandler(AddressOf Me.CyanRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property RedRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RedRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._RedRadio Is Nothing) Then
                    RemoveHandler Me._RedRadio.CheckedChanged, New EventHandler(AddressOf Me.RedRadio_CheckedChanged)
                End If
                Me._RedRadio = WithEventsValue
                If (Not Me._RedRadio Is Nothing) Then
                    AddHandler Me._RedRadio.CheckedChanged, New EventHandler(AddressOf Me.RedRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property GreenRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._GreenRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._GreenRadio Is Nothing) Then
                    RemoveHandler Me._GreenRadio.CheckedChanged, New EventHandler(AddressOf Me.GreenRadio_CheckedChanged)
                End If
                Me._GreenRadio = WithEventsValue
                If (Not Me._GreenRadio Is Nothing) Then
                    AddHandler Me._GreenRadio.CheckedChanged, New EventHandler(AddressOf Me.GreenRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property OrangeRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._OrangeRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._OrangeRadio Is Nothing) Then
                    RemoveHandler Me._OrangeRadio.CheckedChanged, New EventHandler(AddressOf Me.OrangeRadio_CheckedChanged)
                End If
                Me._OrangeRadio = WithEventsValue
                If (Not Me._OrangeRadio Is Nothing) Then
                    AddHandler Me._OrangeRadio.CheckedChanged, New EventHandler(AddressOf Me.OrangeRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property GreyRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._GreyRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._GreyRadio Is Nothing) Then
                    RemoveHandler Me._GreyRadio.CheckedChanged, New EventHandler(AddressOf Me.GreyRadio_CheckedChanged)
                End If
                Me._GreyRadio = WithEventsValue
                If (Not Me._GreyRadio Is Nothing) Then
                    AddHandler Me._GreyRadio.CheckedChanged, New EventHandler(AddressOf Me.GreyRadio_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property ColorPanel As Panel
            <DebuggerNonUserCode> _
            Get
                Return Me._ColorPanel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Panel)
                Me._ColorPanel = WithEventsValue
            End Set
        End Property

        Friend Overridable Property BlackRadio As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._BlackRadio
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._BlackRadio Is Nothing) Then
                    RemoveHandler Me._BlackRadio.CheckedChanged, New EventHandler(AddressOf Me.BlackRadio_CheckedChanged)
                End If
                Me._BlackRadio = WithEventsValue
                If (Not Me._BlackRadio Is Nothing) Then
                    AddHandler Me._BlackRadio.CheckedChanged, New EventHandler(AddressOf Me.BlackRadio_CheckedChanged)
                End If
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

        Friend Overridable Property TrackBar1 As TrackBar
            <DebuggerNonUserCode> _
            Get
                Return Me._TrackBar1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TrackBar)
                If (Not Me._TrackBar1 Is Nothing) Then
                    RemoveHandler Me._TrackBar1.ValueChanged, New EventHandler(AddressOf Me.TrackBar1_ValueChanged)
                End If
                Me._TrackBar1 = WithEventsValue
                If (Not Me._TrackBar1 Is Nothing) Then
                    AddHandler Me._TrackBar1.ValueChanged, New EventHandler(AddressOf Me.TrackBar1_ValueChanged)
                End If
            End Set
        End Property

        Friend Overridable Property Label3 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox1 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox1 = WithEventsValue
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

        Friend Overridable Property GroupBox2 As GroupBox
            <DebuggerNonUserCode> _
            Get
                Return Me._GroupBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton1 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._RadioButton1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton3 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._RadioButton3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property RadioButton2 As RadioButton
            <DebuggerNonUserCode> _
            Get
                Return Me._RadioButton2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._RadioButton2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CheckBox2 As CheckBox
            <DebuggerNonUserCode> _
            Get
                Return Me._CheckBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._CheckBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TrackBar2 As TrackBar
            <DebuggerNonUserCode> _
            Get
                Return Me._TrackBar2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As TrackBar)
                If (Not Me._TrackBar2 Is Nothing) Then
                    RemoveHandler Me._TrackBar2.ValueChanged, New EventHandler(AddressOf Me.TrackBar2_ValueChanged)
                End If
                Me._TrackBar2 = WithEventsValue
                If (Not Me._TrackBar2 Is Nothing) Then
                    AddHandler Me._TrackBar2.ValueChanged, New EventHandler(AddressOf Me.TrackBar2_ValueChanged)
                End If
            End Set
        End Property

        Friend Overridable Property Label2 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label4 As Label
            <DebuggerNonUserCode> _
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode> _
            Set(ByVal WithEventsValue As Label)
                Me._Label4 = WithEventsValue
            End Set
        End Property


        ' Fields
        Private components As IContainer
        <AccessedThroughProperty("ResetButt")> _
        Private _ResetButt As Button
        <AccessedThroughProperty("CancelButt")> _
        Private _CancelButt As Button
        <AccessedThroughProperty("ApplyButt")> _
        Private _ApplyButt As Button
        <AccessedThroughProperty("OKButt")> _
        Private _OKButt As Button
        <AccessedThroughProperty("SettingsTab")> _
        Private _SettingsTab As TabControl
        <AccessedThroughProperty("LookTab")> _
        Private _LookTab As TabPage
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("YellowRadio")> _
        Private _YellowRadio As RadioButton
        <AccessedThroughProperty("BlueRadio")> _
        Private _BlueRadio As RadioButton
        <AccessedThroughProperty("VioletRadio")> _
        Private _VioletRadio As RadioButton
        <AccessedThroughProperty("CyanRadio")> _
        Private _CyanRadio As RadioButton
        <AccessedThroughProperty("RedRadio")> _
        Private _RedRadio As RadioButton
        <AccessedThroughProperty("GreenRadio")> _
        Private _GreenRadio As RadioButton
        <AccessedThroughProperty("OrangeRadio")> _
        Private _OrangeRadio As RadioButton
        <AccessedThroughProperty("GreyRadio")> _
        Private _GreyRadio As RadioButton
        <AccessedThroughProperty("ColorPanel")> _
        Private _ColorPanel As Panel
        <AccessedThroughProperty("BlackRadio")> _
        Private _BlackRadio As RadioButton
        <AccessedThroughProperty("AudioTab")> _
        Private _AudioTab As TabPage
        <AccessedThroughProperty("TrackBar1")> _
        Private _TrackBar1 As TrackBar
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("CheckBox1")> _
        Private _CheckBox1 As CheckBox
        <AccessedThroughProperty("VideoTab")> _
        Private _VideoTab As TabPage
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox
        <AccessedThroughProperty("RadioButton1")> _
        Private _RadioButton1 As RadioButton
        <AccessedThroughProperty("RadioButton3")> _
        Private _RadioButton3 As RadioButton
        <AccessedThroughProperty("RadioButton2")> _
        Private _RadioButton2 As RadioButton
        <AccessedThroughProperty("CheckBox2")> _
        Private _CheckBox2 As CheckBox
        <AccessedThroughProperty("TrackBar2")> _
        Private _TrackBar2 As TrackBar
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label
    End Class
End Namespace

