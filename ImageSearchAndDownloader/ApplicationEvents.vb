'Imports Skybound.Gecko
'Imports System.IO
Namespace My
    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        'Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean

        '    Dim ProfileDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\subfolder\xulrunner\DefaultProfile"

        '    If Not Directory.Exists(ProfileDirectory) Then
        '        Directory.CreateDirectory(ProfileDirectory)
        '    End If
        '    Xpcom.ProfileDirectory = ProfileDirectory

        '    Dim xrPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        '    xrPath = xrPath.Substring(0, xrPath.LastIndexOf("\") + 1) & "\subfolder\xulrunner"
        '    Xpcom.Initialize(xrPath)

        '    Return True
        'End Function

        'Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
        '    Skybound.Gecko.Xpcom.Initialize("D:\Khaled\ImageSearchAndDownloader\ImageSearchAndDownloader\xulrunner")
        '    'Skybound.Gecko.Xpcom.ProfileDirectory = "xulrunner\defaults\profile"
        'End Sub
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            CreateBrowserKey()
        End Sub
        Private Sub MyApplication_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            ' I don't like applications that defecate in the registry and then don't cleanup their own mess
            ' so remove the key
            RemoveBrowerKey()
        End Sub
        Private Const BrowserKeyPath As String = "\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION"
        Private Sub CreateBrowserKey(Optional ByVal IgnoreIDocDirective As Boolean = False)
            Dim basekey As String = Microsoft.Win32.Registry.CurrentUser.ToString
            Dim value As Int32
            Dim thisAppsName As String = My.Application.Info.AssemblyName & ".exe"
            ' Value reference: http://msdn.microsoft.com/en-us/library/ee330730%28v=VS.85%29.aspx
            ' IDOC Reference:  http://msdn.microsoft.com/en-us/library/ms535242%28v=vs.85%29.aspx
            Select Case (New WebBrowser).Version.Major
                Case 8
                    If IgnoreIDocDirective Then
                        value = 8888
                    Else
                        value = 8000
                    End If
                Case 9
                    If IgnoreIDocDirective Then
                        value = 9999
                    Else
                        value = 9000
                    End If
                Case 10
                    If IgnoreIDocDirective Then
                        value = 10001
                    Else
                        value = 10000
                    End If
                Case Else
                    Exit Sub
            End Select
            Microsoft.Win32.Registry.SetValue(Microsoft.Win32.Registry.CurrentUser.ToString & BrowserKeyPath, _
                                              Process.GetCurrentProcess.ProcessName & ".exe", _
                                              value, _
                                              Microsoft.Win32.RegistryValueKind.DWord)
        End Sub
        Private Sub RemoveBrowerKey()
            Dim key As Microsoft.Win32.RegistryKey
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(BrowserKeyPath.Substring(1), True)
            key.DeleteValue(Process.GetCurrentProcess.ProcessName & ".exe", False)
        End Sub
    End Class


End Namespace

