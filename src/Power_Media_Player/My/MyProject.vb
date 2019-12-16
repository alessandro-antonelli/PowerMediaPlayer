Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Power_Media_Player
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Namespace Power_Media_Player.My
    <HideModuleName, StandardModule, GeneratedCode("MyTemplate", "8.0.0.0")> _
    Friend NotInheritable Class MyProject
        ' Properties
        <HelpKeyword("My.Computer")> _
        Friend Shared ReadOnly Property Computer As MyComputer
            <DebuggerHidden> _
            Get
                Return MyProject.m_ComputerObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.Application")> _
        Friend Shared ReadOnly Property Application As MyApplication
            <DebuggerHidden> _
            Get
                Return MyProject.m_AppObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.User")> _
        Friend Shared ReadOnly Property User As User
            <DebuggerHidden> _
            Get
                Return MyProject.m_UserObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.Forms")> _
        Friend Shared ReadOnly Property Forms As MyForms
            <DebuggerHidden> _
            Get
                Return MyProject.m_MyFormsObjectProvider.GetInstance
            End Get
        End Property

        <HelpKeyword("My.WebServices")> _
        Friend Shared ReadOnly Property WebServices As MyWebServices
            <DebuggerHidden> _
            Get
                Return MyProject.m_MyWebServicesObjectProvider.GetInstance
            End Get
        End Property


        ' Fields
        Private Shared ReadOnly m_ComputerObjectProvider As ThreadSafeObjectProvider(Of MyComputer) = New ThreadSafeObjectProvider(Of MyComputer)
        Private Shared ReadOnly m_AppObjectProvider As ThreadSafeObjectProvider(Of MyApplication) = New ThreadSafeObjectProvider(Of MyApplication)
        Private Shared ReadOnly m_UserObjectProvider As ThreadSafeObjectProvider(Of User) = New ThreadSafeObjectProvider(Of User)
        Private Shared m_MyFormsObjectProvider As ThreadSafeObjectProvider(Of MyForms) = New ThreadSafeObjectProvider(Of MyForms)
        Private Shared ReadOnly m_MyWebServicesObjectProvider As ThreadSafeObjectProvider(Of MyWebServices) = New ThreadSafeObjectProvider(Of MyWebServices)

        ' Nested Types
        <MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)> _
        Friend NotInheritable Class MyForms
            ' Methods
            <DebuggerHidden> _
            Private Shared Function Create__Instance__(Of T As { Form, New })(ByVal Instance As T) As T
                Dim local As T
                Dim exception As TargetInvocationException
                Dim flag1 As Boolean
                If ((Not Instance Is Nothing) AndAlso Not Instance.IsDisposed) Then
                    Return Instance
                End If
                If (MyForms.m_FormBeingCreated Is Nothing) Then
                    MyForms.m_FormBeingCreated = New Hashtable
                ElseIf MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
                    Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(0  - 1) {}))
                End If
                MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
                Try 
                    local = Activator.CreateInstance(Of T)
                Catch exception1 As TargetInvocationException When ((Function() // NOTE: To create compilable code, filter at IL offset 0074 was represented using lambda expression.
                    ProjectData.SetProjectError(exception = exception1)
                    flag1 = Not Object.ReferenceEquals(exception.InnerException, Nothing)
                    Return DirectCast(flag1, T)
                End Function)())
                    Dim args As String() = New String() { exception.InnerException.Message }
                    Throw New InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException)
                Finally
                    MyForms.m_FormBeingCreated.Remove(GetType(T))
                End Try
                Return local
            End Function

            <DebuggerHidden> _
            Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
                instance.Dispose
                Dim local As T = CType(Nothing, T)
                instance = local
            End Sub

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(o)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Friend Function [GetType]() As Type
                Return GetType(MyForms)
            End Function

            <EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function


            ' Properties
            Public Property About As About
                <DebuggerNonUserCode> _
                Get
                    Me.m_About = MyForms.Create__Instance__(Of About)(Me.m_About)
                    Return Me.m_About
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As About)
                    If Not Object.ReferenceEquals(Value, Me.m_About) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of About)(Me.m_About)
                    End If
                End Set
            End Property

            Public Property FileInfo As FileInfo
                <DebuggerNonUserCode> _
                Get
                    Me.m_FileInfo = MyForms.Create__Instance__(Of FileInfo)(Me.m_FileInfo)
                    Return Me.m_FileInfo
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As FileInfo)
                    If Not Object.ReferenceEquals(Value, Me.m_FileInfo) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of FileInfo)(Me.m_FileInfo)
                    End If
                End Set
            End Property

            Public Property Main As Main
                <DebuggerNonUserCode> _
                Get
                    Me.m_Main = MyForms.Create__Instance__(Of Main)(Me.m_Main)
                    Return Me.m_Main
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Main)
                    If Not Object.ReferenceEquals(Value, Me.m_Main) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Main)(Me.m_Main)
                    End If
                End Set
            End Property

            Public Property Settings As Settings
                <DebuggerNonUserCode> _
                Get
                    Me.m_Settings = MyForms.Create__Instance__(Of Settings)(Me.m_Settings)
                    Return Me.m_Settings
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Settings)
                    If Not Object.ReferenceEquals(Value, Me.m_Settings) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Settings)(Me.m_Settings)
                    End If
                End Set
            End Property

            Public Property SplashScreen As SplashScreen
                <DebuggerNonUserCode> _
                Get
                    Me.m_SplashScreen = MyForms.Create__Instance__(Of SplashScreen)(Me.m_SplashScreen)
                    Return Me.m_SplashScreen
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As SplashScreen)
                    If Not Object.ReferenceEquals(Value, Me.m_SplashScreen) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of SplashScreen)(Me.m_SplashScreen)
                    End If
                End Set
            End Property

            Public Property Updates As Updates
                <DebuggerNonUserCode> _
                Get
                    Me.m_Updates = MyForms.Create__Instance__(Of Updates)(Me.m_Updates)
                    Return Me.m_Updates
                End Get
                <DebuggerNonUserCode> _
                Set(ByVal Value As Updates)
                    If Not Object.ReferenceEquals(Value, Me.m_Updates) Then
                        If (Not Value Is Nothing) Then
                            Throw New ArgumentException("Property can only be set to Nothing")
                        End If
                        Me.Dispose__Instance__(Of Updates)(Me.m_Updates)
                    End If
                End Set
            End Property


            ' Fields
            Public m_About As About
            Public m_FileInfo As FileInfo
            Public m_Main As Main
            Public m_Settings As Settings
            Public m_SplashScreen As SplashScreen
            Public m_Updates As Updates
            <ThreadStatic> _
            Private Shared m_FormBeingCreated As Hashtable
        End Class

        <EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")> _
        Friend NotInheritable Class MyWebServices
            ' Methods
            <DebuggerHidden> _
            Private Shared Function Create__Instance__(Of T As New)(ByVal instance As T) As T
                Return If((Not instance Is Nothing), instance, Activator.CreateInstance(Of T))
            End Function

            <DebuggerHidden> _
            Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
                Dim local As T = CType(Nothing, T)
                instance = local
            End Sub

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(o)
            End Function

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Friend Function [GetType]() As Type
                Return GetType(MyWebServices)
            End Function

            <DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)> _
            Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function

        End Class

        <EditorBrowsable(EditorBrowsableState.Never), ComVisible(False)> _
        Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
            ' Properties
            Friend ReadOnly Property GetInstance As T
                <DebuggerHidden> _
                Get
                    If (ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing) Then
                        ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)
                    End If
                    Return ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
                End Get
            End Property


            ' Fields
            <CompilerGenerated, ThreadStatic> _
            Private Shared m_ThreadStaticValue As T
        End Class
    End Class
End Namespace

