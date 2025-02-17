'Angel Nava
'Spring 2025
'RCET2265
'AccumulateMessageFunction
'https://github.com/TheGoldenPorkchop/AccumulateMessages/tree/master
Option Strict On
Option Explicit On


Imports System

Module MessageProgram

    Private messages As New List(Of String)()

    Sub Main(args As String())
        'uncomment to test interactively
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'your code here
        If clear Then
            messages.Clear()
        End If

        If Not String.IsNullOrEmpty(newMessage) AndAlso Not clear Then
            messages.Add(newMessage)
        End If

        Return String.Join(vbNewLine, messages) & If(messages.Count > 0, vbNewLine, "")
    End Function


End Module
