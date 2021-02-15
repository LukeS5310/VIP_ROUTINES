Imports System.Data.SQLite
Public Class MAIN
    Dim HasLodaded As Boolean
    Dim ADV_PATH As String = ""
    Dim MAN_PATH As String = ""
    Dim IsDone As Boolean
    Dim IsBusy As Boolean
    Dim State As Byte = 0
    Dim IsDebug As Boolean = True
    Dim x As Process = Process.GetCurrentProcess()
    Private Sub BTN_BROWSE_OUTPUT_Click(sender As Object, e As EventArgs) Handles BTN_BROWSE_OUTPUT.Click
        FBD.ShowDialog()
        LBL_MAN_ADV8_OUTPUT_PATH.Text = FBD.SelectedPath
        My.Settings.OutPath = FBD.SelectedPath
    End Sub

    Private Sub BTN_BROWSE_MAN_ADV_FOLDER_Click(sender As Object, e As EventArgs) Handles BTN_BROWSE_MAN_ADV_FOLDER.Click
        FBD.ShowDialog()
        LBL_MAN_ADV8_PATH.Text = FBD.SelectedPath
        My.Settings.InPath = FBD.SelectedPath
    End Sub

    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_MAN_ADV8_OUTPUT_PATH.Text = My.Settings.OutPath
        LBL_MAN_ADV8_PATH.Text = My.Settings.InPath
        DBOperations.DB_Init()
        HasLodaded = True
        Try
            DTP_ADV.Value = My.Settings.RunTime
        Catch ex As Exception
            DTP_ADV.Value = "14.06.1994 17:00"

        End Try
        If IsDebug = False Then BTN_DBG.Hide()
        Check_Loop.Start()
        ''MsgBox(My.Settings.RunTime)
        Dim stmp() = My.Settings.Weekdays.Split(",")
        For Each i In stmp
            If i = "" Then Continue For
            CBLIST_WEEKDAYS.SetItemChecked(i, True)
        Next


    End Sub

    Private Sub DTP_ADV_ValueChanged(sender As Object, e As EventArgs) Handles DTP_ADV.ValueChanged
        If HasLodaded = False Then Exit Sub '' prevent autoset bug

        My.Settings.RunTime = DTP_ADV.Value

        'MsgBox(DateAdd(DateInterval.Minute, 10, DTP_ADV.Value))


    End Sub

    Private Sub DoCompare_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DoCompare.DoWork

        Dim Importer As ICSVPFR = New CSVADVFile
        Importer.ImportCSVToDB(ADV_PATH)


        DoCompare.ReportProgress(50)
        Importer = New CSVMANFile
        Importer.ImportCSVToDB(MAN_PATH)
        DoCompare.ReportProgress(100)


    End Sub
    Private Sub DoCompare_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles DoCompare.ProgressChanged
        TS_PB.ProgressBar.Value = e.ProgressPercentage
    End Sub
    Private Function resolve_sourse(sourse As Byte)
        If sourse = 1 Then
            Return "АДВ-8"

        ElseIf sourse = 2 Then
            Return "ПТК НВП"

        End If

        Return "Другое"
    End Function
    Public Function validatenull(instring As String)
        If instring = "" Then
            Return DBNull.Value

        End If
        Return instring
    End Function

    Public Function BPLACE_FORM(instring() As String)
        Dim formed As String = ""
        For i = 13 To 16
            If instring.Length > i Then
                formed &= instring(i) & " "

            End If
        Next
        Return formed
    End Function

    Private Sub DoCompare_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DoCompare.RunWorkerCompleted
        TS_PROGRESSINFO.Text = "Индексация Завершена. Производится выборка..."
        FormFile.RunWorkerAsync()
    End Sub




    Private Sub BTN_DBG_Click(sender As Object, e As EventArgs) Handles BTN_DBG.Click

        WorkOn()
    End Sub

    Private Sub Main_Loop_Tick(sender As Object, e As EventArgs) Handles Check_Loop.Tick
        If IsBusy = True Then Exit Sub '' WORKING GO AWAY
        If IsDone = True And TimeOfDay.Minute > DTP_ADV.Value.Minute + 12 Then
            IsDone = False
        End If
        SaveWeekdays() ''prevent no update bug
        If DTP_ADV.Value.Hour = TimeOfDay.Hour And DTP_ADV.Value.Minute <= TimeOfDay.Minute And DTP_ADV.Value.Minute + 10 >= TimeOfDay.Minute And IsDone = False And VerifyDayOfWeek() = True Then

            IsBusy = True

            WorkOn()
        End If

    End Sub
    Private Sub WorkOn()
        State += 1

        Select Case State
            Case 1  ' ЭТО МОСКВА
                ADV_PATH = My.Settings.InPath & "\adv8_m.csv"
                MAN_PATH = My.Settings.InPath & "\man_m.csv"
                TS_PROGRESSINFO.Text = "Москва. Индексация..."
            Case 2 ' ЭТО ОБЛАСТЬ
                TS_PROGRESSINFO.Text = "МО. Индексация..."
                ADV_PATH = My.Settings.InPath & "\adv8_mo.csv"
                MAN_PATH = My.Settings.InPath & "\man_mo.csv"
        End Select
        DoCompare.RunWorkerAsync()

    End Sub

    Private Sub FormFile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles FormFile.DoWork
        Dim outsrings As New List(Of String) From {
            String.Join(";", "ИСТОЧНИК", "РАЙОН", "СНИЛС", "ФАМИЛИЯ", "ИМЯ", "ОТЧЕСТВО", "ДАТА РОЖДЕНИЯ", "ПОЛ", "МЕСТО РОЖДЕНИЯ", "ДАТА СМЕРТИ", "ДАТА АКТА", "НОМЕР АКТА", "НАИМЕНОВАНИЕ ЗАГС", "СТАТУС ДЕЛА", "ВРЕМЯ СВЕДЕНИЙ")
        }
        Dim db As New DB_ENGINE

        ''REMOVE ADV DUPES
        DBOperations.RunSimpleCmd("DELETE FROM ADV_TABLE WHERE ROW_IDS NOT IN (SELECT MAX(ROW_IDS) FROM ADV_TABLE GROUP BY SNILS); DELETE FROM ADV_TABLE WHERE ROW_IDS NOT IN (SELECT MAX(ROW_IDS) FROM ADV_TABLE GROUP BY ID);")
        FormFile.ReportProgress(10)
        ''ВИД ПЕРВЫЙ - СОВПАДЕНИЕ ПО ID
        DBOperations.RunSimpleCmd("CREATE VIEW ADV_ID_COMP AS SELECT ADV_TABLE.ID,MAN_TABLE.ID AS MAN_ID FROM ADV_TABLE INNER JOIN MAN_TABLE ON ADV_TABLE.ID = MAN_TABLE.ID WHERE ADV_TABLE.DEATHDAT <> MAN_TABLE.DEATHDAT OR MAN_TABLE.ACTNUM<>ADV_TABLE.ACTNUM AND MAN_TABLE.STATUS <>1;")
        FormFile.ReportProgress(30)
        ''Выборка данных
        Dim cmd As New SQLite.SQLiteCommand(db.Open)
        Dim reader As SQLite.SQLiteDataReader
        cmd.CommandText = "SELECT * FROM ADV_ID_COMP;"
        FormFile.ReportProgress(50)
        Dim status As New String(""), ra As New String("")
        reader = cmd.ExecuteReader
        While reader.Read
            outsrings.Add(GetManInfo(reader(1), ra, status))
            outsrings.Add(GetAdvInfo(reader(0), ra, status))


        End While
        reader.Close()
        ''ВЫБОРКА - ПРОХОД 2
        cmd.CommandText = "SELECT ADV_TABLE.ID,MAN_TABLE.ID AS MAN_ID FROM ADV_TABLE INNER JOIN MAN_TABLE ON ADV_TABLE.SNILS = MAN_TABLE.SNILS WHERE ADV_TABLE.ID NOT IN (SELECT ID FROM ADV_ID_COMP) AND ADV_TABLE.DEATHDAT <> MAN_TABLE.DEATHDAT OR MAN_TABLE.ACTNUM<>ADV_TABLE.ACTNUM AND MAN_TABLE.STATUS <>1;"
        reader = cmd.ExecuteReader
        While reader.Read
            outsrings.Add(GetManInfo(reader(1), ra, status))
            outsrings.Add(GetAdvInfo(reader(0), ra, status))


        End While
        reader.Close()
        DBOperations.RunSimpleCmd("DROP VIEW ADV_ID_COMP;")
        FormFile.ReportProgress(100)
        Dim Reg As String = ""
        Select Case State
            Case 1
                Reg = "M"
            Case 2
                Reg = "MO"
        End Select
        IO.File.WriteAllLines(My.Settings.OutPath & "\ADV8-" & Reg & "-" & String.Join(".", Date.Today.Day.ToString(), Date.Today.Month.ToString(), Date.Today.Year.ToString) & ".CSV", outsrings, System.Text.Encoding.GetEncoding(1251))
        DBOperations.DB_CleanUP()
    End Sub
    Private Sub FormFile_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles FormFile.ProgressChanged
        TS_PB.ProgressBar.Value = e.ProgressPercentage

    End Sub
    Private Function GetAdvInfo(id As String, RA As String, STATUS As String) As String
        Dim stmp As New String("")
        Dim db As New DB_ENGINE
        Dim cmd As New SQLiteCommand(db.Open) With {.CommandText = "SELECT * FROM ADV_TABLE WHERE ID=@ID"}
        cmd.Parameters.Add("@ID", DbType.String).Value = id
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        While reader.Read()
            stmp = String.Join(";", resolve_sourse(reader(0)), RA, reader(1), reader(2), reader(3), reader(4), reader(5).ToString().Replace(" 0:00:00", ""), reader(6), reader(7), reader(8).ToString().Replace(" 0:00:00", ""), reader(9).ToString().Replace(" 0:00:00", ""), "=""" & reader(10) & """", reader(11), STATUS, reader(12).ToString().Replace(" 0:00:00", ""))
        End While
        db.Close()


        Return stmp
    End Function
    Private Function GetManInfo(id As String, ByRef RA As String, ByRef STATUS As String) As String
        Dim stmp As New String("")
        Dim db As New DB_ENGINE
        Dim cmd As New SQLiteCommand(db.Open) With {.CommandText = "SELECT * FROM MAN_TABLE WHERE ID=@ID"}
        cmd.Parameters.Add("@ID", DbType.String).Value = id
        Dim reader As SQLiteDataReader = cmd.ExecuteReader
        While reader.Read()
            stmp = String.Join(";", resolve_sourse(reader(0)), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6).ToString().Replace(" 0:00:00", ""), reader(7), reader(8), reader(9).ToString().Replace(" 0:00:00", ""), reader(10).ToString().Replace(" 0:00:00", ""), "=""" & reader(11) & """", "", reader(12), reader(13).ToString().Replace(" 0:00:00", ""))
            RA = reader(1)
            STATUS = reader(12)
        End While
        db.Close()


        Return stmp
    End Function

    Private Sub FormFile_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles FormFile.RunWorkerCompleted
        TS_PB.ProgressBar.Value = 0
        TS_PROGRESSINFO.Text = "Операция завершена."
        Select Case State
            Case 1
                WorkOn()
            Case Else
                State = 0 '' AND DO OTHER CODE DAMMIT
                IsBusy = False
                IsDone = True

        End Select
    End Sub

    Private Sub Mem_Timer_Tick(sender As Object, e As EventArgs) Handles Mem_Timer.Tick
        x = Process.GetCurrentProcess()
        Dim inf As String
        inf = "Mem Usage: " & Decimal.Round(x.WorkingSet64 / 1024 / 1024, 2, MidpointRounding.AwayFromZero) & " MB / 2048 MB"
        TS_MEMORY.Text = inf


    End Sub


    Private Sub SaveWeekdays()
        Dim stmp As String = ""
        For Each ind In CBLIST_WEEKDAYS.CheckedIndices
            If stmp = "" Then
                stmp = ind
            Else
                stmp = String.Join(",", stmp, ind)
            End If
        Next
        My.Settings.Weekdays = stmp


    End Sub
    Private Sub MAIN_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveWeekdays()
    End Sub
    Private Function VerifyDayOfWeek() As Boolean
        SaveWeekdays()
        Dim stmp() = My.Settings.Weekdays.Split(",")
        For Each i In stmp
            If i = "" Then Continue For
            If i + 1 = Date.Now.DayOfWeek Then Return True
        Next
        Return False
    End Function

    Private Sub NotifyAreaIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyAreaIcon.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MAIN_Resize(sender As Form, e As EventArgs) Handles MyBase.Resize
        If sender.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyAreaIcon.BalloonTipText = "Программа свернута в трей, дважды щелкните, чтобы развернуть"
            NotifyAreaIcon.BalloonTipTitle = "Регулярные операции выплаты VIP_ROUTINES"
            NotifyAreaIcon.ShowBalloonTip(3000)
        End If
    End Sub
End Class
