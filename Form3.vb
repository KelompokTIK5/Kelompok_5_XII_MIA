Public Class Form3

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTTanggal.ValueChanged, DTTanggal.ValueChanged, Enabled.ValueChanged

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTTanggal.Format = DateTimePickerFormat.Short
        DTTanggal.CustomFormat = "dd/mm/yyyy"
        DTTanggal.Value = Format(Now)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = DTTanggal.Text

    End Sub
End Class