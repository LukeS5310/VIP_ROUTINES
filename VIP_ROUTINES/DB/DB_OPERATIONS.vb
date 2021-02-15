Imports System.Data.SQLite
Namespace DBOperations
    Module DB_OPERATIONS
#Region "Table Generation Code"
        Private ADV_TABLE As String = $"
CREATE TABLE ADV_TABLE (
    SOURSE     INTEGER (2),
    SNILS      TEXT (14),
    FA         TEXT (32),
    IM         TEXT (32),
    OT         TEXT (32),
    RDAT       DATE,
    GENDER     TEXT (1),
    BIRTHPLACE TEXT (192),
    DEATHDAT   DATE,
    ACTDAT     DATE,
    ACTNUM     TEXT (32),
    ZAGS       TEXT (255),
    SVEDTIME   DATETIME,
    ID         TEXT (32),
    ROW_IDS         INTEGER PRIMARY KEY AUTOINCREMENT
);
"
        Private MAN_TABLE As String = $"
CREATE TABLE MAN_TABLE (
    SOURSE     INTEGER (2),
    RA         TEXT (3),
    SNILS      TEXT (14),
    FA         TEXT (32),
    IM         TEXT (32),
    OT         TEXT (32),
    RDAT       DATE,
    GENDER     TEXT (1),
    BIRTHPLACE TEXT (192),
    DEATHDAT   DATE,
    ACTDAT     DATE,
    ACTNUM     TEXT (32),
    STATUS     INTEGER,
    SVEDTIME   DATETIME,
    ID         TEXT (32) PRIMARY KEY

);


"
#End Region

        Sub DB_Init() ''Creates DB
            If IO.File.Exists(Application.StartupPath & "\ADV8.db") = False Then
                Dim DB As New DB_ENGINE
                RunSimpleCmd(ADV_TABLE & MAN_TABLE)
                RunSimpleCmd("PRAGMA synchronous = OFF")
                RunSimpleCmd("PRAGMA journal_mode = OFF")
                RunSimpleCmd("PRAGMA page_size = 10000")
                ''GENERATE TABLES
            Else
                DB_CleanUP()
            End If
        End Sub
        Function AppendDupeFIO(FA As String, IM As String, OT As String) As String
            Dim stmp As String = "d"
            If FA <> "" Then stmp &= FA(0)
            If IM <> "" Then stmp &= IM(0)
            If OT <> "" Then stmp &= OT(0)
            Return stmp
        End Function

        Sub DB_CleanUP()

            RunSimpleCmd("DELETE FROM MAN_TABLE;DELETE FROM ADV_TABLE;DROP VIEW IF EXISTS ADV_ID_COMP;VACUUM;")
        End Sub
        Public Function RunSimpleCmd(cmdtext As String) As Boolean
            Dim db As New DB_ENGINE
            Try
                Dim cmd As New SQLiteCommand(db.Open())
                cmd.CommandText = cmdtext
                cmd.ExecuteNonQuery()
                db.Close()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                db.Close()
                Return False
            End Try
        End Function
    End Module



End Namespace
