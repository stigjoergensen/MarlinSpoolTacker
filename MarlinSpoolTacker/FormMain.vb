Public Class FormMain


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        CheckBoxConnect.Appearance = System.Windows.Forms.Appearance.Button
        onDisconnected()

        For Each Portname In System.IO.Ports.SerialPort.GetPortNames()
            ComboBoxComPort.Items.Add(Portname)
        Next
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If CheckBoxConnect.Checked Then DisConnect()

        Configuration.Config.Data.LastWindowSize = Me.Size
        Configuration.Config.Data.LastWindowState = Me.WindowState
        Configuration.Config.Data.LastWindowLocation = Me.Location
        Configuration.Config.Data.LastComPort = Me.ComboBoxComPort.Text
        Integer.TryParse(ComboBoxSpeed.Text, Configuration.Config.Data.LastBaudRate)

        Configuration.Config.Save()
        SpoolDatabase1.Save()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = Configuration.Config.Data.LastWindowLocation
        Me.Size = Configuration.Config.Data.LastWindowSize
        Me.WindowState = Configuration.Config.Data.LastWindowState
        Me.ComboBoxComPort.Text = Configuration.Config.Data.LastComPort
        Me.ComboBoxSpeed.Text = Configuration.Config.Data.LastBaudRate

        'ListViewMacro.DataBindings.Add(New Binding("Text", Config.MacroList, "Title"))
        'ListViewMacro.Refresh()

        If Configuration.Config.Data.AutoConnect Then CheckBoxConnect.Checked = True
    End Sub


    Private Sub CheckBoxConnect_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConnect.CheckedChanged
        If CheckBoxConnect.Checked Then
            CheckBoxConnect.Text = "Conneting..."
            ToolStripStatusConnected.Text = "Connecting"
            If Not Connect() Then
                onDisconnected()
            End If
        Else
            ToolStripStatusConnected.Text = "Disconnecting"
            CheckBoxConnect.Text = "Disconneting..."
            DisConnect()
        End If
    End Sub

    Private Function Connect() As Boolean
        CheckBoxConnect.Enabled = False
        Threading.Thread.Sleep(100)
        onConnected()
        Return True
    End Function

    Private Sub DisConnect()
        CheckBoxConnect.Enabled = False
        Threading.Thread.Sleep(100)
        onDisconnected()
    End Sub


    Private Sub onConnected()
        SpoolDatabase1.Connected()
        CheckBoxConnect.Text = "Disconnect"
        CheckBoxConnect.Checked = True
        CheckBoxConnect.Enabled = True
        ToolStripStatusConnected.Text = "Connected"
        TabControl1.TabPages.Insert(0, TabPagePrinter)
        TabControl1.TabPages.Insert(2, TabPageConsole)
        TabControl1.SelectedTab = TabPagePrinter

        'Get printername
        LabelPrinterName.Text = "This is a dummy printername"
    End Sub

    Private Sub onDisconnected()
        SpoolDatabase1.Disconnected()
        CheckBoxConnect.Text = "Connect"
        CheckBoxConnect.Checked = False
        CheckBoxConnect.Enabled = True
        ToolStripStatusConnected.Text = "Disconnected"
        TabControl1.TabPages.Remove(TabPagePrinter)
        TabControl1.TabPages.Remove(TabPageConsole)
        TabControl1.SelectedTab = TabPageSpoolDB
        LabelPrinterName.Text = ""
    End Sub

End Class
