Imports System.Data.SQLite

Public Class CSVMANFile : Implements ICSVPFR

    Public Sub ImportCSVToDB(path As String) Implements ICSVPFR.ImportCSVToDB
        Dim db As New DB_ENGINE
        Dim cmd As New SQLiteCommand(db.Open)
        Dim transact As SQLiteTransaction = cmd.Connection.BeginTransaction()
        Dim SR As New IO.StreamReader(path, System.Text.Encoding.GetEncoding(1251))
        Dim stmp() As String
        While SR.Peek >= 0
            Try


                stmp = SR.ReadLine.Split(";")
                cmd.CommandText = "INSERT INTO MAN_TABLE (SOURSE,RA,SNILS,FA,IM,OT,RDAT,GENDER,BIRTHPLACE,DEATHDAT,ACTDAT,ACTNUM,STATUS,SVEDTIME,ID) VALUES(@SOURSE,@RA,@SNILS,@FA,@IM,@OT,@RDAT,@GENDER,@BIRTHPLACE,@DEATHDAT,@ACTDAT,@ACTNUM,@STATUS,@SVEDTIME,@ID)"
                cmd.Parameters.Add("@SOURSE", DbType.Int16).Value = 2
                cmd.Parameters.Add("@RA", DbType.String).Value = stmp(11)
                cmd.Parameters.Add("@SNILS", DbType.String).Value = stmp(7)
                cmd.Parameters.Add("@FA", DbType.String).Value = stmp(3)
                cmd.Parameters.Add("@IM", DbType.String).Value = stmp(5)
                cmd.Parameters.Add("@OT", DbType.String).Value = stmp(8)
                cmd.Parameters.Add("@RDAT", DbType.Date).Value = MAIN.validatenull(stmp(12))
                cmd.Parameters.Add("@GENDER", DbType.String).Value = stmp(9)
                cmd.Parameters.Add("@BIRTHPLACE", DbType.String).Value = MAIN.BPLACE_FORM(stmp)
                cmd.Parameters.Add("@DEATHDAT", DbType.Date).Value = MAIN.validatenull(stmp(2))
                cmd.Parameters.Add("@ACTDAT", DbType.Date).Value = MAIN.validatenull(stmp(0))
                cmd.Parameters.Add("@ACTNUM", DbType.String).Value = stmp(6)
                cmd.Parameters.Add("@SVEDTIME", DbType.DateTime).Value = MAIN.validatenull(stmp(1))
                cmd.Parameters.Add("@STATUS", DbType.String).Value = stmp(10)
                cmd.Parameters.Add("@ID", DbType.String).Value = stmp(4)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Console.WriteLine("Err")
                Continue While
            End Try
        End While
        transact.Commit()
        db.Close()
    End Sub
End Class
