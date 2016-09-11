Public Class MainForm
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnHombres.Click
        btnHombres.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnMujeres.ForeColor = Color.SteelBlue
        btnHombres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click
        btnCalzado.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnHombres.ForeColor = Color.Black
        btnAccesorios.ForeColor = Color.Black

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnAccesorios.Click
        btnAccesorios.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnHombres.ForeColor = Color.Black

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblTituloProducto.Text = "CAMISA DE ALGODON"
        lblPrecio.Text = "$120"
        pbProductos.Image = ilProductos.Images.Item(0)
        lblXS.ForeColor = Color.Gray
        lblS.ForeColor = Color.Black
        lblM.ForeColor = Color.Gray
        lblL.ForeColor = Color.Black
        lblXL.ForeColor = Color.Gray
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblTituloProducto.Text = "BLAZER MEZCLA LANA"
        lblPrecio.Text = "$240"
        pbProductos.Image = ilProductos.Images.Item(1)
        lblXS.ForeColor = Color.Black
        lblS.ForeColor = Color.Black
        lblM.ForeColor = Color.Gray
        lblL.ForeColor = Color.Gray
        lblXL.ForeColor = Color.Gray
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblTituloProducto.Text = "JERSEY CUELLO PICO"
        lblPrecio.Text = "$160"
        pbProductos.Image = ilProductos.Images.Item(2)
        lblXS.ForeColor = Color.Black
        lblS.ForeColor = Color.Black
        lblM.ForeColor = Color.Gray
        lblL.ForeColor = Color.Black
        lblXL.ForeColor = Color.Black
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblTituloProducto.Text = "POLO CUELLO REDONDO"
        lblPrecio.Text = "$70"
        pbProductos.Image = ilProductos.Images.Item(3)
        lblXS.ForeColor = Color.Black
        lblS.ForeColor = Color.Gray
        lblM.ForeColor = Color.Gray
        lblL.ForeColor = Color.Black
        lblXL.ForeColor = Color.Black
    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub TableLayoutPanel11_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel11.Paint

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lblXS.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblS.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblM.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles lblL.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles lblXL.Click

    End Sub
End Class