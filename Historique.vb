Module Historique
    ' La ListBox doit être publique ou transmise depuis le Form
    Public Sub AjouterAction(ByVal listBox As ListBox, ByVal action As String)
        listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm") & ": " & action)
        ' Garder seulement les 10 dernières actions
        If listBox.Items.Count > 10 Then
            listBox.Items.RemoveAt(10)
        End If
    End Sub
End Module
