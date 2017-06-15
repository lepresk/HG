Namespace Printing
    Public Class FactureParams

        Public caissier As String = ""
        Public client As String = ""
        Public totalTTc As String = ""
        Public remise As String = ""
        Public netPayer As String = ""
        Public numero As String = ""
        Public fac_id As String = ""
        Public payer As String = ""


        Sub New(cais As String, cli As String, ttc As String, remi As String, net As String, num As String, fid As String, paid As String)
            caissier = cais
            client = cli
            totalTTc = ttc
            remise = remi & " " & My.Settings.unite_monetaire
            netPayer = net
            numero = num
            fac_id = fid
            payer = paid
        End Sub

    End Class
End Namespace