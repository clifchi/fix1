Imports System.IO
Imports Microsoft.VisualBasic
Public Class FixClass
    Public Sub My_Log(ByVal my_LogMsg As String, ByVal my_LogName As String)

        ''dr = cmd.ExecuteReader()   '---- 這時候執行SQL指令，取出資料
        ''If dr.HasRows Then
        ''    My_Log("執行SQL指令", "log")
        ''Else
        ''    My_Log("執行SQL指令，卻沒有任何資料！", "err")
        ''End If



        Dim myLog_FileName As String = System.DateTime.Now.ToString("yyyyMMdd")
        '-- 以日期當作檔名，一天記錄一個檔案。

        Try
            Dim my_Dir As String = "c:\temp\" & System.DateTime.Now.ToString("yyyyMMdd")
            If Not Directory.Exists(my_Dir) Then
                Directory.CreateDirectory(my_Dir)  '--如果這目錄不存在，就建立它。
            End If

            Dim strRecord As String = System.String.Format("[{0:yyyy/MM/dd hh:mm:ss}]Message : {1}", System.DateTime.Now, my_LogMsg.Trim())

            Dim LogFile As String = my_Dir & "\" & myLog_FileName & "." & my_LogName   '--紀錄檔的副檔名(my_LogName)是 .log or .err

            Dim sw As New StreamWriter(LogFile, True, System.Text.Encoding.GetEncoding("BIG5"))
            '--第一個參數，檔名。
            '--第二個參數，是否採用APPEND的方式？表示新的資料，會附加在檔案末端。
            '--第三個參數，正體中文編碼 System.Text.Encoding.GetEncoding("BIG5")，預設值UTF-8。
            sw.WriteLine(strRecord)

            sw.Flush()
            sw.Close()
            sw.Dispose()
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub

    Public Sub CheckSession()
    


    End Sub

End Class
