Option Strict On
Option Explicit On

Public Class Form1
    ' ****************************************************************************
    ' Surname, Initials:Sikhipha A
    ' Student Number:223068260
    ' Practical: P24IFM-08
    ' Class name: Form1
    ' ****************************************************************************

    Private num_of_shops As Integer = 0
    Private num_of_days As Integer = 0
    Private eggs_sold(,) As Integer


    Private Sub btn_set_number_of_shops_Click(sender As Object, e As EventArgs) Handles btn_set_number_of_shops.Click


        Dim input As Integer = CInt(InputBox("Enter the number of shops in which the eggs were sold "))
        If CStr(input) <> "" Then
            num_of_shops = input

        End If
    End Sub

    Private Sub btn_set_number_of_Days_Click(sender As Object, e As EventArgs) Handles btn_set_number_of_Days.Click


        Dim input As Integer = CInt(InputBox("Enter the number of days in which the eggs were sold"))
        If CStr(input) <> "" Then
            num_of_days = input
        End If
        ReDim eggs_sold(num_of_shops - 1, num_of_days - 1)
        set_grid()
    End Sub


    Private Sub set_grid()
        grd_num_of_days_and_shops.Rows = num_of_days + 3
        grd_num_of_days_and_shops.Cols = num_of_shops + 1

        For i = 0 To num_of_shops - 1
            grd_num_of_days_and_shops.Row = 0
            grd_num_of_days_and_shops.Col = i + 1
            grd_num_of_days_and_shops.Text = "shop " + CStr(i + 1)


        Next


        For m = 0 To num_of_days - 1
            grd_num_of_days_and_shops.Row = m + 1
            grd_num_of_days_and_shops.Col = 0
            grd_num_of_days_and_shops.Text = "Day " + CStr(m + 1)
        Next

    End Sub

    Private Sub btn_registrer_egg_Click(sender As Object, e As EventArgs) Handles btn_registrer_egg.Click
        Dim day_input As Integer = CInt(InputBox("Which Day Do You  Want Enter"))
        Dim shop_input As Integer = CInt(InputBox("Which shop"))
        Dim egg_input As Integer = CInt(InputBox("How Many  Eggs Were Sold"))
        If CStr(day_input) <> "" And CStr(egg_input) <> "" And CStr(shop_input) <> "" Then
            eggs_sold(shop_input - 1, day_input - 1) = egg_input
            update_grid()
        End If
    End Sub
    Private Sub update_grid()
        For shop As Integer = 0 To num_of_shops - 1
            For day As Integer = 0 To num_of_days - 1
                grd_num_of_days_and_shops.Row = day + 1 ' Offset by 1 because of header row
                grd_num_of_days_and_shops.Col = shop + 1  ' Offset by 1 because of header column.. like row 0 and col0 got nothing
                grd_num_of_days_and_shops.Text = eggs_sold(shop, day).ToString()
            Next

            Dim total_eggs_sold As Integer = calc_total_eggs_sold(shop)
            grd_num_of_days_and_shops.Row = num_of_days + 2
            grd_num_of_days_and_shops.Col = shop + 1
            grd_num_of_days_and_shops.Text = total_eggs_sold.ToString()

            grd_num_of_days_and_shops.Col = 0
            grd_num_of_days_and_shops.Row = num_of_days + 2
            grd_num_of_days_and_shops.Text = "total eggs sold"
        Next

    End Sub

    Private Function calc_total_eggs_sold(ByVal shop_index As Integer) As Integer
        Dim total_eggs_sold As Integer = 0
        For day As Integer = 0 To num_of_days - 1
            total_eggs_sold += eggs_sold(shop_index, day)
        Next
        Return total_eggs_sold


    End Function
End Class
