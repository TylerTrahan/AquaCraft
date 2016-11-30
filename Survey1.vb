Public Class Survey1
    Public Structure PointXY
        Public x As Long
        Public y As Long
    End Structure

    Public Structure DoubleXY
        Public x As Double
        Public y As Double
    End Structure

    Public Structure DoubleLL
        Public lat As Double
        Public lon As Double
    End Structure

    Public Structure LargeInt
        Public lngLower As Long
        Public lngUpper As Long
    End Structure

    Public Structure VectorArray
        Public x As Double
        Public y As Double
        Public Z As Double
    End Structure

    Public Structure ggaInfo_t
        ' $GPGGA,141449.00,2948.24652,N,09533.52845,W,2,9,0.8,34.29,M,-25.92,M,8,0108*6F
        Public Utc As Double
        Public lat As Double
        Public LatHemi As String
        Public lon As Double
        Public LonHemi As String
        Public Quality As Integer
        Public SatsUsed As Integer
        Public hdop As Single
        Public Altitude As Single
        Public AltUnit As String
        Public GeoSep As Single
        Public GeoSepUnit As String
        Public hae As Single
        Public diffage As Single
        Public StationID As Integer
        Public LastUpdate As Long
    End Structure

    Public Structure gllInfo_t
        ' $GPGLL,2527.2572,N,05520.5600,E,095837,A*xx
        ' $GPGLL,2948.245862,N,09533.528832,W,000010.00,A,D*7D
        Public lat As Double
        Public LatHemi As String
        Public lon As Double
        Public LonHemi As String
        Public Utc As Double
        Public Status As String
        Public Mode As String
        Public LastUpdate As Long
    End Structure

    Public Structure gsaInfo_t
        ' $GPGSA,M,3,,8,1,2,7,,3,13,11,31,28,,2.2,0.8,2.0*01
        Public Mode As String
        Public ModeStat As Integer
        Public SatID() As Integer 'redim as 42
        Public pdop As Single
        Public hdop As Single
        Public vdop As Single
        Public LastUpdate As Long
    End Structure

    Public Structure gstInfo_t
        ' $GPGST,141448.0,0.0432,0.0768,0.0613,-53.2385,0.0673,0.0716,0.2887*43
        Public Utc As Double
        Public Rms As Single
        Public SDSemiMajor As Single
        Public SDSemiMinor As Single
        Public OrientSemiMajor As Single
        Public SDLat As Single
        Public SDLon As Single
        Public SDAlt As Single
        Public LastUpdate As Long
    End Structure

    Public Structure satsInfo_t
        ' $PNCTR,SATS,4,1,01,15,169,47,39,02,08,071,43,38,03,13,043,40,38*70
        ' $PNCTR,SATS,4,2,07,11,217,45,39,08,44,325,51,45,11,28,131,53,42*70
        ' $PNCTR,SATS,4,3,13,42,195,51,42,28,31,279,49,43,29,02,326,00,00*72
        ' $PNCTR,SATS,4,4,31,51,048,52,46*71
        Public MessageMax As Integer
        Public MessageNum As Integer
        Public SatID() As Integer 'redim as 36
        Public SatElev() As Integer 'redim as 36
        Public SatAzimuth() As Integer 'redim as 36
        Public SatL1SNR() As Integer 'redim as 36
        Public SatL2SNR() As Integer 'redim as 36
        Public SatsInView As Integer
        Public LastUpdate As Long
    End Structure

    Public Structure gsvInfo_t
        ' $GPGSV,3,1,09,05,14,050,08,11,22,296,10,14,51,030,18,15,11,174,07*79
        ' $GPGSV,3,2,09,16,03,184,,18,20,126,07,23,46,118,,25,68,237,18*7C
        ' $GPGSV,3,3,09,30,30,077,13,,,,,,,,,,,,*42
        Public MessageMax As Integer
        Public MessageNum As Integer
        Public SatsInView As Integer
        Public SatID() As Integer 'redim as 36
        Public SatElev() As Integer 'redim as 36
        Public SatAzimuth() As Integer 'redim as 36
        Public SatSNR() As Integer 'redim as 36
        Public LastUpdate As Long
    End Structure

    Public Structure hdtInfo_t
        ' $HEHDT,348.0,T*20
        Public HeadingT As Single
        Public HeadingTID As String
        Public LastUpdate As Long
    End Structure

    Public Structure hdmInfo_t
        ' $HEHDT,348.0,M*xx
        Public HeadingM As Single
        Public HeadingMID As String
        Public LastUpdate As Long
    End Structure

    Public Structure sgbInfo_t
        Public HeadingT As Single
        Public LastUpdate As Long
    End Structure

    Public Structure vtgInfo_t
        ' $GPVTG,0,T,,,0.00,N,0.00,K*33
        ' $GPVTG,0.0,T,,M,0.04,N,0.07,K,D*0B
        Public cogt As Single
        Public CogTID As String
        Public CogM As Single
        Public CogMID As String
        Public SpeedKt As Single
        Public SpeedKtID As String
        Public SpeedKmh As Single
        Public SpeedKmhID As String
        Public Mode As String
        Public LastUpdate As Long
    End Structure

    Public Structure zdaInfo_t
        ' $GPZDA,141449.00,3,2,2004,+0,+0*6C
        Public Utc As Double
        Public Day As Integer
        Public Month As Integer
        Public Year As Integer
        Public LocalTZhr As Integer
        Public LocalTZmn As Integer
        Public LastUpdate As Long
    End Structure

    Public Structure rd1Info_t
        Public WeekSec As Double
        Public Week As Integer
        Public Frequency As Double
        Public Lock As Integer
        Public BitErrorRate1 As Integer
        Public BitErrorRate2 As Integer
        Public Agc As Integer
        Public Dds As Integer
        Public Doppler As Integer
        Public DspStatus As String
        Public ArmStatus As String
        Public DiffStatus As String
        Public NavCondition As String
        Public LastUpdate As Long
    End Structure

    Public Structure rxqInfo_t
        ' $PNCTR,RXQ,141450,Y,12.3,2,0*40
        Public Utc As Double
        Public SFLock As String
        Public SFSNR As Double
        Public PerIdlePacket As Integer
        Public PerBadPacket As Integer
        Public LastUpdate As Long
    End Structure

    Public Structure navqInfo_t
        ' either - $PNCTR,NAVQ,123519,3D,RTG,DUAL*55
        '     or - $PNCTR,NAVQ,202759,NN*74
        Public Utc As Double
        Public NavMode As String
        Public CorrType As String
        Public SignalType As String
        Public LastUpdate As Long
    End Structure

    Public Structure ohprInfo_t
        '$OHPR,78.8,-0.5,-1.4,-0.009,-0.025,0.976*34
        Public Heading As Double
        Public Pitch As Double
        Public Roll As Double
        Public Depth As Double
        Public LastUpdate As Long
    End Structure

    Public Structure encoderInfo_t
        'Encoder String
        Public Value As Double
        Public LastUpdate As Long
    End Structure

    Public Structure flowInfo_t
        'Encoder String
        Public Value As Double
        Public LastUpdate As Long
    End Structure

    Public Structure NmeaInfo_t
        Public gga As ggaInfo_t
        Public gll As gllInfo_t
        Public gsa As gsaInfo_t
        Public gst As gstInfo_t
        Public gsv As gsvInfo_t
        Public sats As satsInfo_t
        Public hdt As hdtInfo_t
        Public hdm As hdmInfo_t
        Public sgb As sgbInfo_t
        Public vtg As vtgInfo_t
        Public zda As zdaInfo_t
        Public rd1 As rd1Info_t
        Public rxq As rxqInfo_t
        Public navq As navqInfo_t
        Public ohpr As ohprInfo_t
        Public encoder As encoderInfo_t
        Public flow As flowInfo_t
    End Structure

    Public NmeaArray()
    Public NmeaInfo As NmeaInfo_t
    ' init arrays

    Public Const earth_radius = 6371008 'meters
    Public TraverseX As Double
    Public TraverseY As Double
    Public InverseBearing As Double
    Public InverseDistance As Double
    Public IntersectCoord As DoubleXY
    Public FourPtIntersect_Y As Double
    Public FourPtIntersect_X As Double
    'Public StandardDeviationRT As Double
    Public StdDevSetArrayRT(,) As Double
    Public Const PI = 3.14159265358979
    'Public Const PI = 4 * Atn(1 / 1)
    Public Declare Function GetTickCount& Lib "kernel32" () 'added 000222
    Public Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
    Public Declare Function GetSystemDirectory Lib "kernel32" Alias "GetSystemDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long

    Public Sub New()

    End Sub
    Public Function InitNmeaInfo() As Integer
        ReDim NmeaInfo.gsa.SatID(42)
        ReDim NmeaInfo.sats.SatID(36)
        ReDim NmeaInfo.sats.SatAzimuth(36)
        ReDim NmeaInfo.sats.SatElev(36)
        ReDim NmeaInfo.sats.SatL1SNR(36)
        ReDim NmeaInfo.sats.SatL2SNR(36)
        ReDim NmeaInfo.gsv.SatElev(36)
        ReDim NmeaInfo.gsv.SatID(36)
        ReDim NmeaInfo.gsv.SatSNR(36)
        InitNmeaInfo = 1
    End Function
    ' convert from degrees to radians

    Public Function DegreesToRadians(degrees As Double) As Double
        DegreesToRadians = degrees / (180 / PI)
    End Function

    ' convert from radians to degrees

    Public Function RadiansToDegrees(radians As Double) As Double
        RadiansToDegrees = radians * (180 / PI)
    End Function

    ' sm_wait (WaitTime As Long) As Long
    ' ex: RetVal = sm_wait(500)
    ' returns: non zero upon completion of delay

    Public Function sm_wait&(WaitTime&)
        Dim ClockTicks&
        Dim ClockStart&
        ClockStart = GetTickCount
        Do While ClockTicks < (ClockStart + WaitTime)
            ClockTicks = GetTickCount
            'DoEvents
        Loop
        sm_wait = ClockTicks

    End Function

    ' ToJulian()
    ' arguments: WfgDate - date string from winfrog dat file
    ' returns: julian day
    ' ex: JulianDay = ToJulian(07-27-99) = 208

    Public Function ToJulian(WfgDate) As Integer

        Dim WfgDay = Mid$(WfgDate, 4, 2)
        Dim WfgMon = Mid$(WfgDate, 1, 2)
        Dim WfgYer = Mid$(WfgDate, 7, 2)
        Dim WfgYear As Integer
        Dim Leap As Integer

        'Debug.Print WfgDay
        'Debug.Print WfgMon
        'Debug.Print WfgYer

        If (Val(WfgYer) > 50) Then
            WfgYer = "19" + WfgYer
            WfgYear = WfgYer
        Else
            WfgYer = "20" + WfgYer
            WfgYear = WfgYer
        End If

        ' Leap Year Calculation
        If (WfgYer Mod 4) < 0 Or (WfgYer Mod 4) > 0 Then
            Leap = 0
        ElseIf (WfgYer Mod 400) = 0 Then
            Leap = 1
        ElseIf (WfgYer Mod 100) = 0 Then
            Leap = 0
        Else
            Leap = 1
        End If

        If WfgMon = "01" Then
            ToJulian = Val(WfgDay)
        ElseIf WfgMon = "02" Then
            ToJulian = Val(Leap) + 31 + Val(WfgDay)
        ElseIf WfgMon = "03" Then
            ToJulian = Val(Leap) + 59 + Val(WfgDay)
        ElseIf WfgMon = "04" Then
            ToJulian = Val(Leap) + 90 + Val(WfgDay)
        ElseIf WfgMon = "05" Then
            ToJulian = Val(Leap) + 120 + Val(WfgDay)
        ElseIf WfgMon = "06" Then
            ToJulian = Val(Leap) + 151 + Val(WfgDay)
        ElseIf WfgMon = "07" Then
            ToJulian = Val(Leap) + 181 + Val(WfgDay)
        ElseIf WfgMon = "08" Then
            ToJulian = Val(Leap) + 212 + Val(WfgDay)
        ElseIf WfgMon = "09" Then
            ToJulian = Val(Leap) + 243 + Val(WfgDay)
        ElseIf WfgMon = "10" Then
            ToJulian = Val(Leap) + 273 + Val(WfgDay)
        ElseIf WfgMon = "11" Then
            ToJulian = Val(Leap) + 304 + Val(WfgDay)
        ElseIf WfgMon = "12" Then
            ToJulian = Val(Leap) + 334 + Val(WfgDay)
        Else
            ToJulian = 0
        End If

    End Function

    ' TruncTime()
    ' arguments: WfgTime - time string from winfrog dat file
    ' returns: time without delimiters (hrmnscd)
    ' ex: FixTime = TruncTime(01:00:31.4) = 0100314

    Public Function TruncTime(WfgTime)
        Dim Max = Len(WfgTime)
        Dim Cnt = 1
        Dim NewTime = ""

        While Cnt <= Max
            If Mid$(WfgTime, Cnt, 1) = ":" Then
                Cnt = Cnt + 1
            ElseIf Mid$(WfgTime, Cnt, 1) = "." Then
                Cnt = Cnt + 1
            Else
                NewTime = NewTime + Mid$(WfgTime, Cnt, 1)
                Cnt = Cnt + 1
            End If
        End While
        TruncTime = NewTime

    End Function

    ' Traverse()
    ' arguments: StartX - starting X coordinate for traverse
    '            StartY - starting Y coordinate for traverse
    '            Bearing - bearing of traverse
    '            Distance - distance of traverse
    ' returns: assigns values to Public variables TraverseX and TraverseY
    ' ex: Call Traverse(StartX, StartY, Bearing, Distance)

    Public Sub Traverse(StartX As Double, StartY As Double, bearing As Double, distance As Double)
        Dim dy As Double
        Dim dx As Double

        dy = (Math.Cos(DegreesToRadians(bearing))) * distance
        dx = (Math.Sin(DegreesToRadians(bearing))) * distance
        TraverseX = StartX + dx
        TraverseY = StartY + dy

    End Sub

    ' Inverse()
    ' arguments: StartX - starting X coordinate of inverse
    '            StartY - starting Y coordinate of inverse
    '            EndX - ending X of inverse
    '            EndY - ending Y of inverse
    ' returns: assigns values to Public variables InverseBearing and InverseDistance
    ' ex: Call Inverse(StartX, StartY, EndX, EndY)
    Public Sub Inverse(StartX As Double, StartY As Double, EndX As Double, EndY As Double)
        Dim DiffX As Double
        Dim DiffY As Double
        If StartX = 0 Then
            StartX = StartX + 0.000000001
        End If
        If StartY = 0 Then
            StartY = StartY + 0.000000001
        End If
        If EndX = 0 Then
            EndX = EndX + 0.000000001
        End If
        If EndY = 0 Then
            EndY = EndY + 0.000000001
        End If

        DiffX = EndX - StartX
        DiffY = EndY - StartY
        If DiffX = 0 Then
            DiffX = DiffX + 0.000000001
        End If
        If DiffY = 0 Then
            DiffY = DiffY + 0.000000001
        End If


        InverseDistance = Math.Sqrt(((DiffY) * (DiffY)) + ((DiffX) * (DiffX)))
        InverseBearing = RadiansToDegrees((Math.Atan(CDbl((DiffY) / (DiffX)))))

        ' put InverseBearing between 0 and 360
        If InverseBearing < 0 Then
            InverseBearing = InverseBearing + 360
        ElseIf InverseBearing > 360 Then
            InverseBearing = InverseBearing - 360
        End If

        ' find quadrant and adjust bearing
        If DiffX > 0 And DiffY > 0 Then
            InverseBearing = 90 - InverseBearing
        ElseIf DiffX > 0 And DiffY < 0 Then
            InverseBearing = 180 - (InverseBearing - 270)
        ElseIf DiffX < 0 And DiffY < 0 Then
            InverseBearing = 270 - InverseBearing
        ElseIf DiffX < 0 And DiffY > 0 Then
            InverseBearing = 360 - (InverseBearing - 270)
        End If

    End Sub

    ' FourPointIntersection()
    ' arguments: Start1_Y - Starting Y on 1st Line
    '            Start1_X - Starting X on 1st Line
    '            End1_Y - Ending Y on 1st Line
    '            End1_X - Ending X on 1st Line
    '            Start2_Y - Starting Y on 2nd Line
    '            Start2_X - Starting X on 2nd Line
    '            End2_Y - Ending Y on 2nd Line
    '            End2_X - Ending X on 2nd Line
    ' Returns:  Assigns values to Public Variables FourPtIntersect_Y and FourPtIntersect_X
    ' Ex:  Call FourPointIntersection(Start1_Y,Start1_X,End1_Y,End1_X,Start2_Y,Start2_X,End2_Y,End2_X)

    Public Sub FourPtIntersection(YA As Double, XA As Double, YB As Double, XB As Double, Yc As Double, Xc As Double, YD As Double, XD As Double)
        Static RValue As Double
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        a = (YA - Yc) * (XD - Xc)
        b = (XA - Xc) * (YD - Yc)
        C = (XB - XA) * (YD - Yc)
        d = (YB - YA) * (XD - Xc)
        RValue = (a - b) / (C - d)
        'Debug.Print RValue
        FourPtIntersect_Y = YA + RValue * (YB - YA)
        'Debug.Print Intersect_Y
        FourPtIntersect_X = XA + RValue * (XB - XA)
        'Debug.Print Intersect_X
    End Sub

    ' Finds the perpendicular distance from a point to a given line.
    ' DistanceToLine()
    ' arguments: X1 - Starting X of Line
    '            Y1 - Starting Y of Line
    '            X2 - Ending X of Line
    '            Y2 - Ending Y of Line
    '            Xp - X Coordinate of Point
    '            Yp - Y Coordinate of Point
    ' Returns: Double Distance to Line

    Public Function DistanceToLine(X1 As Double, Y1 As Double, X2 As Double, Y2 As Double, Xp As Double, Yp As Double) As Double
        Dim P As Single
        Dim Xc As Double
        Dim Yc As Double

        P = (Y2 - Yp) * (Y2 - Y1) - (X2 - Xp) * (X1 - X2)
        P = P / ((Y1 - Y2) ^ 2 + (X1 - X2) ^ 2)
        Xc = P * X1 + (1 - P) * X2
        Yc = P * Y1 + (1 - P) * Y2
        IntersectCoord.x = Xc
        IntersectCoord.y = Yc

        ' return distance from point to line
        DistanceToLine = Math.Sqrt((Xc - Xp) ^ 2 + (Yc - Yp) ^ 2) 'a² + b² = c²

    End Function
    Public Function PointSegmentDistanceSquared(point As DoubleXY, lineStart As DoubleXY, lineEnd As DoubleXY, intersectPoint As DoubleXY)

        Dim kMinSegmentLenSquared As Double = 0.00000001 'adjust To suit.  If you use float, you'll probably want something like 0.000001f
        Dim kEpsilon As Double = 0.00000000000001 'adjust To suit.  If you use floats, you'll probably want something like 1E-7f
        Dim dX As Double = lineEnd.x - lineStart.x
        Dim dY As Double = lineEnd.y - lineStart.y
        Dim dp1X As Double = point.x - lineStart.x
        Dim dp1Y As Double = point.y - lineStart.y
        Dim segLenSquared As Double = (dX * dX) + (dY * dY)
        Dim t As Double = 0.0
        Dim distance As Double

        If (segLenSquared >= -kMinSegmentLenSquared And segLenSquared <= kMinSegmentLenSquared) Then

            ' segment Is a point.
            intersectPoint = lineStart
            t = 0.0
            distance = ((dp1X * dp1X) + (dp1Y * dp1Y))
        Else
            ' Project a line from p to the segment [p1,p2].  By considering the line
            ' extending the segment, parameterized as p1 + (t * (p2 - p1)),
            ' we find projection of point p onto the line. 
            ' It falls where t = [(p - p1) . (p2 - p1)] / |p2 - p1|^2
            t = ((dp1X * dX) + (dp1Y * dY)) / segLenSquared
            If (t < kEpsilon) Then
                ' intersects at Or to the "left" of first segment vertex (lineStart.X, lineStart.Y).  If t Is approximately 0.0, then
                ' intersection Is at p1.  If t Is less than that, then there Is no intersection (i.e. p Is Not within
                ' the 'bounds' of the segment)
                If (t > -kEpsilon) Then
                    ' intersects at 1st segment vertex
                    t = 0.0
                End If
                ' set our 'intersection' point to p1.
                intersectPoint = lineStart
                ' Note: If you Then wanted the ACTUAL intersection point Of where the projected lines would intersect If
                ' we were doing PointLineDistanceSquared, then intersectPoint.X would be (lineStart.X + (t * dx)) And
                ' intersectPoint.y would be (lineStart.Y + (t * dy)).
            ElseIf (t > (1.0 - kEpsilon)) Then
                ' intersects at Or to the "right" of second segment vertex (lineEnd.X, lineEnd.Y).  If t Is approximately 1.0, then
                ' intersection Is at p2.  If t Is greater than that, then there Is no intersection (i.e. p Is Not within
                ' the 'bounds' of the segment)
                If (t < (1.0 + kEpsilon)) Then
                    ' intersects at 2nd segment vertex
                    t = 1.0
                End If
                ' set our 'intersection' point to p2.
                intersectPoint = lineEnd
                ' Note: If you Then wanted the ACTUAL intersection point Of where the projected lines would intersect If
                ' we were doing PointLineDistanceSquared, then intersectPoint.X would be (lineStart.X + (t * dx)) And intersectPoint.Y would be (lineStart.Y + (t * dy)).
            Else
                ' The projection of the point to the point on the segment that Is perpendicular succeeded And the point
                ' Is 'within' the bounds of the segment.  Set the intersection point as that projected point.
                intersectPoint.x = (lineStart.x + (t * dX))
                intersectPoint.y = (lineStart.y + (t * dY))
            End If
            ' return the squared distance from p to the intersection point.  Note that we return the squared distance
            ' as an optimization because many times you just need to compare relative distances And the squared values
            ' works fine for that.  If you want the ACTUAL distance, just take the square root of this value.
            Dim dpqX As Double = point.x - intersectPoint.x
            Dim dpqY As Double = point.y - intersectPoint.y

            distance = Math.Sqrt((dpqX * dpqX) + (dpqY * dpqY))
        End If

        Return distance

    End Function

    '    Public Function ClosestPoint(point As DoubleXY, linePointA As DoubleXY, linePointB As DoubleXY) As DoubleXY

    '    Dim x0 = point.x;
    '    Dim y0 = point.y;

    '    Dim x1 = linePointA.x;
    '    Dim y1 = linePointA.y;

    '    Dim x2 = linePointB.x;
    '    Dim y2 = linePointB.y;

    '    Dim Dx = (x2 - x1);
    '    Dim Dy = (y2 - y1);

    '    Dim numerator = Math.Abs(Dy * x0 - Dx * y0 - x1 * y2 + x2 * y1);
    '    Dim denominator = Math.Sqrt(Dx * Dx + Dy * Dy);
    '    If (denominator == 0) Then
    '    Return this.dist2(point, linePointA);
    '    End If

    '    Return numerator / denominator

    '    End Function

    ' StdDevRealTime()
    ' arguments: NewValue - New Value in set
    '            Reset = 1 (optional) - Resets NumValues to 0 to restart calculation
    ' Returns: Calculates standard deviation of current set and returns standard deviation
    ' Ex: Call StdDevRealTime(NewValue [,1])

    Public Function StdDevRealTime(NewValue As Double, Optional Reset As Integer = 0) As Double

        ' variable declaration
        Static NumValues As Integer
        Dim ArithmeticMean As Double
        Dim MeanOfSquaresOfResiduals
        Dim TotalSquaresOfResiduals As Double = 0

        ' variable initialization
        Dim Cnt = 0
        Dim TotalValue = 0

        ' dynamically increase array size
        ReDim Preserve StdDevSetArrayRT(3, NumValues)

        ' check for calculation reset
        If Reset = 1 Then
            NumValues = 0
        End If

        ' store NewValue in array
        StdDevSetArrayRT(0, NumValues) = NewValue

        ' calculate standard deviation
        NumValues = NumValues + 1
        While Cnt < NumValues
            TotalValue = TotalValue + StdDevSetArrayRT(0, Cnt)
            Cnt = Cnt + 1
        End While
        ArithmeticMean = TotalValue / NumValues
        Cnt = 0
        While Cnt < NumValues
            StdDevSetArrayRT(1, Cnt) = StdDevSetArrayRT(0, Cnt) - ArithmeticMean
            StdDevSetArrayRT(2, Cnt) = StdDevSetArrayRT(1, Cnt) * StdDevSetArrayRT(1, Cnt)
            Cnt = Cnt + 1
        End While
        Cnt = 0
        While Cnt < NumValues
            TotalSquaresOfResiduals = TotalSquaresOfResiduals + StdDevSetArrayRT(2, Cnt)
            Cnt = Cnt + 1
        End While
        MeanOfSquaresOfResiduals = TotalSquaresOfResiduals / NumValues

        ' return current standard deviation
        StdDevRealTime = Math.Sqrt(MeanOfSquaresOfResiduals)

    End Function

    Public Function StandardDeviation(ByRef arr() As Double) As Double

        'standard deviation
        Dim Sum As Double
        Dim sumSquare As Double
        Dim Value As Double
        Dim count As Long
        Dim index As Long
        Sum = 0
        sumSquare = 0
        Value = 0
        count = 0
        index = 0

        ' evaluate sum of values
        For index = LBound(arr) To UBound(arr)
            Value = arr(index)
            count = count + 1
            Sum = Sum + Value
            sumSquare = sumSquare + Value * Value
        Next

        If ((Sum * Sum / count)) > sumSquare Then
            StandardDeviation = 0
        Else
            StandardDeviation = Math.Sqrt((sumSquare - (Sum * Sum / count)) / count)
        End If

        'StandardDeviation = Sqr((sumSquare - (sum * sum / count)) / count)

    End Function

    ' VarianceRealTime()
    ' arguments: NewValue - New Value in set
    '            Reset = 1 (optional) - Resets NumValues to 0 to restart calculation
    ' Returns: Calculates standard deviation of current set and returns standard deviation
    ' Ex: Call VarianceRealTime(NewValue [,1])

    Public Function VarianceRealTime(NewValue As Double, Optional Reset As Integer = 0) As Double

        ' variable declaration
        Static NumValues As Integer
        Dim ArithmeticMean As Double
        Dim MeanOfSquaresOfResiduals As Double
        Dim TotalSquaresOfResiduals As Double = 0

        ' variable initialization
        Dim Cnt = 0
        Dim TotalValue = 0

        ' dynamically increase array size
        ReDim Preserve StdDevSetArrayRT(3, NumValues)

        ' check for calculation reset
        If Reset = 1 Then
            NumValues = 0
        End If

        ' store NewValue in array
        StdDevSetArrayRT(0, NumValues) = NewValue

        ' calculate standard deviation
        NumValues = NumValues + 1
        While Cnt < NumValues
            'DoEvents
            TotalValue = TotalValue + StdDevSetArrayRT(0, Cnt)
            Cnt = Cnt + 1
        End While
        ArithmeticMean = TotalValue / NumValues
        Cnt = 0
        While Cnt < NumValues
            'DoEvents
            StdDevSetArrayRT(1, Cnt) = StdDevSetArrayRT(0, Cnt) - ArithmeticMean
            StdDevSetArrayRT(2, Cnt) = StdDevSetArrayRT(1, Cnt) * StdDevSetArrayRT(1, Cnt)
            Cnt = Cnt + 1
        End While
        Cnt = 0
        While Cnt < NumValues
            'DoEvents
            TotalSquaresOfResiduals = TotalSquaresOfResiduals + StdDevSetArrayRT(2, Cnt)
            Cnt = Cnt + 1
        End While
        MeanOfSquaresOfResiduals = TotalSquaresOfResiduals / NumValues

        ' return current standard deviation
        VarianceRealTime = MeanOfSquaresOfResiduals

    End Function

    ' Variance()
    ' arguments: NewValues() - Array of new values
    '            NumValues   - Long containing the number of values
    ' Returns: Calculates variance of current set and returns
    ' Ex: Call VarianceRealTime(NewValues, NumValues)

    Public Function Variance(NewValues() As Double, NumValues As Long) As Double

        ' variable declaration
        'Static NumValues As Integer
        Dim ArithmeticMean As Double
        Dim MeanOfSquaresOfResiduals As Double
        Dim TotalSquaresOfResiduals As Double = 0

        ' variable initialization
        Dim Cnt = 0
        Dim TotalValue = 0

        ' dynamically increase array size
        ReDim Preserve StdDevSetArrayRT(3, NumValues)

        While Cnt < NumValues
            'DoEvents
            StdDevSetArrayRT(0, Cnt) = NewValues(Cnt)
            Cnt = Cnt + 1
        End While

        Cnt = 0
        While Cnt < NumValues
            'DoEvents
            TotalValue = TotalValue + StdDevSetArrayRT(0, Cnt)
            Cnt = Cnt + 1
        End While
        ArithmeticMean = TotalValue / NumValues

        Cnt = 0
        While Cnt < NumValues
            'DoEvents
            StdDevSetArrayRT(1, Cnt) = StdDevSetArrayRT(0, Cnt) - ArithmeticMean
            StdDevSetArrayRT(2, Cnt) = StdDevSetArrayRT(1, Cnt) * StdDevSetArrayRT(1, Cnt)
            Cnt = Cnt + 1
        End While

        Cnt = 0
        While Cnt < NumValues
            'DoEvents
            TotalSquaresOfResiduals = TotalSquaresOfResiduals + StdDevSetArrayRT(2, Cnt)
            Cnt = Cnt + 1
        End While
        MeanOfSquaresOfResiduals = TotalSquaresOfResiduals / NumValues

        ' return current variance
        Variance = MeanOfSquaresOfResiduals

    End Function

    Public Function HarmonicMean(ByRef DataArray() As Double, ByVal nPoints As Integer) As Double
        Dim datacount As Integer
        Dim reciprocals As Double
        For datacount = 0 To (nPoints - 1)
            reciprocals = reciprocals + (1 / DataArray(datacount))
        Next datacount
        HarmonicMean = nPoints / reciprocals
    End Function

    Public Function Median(ByRef DataArray() As Double) As Double
        Dim TempArray() As Double
        ReDim TempArray(UBound(DataArray))
        TempArray = DataArray
        'QuickSort (TempArray)

        If (UBound(TempArray) Mod 2) = 0 Then
            ' odd number of items
            Median = TempArray(UBound(TempArray) \ 2)
        Else
            ' even number of items
            Median = (TempArray(UBound(TempArray) \ 2) + TempArray(1 + UBound(TempArray) \ 2)) / 2
        End If
    End Function

    Public Function FileUnixToDos(ByVal FileName As String, ByVal FileNumber As Integer) As Integer
        Dim Cnt = 0
        Dim Max = FileLen(FileName)
        Dim TempString = ""
        Dim TempNumber
        Dim LineChar

        FileUnixToDos = -1 ' assume failure
        If Max = 0 Then
            Exit Function
        End If
        TempNumber = FileSystem.FreeFile()
        FileSystem.FileOpen(TempNumber, "dosfile.tmp", OpenMode.Output)
        While EOF(FileNumber) = False
            LineChar = FileSystem.InputString(TempNumber, 1)
            If LineChar = Chr(10) Then
                FileSystem.Print(TempNumber, TempString)
                TempString = ""
            ElseIf LineChar = Chr(13) Then
                'do nothing
            Else
                TempString = TempString + LineChar
            End If
        End While
        FileClose(FileNumber)
        FileClose(TempNumber)
        FileCopy("dosfile.tmp", FileName)
        Kill("dosfile.tmp")
        FileOpen(FileNumber, FileName, OpenMode.Input)
        FileUnixToDos = FileNumber ' return success
    End Function

    Public Function LinearRegression(ByRef PointArray() As DoubleXY, ByVal nPoints As Integer, ByRef Slope As Double, ByRef Intercept As Double)

        ' linear regression to determine the best fit line for a given set of
        ' points. solves for the slope and the Y intercept. given the equation
        ' of a line y = m(slope)x + b(y-intercept), any point along the line can
        ' be calculated.

        Dim sum_X As Double
        Dim avg_X As Double ' (x1 + x2 + ...xN) / N
        Dim sum_Y As Double
        Dim avg_Y As Double ' (y1 + y2 + ...yN) / N
        Dim sum_X_squares As Double
        Dim avg_X_squares As Double ' ((x1)ª + (x2)ª + ...(xN)ª) / N
        Dim sum_XY As Double
        Dim avg_XY As Double ' ((x1 * y1) + (x2 * y2) + ...(xN * yN)) / N
        Dim Cnt As Integer

        LinearRegression = -1 ' assume failure

        sum_X = 0
        sum_Y = 0
        sum_X_squares = 0
        sum_XY = 0

        For Cnt = 0 To (nPoints - 1)
            sum_X = sum_X + PointArray(Cnt).x
            sum_Y = sum_Y + PointArray(Cnt).y
            sum_X_squares = sum_X_squares + (PointArray(Cnt).x * PointArray(Cnt).x)
            sum_XY = sum_XY + (PointArray(Cnt).x * PointArray(Cnt).y)
        Next Cnt

        avg_X = sum_X / nPoints
        avg_Y = sum_Y / nPoints
        avg_X_squares = sum_X_squares / nPoints
        avg_XY = sum_XY / nPoints

        Slope = (avg_XY - (avg_X * avg_Y)) / (avg_X_squares - (avg_X * avg_X))
        Intercept = avg_Y - (Slope * avg_X)

        LinearRegression = Cnt + 1 ' return should equal nPoints

    End Function

    Public Function WindowsDirectory() As String
        Dim WinPath As String = ""
        WinPath = WinPath.PadLeft(255, Chr(0))
        WindowsDirectory = Left(WinPath, GetWindowsDirectory(WinPath, Len(WinPath)))
    End Function

    Public Function SystemDirectory() As String
        Dim SysPath As String = ""
        SysPath = SysPath.PadLeft(255, Chr(0))
        SystemDirectory = Left(SysPath, GetSystemDirectory(SysPath, Len(SysPath)))
    End Function

    Public Function sm_parse(ByVal InString As String, Delimiter As String, ByRef DynArray() As String) As Integer
        ' returns: elements in the array (tokens?)
        Dim Max As Integer
        Dim LoopCnt As Integer
        Dim ArrayCnt As Integer
        Dim DCnt As Integer
        Dim InChar

        Max = Len(InString)
        ArrayCnt = 1
        DCnt = 0
        ReDim DynArray(ArrayCnt)

        If Delimiter = " " Then
            For LoopCnt = 1 To Max
                InChar = Mid$(InString, LoopCnt, 1)
                If InChar = Delimiter Then
                    If DCnt = 0 Then
                        ArrayCnt = ArrayCnt + 1
                        ReDim Preserve DynArray(ArrayCnt)
                        DCnt = DCnt + 1
                    End If
                Else
                    DynArray(ArrayCnt) = DynArray(ArrayCnt) + InChar
                    DCnt = 0
                End If
            Next LoopCnt
        Else
            For LoopCnt = 1 To Max
                InChar = Mid$(InString, LoopCnt, 1)
                If InChar = Delimiter Then
                    ArrayCnt = ArrayCnt + 1
                    ReDim Preserve DynArray(ArrayCnt)
                Else
                    DynArray(ArrayCnt) = DynArray(ArrayCnt) + InChar
                    '            Debug.Print DynArray(ArrayCnt)
                End If
            Next LoopCnt
        End If
        sm_parse = ArrayCnt
    End Function

    Public Function Check_Sum(CheckString As String) As Boolean
        ' usage: Result = Check_Sum(CheckString)
        ' returns: True or False
        ' what does it do? Exclusive OR each character in string, convert to hex
        Dim Cnt As Integer
        Dim Sum As Integer
        Dim SumCheck As String
        Dim CheckChar As String
        Dim Max As Integer

        Cnt = 2 ' skip over ($) and start with GPGGA,XXX...
        Sum = 0
        Max = Len(CheckString) - 3 ' leave off (*HH) checksum
        While Cnt <= Max
            CheckChar = Mid$(CheckString, Cnt, 1)
            Sum = Sum Xor Asc(Mid$(CheckString, Cnt, 1))
            Cnt = Cnt + 1
        End While
        SumCheck = Hex(Sum)
        ' verify calculated checksum against observed checksum
        If Val(SumCheck) = Val(Mid$(CheckString, Max + 2, 2)) Then
            Check_Sum = True
        Else
            Check_Sum = False
        End If
    End Function

    Public Function ChkSumVal(InString As String) As String
        ' Added by S. McBay on July 30 2001
        ' ChkSumVal(InString As String) As String
        ' usage: CheckSum = ChkSumVal(InString)
        ' returns: string containing hex checksum
        ' what does it do? Exclusive OR each character in string, convert to hex
        Dim Cnt As Integer
        Dim Sum As Integer
        'Dim SumCheck As String
        Dim CheckChar As String
        Dim Max As Integer

        Cnt = 1
        Sum = 0
        Max = Len(InString)
        While Cnt <= Max
            CheckChar = Mid$(InString, Cnt, 1)
            Sum = Sum Xor Asc(Mid$(InString, Cnt, 1))
            Cnt = Cnt + 1
        End While
        ChkSumVal = CStr(Hex(Sum))
    End Function

    Public Function WebChkSum(InString As String) As String
        ' Added by S. McBay on February 19 2013
        ' WebChkSum(InString As String) As String
        ' usage: CheckSum = WebChkSum(InString)
        ' returns: string containing hex checksum
        ' Adds the ASCII value of each character, convert to hex, return 2 least significant digits
        Dim Cnt As Integer
        Dim Sum As Integer
        Dim Max As Integer
        Dim CheckChar As String
        'Dim HexSum As String
        Cnt = 1
        Sum = 0
        Max = Len(InString)
        While Cnt <= Max
            CheckChar = Mid$(InString, Cnt, 1)
            Sum = Sum + Asc(CheckChar)
            Cnt = Cnt + 1
        End While
        Max = Len(Str(Sum))
        If Max > 2 Then
            WebChkSum = Mid$(Hex(Sum), Max - 2, 2)
        Else
            WebChkSum = Hex(Sum)
        End If

    End Function

    Public Function Bool2Int(ByVal InBool As Boolean) As Integer
        If InBool = True Then
            Bool2Int = 1
        ElseIf InBool = False Then
            Bool2Int = 0
        Else
            Bool2Int = -1
        End If
    End Function

    Public Function Int2Bool(ByVal InInt As Integer) As Boolean
        If InInt = 0 Then
            Int2Bool = False
        ElseIf InInt > 0 Then
            Int2Bool = True
        Else
            Int2Bool = False
        End If
    End Function

    Public Function BaseConvert(NumIn As String, BaseIn As Byte, BaseOut As Byte) As String
        'Binary      = Base 2
        'Octal       = Base 8
        'Decimal     = Base 10
        'Hexadecimal = Base 16

        Dim I As Integer, CurrentCharacter As String, CharacterValue As Integer
        Dim PlaceValue As Integer, RunningTotal As Double, Remainder As Double
        Dim BaseOutDouble As Double, NumInCaps As String
        BaseConvert = ""

        If NumIn = "" Or BaseIn < 2 Or BaseIn > 36 Or BaseOut < 1 Or BaseOut > 36 Then
            BaseConvert = "Error"
            Exit Function
        End If

        NumInCaps = UCase(NumIn)

        PlaceValue = Len(NumInCaps)

        For I = 1 To Len(NumInCaps)
            PlaceValue = PlaceValue - 1
            CurrentCharacter = Mid$(NumInCaps, I, 1)
            CharacterValue = 0
            If Asc(CurrentCharacter) > 64 And Asc(CurrentCharacter) < 91 Then
                CharacterValue = Asc(CurrentCharacter) - 55
            End If

            If CharacterValue = 0 Then
                If Asc(CurrentCharacter) < 48 Or Asc(CurrentCharacter) > 57 Then
                    BaseConvert = "Error"
                    Exit Function
                Else
                    CharacterValue = Val(CurrentCharacter)
                End If
            End If

            If CharacterValue < 0 Or CharacterValue > BaseIn - 1 Then
                BaseConvert = "Error"
                Exit Function
            End If
            RunningTotal = RunningTotal + CharacterValue * (BaseIn ^ PlaceValue)
        Next I

        Do
            BaseOutDouble = CDbl(BaseOut)
            Remainder = RunningTotal - (Int(RunningTotal / BaseOutDouble) * BaseOutDouble)
            RunningTotal = (RunningTotal - Remainder) / BaseOut

            If Remainder >= 10 Then
                CurrentCharacter = Chr(Remainder + 55)
            Else
                CurrentCharacter = Right$(Str(Remainder), Len(Str(Remainder)) - 1)
            End If
            BaseConvert = CurrentCharacter & BaseConvert
        Loop While RunningTotal > 0
    End Function

    Public Function FileSize(File As String) As String
        Dim LSize As String
        If File = "" Then
            FileSize = ""
            Exit Function
        End If
        LSize = FileLen(File)
        FileSize = LSize 'Size in bytes
    End Function

    Public Function GreatCircleDistance(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double) As Double
        ' approx radius of Earth in meters.  True radius varies from
        ' 6357km (polar) to 6378km (equatorial).
        Dim dlon As Double
        Dim dlat As Double
        Dim d As Double
        Dim a As Double

        dlon = lon2 - lon1
        dlat = lat2 - lat1
        a = (Math.Sin(dlat / 2)) ^ 2 + Math.Cos(lat1) * Math.Cos(lat2) * (Math.Sin(dlon / 2)) ^ 2
        d = 2 * Math.Atan(Math.Sqrt(a) / Math.Sqrt(1 - a))

        ' This is a simpler formula, but it's subject to rounding errors
        ' for small distances.  See http://www.census.gov/cgi-bin/geo/gisfaq?Q5.1
        ' d = acos(sin(Lat1) * sin(Lat2) + cos(Lat1) * cos(Lat2) * cos(Lon1-Lon2))

        GreatCircleDistance = earth_radius * d ' earth_radius defined above as earth_radius = 6367000 meters

    End Function

    ' compute the initial bearing (in degrees) to get from lat1/long1 to lat2/long2
    Public Function InitialHeading(ByVal lat1 As Double, ByVal lon1 As Double, ByVal lat2 As Double, ByVal lon2 As Double) As Double
        ' note that this is the same d calculation as above.
        ' duplicated for clarity.
        Dim dlon As Double
        Dim dlat As Double
        Dim d As Double
        Dim a As Double
        Dim Heading As Double

        dlon = lon2 - lon1
        dlat = lat2 - lat1
        a = (Math.Sin(dlat / 2)) ^ 2 + Math.Cos(lat1) * Math.Cos(lat2) * (Math.Sin(dlon / 2)) ^ 2
        d = 2 * Math.Atan(Math.Sqrt(a) / Math.Sqrt(1 - a))

        Heading = Arcos((Math.Sin(lat2) - Math.Sin(lat1) * Math.Cos(d)) / (Math.Sin(d) * Math.Cos(lat1)))
        If (Math.Sin(lon2 - lon1) < 0) Then
            Heading = 2 * PI - Heading ' PI defined above as PI = 4 * Atn(1 / 1)
        End If

        InitialHeading = RadiansToDegrees(Heading)

    End Function

    ' compute cross track distance in geodetic coordinates
    Public Function CrossTrack(latA, lonA, latB, lonB, latC, lonC) As Double
        Dim dAC As Double
        Dim brngAB As Double
        Dim brngAC As Double
        Dim dXT As Double

        dAC = GreatCircleDistance(latA, lonA, latC, lonC)
        brngAB = InitialHeading(latA, lonA, latB, lonB)
        brngAC = InitialHeading(latA, lonA, latC, lonC)
        dXT = Arcsin(Math.Sin(dAC / earth_radius) * Math.Sin(brngAC - brngAB)) * earth_radius
        CrossTrack = dXT 'distance returned in meters

    End Function

    ' compute new coordinates from start point distance and bearing
    Public Sub GreatCircleTraverse(latA As Double, lonA As Double, distB As Double, brngB As Double, latB As Double, lonB As Double)
        Dim a As Double
        Dim b As Double

        'Convert to radians
        a = DegreesToRadians(latA)
        b = DegreesToRadians(lonA)
        brngB = DegreesToRadians(brngB)
        distB = distB / earth_radius ' meters

        latB = RadiansToDegrees(Arcsin(Math.Sin(a) * Math.Cos(distB) + Math.Cos(a) * Math.Sin(distB) * Math.Cos(brngB)))
        lonB = RadiansToDegrees(b + atan2(Math.Sin(brngB) * Math.Sin(distB) * Math.Cos(a), Math.Cos(distB) - Math.Sin(a) * Math.Sin(latB)))

        If lonB < -180 Then
            lonB = lonB + 360
        ElseIf lonB > 180 Then
            lonB = lonB - 360
        End If

    End Sub

    Public Function Arcos(ByVal x As Double) As Double
        Arcos = Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1)
    End Function

    Function Arcsin(x As Double) As Double
        Arcsin = Math.Atan(x / Math.Sqrt(-x * x + 1))
    End Function

    Public Function atan2(y As Double, x As Double) As Double

        If x > 0 Then
            atan2 = Math.Atan(y / x)
        ElseIf x < 0 Then
            atan2 = Math.Sign(y) * (PI - Math.Atan(Math.Abs(y / x)))
        ElseIf y = 0 Then
            atan2 = 0
        Else
            atan2 = Math.Sign(y) * PI / 2
        End If

    End Function

    Public Function BoxCarFilter(ByRef ValueArray() As Double)
        Dim Min As Integer
        Dim Max As Integer
        Dim Sum As Double
        Min = LBound(ValueArray)
        Max = UBound(ValueArray)
        For count = Min To Max
            Sum = Sum + ValueArray(count)
        Next
        BoxCarFilter = Sum / (Max - Min)
    End Function

    Public Function UnixToTime(ByVal strUnixTime As String) As Date
        UnixToTime = DateAdd(DateInterval.Second, Val(strUnixTime), #1/1/1970#)
        If UnixToTime.IsDaylightSavingTime = True Then
            UnixToTime = DateAdd(DateInterval.Hour, 1, UnixToTime)
        End If
    End Function

    Public Function TimeToUnix(ByVal dteDate As Date) As String
        If dteDate.IsDaylightSavingTime = True Then
            dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
        End If
        TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate)
    End Function

    Public Function parseNmea(ByVal InString As String) As Boolean
        Dim Max As Integer
        Dim temp As Integer
        Dim I As Integer
        Dim NmeaID As String
        Dim TempTime As Long
        Dim TempDiff As Double
        Dim SatCount As Integer
        Dim MessageCount As Integer
        Dim BeginMessage As Integer
        Dim EndMessage As Integer
        Dim TempArray(1) As String
        Dim BitErrArray(1)
        Static GsvSats As Integer
        Dim errmsg As String
        'On Error GoTo ErrorHandler

        If InStr(1, InString, "$", vbTextCompare) <= 0 Then ' probably an invalid BAUD rate selected
            parseNmea = False
            Exit Function
        End If

        InString = Mid$(InString, InStr(1, InString, "$", vbTextCompare)) ' Strip-off any data before the dollar character

        If Check_Sum(InString) Then ' device EITHER with OR without CheckSum validation
            Call sm_parse(InString, "*", TempArray) ' parse out checksum if present (ie; strip off * etc...)
            Call sm_parse(TempArray(1), ",", NmeaArray)
            Max = UBound(NmeaArray)
            NmeaID = Right$(NmeaArray(1), Len(NmeaArray(1)) - 3) ' skip over $xx characters
            parseNmea = False
            Select Case NmeaID
                Case "GGA"
                    If Max = 15 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.gga.Utc = NmeaArray(2)
                        End If
                        If IsNumeric(NmeaArray(3)) Then
                            NmeaInfo.gga.lat = NmeaArray(3)
                        End If
                        NmeaInfo.gga.LatHemi = NmeaArray(4)
                        If IsNumeric(NmeaArray(5)) Then
                            NmeaInfo.gga.lon = NmeaArray(5)
                        End If
                        NmeaInfo.gga.LonHemi = NmeaArray(6)
                        If IsNumeric(NmeaArray(7)) Then
                            NmeaInfo.gga.Quality = NmeaArray(7)
                        End If
                        If IsNumeric(NmeaArray(8)) Then
                            NmeaInfo.gga.SatsUsed = NmeaArray(8)
                        End If
                        If IsNumeric(NmeaArray(9)) Then
                            NmeaInfo.gga.hdop = NmeaArray(9)
                        End If
                        If IsNumeric(NmeaArray(10)) Then
                            NmeaInfo.gga.Altitude = NmeaArray(10)
                        End If
                        NmeaInfo.gga.AltUnit = NmeaArray(11)
                        If IsNumeric(NmeaArray(12)) Then
                            NmeaInfo.gga.GeoSep = NmeaArray(12)
                        End If
                        NmeaInfo.gga.GeoSepUnit = NmeaArray(13)
                        If IsNumeric(NmeaArray(14)) Then
                            NmeaInfo.gga.diffage = NmeaArray(14)
                        Else
                            NmeaInfo.gga.diffage = -1
                        End If
                        If IsNumeric(NmeaArray(15)) Then
                            NmeaInfo.gga.StationID = NmeaArray(15)
                        Else
                            NmeaInfo.gga.StationID = -1
                        End If
                        NmeaInfo.gga.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding GGA " + InString + " Expected 15 but got " + Str(Max))
                    End If
                    Exit Function
                Case "GLL"
                    If Max = 7 Or Max = 8 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.gll.lat = NmeaArray(2)
                        End If
                        NmeaInfo.gll.LatHemi = NmeaArray(3)
                        If IsNumeric(NmeaArray(4)) Then
                            NmeaInfo.gll.lon = NmeaArray(4)
                        End If
                        NmeaInfo.gll.LonHemi = NmeaArray(5)
                        If IsNumeric(NmeaArray(6)) Then
                            NmeaInfo.gll.Utc = NmeaArray(6)
                        End If
                        NmeaInfo.gll.Status = NmeaArray(7)
                        ' for NMEA-0183 version 3.0
                        If Max = 8 Then
                            NmeaInfo.gll.Mode = NmeaArray(8)
                        End If
                        NmeaInfo.gll.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding GLL " + InString + " Expected 7 or 8 but got " + Str(Max))
                    End If
                    Exit Function
                Case "GSA"
                    If Max = 18 Then
                        NmeaInfo.gsa.Mode = NmeaArray(2)
                        NmeaInfo.gsa.ModeStat = NmeaArray(3)
                        For SatCount = 4 To Max - 3
                            NmeaInfo.gsa.SatID(SatCount - 3) = NmeaArray(SatCount)
                        Next SatCount
                        If IsNumeric(NmeaArray(16)) Then
                            NmeaInfo.gsa.pdop = NmeaArray(16)
                        End If
                        If IsNumeric(NmeaArray(17)) Then
                            NmeaInfo.gsa.hdop = NmeaArray(17)
                        End If
                        If IsNumeric(NmeaArray(18)) Then
                            NmeaInfo.gsa.vdop = NmeaArray(18)
                        End If
                        NmeaInfo.gsa.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding GSA " + InString + " Expected 18 but got " + Str(Max))
                    End If
                    Exit Function
                Case "GST"
                    If Max = 9 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.gst.Utc = NmeaArray(2)
                        Else
                            Exit Function
                        End If
                        If IsNumeric(NmeaArray(3)) Then
                            NmeaInfo.gst.Rms = NmeaArray(3)
                        Else
                            Exit Function
                        End If
                        If IsNumeric(NmeaArray(4)) Then
                            NmeaInfo.gst.SDSemiMajor = NmeaArray(4)
                        End If
                        If IsNumeric(NmeaArray(5)) Then
                            NmeaInfo.gst.SDSemiMinor = NmeaArray(5)
                        End If
                        If IsNumeric(NmeaArray(6)) Then
                            NmeaInfo.gst.OrientSemiMajor = NmeaArray(6)
                        End If
                        If IsNumeric(NmeaArray(7)) Then
                            NmeaInfo.gst.SDLat = NmeaArray(7)
                        End If
                        If IsNumeric(NmeaArray(8)) Then
                            NmeaInfo.gst.SDLon = NmeaArray(8)
                        End If
                        If IsNumeric(NmeaArray(9)) Then
                            NmeaInfo.gst.SDAlt = NmeaArray(9)
                        End If
                        NmeaInfo.gst.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding GST " + InString + " Expected 9 but got " + Str(Max))
                    End If
                    Exit Function
                Case "GSV"
                    If IsNumeric(NmeaArray(2)) Then
                        NmeaInfo.gsv.MessageMax = NmeaArray(2)
                    End If
                    If IsNumeric(NmeaArray(3)) Then
                        NmeaInfo.gsv.MessageNum = NmeaArray(3)
                    End If
                    If IsNumeric(NmeaArray(4)) Then
                        NmeaInfo.gsv.SatsInView = NmeaArray(4)
                    End If
                    If NmeaInfo.gsv.MessageNum = 1 Then
                        GsvSats = 0
                    End If
                    SatCount = 0
                    For MessageCount = 1 To (Max - 5) / 4
                        If IsNumeric(NmeaArray((MessageCount * 4) + 1)) Then
                            NmeaInfo.gsv.SatID(GsvSats) = NmeaArray((MessageCount * 4) + 1)
                        End If
                        If IsNumeric(NmeaArray(1 + ((MessageCount * 4) + 1))) Then
                            NmeaInfo.gsv.SatElev(GsvSats) = NmeaArray(1 + ((MessageCount * 4) + 1))
                        End If
                        If IsNumeric(NmeaArray(2 + ((MessageCount * 4) + 1))) Then
                            NmeaInfo.gsv.SatAzimuth(GsvSats) = NmeaArray(2 + ((MessageCount * 4) + 1))
                        End If
                        If IsNumeric(NmeaArray(3 + ((MessageCount * 4) + 1))) Then
                            NmeaInfo.gsv.SatSNR(GsvSats) = NmeaArray(3 + ((MessageCount * 4) + 1))
                        End If
                        GsvSats = GsvSats + 1
                    Next MessageCount
                    If NmeaInfo.gsv.MessageMax = NmeaInfo.gsv.MessageNum Then
                        NmeaInfo.gsv.LastUpdate = GetTickCount
                    End If
                    parseNmea = True
                    Exit Function
                Case "CTR"  ' these are the C-Nav2000 messages following the $PN prefix
                    If NmeaArray(2) Like "SATS" Then
                        If IsNumeric(NmeaArray(3)) Then
                            NmeaInfo.sats.MessageMax = NmeaArray(3)
                        End If
                        If IsNumeric(NmeaArray(4)) Then
                            NmeaInfo.sats.MessageNum = NmeaArray(4)
                        End If
                        If NmeaInfo.sats.MessageNum = 1 Then
                            NmeaInfo.sats.SatsInView = 0
                        End If
                        For MessageCount = 1 To (Max - 5) / 5
                            If IsNumeric(NmeaArray(MessageCount * 5)) Then
                                NmeaInfo.sats.SatID(NmeaInfo.sats.SatsInView) = NmeaArray(MessageCount * 5)
                            End If
                            If IsNumeric(NmeaArray(1 + (MessageCount * 5))) Then
                                NmeaInfo.sats.SatElev(NmeaInfo.sats.SatsInView) = NmeaArray(1 + (MessageCount * 5))
                            End If
                            If IsNumeric(NmeaArray(2 + (MessageCount * 5))) Then
                                NmeaInfo.sats.SatAzimuth(NmeaInfo.sats.SatsInView) = NmeaArray(2 + (MessageCount * 5))
                            End If
                            If IsNumeric(NmeaArray(3 + (MessageCount * 5))) Then
                                NmeaInfo.sats.SatL1SNR(NmeaInfo.sats.SatsInView) = NmeaArray(3 + (MessageCount * 5))
                            End If
                            If IsNumeric(NmeaArray(4 + (MessageCount * 5))) Then
                                NmeaInfo.sats.SatL2SNR(NmeaInfo.sats.SatsInView) = NmeaArray(4 + (MessageCount * 5))
                            End If
                            NmeaInfo.sats.SatsInView = NmeaInfo.sats.SatsInView + 1
                        Next MessageCount
                        If NmeaInfo.sats.MessageMax = NmeaInfo.sats.MessageNum Then
                            NmeaInfo.sats.LastUpdate = GetTickCount
                        End If
                        parseNmea = True
                        Exit Function
                    End If
                    If NmeaArray(2) Like "RXQ" Then
                        '$PNCTR,RXQ,123519,Y,9.6,54,0* 78
                        If Max > 3 Then
                            If IsNumeric(NmeaArray(3)) Then
                                NmeaInfo.rxq.Utc = NmeaArray(3)
                            End If
                            NmeaInfo.rxq.SFLock = NmeaArray(4)
                            If NmeaInfo.rxq.SFLock = "Y" Then
                                NmeaInfo.rxq.SFSNR = NmeaArray(5)
                                NmeaInfo.rxq.PerIdlePacket = NmeaArray(6)
                                NmeaInfo.rxq.PerBadPacket = NmeaArray(7)
                            End If
                            NmeaInfo.rxq.LastUpdate = GetTickCount
                            parseNmea = True
                        Else
                            Debug.Print("ERROR Decoding RXQ " + InString + " Expected 4 or 7 but got " + Str(Max))
                        End If
                        Exit Function
                    End If
                    If NmeaArray(2) Like "NAVQ" Then
                        ' either - $PNCTR,NAVQ,123519,3D,RTG,DUAL*55
                        '     or - $PNCTR,NAVQ,202759,NN*74
                        If Max > 3 Then
                            If IsNumeric(NmeaArray(3)) Then
                                NmeaInfo.navq.Utc = NmeaArray(3)
                            End If
                            If IsNumeric(NmeaArray(4)) Then
                                NmeaInfo.navq.NavMode = NmeaArray(4)
                            End If
                            If NmeaArray(4) = "NN" Then
                                NmeaInfo.navq.NavMode = "None"
                            Else
                                NmeaInfo.navq.CorrType = NmeaArray(5)
                                NmeaInfo.navq.SignalType = NmeaArray(6)
                            End If
                            NmeaInfo.navq.LastUpdate = GetTickCount
                            parseNmea = True
                        Else
                            Debug.Print("ERROR Decoding NAVQ " + InString + " Expected 4 or 6 but got " + Str(Max))
                        End If
                        Exit Function
                    End If
                Case "VTG"
                    If Max = 9 Or Max = 10 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.vtg.cogt = NmeaArray(2)
                        Else
                            Exit Function
                        End If
                        NmeaInfo.vtg.CogTID = NmeaArray(3)
                        If IsNumeric(NmeaArray(4)) Then
                            NmeaInfo.vtg.CogM = NmeaArray(4)
                        End If
                        NmeaInfo.vtg.CogMID = NmeaArray(5)
                        If IsNumeric(NmeaArray(6)) Then
                            NmeaInfo.vtg.SpeedKt = NmeaArray(6)
                        End If
                        NmeaInfo.vtg.SpeedKtID = NmeaArray(7)
                        If IsNumeric(NmeaArray(8)) Then
                            NmeaInfo.vtg.SpeedKmh = NmeaArray(8)
                        End If
                        NmeaInfo.vtg.SpeedKmhID = NmeaArray(9)
                        NmeaInfo.vtg.LastUpdate = GetTickCount
                        parseNmea = True
                        ' for NMEA-0183 version 3.0
                        If Max = 10 Then
                            NmeaInfo.vtg.Mode = NmeaArray(10)
                        End If
                        NmeaInfo.vtg.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding VTG " + InString + " Expected 9 or 10 but got " + Str(Max))
                    End If
                    Exit Function
                Case "ZDA"
                    If Max = 7 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.zda.Utc = NmeaArray(2)
                        End If
                        If IsNumeric(NmeaArray(3)) Then
                            NmeaInfo.zda.Day = NmeaArray(3)
                        End If
                        If IsNumeric(NmeaArray(4)) Then
                            NmeaInfo.zda.Month = NmeaArray(4)
                        End If
                        If IsNumeric(NmeaArray(5)) Then
                            NmeaInfo.zda.Year = NmeaArray(5)
                        End If
                        If IsNumeric(NmeaArray(6)) Then
                            NmeaInfo.zda.LocalTZhr = NmeaArray(6)
                        End If
                        If IsNumeric(NmeaArray(7)) Then
                            NmeaInfo.zda.LocalTZmn = NmeaArray(7)
                        End If
                        NmeaInfo.zda.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding ZDA " + InString + " Expected 7 but got " + Str(Max))
                    End If
                    Exit Function
                Case "HDT"
                    If Max = 3 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.hdt.HeadingT = NmeaArray(2)
                        End If
                        NmeaInfo.hdt.HeadingTID = NmeaArray(3)
                        NmeaInfo.hdt.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding " + " HDT " + InString + " Expected 3 but got " + Str(Max))
                    End If
                    Exit Function
