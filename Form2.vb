﻿Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(TxtNama.Text & vbCrLf & CmbKelas.Text & vbCrLf & CmbJenisKelamin.Text & vbCrLf & CmbMataPelajaran.Text, "Hasil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub CmbMataPelajaran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMataPelajaran.SelectedIndexChanged

    End Sub
End Class