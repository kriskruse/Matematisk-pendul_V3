Module Ver2Vin
    'Variable til transformation mellem verdens- og vindueskoordinater
    Dim SkalerX As Single = 1
    Dim SkalerY As Single = 1
    Dim FlytX As Single = 0
    Dim FlytY As Single = 0

    'Omregner verdenskoordinater til vindueskoordinater
    Public Function XVerdenToVin(ByVal Xve As Single) As Single
        Dim Xvi As Single
        Xvi = Xve * SkalerX + FlytX
        Return Xvi
    End Function

    Public Function YVerdenToVin(ByVal Yve As Single) As Single
        Dim Yvi As Single
        Yvi = Yve * SkalerY + FlytY
        Return Yvi
    End Function

    'Omregner vindueskoordinater til verdenskoordinater
    Public Function XvinToVerden(ByVal Xvi As Single) As Single
        Dim Xve As Single
        Xve = (Xvi - FlytX) / SkalerX
        Return Xve
    End Function

    Public Function YvinToVerden(ByVal Yvi As Single) As Single
        Dim Yve As Single
        Yve = (Yvi - FlytY) / SkalerY
        Return Yve
    End Function

    'Omregner verdensstørrelser til vinduesstørrelser
    Public Function BreddeVerdenToVin(ByVal Bve As Single) As Single
        Dim Bvi As Single
        Bvi = Math.Abs(Bve * SkalerX)
        Return Bvi
    End Function

    Public Function HoejdeVerdenToVin(ByVal Hve As Single) As Single
        Dim Hvi As Single
        Hvi = Math.Abs(Hve * SkalerY)
        Return Hvi
    End Function

    'Omregner vinduesstørrelser til verdensstørrelser
    Public Function BreddeVinToVerden(ByVal Bvi As Single) As Single
        Dim Bve As Single
        Bve = Math.Abs(Bvi / SkalerX)
        Return Bve
    End Function

    Public Function HoejdeVinToVerden(ByVal Hvi As Single) As Single
        Dim Hve As Single
        Hve = Math.Abs(Hvi / SkalerY)
        Return Hve
    End Function

    'Beregner variablerne til omregning af koordinater mellem verden og vindue
    Public Sub SaetTransformationsVariabler(ByVal EnsSkalering As Boolean,
                                            ByVal XveV As Single, ByVal XveH As Single,
                                            ByVal YveB As Single, ByVal YveT As Single,
                                            ByVal XviV As Single, ByVal XviH As Single,
                                            ByVal YviB As Single, ByVal YviT As Single)
        'Værdier for skalering verden til vindue
        SkalerX = (XviH - XviV) / (XveH - XveV)
        SkalerY = (YviT - YviB) / (YveT - YveB)
        If EnsSkalering Then 'Sæt skaleringerne ens, hvis EnsSkalering=True
            If Math.Abs(SkalerX) < Math.Abs(SkalerY) Then
                SkalerY = -SkalerX 'Med forskellig fortegn, idet SkalerY
            Else
                SkalerX = -SkalerY 'Med forskellig fortegn, idet SkalerY
            End If
        End If
        'Værdier for flyt verden til vindue
        FlytX = XviV - XveV * SkalerX
        FlytY = YviB - YveB * SkalerY
    End Sub

End Module

