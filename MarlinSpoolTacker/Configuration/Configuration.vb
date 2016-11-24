Public Class Configuration

    Shared Property Config As ConfigClass

    Public Sub New()
        InitializeComponent()
        Config = New ConfigClass()
        DataGridViewMacro.AutoGenerateColumns = False
        DataGridViewMaterial.AutoGenerateColumns = False

        DataGridViewMaterial.DataSource = Config.MaterialSource
        DataGridViewMaterial.Refresh()

        DataGridViewMacro.DataSource = Config.MacroSource
        DataGridViewMacro.Refresh()

        WarningThreshold.Value = Config.Data.WarningThreshold
        CriticalThreashold.Value = Config.Data.CriticalThreashold
        AutoConnect.Checked = Config.Data.AutoConnect

        CheckBoxOpenLastSpoolDB.Checked = Config.Data.AutomaticLoadSpoolDB
        autoSave.Checked = Config.Data.AutoSaveSpoolDB
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
    End Sub

    Public Sub Save()
        Config.Data.WarningThreshold = WarningThreshold.Value
        Config.Data.CriticalThreashold = CriticalThreashold.Value
        Config.Data.AutoSaveSpoolDB = autoSave.Checked
        Config.Data.AutoConnect = AutoConnect.Checked
        Config.Data.AutomaticLoadSpoolDB = CheckBoxOpenLastSpoolDB.Checked
    End Sub

End Class
