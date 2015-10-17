Public Class Form2
        Dim hasil As String = ""

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        Try
            Select Case Cmb_pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(Txb_baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(Txb_baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(Txb_baris.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(Txb_baris.Text))
                Case Else
                    txb_hasil.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            txb_hasil.Text = "Masukan Bukan Angka"
        End Try
    End Sub

    Private Sub pyramid(batas As Integer)
        Dim btsKolom1 As Integer = batas
        Dim btsKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < btsKolom1 Or kolom > btsKolom2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            btsKolom1 -= 1
            btsKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        txb_hasil.Text = hasil
        hasil = ""
    End Sub

    Private Sub hollowPyramid(batas As Integer)
        Dim btsKolom1 As Integer = batas
        Dim btsKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = btsKolom1 Or kolom = btsKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            btsKolom1 -= 1
            btsKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        txb_hasil.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedPyramid(batas As Integer)
        Dim btsKolom1 As Integer = 0
        Dim btsKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > btsKolom1 And kolom < btsKolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            btsKolom1 += 1
            btsKolom2 -= 1
        Next
        txb_hasil.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub hollowInvertedPyramid(batas As Integer)
        Dim btsKolom1 As Integer = 1
        Dim btsKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = btsKolom1 Or kolom = btsKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            btsKolom1 += 1
            btsKolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        txb_hasil.Text = hasil
        Me.hasil = ""
    End Sub
End Class