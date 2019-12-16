Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices

Namespace Power_Media_Player.My
    <EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")> _
    Friend NotInheritable Class MySettings
        Inherits ApplicationSettingsBase
        ' Methods
        <DebuggerNonUserCode, EditorBrowsable(EditorBrowsableState.Advanced)> _
        Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
            If MyProject.Application.SaveMySettingsOnExit Then
                MySettingsProperty.Settings.Save
            End If
        End Sub


        ' Properties
        Public Shared ReadOnly Property [Default] As MySettings
            Get
                If Not MySettings.addedHandler Then
                    Dim addedHandlerLockObject As Object = MySettings.addedHandlerLockObject
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject)
                    SyncLock addedHandlerLockObject
                        If Not MySettings.addedHandler Then
                            AddHandler MyProject.Application.Shutdown, New ShutdownEventHandler(AddressOf MySettings.AutoSaveSettings)
                            MySettings.addedHandler = True
                        End If
                    End SyncLock
                End If
                Return MySettings.defaultInstance
            End Get
        End Property

        <UserScopedSetting, DefaultSettingValue("CornflowerBlue"), DebuggerNonUserCode> _
        Public Property Color As Color
            Get
                Dim color2 As Color
                Dim obj1 As Object = Me("Color")
                If (Not obj1 Is Nothing) Then
                    Return DirectCast(obj1, Color*)
                End If
                Dim local1 As Object = obj1
                Return color2
            End Get
            Set(ByVal Value As Color)
                Me("Color") = Value
            End Set
        End Property

        <DebuggerNonUserCode, DefaultSettingValue("False"), UserScopedSetting> _
        Public Property Updates As Boolean
            Get
                Return Conversions.ToBoolean(Me("Updates"))
            End Get
            Set(ByVal Value As Boolean)
                Me("Updates") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("10000")> _
        Public Property Volume As Integer
            Get
                Return Conversions.ToInteger(Me("Volume"))
            End Get
            Set(ByVal Value As Integer)
                Me("Volume") = Value
            End Set
        End Property

        <UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("Black")> _
        Public Property FontColor As Color
            Get
                Dim color2 As Color
                Dim obj1 As Object = Me("FontColor")
                If (Not obj1 Is Nothing) Then
                    Return DirectCast(obj1, Color*)
                End If
                Dim local1 As Object = obj1
                Return color2
            End Get
            Set(ByVal Value As Color)
                Me("FontColor") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("True")> _
        Public Property VolumeOn As Boolean
            Get
                Return Conversions.ToBoolean(Me("VolumeOn"))
            End Get
            Set(ByVal Value As Boolean)
                Me("VolumeOn") = Value
            End Set
        End Property

        <DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("6000")> _
        Public Property Balance As Integer
            Get
                Return Conversions.ToInteger(Me("Balance"))
            End Get
            Set(ByVal Value As Integer)
                Me("Balance") = Value
            End Set
        End Property


        ' Fields
        Private Shared defaultInstance As MySettings = DirectCast(SettingsBase.Synchronized(New MySettings), MySettings)
        Private Shared addedHandler As Boolean
        Private Shared addedHandlerLockObject As Object = New Object
    End Class
End Namespace

