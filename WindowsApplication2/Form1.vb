'Léon McGregor
'Update: 05/08/12
'Name: Simple Browser
'Assess: Visual Basic 2010 Express

Public Class Form1

    Dim fav1 As String
    Dim fav2 As String

    'go button
    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        browser1.Navigate(addressBar.Text)

    End Sub
    'back button
    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        browser1.GoBack()

    End Sub
    'forward button
    Private Sub cmdForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdForward.Click
        browser1.GoForward()

    End Sub
    'stop button
    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        browser1.Stop()

    End Sub
    'refresh button
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        browser1.Refresh()

    End Sub
    'hide/show address bar button
    Private Sub cmdHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Panel2.Visible = False Then
            Panel2.Visible = True
        Else : Panel2.Visible = False
        End If
    End Sub

    'hides control bars
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If Panel4.Visible = True Then
            Panel2.Visible = False
        Else : Panel2.Visible = True
        End If
        If Panel4.Visible = True Then
            Panel4.Visible = False
        Else : Panel4.Visible = True
        End If
    End Sub


    'shortcuts
    Private Sub linkMail_Click(sender As System.Object, e As System.EventArgs) Handles linkMail.Click
        browser1.Navigate("http://outlook.com")
    End Sub

    Private Sub linkWiki_Click(sender As System.Object, e As System.EventArgs) Handles linkWiki.Click
        browser1.Navigate("https://en.wikipedia.org")
    End Sub

    Private Sub linkSearch_Click(sender As System.Object, e As System.EventArgs) Handles linkSearch.Click
        browser1.Navigate("https://www.duckduckgo.com")
    End Sub

    Private Sub linkTweet_Click(sender As System.Object, e As System.EventArgs) Handles linkTweet.Click
        browser1.Navigate("https://t9k.me/1Kq")
    End Sub

    'Favourites

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        browser1.Navigate(My.Settings.Fav1)
    End Sub

    Private Sub addFav1_Click(sender As System.Object, e As System.EventArgs) Handles addFav1.Click
        My.Settings.Fav1 = addressBar.Text
    End Sub

    Private Sub addFav2_Click(sender As System.Object, e As System.EventArgs) Handles addFav2.Click
        My.Settings.Fav2 = addressBar.Text
    End Sub

    Private Sub linkFav2_Click(sender As System.Object, e As System.EventArgs) Handles linkFav2.Click
        browser1.Navigate(My.Settings.Fav2)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles linkFav3.Click
        browser1.Navigate(My.Settings.fav3)
    End Sub

    Private Sub addFav3_Click(sender As System.Object, e As System.EventArgs) Handles addFav3.Click
        My.Settings.fav3 = addressBar.Text
    End Sub

    Private Sub linkFav4_Click(sender As System.Object, e As System.EventArgs) Handles linkFav4.Click
        browser1.Navigate(My.Settings.fav4)
    End Sub

    Private Sub addFav4_Click(sender As System.Object, e As System.EventArgs) Handles addFav4.Click
        My.Settings.fav4 = addressBar.Text
    End Sub

    Private Sub hideControl_Click(sender As System.Object, e As System.EventArgs) Handles hideControl.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        Else : Panel2.Visible = False
        End If
    End Sub
    'website adress
    Private Sub addressBar_click(sender As System.Object, e As System.EventArgs) Handles addressBar.Click
        '  addressBar.Text = browser1.Url
    End Sub
End Class

