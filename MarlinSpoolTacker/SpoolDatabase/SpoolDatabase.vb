Public Class SpoolDatabase

    Public List As List(Of Spool)
    Public Source As BindingSource


    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        OpenFileDialogSpoolDB.FileName = Configuration.Config.Data.LastSpoolDbFilename
        SaveFileDialogSpoolDB.FileName = Configuration.Config.Data.LastSpoolDbFilename

        If Configuration.Config.Data.AutomaticLoadSpoolDB AndAlso Configuration.Config.Data.LastSpoolDbFilename <> "" Then OpenFileDialog1_FileOk(Me, Nothing)
    End Sub

    Public Sub New()
        InitializeComponent()
        List = New List(Of Spool)
        Source = New BindingSource(List, "")
        DataGridViewSpools.AutoGenerateColumns = False
        DataGridViewSpools.Rows.Clear()
        DataGridViewSpools.DataSource = Source

    End Sub

    Public Sub Save()
        If Configuration.Config.Data.AutoSaveSpoolDB AndAlso SaveFileDialogSpoolDB.FileName <> "" Then SaveFileDialog1_FileOk(Me, Nothing)
    End Sub

    Public Sub Connected()
        ButtonUpload.Enabled = True
        ButtonDownload.Enabled = True
    End Sub

    Public Sub Disconnected()
        ButtonUpload.Enabled = False
        ButtonDownload.Enabled = False
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        Dim item As Spool = New Spool With {.SpoolID = 1, .SpoolType = "ABS", .Description = "Description", .Temperature = 100, .FlowRate = 128, .ESteps = 0, .Length = 330000, .Used = 1000, .Flags = Spool.SpoolFlag.ForceTemperature}
        List.Add(item)
        Source.ResetBindings(True)
        DataGridViewSpools.Refresh()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialogSpoolDB.FileOk
        Configuration.Config.Data.LastSpoolDbFilename = SaveFileDialogSpoolDB.FileName
        Dim File As System.IO.BinaryWriter = New IO.BinaryWriter(SaveFileDialogSpoolDB.OpenFile(), System.Text.Encoding.UTF8, False)
        Dim FileExt As System.IO.FileStream = New System.IO.FileStream(System.IO.Path.ChangeExtension(SaveFileDialogSpoolDB.FileName, "sedb"), System.IO.FileMode.Create)
        For Each item As Spool In List
            item.write(File, FileExt)
        Next
        File.Close()
        FileExt.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialogSpoolDB.FileOk
        DataGridViewSpools.Rows.Clear()
        Configuration.Config.Data.LastSpoolDbFilename = OpenFileDialogSpoolDB.FileName
        Try
            Dim File As System.IO.BinaryReader = New IO.BinaryReader(OpenFileDialogSpoolDB.OpenFile(), System.Text.Encoding.UTF8)
            Dim FileExt As System.IO.FileStream = New IO.FileStream(System.IO.Path.ChangeExtension(OpenFileDialogSpoolDB.FileName, "sedb"), System.IO.FileMode.OpenOrCreate)
            File.BaseStream.Position = 0
            FileExt.Position = 0
            While File.BaseStream.Position < File.BaseStream.Length
                Dim item As Spool = New Spool(File, FileExt)
                List.Add(item)
            End While
            File.Close()
            FileExt.Close()
            Source.ResetBindings(True)
            DataGridViewSpools.Refresh()
        Catch ex As Exception
            Configuration.Config.Data.LastSpoolDbFilename = ""
            SaveFileDialogSpoolDB.FileName = ""
        End Try
    End Sub

    Private Sub MenuNewSpool_Click(sender As Object, e As EventArgs) Handles MenuNewSpool.Click
        Dim item As Spool = New Spool(Nothing)
        If FormEditor.ShowModal(item) = Windows.Forms.DialogResult.OK Then
            List.Add(item)
            Source.ResetBindings(False)
            DataGridViewSpools.Refresh()
        End If
    End Sub

    Private Sub MenuEditSpool_Click(sender As Object, e As EventArgs) Handles MenuEditSpool.Click
        If FormEditor.ShowModal(DataGridViewSpools.CurrentRow.DataBoundItem) Then
            Source.ResetBindings(False)
            DataGridViewSpools.Refresh()
        End If
    End Sub

    Private Sub ButtonSave_Click_1(sender As Object, e As EventArgs) Handles ButtonSave.Click
        SaveFileDialogSpoolDB.ShowDialog()
    End Sub

    Private Sub ButtonLoad_Click_1(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        OpenFileDialogSpoolDB.ShowDialog()
    End Sub

End Class