'    Case "HDM"
'        If Max = 3 Then
'            If IsNumeric(NmeaArray(2)) Then
'                NmeaInfo.hdm.HeadingM = NmeaArray(2)
'            End If
'            NmeaInfo.hdm.HeadingMID = NmeaArray(3)
'            NmeaInfo.hdm.LastUpdate = GetTickCount
'            parseNmea = True
'        Else
'            Debug.Print "ERROR Decoding Gyro HDM " + InString + " Expected 3 but got " + Str(Max)
'        End If
'        Exit Function
                Case "PR"
                    If Max = 5 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.ohpr.Heading = NmeaArray(2)
                        End If
                        If IsNumeric(NmeaArray(3)) Then
                            NmeaInfo.ohpr.Pitch = NmeaArray(3)
                        End If
                        If IsNumeric(NmeaArray(4)) Then
                            NmeaInfo.ohpr.Roll = NmeaArray(4)
                        End If
                        If IsNumeric(NmeaArray(5)) Then
                            NmeaInfo.ohpr.Depth = NmeaArray(5)
                        End If
                        NmeaInfo.ohpr.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding OHPR " + InString + " Expected 7 but got " + Str(Max))
                    End If
                    Exit Function
                Case Else
                    parseNmea = False
            End Select
        Else
            Call sm_parse(InString, ",", NmeaArray)
            Max = UBound(NmeaArray)
            NmeaID = Right$(NmeaArray(1), 3)
            Select Case NmeaID
                Case "HDT"
                    If Max = 3 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.hdt.HeadingT = NmeaArray(2)
                        End If
                        NmeaInfo.hdt.HeadingTID = NmeaArray(3)
                        NmeaInfo.hdt.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding HDT " + InString + " Expected 3 but got " + Str(Max))
                    End If
                    Exit Function
                Case "HDM"
                    If Max = 3 Then
                        If IsNumeric(NmeaArray(2)) Then
                            NmeaInfo.hdm.HeadingM = NmeaArray(2)
                        End If
                        NmeaInfo.hdm.HeadingMID = NmeaArray(3)
                        NmeaInfo.hdm.LastUpdate = GetTickCount
                        parseNmea = True
                    Else
                        Debug.Print("ERROR Decoding HDM " + InString + " Expected 3 but got " + Str(Max))
                    End If
                    Exit Function
                Case "RD1"
                    If Max >= 6 Then
                        If IsNumeric(NmeaArray(6)) Then
                            NmeaInfo.rd1.BitErrorRate1 = NmeaArray(6)
                            NmeaInfo.rd1.BitErrorRate2 = -1
                        Else
                            Call sm_parse(NmeaArray(6), "-", BitErrArray)
                            If IsNumeric(BitErrArray(1)) Then
                                NmeaInfo.rd1.BitErrorRate1 = BitErrArray(1)
                            End If
                            If IsNumeric(BitErrArray(2)) Then
                                NmeaInfo.rd1.BitErrorRate2 = BitErrArray(2)
                            End If
                        End If
                        NmeaInfo.rd1.LastUpdate = GetTickCount
                        parseNmea = True
                    End If
                    Exit Function
                Case Else
                    Debug.Print("Decoding Failed " + InString + " - detected fields = " + Str(Max))
            End Select
        End If
        Exit Function

