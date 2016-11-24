Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class ConfigData
    Public Property LastComPort As String
    Public Property LastBaudRate As Integer
    Public Property AutoConnect As Boolean = False

    Public Property LastWindowSize As Size
    Public Property LastWindowState As FormWindowState
    Public Property LastWindowLocation As Point

    Public Property AutomaticLoadSpoolDB As Boolean = True
    Public Property AutoSaveSpoolDB As Boolean = False
    Public Property LastSpoolDbFilename As String
    Public Property LastGCodePath As String

    Public Property WarningThreshold As Integer = 15
    Public Property CriticalThreashold As Integer = 5
End Class

<Serializable()>
Public Class FilamentDiameter
    Public Property DiameterValue As Double
    Public Property DiameterText As String
End Class

<Serializable()>
Public Class Material
    Public Property MaterialType As String
    Public Property TemperatureMin As Integer
    Public Property TemperatureMax As Integer
    Public Property Density As Integer
    Public Property GlassTransition As Integer

    Public ReadOnly Property DefaultTemperature As Integer
        Get
            Return ((TemperatureMax - TemperatureMin) * 90 / 100) + TemperatureMin
        End Get
    End Property

    Public Property DensityDisplay As Double
        Get
            Return Density / 1000
        End Get
        Set(value As Double)
            Density = value * 1000
        End Set
    End Property


    'volume = mass / (density / 10)
    'area = Diameter / 2 ^ 2 * pi
    'length = Volume / area
    Public Function GetLength(WeightInGrams As Integer, Diameter As Double) As Double
        'Length = (Mass / density) / ((Diameter /2)^2 * pi)
        Return (WeightInGrams / Density) / ((Diameter / 2) ^ 2 * Math.PI)
    End Function

    Public Function GetWeight(Length As Integer, Diameter As Double) As Integer
        ' weight = ((diameter /2)^2 * pi) * length * density
        Return ((Diameter / 2) ^ 2) * Math.PI * (Length / 100000) * Density
    End Function
End Class

<Serializable()>
Public Class Macro
    Public Property Title As String
    Public Property GCodes As String
    Public ReadOnly Property SystemMacro As Boolean
        Get
            Return Title.Substring(1, 1) = "_"
        End Get
    End Property
End Class

<Serializable()>
Public Class MaterialList
    Inherits CollectionBase

    Default Public Property Item(ByVal index As Integer) As Material
        Get
            Return CType(List.Item(index), Material)
        End Get
        Set(value As Material)
            List.Item(index) = value
        End Set
    End Property

    Default Public ReadOnly Property item(ByVal MaterialType As String) As Material
        Get
            Dim result As Material = Nothing
            If MaterialType IsNot Nothing Then
                For Each res As Material In List
                    If res.MaterialType.ToUpper() = MaterialType.ToUpper() Then result = res
                Next
            End If
            Return result
        End Get
    End Property

    Public Function add(ByVal item As Material) As Integer
        Return List.Add(item)
    End Function

    Public Sub InitializeNewList()
        Dim item As Material
        item = New Material With {.MaterialType = "PLA", .TemperatureMin = 180, .TemperatureMax = 220, .GlassTransition = 60, .Density = 1300}
        List.Add(item)
        item = New Material With {.MaterialType = "ABS", .TemperatureMin = 200, .TemperatureMax = 250, .GlassTransition = 105, .Density = 1070}
        List.Add(item)
        item = New Material With {.MaterialType = "PETG", .TemperatureMin = 200, .TemperatureMax = 250, .GlassTransition = 80, .Density = 1380}
        List.Add(item)
    End Sub

End Class

<Serializable()>
Public Class MacroList
    Inherits CollectionBase

    Default Public Property Item(ByVal Index As Integer) As Macro
        Get
            Return CType(List.Item(Index), Macro)
        End Get
        Set(value As Macro)
            List.Item(Index) = value
        End Set
    End Property
    Public Function add(ByVal item As Macro) As Integer
        Return List.Add(item)
    End Function

    Public Sub InitializeNewList()
        Dim item As Macro
        item = New Macro With {.Title= "_Abort", .GCodes = "G10000;move z by 10 mm" + vbCrLf + "g10000 ; move X home" + vbCrLf + "g0000 ; move y home"}
        List.Add(item)
        item = New Macro With {.Title = "_onConnect", .GCodes = "M117 Connected to host; display message"}
        List.Add(item)
        item = New Macro With {.Title = "_onDisconnect", .GCodes = "M117 Disconnected from host; display message"}
        List.Add(item)
    End Sub
End Class

