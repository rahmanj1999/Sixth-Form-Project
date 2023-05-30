Partial Class InformationDataSet
    Partial Public Class StudentInfoDataTable
        Private Sub StudentInfoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.UsernameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace InformationDataSetTableAdapters
    Partial Public Class QuestionsTableAdapter
    End Class

    Partial Public Class StatsTableAdapter
    End Class

    Partial Public Class ScoreTableAdapter
    End Class

    Partial Public Class StudentInfoTableAdapter
    End Class
End Namespace

Namespace InformationDataSetTableAdapters
    Partial Public Class QuestionsTableAdapter
    End Class
End Namespace
