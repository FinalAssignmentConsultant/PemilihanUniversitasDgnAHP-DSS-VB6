Public Class DisplayMatrix

    Public Sub ShowArray(ByVal array(,) As Single, ByVal length As Integer)

        length = length + 1
        txt00.Text = array(0, 0)
        txt01.Text = array(0, 1)
        txt02.Text = array(0, 2)
        txt03.Text = array(0, 3)
        txt04.Text = array(0, 4)

        txt10.Text = array(1, 0)
        txt11.Text = array(1, 1)
        txt12.Text = array(1, 2)
        txt13.Text = array(1, 3)
        txt14.Text = array(1, 4)

        txt20.Text = array(2, 0)
        txt21.Text = array(2, 1)
        txt22.Text = array(2, 2)
        txt23.Text = array(2, 3)
        txt24.Text = array(2, 4)

        txt30.Text = array(3, 0)
        txt31.Text = array(3, 1)
        txt32.Text = array(3, 2)
        txt33.Text = array(3, 3)
        txt34.Text = array(3, 4)

        txt40.Text = array(4, 0)
        txt41.Text = array(4, 1)
        txt42.Text = array(4, 2)
        txt43.Text = array(4, 3)
        txt44.Text = array(4, 4)

        txt30.Visible = False
        txt31.Visible = False
        txt32.Visible = False
        txt33.Visible = False
        txt34.Visible = False

        txt03.Visible = False
        txt13.Visible = False
        txt23.Visible = False
        txt33.Visible = False
        txt43.Visible = False

        txt40.Visible = False
        txt41.Visible = False
        txt42.Visible = False
        txt43.Visible = False
        txt44.Visible = False

        txt04.Visible = False
        txt14.Visible = False
        txt24.Visible = False
        txt34.Visible = False
        txt44.Visible = False

        Text = length
        Select Case length
            Case 4
                txt30.Visible = True
                txt31.Visible = True
                txt32.Visible = True
                txt33.Visible = True
                '   txt34.Visible = True

                txt03.Visible = True
                txt13.Visible = True
                txt23.Visible = True
                txt33.Visible = True
                '  txt43.Visible = True

            Case 5
                txt30.Visible = True
                txt31.Visible = True
                txt32.Visible = True
                txt33.Visible = True
                'txt34.Visible = True

                txt03.Visible = True
                txt13.Visible = True
                txt23.Visible = True
                txt33.Visible = True
                ' txt43.Visible = True


                txt40.Visible = True
                txt41.Visible = True
                txt42.Visible = True
                txt43.Visible = True
                txt44.Visible = True

                txt04.Visible = True
                txt14.Visible = True
                txt24.Visible = True
                txt34.Visible = True
                txt44.Visible = True

        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class