<Serializable()>
Public Class FilamentList
    Inherits CollectionBase

    Default Public Property Item(ByVal Index As Integer) As FilamentDiameter
        Get
            Return CType(List.Item(Index), FilamentDiameter)
        End Get
        Set(value As FilamentDiameter)
            List.Item(Index) = value
        End Set
    End Property

    Public Function add(ByVal Filament As FilamentDiameter) As Integer
        Return List.Add(Filament)
    End Function

    Public Sub New()
        add(New FilamentDiameter() With {.DiameterText = "1.75", .DiameterValue = 1.75})
        add(New FilamentDiameter() With {.DiameterText = "2.85", .DiameterValue = 2.85})
        add(New FilamentDiameter() With {.DiameterText = "3.0", .DiameterValue = 3.0})
    End Sub
End Class


Public Class ConfigClass
    Public Property Data As ConfigData
    Public Property MaterialSource As BindingSource
    Public Property MacroSource As BindingSource
    Public Property FilamentSource As BindingSource

    Private ConfigFilename As String = ""
    Private MaterialFilename As String = ""
    Private MacroFileName As String = ""


    Public Sub New()
        FilamentSource = New BindingSource(New FilamentList(), "")
        FilamentSource.ResetBindings(True)

        Dim path As String = Application.StartupPath()
        ConfigFilename = path + "\config.db"
        MaterialFilename = path + "\Material.db"
        MacroFileName = path + "\macro.db"

        If File.Exists(ConfigFilename) Then
            Dim fs As Stream = File.OpenRead(ConfigFilename)
            Dim deserializer As New BinaryFormatter()
            Try
                Data = CType(deserializer.Deserialize(fs), ConfigData)
            Catch ex As Exception
                Data = New ConfigData()
                MessageBox.Show("Cannot read configuration, deleting the files", "Configfile invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                File.Delete(ConfigFilename)
            Finally
                fs.Close()
            End Try
        Else
            Data = New ConfigData()
            Data.LastWindowSize = New Size(1000, 500)
            Data.LastWindowState = FormWindowState.Normal
        End If

        If File.Exists(MaterialFilename) Then
            Dim fs As Stream = File.OpenRead(MaterialFilename)
            Dim desserializer As New BinaryFormatter()
            Try
                MaterialSource = New BindingSource(CType(desserializer.Deserialize(fs), MaterialList), "")
                MaterialSource.ResetBindings(True)
            Catch ex As Exception
                MaterialSource = New BindingSource(New MaterialList(), "")
                CType(MaterialSource.DataSource, MaterialList).InitializeNewList()
                MaterialSource.ResetBindings(True)
                MessageBox.Show("Cannot read Material storage, deleting the files", "Material invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                File.Delete(MaterialFilename)
            Finally
                fs.Close()
            End Try
        Else
            MaterialSource = New BindingSource(New MaterialList(), "")
            CType(MaterialSource.DataSource, MaterialList).InitializeNewList()
            MaterialSource.ResetBindings(True)
        End If

        If File.Exists(MacroFileName) Then
            Dim fs As Stream = File.OpenRead(MacroFileName)
            Dim desserializer As New BinaryFormatter()
            Try
                MacroSource = New BindingSource(CType(desserializer.Deserialize(fs), MacroList), "")
                MacroSource.ResetBindings(True)
            Catch ex As Exception
                MacroSource = New BindingSource(New MacroList(), "")
                CType(MacroSource.DataSource, MacroList).InitializeNewList()
                MacroSource.ResetBindings(True)
                MessageBox.Show("Cannot read Macro storage, deleting the files", "Macro invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                File.Delete(MacroFileName)
            Finally
                fs.Close()
            End Try
        Else
            MacroSource = New BindingSource(New MacroList(), "")
            CType(MacroSource.DataSource, MacroList).InitializeNewList()
            MacroSource.ResetBindings(True)
        End If
    End Sub

    Public Sub Save()
        Dim Fs As Stream = File.Create(ConfigFilename)
        Dim serializer As New BinaryFormatter()
        serializer.Serialize(Fs, Data)
        Fs.Close()

        Fs = File.Create(MaterialFilename)
        serializer.Serialize(Fs, CType(MaterialSource.DataSource, MaterialList))
        Fs.Close()

        Fs = File.Create(MacroFileName)
        serializer.Serialize(Fs, CType(MacroSource.DataSource, MacroList))
        Fs.Close()

    End Sub

    'Length=mass/(density x Pi X (diameter/2)^2)
    Public Shared Function Length(Density As Double, Diameter As Double, Grams As Integer)
        Return (Grams / 1000) / (Density * Math.PI * ((Diameter / 2) * (Diameter / 2)))
    End Function
End Class

