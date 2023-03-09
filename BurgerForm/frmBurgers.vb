Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        ' This code is executed when the user clicks the Prime button. It displays the
        ' the prime beef picture, hides the veggie picture, and enables the Select Meal button.

        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnVeggieBurger_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        ' This code is executed when the user clicks the Veggie button. It displays the
        ' veggie picture, hides the prime picture, and enables the Select Meal button.

        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        ' This code is executed when the user clicks the Select Meal button. It disables the
        ' Prime Beef button, the Select button, and the Veggie button. It hides the
        ' Instructions label, displays the Confirmation label, and enables the Exit Window button.

        btnPrime.Enabled = False
        btnSelectMeal.Enabled = False
        btnVeggie.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user clicks the Exit Window button. 
        ' It closes the window and terminates the program execution.

        Me.Close()
    End Sub

    Private Sub frmBurgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This code is executed when the form loads.
        ' Notice that the form name is spelled the same all through the code. 
        picPrime.Visible = True

    End Sub
End Class
