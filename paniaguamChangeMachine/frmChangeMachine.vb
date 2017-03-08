'Application name: Virtual Change Machine
'Date: 10/28/15
'Programmer: Manuel Paniagua
'Purpose: Convert pennies into dollar amounts

Option Infer Off
Option Strict On
Option Explicit On

Public Class frmChangeMachine

    Const cintDOLLAR As Integer = 100               'declares constants with coin values
    Const cintQUARTER As Integer = 25
    Const cintDIME As Integer = 10
    Const cintNICKEL As Integer = 5

    Dim intDollar As Integer                        'variables to hold coin quantity
    Dim intQuarter As Integer
    Dim intDime As Integer
    Dim intNickel As Integer
    Dim intPenny As Integer


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                                  'closes form
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        intPenny = Convert.ToInt32(txtPennies.Text) 'converts textbox to an integer

        intDollar = intPenny \ cintDOLLAR           'integer division calculates total dollars
        intPenny = intPenny Mod cintDOLLAR          'mod calculates remaining pennies
        intQuarter = intPenny \ cintQUARTER         'integer division calculates total quarters
        intPenny = intPenny Mod cintQUARTER         'mod calculates remaining pennies
        intDime = intPenny \ cintDIME               'integer division calculates total dimes
        intPenny = intPenny Mod cintDIME            'mod calculates remaining pennies
        intNickel = intPenny \ cintNICKEL           'integer division calculates total nickels
        intPenny = intPenny Mod cintNICKEL          'mod calculates remaining pennies

        lblDollars.Text = intDollar.ToString        'outputs coin quantities
        lblQuarters.Text = intQuarter.ToString
        lblDimes.Text = intDime.ToString
        lblNickels.Text = intNickel.ToString
        lblPennies.Text = intPenny.ToString

        btnClear.Enabled = True                     'enables clear and exit buttons
        btnExit.Enabled = True

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPennies.Clear()                          'clears pennies textbox

        lblDollars.Text = " "                       'clears all labels
        lblQuarters.Text = " "
        lblDimes.Text = " "
        lblNickels.Text = " "
        lblPennies.Text = " "

        txtPennies.Focus()                          'returns focuse to pennies textbox after clear button is clicked

        btnClear.Enabled = False                    'disables clear and exit buttons
        btnExit.Enabled = False

    End Sub
End Class
