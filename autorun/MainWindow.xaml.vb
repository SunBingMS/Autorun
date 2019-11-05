Imports MahApps.Metro.Controls

Class MainWindow
    Inherits MetroWindow

    Private Sub btnStart_Menu_Click(sender As Object, e As RoutedEventArgs) Handles btnStart_Menu.Click
        System.Diagnostics.Process.Start(".\bat\ShortCutStart.bat")
    End Sub

    Private Sub btnStartMenu_Click(sender As Object, e As RoutedEventArgs) Handles btnStartMenu.Click
        System.Diagnostics.Process.Start(".\bat\StartMenu.bat")
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As RoutedEventArgs) Handles btnMenu.Click
        System.Diagnostics.Process.Start(".\bat\Menu.bat")
    End Sub

    Private Sub btnJimSystem_HOME_Click(sender As Object, e As RoutedEventArgs) Handles btnJimSystem_HOME.Click
        System.Diagnostics.Process.Start(".\bat\OGU_Home.bat")
    End Sub

    Private Sub btnJimSystem_Click(sender As Object, e As RoutedEventArgs) Handles btnJimSystem.Click
        System.Diagnostics.Process.Start(".\bat\OGU00Menu.bat")
    End Sub

    Private Sub btnWeZDB7_HOME_Click(sender As Object, e As RoutedEventArgs) Handles btnWeZDB7_HOME.Click
        System.Diagnostics.Process.Start(".\bat\WeZDB7_Home.bat")
    End Sub

    Private Sub btnWeZDB7_Click(sender As Object, e As RoutedEventArgs) Handles btnWeZDB7.Click
        System.Diagnostics.Process.Start(".\bat\WeZDB7.bat")
    End Sub

    Private Sub btnMessengerBox_HOME_Click(sender As Object, e As RoutedEventArgs) Handles btnMessengerBox_HOME.Click
        System.Diagnostics.Process.Start(".\bat\MessengerBox_Home.bat")
    End Sub

    Private Sub btnMessengerBox_Click(sender As Object, e As RoutedEventArgs) Handles btnMessengerBox.Click
        System.Diagnostics.Process.Start(".\bat\MessengerBox.bat")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As RoutedEventArgs) Handles btnReset.Click
        System.Diagnostics.Process.Start(".\bat\ResetOGU.bat")
    End Sub

    Private Sub MetroWindow_Loaded(sender As Object, e As RoutedEventArgs)
        lblVer.Content = "Version: " & Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString
    End Sub

    Private Sub btnStart_Menu_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnStart_Menu.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\ShortCutStart.bat")
    End Sub

    Private Sub btnStartMenu_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnStartMenu.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\StartMenu.bat")
    End Sub

    Private Sub btnMenu_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnMenu.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\Menu.bat")
    End Sub

    Private Sub btnJimSystem_HOME_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnJimSystem_HOME.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU_Home.bat")
    End Sub

    Private Sub btnJimSystem_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnJimSystem.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU00Menu.bat")
    End Sub

    Private Sub btnWeZDB7_HOME_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnWeZDB7_HOME.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\WeZDB7_Home.bat")
    End Sub

    Private Sub btnWeZDB7_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnWeZDB7.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\WeZDB7.bat")
    End Sub

    Private Sub btnMessengerBox_HOME_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnMessengerBox_HOME.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\MessengerBox_Home.bat")
    End Sub

    Private Sub btnMessengerBox_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnMessengerBox.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\MessengerBox.bat")
    End Sub

    Private Sub btnReset_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnReset.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\ResetOGU.bat")
    End Sub

    Private Sub btnCommon_Click(sender As Object, e As RoutedEventArgs) Handles btnCommon.Click
        System.Diagnostics.Process.Start(".\bat\OGU99Common.bat")
    End Sub

    Private Sub btnCommonClient_Click(sender As Object, e As RoutedEventArgs) Handles btnCommonClient.Click
        System.Diagnostics.Process.Start(".\bat\OGU98Common_Client.bat")
    End Sub

    Private Sub btnCommonServer_Click(sender As Object, e As RoutedEventArgs) Handles btnCommonServer.Click
        System.Diagnostics.Process.Start(".\bat\OGU97Common_Server.bat")
    End Sub

    Private Sub btnTemplate_Click(sender As Object, e As RoutedEventArgs) Handles btnTemplate.Click
        System.Diagnostics.Process.Start(".\bat\Template.bat")
    End Sub

    Private Sub btnOGU00Menu_HOME_Click(sender As Object, e As RoutedEventArgs) Handles btnOGU00Menu_HOME.Click
        System.Diagnostics.Process.Start(".\bat\OGU_Home.bat")
    End Sub

    Private Sub btnOGU00Menu_Click(sender As Object, e As RoutedEventArgs) Handles btnOGU00Menu.Click
        System.Diagnostics.Process.Start(".\bat\OGU00Menu.bat")
    End Sub

    Private Sub btnOGU01Nyushi_Click(sender As Object, e As RoutedEventArgs) Handles btnOGU01Nyushi.Click
        System.Diagnostics.Process.Start(".\bat\OGU01Nyushi.bat")
    End Sub

    Private Sub btnCommon_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnCommon.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU99Common.bat")
    End Sub

    Private Sub btnCommonClient_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnCommonClient.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU98Common_Client.bat")
    End Sub

    Private Sub btnCommonServer_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnCommonServer.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU97Common_Server.bat")
    End Sub

    Private Sub btnTemplate_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnTemplate.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\Template.bat")
    End Sub

    Private Sub btnOGU00Menu_HOME_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnOGU00Menu_HOME.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU_Home.bat")
    End Sub

    Private Sub btnOGU00Menu_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnOGU00Menu.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU00Menu.bat")
    End Sub

    Private Sub btnOGU01Nyushi_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnOGU01Nyushi.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU01Nyushi.bat")
    End Sub

    Private Sub btnCommonWebSV_Click(sender As Object, e As RoutedEventArgs) Handles btnCommonWebSV.Click
        System.Diagnostics.Process.Start(".\bat\WebService.bat")
    End Sub

    Private Sub btnCommonWebSV_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnCommonWebSV.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\WebService.bat")
    End Sub

    Private Sub btnTextBoxEx_Click(sender As Object, e As RoutedEventArgs) Handles btnTextBoxEx.Click
        System.Diagnostics.Process.Start(".\bat\TextBoxEx.bat")
    End Sub

    Private Sub btnTextBoxEx_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnTextBoxEx.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\TextBoxEx.bat")
    End Sub

    Private Sub btnOGU03Gakusei_Click(sender As Object, e As RoutedEventArgs) Handles btnOGU03Gakusei.Click
        System.Diagnostics.Process.Start(".\bat\OGU03Gakusei.bat")
    End Sub

    Private Sub btnOGU03Gakusei_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnOGU03Gakusei.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\OGU03Gakusei.bat")
    End Sub

    Private Sub btnNyushiWebSV_Click(sender As Object, e As RoutedEventArgs) Handles btnNyushiWebSV.Click
        System.Diagnostics.Process.Start(".\bat\NyushiWebSV.bat")
    End Sub

    Private Sub btnNyushiWebSV_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnNyushiWebSV.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\NyushiWebSV.bat")
    End Sub

    Private Sub btnDataGridViewEx_Click(sender As Object, e As RoutedEventArgs) Handles btnDataGridViewEx.Click
        System.Diagnostics.Process.Start(".\bat\DataGridViewEx.bat")
    End Sub

    Private Sub btnDataGridViewEx_MouseRightButtonDown(sender As Object, e As MouseButtonEventArgs) Handles btnDataGridViewEx.MouseRightButtonDown
        System.Diagnostics.Process.Start("notepad.exe", ".\bat\DataGridViewEx.bat")
    End Sub
End Class
