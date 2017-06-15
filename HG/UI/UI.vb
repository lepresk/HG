Namespace UI
    Public Class UI

        ''' <summary>
        ''' Cree et retourne un boutton du menu
        ''' 
        ''' </summary>
        ''' <param name="description"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetMenuButton(ByRef description As BtnMenuDescription) As Button
            Dim button As New Button

            With button
                .Text = description.DisplayText
                .Tag = description.Tags
                .BackColor = Color.FromArgb(21, 136, 173)
                .Cursor = System.Windows.Forms.Cursors.Hand
                .FlatStyle = System.Windows.Forms.FlatStyle.Flat
                .Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                .Size = New System.Drawing.Size(200, 70)
                .UseVisualStyleBackColor = False
                '.Image = CType(My.Resources.ResourceManager.GetObject(description.Icon), System.Drawing.Image)
                .ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
                .Margin = New Padding(1)
                .ForeColor = Color.Black
            End With


            Return button
        End Function

        Public Shared currentPanelProduit As Panel


        Public Shared Function EnhancedItem(ByRef description As ItemProduitDescription) As Panel

            Dim panel As New BouttonProduit
            Dim nomProduit As New TransparentLabel
            Dim imgProduit As New PictureBox

            With panel
                .Controls.Add(nomProduit)
                .Controls.Add(imgProduit)
                .Size = New System.Drawing.Size(205, 65)
                .Tag = description.Tags
                .Cursor = Cursors.Hand
                .Margin = New Padding(1)
            End With


            With nomProduit
                .BackColor = Color.Transparent
                .FlatStyle = System.Windows.Forms.FlatStyle.Flat
                .Font = New System.Drawing.Font("Open Sans", 10.0!)
                .ForeColor = System.Drawing.Color.Black
                .Location = New System.Drawing.Point(50, 10)
                .Size = New System.Drawing.Size(160, 45)
                .Text = description.DisplayText
                .Tag = description.Tags
                .TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            End With



            With imgProduit
                .BackColor = Color.Transparent

                If FileIO.FileSystem.FileExists(description.photo) Then
                    .ImageLocation = description.photo
                Else
                    .Image = CType(My.Resources.ResourceManager.GetObject("default_image"), System.Drawing.Image)
                End If
                .Location = New System.Drawing.Point(11, 14)
                .Size = New System.Drawing.Size(40, 30)
                .SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                .Tag = description.Tags
                .TabStop = False
            End With

            Return panel
        End Function


        ''' <summary>
        ''' Btn facture, fenetre facture en attente
        ''' </summary>
        ''' <param name="description"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetItemFactureAttente(ByRef description As ItemFactureDescription) As Panel

            Dim panel As New Panel
            Dim labelDate As New Label
            Dim couvert As New Label
            Dim user As New Label
            Dim table As New Label
            Dim numTicket As New Label

            '
            'Item
            '
            panel.BackColor = System.Drawing.Color.DeepSkyBlue
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            panel.Controls.Add(labelDate)
            panel.Controls.Add(couvert)
            panel.Controls.Add(user)
            panel.Controls.Add(table)
            panel.Controls.Add(numTicket)
            panel.Cursor = System.Windows.Forms.Cursors.Hand
            panel.Size = New System.Drawing.Size(260, 104)
            panel.Tag = description.Tags
            '
            'numTicket
            '
            numTicket.AutoSize = True
            numTicket.BackColor = System.Drawing.Color.Transparent
            numTicket.Font = New System.Drawing.Font("Consolas", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            numTicket.ForeColor = System.Drawing.Color.RoyalBlue
            numTicket.Location = New System.Drawing.Point(13, 32)
            numTicket.Text = "Facture : " & description.BtnId
            numTicket.Tag = description.Tags
            '
            'table
            '
            table.AutoSize = True
            table.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            table.Location = New System.Drawing.Point(14, 55)
            table.Size = New System.Drawing.Size(99, 19)
            table.Text = "Table : " & description.Table
            table.Tag = description.Tags
            '
            'couvert
            '
            couvert.AutoSize = True
            couvert.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            couvert.Location = New System.Drawing.Point(144, 55)
            couvert.Text = "Couvert : " & description.Couvert
            couvert.Tag = description.Tags
            '
            'user
            '
            user.AutoSize = True
            user.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            user.Location = New System.Drawing.Point(15, 78)
            user.Name = "user"
            user.Text = "Par : " & description.User
            user.Tag = description.Tags

            '
            'labelDate
            '
            labelDate.BackColor = System.Drawing.Color.Lavender
            labelDate.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            labelDate.Location = New System.Drawing.Point(-2, 0)
            labelDate.Name = "labelDate"
            labelDate.Size = New System.Drawing.Size(269, 26)
            labelDate.Text = description.StrDate
            labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            labelDate.Tag = description.Tags
            Return panel
        End Function



        Public Shared Function GetItemServeur(ByRef description As BtnServeurDescription) As Panel
            Dim panel As New Panel
            Dim photServeur As New PictureBox
            Dim nomServeur As New Label
            '
            'item
            '
            panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            panel.Controls.Add(photServeur)
            panel.Controls.Add(nomServeur)
            panel.Cursor = System.Windows.Forms.Cursors.Hand
            panel.Size = New System.Drawing.Size(163, 160)
            panel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            panel.Tag = description.Tags

            '
            'photServeur
            '
            photServeur.Image = Global.HG.My.Resources.Resources.servant_img
            photServeur.Location = New System.Drawing.Point(25, 14)
            photServeur.Size = New System.Drawing.Size(114, 102)
            photServeur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            photServeur.TabStop = False
            photServeur.Tag = description.Tags
            '
            'nomServeur
            '
            nomServeur.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            nomServeur.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            nomServeur.Location = New System.Drawing.Point(0, 117)
            nomServeur.Size = New System.Drawing.Size(162, 41)
            nomServeur.Text = description.DisplayText
            nomServeur.Tag = description.Tags
            nomServeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

            Return panel
        End Function

        Public Shared Function GetButtonChoix(ByRef description As UniteTag) As Button
            Dim btn As New Button

            btn.BackColor = System.Drawing.Color.Turquoise
            btn.Font = New System.Drawing.Font("Open Sans", 12.0!, FontStyle.Bold)
            btn.Size = New System.Drawing.Size(161, 70)
            btn.Text = description.displayText
            btn.Margin = New Padding(1)
            btn.Cursor = Cursors.Hand
            btn.Tag = description

            Return btn
        End Function

    End Class
End Namespace