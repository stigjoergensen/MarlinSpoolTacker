Public Class FormEditor
    Private Spool As Spool
    Private material As Material

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        SpoolType.DataSource = Configuration.Config.MaterialSource
        SpoolType.DisplayMember = "MaterialType"
        SpoolType.ValueMember = "MaterialType"

        Diameter.DataSource = Configuration.Config.FilamentSource
        Diameter.DisplayMember = "DiameterText"
        Diameter.ValueMember = "DiameterValue"
    End Sub

    Public Function ShowModal(ByRef SpoolArg As Spool) As Windows.Forms.DialogResult
        Spool = SpoolArg
        material = CType(Configuration.Config.MaterialSource.DataSource, MarlinSpoolTacker.MaterialList).Item(Spool.SpoolType)
        SpoolID.Value = Spool.SpoolID
        SpoolType.Text = Spool.SpoolType
        Description.Text = Spool.Description
        Diameter.SelectedValue = Spool.DiameterDisplay
        Temperature.Value = Spool.Temperature + Spool.SpoolTemperatureModifer
        FlowRate.Value = (Spool.FlowRate * Spool.FlowRateCalc) + Spool.FlowRateModifier
        ESteps.Value = Spool.ESteps
        Length.Value = Spool.Length / 10
        Used.Value = Spool.Used / 10
        ForceTemperature.Checked = Spool.Flags And MarlinSpoolTacker.Spool.SpoolFlag.ForceTemperature

        Manufactor.Text = Spool.Extension.Manufactor
        OpenDate.Value = Spool.Extension.OpenDate
        BuyDate.Value = Spool.Extension.AquireDate
        ColorText.BackColor = Spool.Extension.Color

        ShowAdditionalInfo()
        ShowModal = ShowDialog()
        If ShowModal = Windows.Forms.DialogResult.OK Then
            Spool.FlagForceTemperature = ForceTemperature.Checked
            Spool.SpoolID = SpoolID.Value
            Spool.SpoolType = SpoolType.Text
            Spool.Description = Description.Text
            Spool.Temperature = Temperature.Value - Spool.SpoolTemperatureModifer
            Spool.FlowRate = (FlowRate.Value - Spool.FlowRateModifier) / Spool.FlowRateCalc
            Spool.ESteps = ESteps.Value
            Spool.Length = Length.Value * 10
            Spool.Used = Used.Value * 10
            Spool.DiameterDisplay = Diameter.SelectedValue

            Spool.Extension.Color = ColorText.BackColor
            Spool.Extension.Manufactor = Manufactor.Text
            Spool.Extension.AquireDate = BuyDate.Value
            Spool.Extension.OpenDate = OpenDate.Value
        End If
    End Function

    Private Sub SpoolType_SelectedValueChanged(sender As Object, e As EventArgs)
        If SpoolType.SelectedValue IsNot Nothing Then
            Me.material = CType(Configuration.Config.MaterialSource.DataSource, MarlinSpoolTacker.MaterialList).Item(SpoolType.SelectedValue)
            If Me.material IsNot Nothing Then
                Temperature.Value = Me.material.DefaultTemperature
                'Temperature.Minimum = material.TemperatureMin
                'Temperature.Maximum = material.TemperatureMax
            End If
            ShowAdditionalInfo()
        End If
    End Sub

    Private Sub ButtonLength_Click(sender As Object, e As EventArgs)
        Dim weight As Integer = 0
        If Integer.TryParse(InputBox("Spool weight in grams", "Enter weight", "1000"), weight) Then
            If SpoolType.SelectedValue IsNot Nothing Then
                Dim material As Material = CType(Configuration.Config.MaterialSource.DataSource, MarlinSpoolTacker.MaterialList).Item(SpoolType.SelectedValue)
                If material IsNot Nothing Then
                    Length.Value = Math.Truncate((material.GetLength(weight, Diameter.SelectedValue) * 100000))
                End If
            End If
        End If
    End Sub

    Private Sub ButtonUsed_Click(sender As Object, e As EventArgs)
        Dim weight As Integer = 0
        If Integer.TryParse(InputBox("Spool weight in grams", "Enter weight", "0"), weight) Then
            If SpoolType.SelectedValue IsNot Nothing Then
                Dim material As Material = CType(Configuration.Config.MaterialSource.DataSource, MarlinSpoolTacker.MaterialList).Item(SpoolType.SelectedValue)
                If material IsNot Nothing Then
                    Used.Value = Math.Truncate((material.GetLength(weight, Diameter.SelectedValue) * 100000))
                End If
            End If
        End If
    End Sub

    Private Sub Length_ValueChanged(sender As Object, e As EventArgs)
        ShowAdditionalInfo()
    End Sub

    Private Sub Used_ValueChanged(sender As Object, e As EventArgs)
        ShowAdditionalInfo()
    End Sub

    Private Sub ShowAdditionalInfo()
        If Spool IsNot Nothing AndAlso material IsNot Nothing Then
            LabelFullWeight.Text = material.GetWeight(Length.Value, Diameter.SelectedValue).ToString()
            LabelRemaining.Text = material.GetWeight(Length.Value - Used.Value, Diameter.SelectedValue).ToString()
        End If
    End Sub

    Private Sub Diameter_SelectedValueChanged(sender As Object, e As EventArgs)
        ShowAdditionalInfo()
    End Sub

    Private Sub ButtonColorPicker_Click(sender As Object, e As EventArgs) Handles ButtonColorPicker.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ColorText.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class