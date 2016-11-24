Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable()>
Public Class SpoolExt
    Public Color As Color
    Public Manufactor As String
    Public AquireDate As DateTime
    Public OpenDate As DateTime

    Public Sub New()
        Color = Drawing.Color.Blue
        Manufactor = ""
        AquireDate = Now()
        OpenDate = Now()
    End Sub

End Class

Public Class Spool

    Public Const FlowRateCalc As Double = (40 / 255)
    Public Const FlowRateModifier As Integer = 80
    Public Const SpoolHotEndMask As Integer = 7
    Public Const SpoolHotEndExclMask As Integer = 255 - SpoolHotEndMask
    Public Const SpoolForceTemperature As Integer = 8
    Public Const SpoolTemperatureModifer As Integer = 145
    Public Const DiameterOffset As Integer = 145

    <Flags> _
    Public Enum SpoolFlag As Byte
        Unknown7 = 128
        Unknown6 = 64
        Unknown5 = 32
        Unknown4 = 16
        ForceTemperature = 8
        ToolB3 = 4
        ToolB2 = 2
        ToolB1 = 1
    End Enum

    Public Property SpoolID As UInt16
    Public Property SpoolType As String
    Public Property Description As String
    Public Property Temperature As Byte
    Public Property FlowRate As Byte
    Public Property ESteps As UInt16
    Public Property Length As UInt32
    Public Property Used As UInt32
    Public Property Flags As SpoolFlag
    Public Property Diameter As Byte
    Public Property Unused1 As Byte
    Public Property Unused2 As Byte
    Public Property EOL As UInt16 = 3338 '3338 = CRLF

    Public Property Extension As SpoolExt

    Public Property Flag7
        Get
            Return Flags And 128
        End Get
        Set(value)
            Flags = Flags And (255 - 128) + (value * 128)
        End Set
    End Property
    Public Property Flag6
        Get
            Return Flags And 64
        End Get
        Set(value)
            Flags = Flags And (255 - 64) + (value * 64)
        End Set
    End Property
    Public Property Flag5
        Get
            Return Flags And 32
        End Get
        Set(value)
            Flags = Flags And (255 - 32) + (value * 32)
        End Set
    End Property
    Public Property Flag4
        Get
            Return Flags And 16
        End Get
        Set(value)
            Flags = Flags And (255 - 16) + (value * 16)
        End Set
    End Property
    Public Property FlagForceTemperature
        Get
            Return Flags And 8
        End Get
        Set(value)
            Flags = Flags And (255 - 8) + (value * 8)
        End Set
    End Property
    Public Property Flag2
        Get
            Return Flags And 4
        End Get
        Set(value)
            Flags = Flags And (255 - 4) + (value * 4)
        End Set
    End Property
    Public Property Flag1
        Get
            Return Flags And 2
        End Get
        Set(value)
            Flags = Flags And (255 - 2) + (value * 2)
        End Set
    End Property
    Public Property Flag0
        Get
            Return Flags And 1
        End Get
        Set(value)
            Flags = Flags And (255 - 1) + (value * 1)
        End Set
    End Property
    Public Property FlowRateDisplay As Byte
        Get
            Return FlowRate * FlowRateCalc + FlowRateModifier
        End Get
        Set(value As Byte)
            FlowRate = (value - FlowRateModifier) / FlowRateCalc
        End Set
    End Property
    Public Property TemperatureDisplay As Integer
        Get
            Return Temperature + SpoolTemperatureModifer
        End Get
        Set(value As Integer)
            Temperature = value - SpoolTemperatureModifer
        End Set
    End Property

    Public Property DiameterDisplay As Double
        Get
            Return (Diameter + DiameterOffset) / 100
        End Get
        Set(value As Double)
            Diameter = (value * 100) - DiameterOffset
        End Set
    End Property

    Public ReadOnly Property RemainingPCT As Integer
        Get
            Return ((Length - Used) * 100) / Length
        End Get
    End Property

    Public ReadOnly Property LengthDisplay As Double
        Get
            Return Length / 1000
        End Get
    End Property

    Public ReadOnly Property UsedDisplay As Double
        Get
            Return Used / 1000
        End Get
    End Property

    Public Sub write(writer As System.IO.BinaryWriter, ExtWriter As stream)
        writer.Write(SpoolID)
        writer.Write(System.Text.Encoding.UTF8.GetBytes(SpoolType.PadRight(5, " ").Substring(0, 4)))
        writer.Write(System.Text.Encoding.UTF8.GetBytes(Description.PadRight(11, " ").Substring(0, 10)))
        writer.Write(Temperature)
        writer.Write(FlowRate)
        writer.Write(ESteps)
        writer.Write(Length)
        writer.Write(Used)
        writer.Write(Flags)
        writer.Write(Diameter)
        writer.Write(Unused1)
        writer.Write(Unused2)
        writer.Write(EOL)

        Dim serializer As New BinaryFormatter()
        serializer.Serialize(ExtWriter, Extension)
    End Sub

    Public Sub New(Optional Reader As System.IO.BinaryReader = Nothing, Optional ExtReader As Stream = Nothing)
        If Reader IsNot Nothing Then
            SpoolID = Reader.ReadUInt16()
            SpoolType = Convert.ToString(Reader.ReadChars(4)).Trim()
            Description = Convert.ToString(Reader.ReadChars(10)).Trim()
            Temperature = Reader.ReadByte()
            FlowRate = Reader.ReadByte()
            ESteps = Reader.ReadUInt16
            Length = Reader.ReadUInt32
            Used = Reader.ReadUInt32
            Flags = Reader.ReadByte()
            Diameter = Reader.ReadByte()
            Unused1 = Reader.ReadByte()
            Unused2 = Reader.ReadByte()
            EOL = Reader.ReadUInt16()

            Dim desserializer As New BinaryFormatter()
            Extension = CType(desserializer.Deserialize(ExtReader), SpoolExt)
        Else
            FlowRate = 128  ' 100 %
            TemperatureDisplay = 230
            Flags = 8   ' force temperature
            Used = 0
            Length = 330 * 1000 ' 330 meter in mm
            EOL = 3338
            DiameterDisplay = 1.75

            Extension = New SpoolExt()
        End If
    End Sub


End Class