ErrorHandler:
        If Err.Number <> 5 Then ' ignore Invalid procedure call or argument errors
            Debug.Print("Error decoding : " + InString)
            'ErrorTrap Err.Number, "System(parseNmea)"
        End If
        Resume Next
    End Function

    Public Function CheckPath(strPath As String) As Boolean
        If Dir$(strPath) <> "" Then
            CheckPath = True
        Else
            CheckPath = False
        End If
    End Function

    'Public Function FreeDiskSpace(ByVal sDriveLetter As String) As Double
    'Dim udtFreeBytesAvail As LargeInt, udtTtlBytes As LargeInt
    'Dim udtTTlFree As LargeInt
    'Dim dblFreeSpace As Double

    'If GetDiskFreeSpaceEx(sDriveLetter, udtFreeBytesAvail, udtTtlBytes, udtTTlFree) Then
    '    If udtFreeBytesAvail.lngLower < 0 Then
    '        dblFreeSpace = udtFreeBytesAvail.lngUpper * 2 ^ 32 + udtFreeBytesAvail.lngLower + 4294967296#
    '    Else
    '        dblFreeSpace = udtFreeBytesAvail.lngUpper * 2 ^ 32 + udtFreeBytesAvail.lngLower
    '    End If
    'End If
    'FreeDiskSpace = dblFreeSpace
    'End Function

    Public Function IsADirectory(ByVal TheName As String) As Boolean
        If GetAttr(TheName) And vbDirectory Then
            IsADirectory = True
        Else
            IsADirectory = False
        End If
    End Function

    Public Function GetDirectories(myPath As String, dirArray() As String) As Boolean
        Dim myName As String
        Dim count As Integer
        ' Display the names in C:\ that represent directories.
        myName = Dir(myPath, vbDirectory)   ' Retrieve the first entry.
        Do While myName <> ""   ' Start the loop.
            ' Ignore the current directory and the encompassing directory.
            If myName <> "." And myName <> ".." Then
                ' Use bitwise comparison to make sure MyName is a directory.
                If (GetAttr(myPath & myName) And vbDirectory) = vbDirectory Then
                    count = count + 1
                    ReDim Preserve dirArray(count)
                    dirArray(count - 1) = myName
                End If
            End If
            myName = Dir()   ' Get next entry.
        Loop
        GetDirectories = True
    End Function

    '    Public Type STAT_ANALYSIS
    '       N As Long
    '       Sum As Double
    '       Mean As Double
    '       Min As Double
    '       Max As Double
    '       Range As Double
    '       SumSquared As Double
    '       SumOfXiSquared As Double
    '       Variance As Double
    '       StandardDeviation As Double
    '       SourceData As Variant
    '       Population As Boolean
    '    End Type

    '    Public Function Analyze(varData As Variant, Optional ByVal blnPopulation As Boolean = True) As STAT_ANALYSIS
    '       Dim blnFirstPass As Boolean 'flag to tell if it's the first pass
    '       Dim i As Long
    '       'passing anything other than an array is useless, so terminate if varData doesn't have an array
    '       If Not CBool(VarType(varData) And vbArray) Then Exit Function
    '       With Analyze
    '          'total number of items
    '          .N = UBound(varData) - LBound(varData) + 1
    '          'statistical analysis needs at the very very least 2 items
    '          If .N < 2 Then Exit Function
    '          .Sum = 0
    '          .SumOfXiSquared = 0
    '          blnFirstPass = True
    '          'go through each item in the data set
    '          For i = LBound(varData) To UBound(varData)
    '             'get the running sum of the items
    '             .Sum = .Sum + varData(i)
    '             'get the running sum of the square of each item
    '             .SumOfXiSquared = .SumOfXiSquared + (varData(i) ^ 2)
    '             'if this isn't the first pass, give the max and min a value to start off
    '             If blnFirstPass Then
    '                .Min = varData(i)
    '                .Max = varData(i)
    '                blnFirstPass = False
    '             Else
    '                'these two statements will eventually find the max and min of the data set
    '                If varData(i) > .Max Then .Max = varData(i)
    '                If varData(i) < .Min Then .Min = varData(i)
    '             End If
    '          Next i
    '          'get the range of the data
    '          .Range = .Max - .Min
    '          'get the mean (average) of the data
    '          .Mean = .Sum / .N
    '          'get the sum of all items squared
    '          .SumSquared = .Sum ^ 2
    '          'get the variance, based on whether the data set is a population or a sample
    '          .Variance = (.SumOfXiSquared - (.SumSquared / .N)) / IIf(blnPopulation, .N, .N - 1)
    '          'get the standard deviation
    '          .StandardDeviation = Sqr(.Variance)
    '          'stick the source data into the struct in case you need it later
    '          .SourceData = varData
    '          'tell whether or not the source data was treated as a population
    '          .Population = blnPopulation
    '       End With
    '    End Function

    Sub QuickSort(ByRef arr() As Double, Optional numEls As Integer = vbNull, Optional descending As Boolean = False)

        Dim Value, temp
        Dim sp As Integer
        Dim leftStk(32) As Long, rightStk(32) As Long
        Dim leftNdx As Long, rightNdx As Long
        Dim I As Long, j As Long

        ' account for optional arguments
        If IsNothing(numEls) Then numEls = UBound(arr)
        ' init pointers
        leftNdx = LBound(arr)
        rightNdx = numEls
        ' init stack
        sp = 1
        leftStk(sp) = leftNdx
        rightStk(sp) = rightNdx

        Do
            If rightNdx > leftNdx Then
                Value = arr(rightNdx)
                I = leftNdx - 1
                j = rightNdx
                ' find the pivot item
                If descending Then
                    Do
                        Do : I = I + 1 : Loop Until arr(I) <= Value
                        Do : j = j - 1 : Loop Until j = leftNdx Or arr(j) >= Value
                        temp = arr(I)
                        arr(I) = arr(j)
                        arr(j) = temp
                    Loop Until j <= I
                Else
                    Do
                        Do : I = I + 1 : Loop Until arr(I) >= Value
                        Do : j = j - 1 : Loop Until j = leftNdx Or arr(j) <= Value
                        temp = arr(I)
                        arr(I) = arr(j)
                        arr(j) = temp
                    Loop Until j <= I
                End If
                ' swap found items
                temp = arr(j)
                arr(j) = arr(I)
                arr(I) = arr(rightNdx)
                arr(rightNdx) = temp
                ' push on the stack the pair of pointers that differ most
                sp = sp + 1
                If (I - leftNdx) > (rightNdx - I) Then
                    leftStk(sp) = leftNdx
                    rightStk(sp) = I - 1
                    leftNdx = I + 1
                Else
                    leftStk(sp) = I + 1
                    rightStk(sp) = rightNdx
                    rightNdx = I - 1
                End If
            Else
                ' pop a new pair of pointers off the stacks
                leftNdx = leftStk(sp)
                rightNdx = rightStk(sp)
                sp = sp - 1
                If sp = 0 Then Exit Do
            End If
        Loop
    End Sub

    Public Function geotoxyz(ByRef x As Double, ByRef y As Double, ByRef Z As Double, ByVal lon As Double, ByVal lat As Double, ByVal a As Double, ByVal invf As Double) As Boolean
        ' WGS84 : a = 6378137.00, invf = 298.257223563
        ' NAD27 : a = 6378206.40, invf = 294.978698200

        Dim height As Integer
        Dim n As Double
        Dim temp As Double
        Dim esqr As Double
        height = 0
        esqr = (2 * (1 / invf)) - ((1 / invf) ^ 2)
        '    esqr = (1 / invf) * (1 / invf)
        temp = Math.Sin(lat)
        n = a / Math.Sqrt(1 - esqr * temp * temp)
        temp = (n + height) * Math.Cos(lat)
        x = temp * Math.Cos(lon)
        y = temp * Math.Sin(lon)
        Z = (n * (1 - esqr) + height) * Math.Sin(lat)

        geotoxyz = True
    End Function

    Public Function xyztogeo(ByRef lon As Double, ByRef lat As Double, ByVal x As Double, ByVal y As Double, ByVal Z As Double, ByVal a As Double, ByVal invf As Double) As Boolean
        ' WGS84 : a = 6378137.00, invf = 298.257223563
        ' NAD27 : a = 6378206.40, invf = 294.978698200

        Dim P As Double
        Dim n As Double
        Dim h As Double
        Dim temp As Double
        Dim esqr As Double

        esqr = (2 * (1 / invf)) - ((1 / invf) ^ 2)
        lon = Math.Atan(y / x)
        P = Math.Sqrt(x * x + y * y)
        lat = Math.Atan(Z / (P * (1 - esqr)))
        temp = Math.Sin(lat)
        n = a / Math.Sqrt(1 - esqr * temp * temp)
        h = P / Math.Cos(lat) - n
        lat = Math.Atan(Z / (P * (1 - esqr * n / (n + h))))

        xyztogeo = True
    End Function


End Class
