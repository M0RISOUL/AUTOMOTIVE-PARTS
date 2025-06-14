﻿Imports System.Data.OleDb
Public Class frmDatabaseRecoveryManagement

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            'set the destination and a file name with the date and time
            Dim backupfiledestination As String = Application.StartupPath & "\LoginAndRegister" & Format(Now(), "yyyy-M-d H m s") & ".accdb"
            'location of the database file that you want to backup
            Dim databaseFile As String = Application.StartupPath & "\LoginAndRegister.accdb"

            'create a backup by using Filecopy Command to copy the file from  location to destination
            FileCopy(databaseFile, backupfiledestination)
            MsgBox("Database Backup has been Created Successfully!")
        Catch ex As Exception
            'catch an error  
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Try
            'set a your database file
            Dim restorefile As String = Application.StartupPath & "\LoginAndRegister.accdb"
            'declare a variable for storing the text message.
            Dim msgText As String
            'filtering the file
            OpenFileDialog1.Filter = "Access | *.accdb"
            'open the file directory
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                'set a text message
                msgText = "Are you sure you want to restore your database? It will overwite your database since the backup have made."
                'validate if you want to restore or not
                If MessageBox.Show(msgText, "Restore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    'restore your database
                    FileCopy(OpenFileDialog1.FileName, restorefile)
                    MsgBox("Database has been restore")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class