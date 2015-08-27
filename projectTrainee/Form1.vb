Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database2DataSet.Table)

    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub


    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        TableBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        TableBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TableBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        TableBindingSource.MoveLast()
    End Sub

    Private Sub TableBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TableBindingSource.CurrentChanged
        Dim gen As String = String.Empty
        gen = TableBindingSource.Current("Gender")


        If gen = "M" Then
            rdoMale.Checked = True
        Else
            rdoFemale.Checked = True
        End If
    End Sub
End Class
