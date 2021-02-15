Imports System.Data.SQLite

Public Class CSVADVFile : Implements ICSVPFR

    Public Sub ImportCSVToDB(path As String) Implements ICSVPFR.ImportCSVToDB
        Dim db As New DB_ENGINE
        Dim cmd As New SQLiteCommand(db.Open)
        Dim transact As SQLiteTransaction = cmd.Connection.BeginTransaction()
        Dim SR As New IO.StreamReader(path, System.Text.Encoding.GetEncoding(1251))
        Dim stmp() As String
        While SR.Peek >= 0
            stmp = SR.ReadLine.Split(";")
            cmd.CommandText = "INSERT INTO ADV_TABLE (SOURSE,SNILS,FA,IM,OT,RDAT,GENDER,BIRTHPLACE,DEATHDAT,ACTDAT,ACTNUM,ZAGS,SVEDTIME,ID) VALUES(@SOURSE,@SNILS,@FA,@IM,@OT,@RDAT,@GENDER,@BIRTHPLACE,@DEATHDAT,@ACTDAT,@ACTNUM,@ZAGS,@SVEDTIME,@ID)"
            cmd.Parameters.Add("@SOURSE", DbType.Int16).Value = 1
            'cmd.Parameters.Add("@RA", DbType.String).Value = stmp(11)
            cmd.Parameters.Add("@SNILS", DbType.String).Value = stmp(17)
            cmd.Parameters.Add("@FA", DbType.String).Value = stmp(13)
            cmd.Parameters.Add("@IM", DbType.String).Value = stmp(15)
            cmd.Parameters.Add("@OT", DbType.String).Value = stmp(18)
            cmd.Parameters.Add("@RDAT", DbType.Date).Value = MAIN.validatenull(stmp(28))
            cmd.Parameters.Add("@GENDER", DbType.String).Value = stmp(27)
            cmd.Parameters.Add("@BIRTHPLACE", DbType.String).Value = String.Join(" ", stmp(29), stmp(30), stmp(31), stmp(32))
            cmd.Parameters.Add("@DEATHDAT", DbType.Date).Value = MAIN.validatenull(stmp(34))
            cmd.Parameters.Add("@ACTDAT", DbType.Date).Value = MAIN.validatenull(stmp(35))
            cmd.Parameters.Add("@ACTNUM", DbType.String).Value = stmp(36)
            cmd.Parameters.Add("@SVEDTIME", DbType.DateTime).Value = MAIN.validatenull(stmp(11))
            cmd.Parameters.Add("@ZAGS", DbType.String).Value = stmp(41)
            cmd.Parameters.Add("@ID", DbType.String).Value = stmp(14)
            cmd.ExecuteNonQuery()

        End While
        transact.Commit()
        db.Close()
    End Sub
End Class
