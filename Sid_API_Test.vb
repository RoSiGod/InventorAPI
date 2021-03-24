Imports Inventor
Imports System.Runtime.InteropServices
Imports System.IO

Module Module1
    Public Sub CreateColumns(inventorApp, H, B, L, t, ColHeight, filepath)

        ' Create a new part document, using the default part template.
        Dim oDoc1 As Document
        oDoc1 = inventorApp.ActiveDocument

        Dim oPartCompDef1 As PartComponentDefinition
        oPartCompDef1 = oDoc1.ComponentDefinition

        Dim oSketch As PlanarSketch
        oSketch = oPartCompDef1.Sketches.Add(oPartCompDef1.WorkPlanes(2))

        Dim oTransGeom1 As TransientGeometry
        oTransGeom1 = inventorApp.TransientGeometry

        Dim oP1 As Point2d
        Dim oP2 As Point2d
        Dim oP3 As Point2d
        Dim oP4 As Point2d
        Dim oP5 As Point2d
        Dim oP6 As Point2d
        Dim oP7 As Point2d
        Dim oP8 As Point2d
        Dim oP9 As Point2d
        Dim oP10 As Point2d
        Dim oP11 As Point2d
        Dim oP12 As Point2d

        oP1 = oTransGeom1.CreatePoint2d(0, 0)
        oP2 = oTransGeom1.CreatePoint2d(0, L)
        oP3 = oTransGeom1.CreatePoint2d(-B, L)
        oP4 = oTransGeom1.CreatePoint2d(-B, L - H)
        oP5 = oTransGeom1.CreatePoint2d(0, L - H)
        oP6 = oTransGeom1.CreatePoint2d(0, 2 * L - H)
        oP7 = oTransGeom1.CreatePoint2d(-t, 2 * L - H)
        oP8 = oTransGeom1.CreatePoint2d(-t, L - H + t)
        oP9 = oTransGeom1.CreatePoint2d(t - B, L - H + t)
        oP10 = oTransGeom1.CreatePoint2d(t - B, L - t)
        oP11 = oTransGeom1.CreatePoint2d(-t, L - t)
        oP12 = oTransGeom1.CreatePoint2d(-t, 0)


        Dim oLines(0 To 11) As SketchLine
        oLines(0) = oSketch.SketchLines.AddByTwoPoints(oP1, oP2)
        oLines(1) = oSketch.SketchLines.AddByTwoPoints(oLines(0).EndSketchPoint, oP3)
        oLines(2) = oSketch.SketchLines.AddByTwoPoints(oLines(1).EndSketchPoint, oP4)
        oLines(3) = oSketch.SketchLines.AddByTwoPoints(oLines(2).EndSketchPoint, oP5)
        oLines(4) = oSketch.SketchLines.AddByTwoPoints(oLines(3).EndSketchPoint, oP6)
        oLines(5) = oSketch.SketchLines.AddByTwoPoints(oLines(4).EndSketchPoint, oP7)
        oLines(6) = oSketch.SketchLines.AddByTwoPoints(oLines(5).EndSketchPoint, oP8)
        oLines(7) = oSketch.SketchLines.AddByTwoPoints(oLines(6).EndSketchPoint, oP9)
        oLines(8) = oSketch.SketchLines.AddByTwoPoints(oLines(7).EndSketchPoint, oP10)
        oLines(9) = oSketch.SketchLines.AddByTwoPoints(oLines(8).EndSketchPoint, oP11)
        oLines(10) = oSketch.SketchLines.AddByTwoPoints(oLines(9).EndSketchPoint, oP12)
        oLines(11) = oSketch.SketchLines.AddByTwoPoints(oLines(10).EndSketchPoint, oLines(0).StartSketchPoint)

        'Object Collection
        Dim oCollection As ObjectCollection
        oCollection = inventorApp.TransientObjects.CreateObjectCollection

        ' Create a profile.
        Dim oProfile As Profile
        oProfile = oSketch.Profiles.AddForSolid

        ' Create the extrusion feature.
        Dim oExtrude As ExtrudeFeature
        oExtrude = oPartCompDef1.Features.ExtrudeFeatures.AddByDistanceExtent(oProfile, ColHeight, PartFeatureExtentDirectionEnum.kPositiveExtentDirection, PartFeatureOperationEnum.kJoinOperation)


        inventorApp.SilentOperation = True

        If System.IO.File.Exists(filepath & "\PartCol.ipt") Then
            System.IO.File.Delete(filepath & "\PartCol.ipt")
            oDoc1.SaveAs(filepath & "\PartCol.ipt", False)
            oDoc1.Save()
        Else
            oDoc1.SaveAs(filepath & "\PartCol.ipt", False)

        End If
        inventorApp.SilentOperation = False
        oDoc1.Close()






    End Sub

    Public Sub CreateBeams(inventorApp, H, B, L, t, BeamLength, filepath)

        ' Create a new part document, using the default part template.
        Dim oDoc2 As Document
        oDoc2 = inventorApp.ActiveDocument

        Dim oPartCompDef2 As PartComponentDefinition
        oPartCompDef2 = oDoc2.ComponentDefinition

        Dim oSketch As PlanarSketch
        oSketch = oPartCompDef2.Sketches.Add(oPartCompDef2.WorkPlanes(2))

        Dim oTransGeom1 As TransientGeometry
        oTransGeom1 = inventorApp.TransientGeometry

        Dim oP1 As Point2d
        Dim oP2 As Point2d
        Dim oP3 As Point2d
        Dim oP4 As Point2d
        Dim oP5 As Point2d
        Dim oP6 As Point2d
        Dim oP7 As Point2d
        Dim oP8 As Point2d
        Dim oP9 As Point2d
        Dim oP10 As Point2d
        Dim oP11 As Point2d
        Dim oP12 As Point2d

        oP1 = oTransGeom1.CreatePoint2d(0, 0)
        oP2 = oTransGeom1.CreatePoint2d(0, L)
        oP3 = oTransGeom1.CreatePoint2d(-B, L)
        oP4 = oTransGeom1.CreatePoint2d(-B, L - H)
        oP5 = oTransGeom1.CreatePoint2d(0, L - H)
        oP6 = oTransGeom1.CreatePoint2d(0, 2 * L - H)
        oP7 = oTransGeom1.CreatePoint2d(-t, 2 * L - H)
        oP8 = oTransGeom1.CreatePoint2d(-t, L - H + t)
        oP9 = oTransGeom1.CreatePoint2d(t - B, L - H + t)
        oP10 = oTransGeom1.CreatePoint2d(t - B, L - t)
        oP11 = oTransGeom1.CreatePoint2d(-t, L - t)
        oP12 = oTransGeom1.CreatePoint2d(-t, 0)


        Dim oLines(0 To 11) As SketchLine
        oLines(0) = oSketch.SketchLines.AddByTwoPoints(oP1, oP2)
        oLines(1) = oSketch.SketchLines.AddByTwoPoints(oLines(0).EndSketchPoint, oP3)
        oLines(2) = oSketch.SketchLines.AddByTwoPoints(oLines(1).EndSketchPoint, oP4)
        oLines(3) = oSketch.SketchLines.AddByTwoPoints(oLines(2).EndSketchPoint, oP5)
        oLines(4) = oSketch.SketchLines.AddByTwoPoints(oLines(3).EndSketchPoint, oP6)
        oLines(5) = oSketch.SketchLines.AddByTwoPoints(oLines(4).EndSketchPoint, oP7)
        oLines(6) = oSketch.SketchLines.AddByTwoPoints(oLines(5).EndSketchPoint, oP8)
        oLines(7) = oSketch.SketchLines.AddByTwoPoints(oLines(6).EndSketchPoint, oP9)
        oLines(8) = oSketch.SketchLines.AddByTwoPoints(oLines(7).EndSketchPoint, oP10)
        oLines(9) = oSketch.SketchLines.AddByTwoPoints(oLines(8).EndSketchPoint, oP11)
        oLines(10) = oSketch.SketchLines.AddByTwoPoints(oLines(9).EndSketchPoint, oP12)
        oLines(11) = oSketch.SketchLines.AddByTwoPoints(oLines(10).EndSketchPoint, oLines(0).StartSketchPoint)

        'Object Collection
        Dim oCollection As ObjectCollection
        oCollection = inventorApp.TransientObjects.CreateObjectCollection

        ' Create a profile.
        Dim oProfile1 As Profile
        oProfile1 = oSketch.Profiles.AddForSolid

        ' Create the extrusion feature.
        Dim oExtrude As ExtrudeFeature
        oExtrude = oPartCompDef2.Features.ExtrudeFeatures.AddByDistanceExtent(oProfile1, BeamLength, PartFeatureExtentDirectionEnum.kPositiveExtentDirection, PartFeatureOperationEnum.kJoinOperation)


        inventorApp.SilentOperation = True
        If System.IO.File.Exists(filepath & "\PartBeam.ipt") Then
            System.IO.File.Delete(filepath & "\PartBeam.ipt")
            oDoc2.SaveAs(filepath & "\PartBeam.ipt", False)
        Else
            oDoc2.SaveAs(filepath & "\PartBeam.ipt", False)

        End If
        inventorApp.SilentOperation = False
        oDoc2.Close()



    End Sub


    Public Sub CreatesecBeams(inventorApp, H, B, L, t, secBeamLength, filepath)

        ' Create a new part document, using the default part template.
        Dim oDoc3 As Document
        oDoc3 = inventorApp.ActiveDocument

        Dim oPartCompDef3 As PartComponentDefinition
        oPartCompDef3 = oDoc3.ComponentDefinition

        Dim oSketch As PlanarSketch
        oSketch = oPartCompDef3.Sketches.Add(oPartCompDef3.WorkPlanes(2))

        Dim oTransGeom1 As TransientGeometry
        oTransGeom1 = inventorApp.TransientGeometry

        Dim oP1 As Point2d
        Dim oP2 As Point2d
        Dim oP3 As Point2d
        Dim oP4 As Point2d
        Dim oP5 As Point2d
        Dim oP6 As Point2d
        Dim oP7 As Point2d
        Dim oP8 As Point2d
        Dim oP9 As Point2d
        Dim oP10 As Point2d
        Dim oP11 As Point2d
        Dim oP12 As Point2d

        oP1 = oTransGeom1.CreatePoint2d(0, 0)
        oP2 = oTransGeom1.CreatePoint2d(0, L)
        oP3 = oTransGeom1.CreatePoint2d(-B, L)
        oP4 = oTransGeom1.CreatePoint2d(-B, L - H)
        oP5 = oTransGeom1.CreatePoint2d(0, L - H)
        oP6 = oTransGeom1.CreatePoint2d(0, 2 * L - H)
        oP7 = oTransGeom1.CreatePoint2d(-t, 2 * L - H)
        oP8 = oTransGeom1.CreatePoint2d(-t, L - H + t)
        oP9 = oTransGeom1.CreatePoint2d(t - B, L - H + t)
        oP10 = oTransGeom1.CreatePoint2d(t - B, L - t)
        oP11 = oTransGeom1.CreatePoint2d(-t, L - t)
        oP12 = oTransGeom1.CreatePoint2d(-t, 0)


        Dim oLines(0 To 11) As SketchLine
        oLines(0) = oSketch.SketchLines.AddByTwoPoints(oP1, oP2)
        oLines(1) = oSketch.SketchLines.AddByTwoPoints(oLines(0).EndSketchPoint, oP3)
        oLines(2) = oSketch.SketchLines.AddByTwoPoints(oLines(1).EndSketchPoint, oP4)
        oLines(3) = oSketch.SketchLines.AddByTwoPoints(oLines(2).EndSketchPoint, oP5)
        oLines(4) = oSketch.SketchLines.AddByTwoPoints(oLines(3).EndSketchPoint, oP6)
        oLines(5) = oSketch.SketchLines.AddByTwoPoints(oLines(4).EndSketchPoint, oP7)
        oLines(6) = oSketch.SketchLines.AddByTwoPoints(oLines(5).EndSketchPoint, oP8)
        oLines(7) = oSketch.SketchLines.AddByTwoPoints(oLines(6).EndSketchPoint, oP9)
        oLines(8) = oSketch.SketchLines.AddByTwoPoints(oLines(7).EndSketchPoint, oP10)
        oLines(9) = oSketch.SketchLines.AddByTwoPoints(oLines(8).EndSketchPoint, oP11)
        oLines(10) = oSketch.SketchLines.AddByTwoPoints(oLines(9).EndSketchPoint, oP12)
        oLines(11) = oSketch.SketchLines.AddByTwoPoints(oLines(10).EndSketchPoint, oLines(0).StartSketchPoint)

        'Object Collection
        Dim oCollection As ObjectCollection
        oCollection = inventorApp.TransientObjects.CreateObjectCollection

        ' Create a profile.
        Dim oProfile1 As Profile
        oProfile1 = oSketch.Profiles.AddForSolid

        ' Create the extrusion feature.
        Dim oExtrude As ExtrudeFeature
        oExtrude = oPartCompDef3.Features.ExtrudeFeatures.AddByDistanceExtent(oProfile1, secBeamLength, PartFeatureExtentDirectionEnum.kPositiveExtentDirection, PartFeatureOperationEnum.kJoinOperation)


        inventorApp.SilentOperation = True
        If System.IO.File.Exists(filepath & "\PartsecBeam.ipt") Then
            System.IO.File.Delete(filepath & "\PartsecBeam.ipt")
            oDoc3.SaveAs(filepath & "\PartsecBeam.ipt", False)

        Else
            oDoc3.SaveAs(filepath & "\PartsecBeam.ipt", False)

        End If
        inventorApp.SilentOperation = False

        oDoc3.Close()

    End Sub


    Sub DrawSheets(inventorApp, filepath)

        Dim oDoc As DrawingDocument = inventorApp.Documents.Add(Inventor.DocumentTypeEnum.kDrawingDocumentObject, inventorApp.FileManager.GetTemplateFile(Inventor.DocumentTypeEnum.kDrawingDocumentObject), True)
        Dim oSheet As Sheet = oDoc.ActiveSheet
        DeleteView(oSheet)

        '*** Define View Locations
        Dim baseViewHorizontal As Double = (oSheet.Width * 0.25)
        Dim baseViewVertical As Double = ((oSheet.Height * 0.75))

        Dim projViewHorizontal As Double = (oSheet.Width * 0.25)
        Dim projViewVertical As Double = ((oSheet.Height * 0.3))

        Dim detailViewHorizontal As Double = (oSheet.Width * 0.6)
        Dim detailViewVertical As Double = (oSheet.Height * 0.5)

        Dim isoViewHorizontal As Double = (oSheet.Width * 0.85)
        Dim isoViewVertical As Double = (oSheet.Height * 0.5)

        '*** Define Model Reference
        Dim modelReference As Document = inventorApp.Documents.Open(filepath & "\FrameAssembly.iam", False)
        Dim oScale As Double = 1

        '*** Create Points for View Locations
        Dim oPoint(4) As Point2d
        oPoint(1) = inventorApp.TransientGeometry.CreatePoint2d(baseViewHorizontal, baseViewVertical)
        oPoint(2) = inventorApp.TransientGeometry.CreatePoint2d(projViewHorizontal, projViewVertical)
        oPoint(3) = inventorApp.TransientGeometry.CreatePoint2d(detailViewHorizontal, detailViewVertical)
        oPoint(4) = inventorApp.TransientGeometry.CreatePoint2d(isoViewHorizontal, isoViewVertical)

        '*** Define View Orientation
        Dim viewOrientation(4) As ViewOrientationTypeEnum
        viewOrientation(1) = 10764
        viewOrientation(4) = 10762

        '*** Define View Style
        Dim viewStyle(4) As DrawingViewStyleEnum
        viewStyle(1) = 32258
        viewStyle(2) = 32258
        viewStyle(3) = 32258
        viewStyle(4) = 32259

        '*** Create the Views
        Dim oBaseView As DrawingView = Nothing
        Dim oProjView As DrawingView = Nothing
        Dim oDetailView As DrawingView = Nothing
        Dim oIsoView As DrawingView = Nothing
        Dim detailCenter As Point2d = oPoint(2)

        For i = 1 To 4
            If i = 1 Then
                oBaseView = oSheet.DrawingViews.AddBaseView(modelReference, oPoint(i), oScale, viewOrientation(i), viewStyle(i))
                oBaseView.Name = "BaseView" & i
                Call SetViewScale(oSheet, oBaseView)
            ElseIf i = 2 Then
                oProjView = oSheet.DrawingViews.AddProjectedView(oBaseView, oPoint(i), viewStyle(i))
                oProjView.Name = "ProjView" & i

            ElseIf i = 3 Then
                detailCenter.Y = detailCenter.Y + 6.1
                oDetailView = oSheet.DrawingViews.AddDetailView(oProjView, oPoint(i), viewStyle(i), True, detailCenter, 3.2)
                oDetailView.Name = "View" & i
                oDetailView.Scale = oProjView.Scale * 0.1
            ElseIf i = 4 Then
                oIsoView = oSheet.DrawingViews.AddBaseView(modelReference, oPoint(i), oScale, viewOrientation(i), viewStyle(i))
                oIsoView.Name = "IsoView" & i
                Call SetViewScale(oSheet, oIsoView)
            End If
        Next


        ' Save Document in the same directory
        If System.IO.File.Exists(filepath & "\Drawings.dwg") Then
            System.IO.File.Delete(filepath & "\Drawings.dwg")
            oDoc.SaveAs(filepath & "\Drawings.dwg", False)

        Else
            oDoc.SaveAs(filepath & "\Drawings.dwg", False)

        End If

    End Sub

    Function SetViewScale(oSheet As Sheet, oView As DrawingView)
        Dim viewScale As Double = Nothing
        Dim trueViewHeight As Double = Nothing
        Dim viewName As String = oView.Name
        Dim viewHeight As Double = Nothing
        If Not viewName.Contains("Iso") Then
            viewHeight = (oSheet.Height * 0.25)
        Else
            viewHeight = (oSheet.Height * 0.25)
        End If
        trueViewHeight = oView.Height
        viewScale = (viewHeight / trueViewHeight)
        oView.Scale = viewScale

    End Function


    Function DeleteView(oSheet As Sheet)
        For Each view As DrawingView In oSheet.DrawingViews
            view.Delete()
        Next
    End Function



    Public Function ChannelSection(Inputs As Array)

        Dim ProID = {{9000, 4500, 8000, 9}, {10000, 5100, 10000, 10}, {10000, 5000, 18000, 12}, {10000, 4500, 10000, 13}, {13000, 5100, 14000, 14},
            {13000, 4800, 18000, 15}, {13000, 4500, 13500, 15}, {15000, 5100, 18000, 12}, {15000, 5600, 18000, 13}, {15000, 5100, 18000, 14}, {18000, 5100, 22500, 15},
            {9000, 4500, 10000, 11}, {18000, 5600, 24000, 13}, {18000, 5100, 22500, 14}, {20000, 5400, 27000, 15}, {20000, 6000, 28000, 15}}

        Dim ChanID = {{102, 51, 1, 12.5}, {102, 51, 1.2, 12.5}, {102, 51, 1.5, 13.5}, {102, 51, 1.9, 14.5},
            {152, 64, 1.2, 14.5}, {152, 64, 1.5, 15.5}, {152, 64, 1.9, 16.5}, {152, 64, 2.4, 18.5},
            {203, 76, 1.5, 15.5}, {203, 76, 1.9, 19}, {203, 76, 2.4, 21}, {254, 76, 1.9, 18.5},
            {254, 76, 2.4, 20.5}, {300, 96, 2.4, 27.5}, {300, 96, 3, 31.5}, {350, 125, 3, 30}}

        Dim ChanName = {"C10010", "C10012", "C10015", "C10019", "C15012", "C15015", "C15019", "C15024", "C20015", "C20019", "C20024", "C25019", "C25024", "C30024", "C30030", "C35030"}
        Dim CID As Double = 0

        ' Identify a suitable Channel ID from the profile inputs
        For i = 0 To 15
            If Inputs(0) >= ProID(i, 0) And Inputs(1) <= ProID(i, 1) And Inputs(2) >= ProID(i, 2) Then
                CID = i

            End If
        Next

        ' If above criteria fail to identify unique Channel ID, Channel ID 9 is set as default
        If CID = 0 Then
            CID = 8
        End If

        Dim Output(3) As Double
        Output(0) = ChanID(CID, 0)
        Output(1) = ChanID(CID, 1)
        Output(2) = ChanID(CID, 2)
        Output(3) = ChanID(CID, 3)


        Return Output

    End Function


End Module


Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FilepathDisplay.TextChanged

    End Sub





    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Get the required inputs from the user
        '****************************************
        Dim SpanL As Double

        If IsNumeric(InSpan.Text) Then
            SpanL = InSpan.Text
        Else
            MsgBox("please enter a number for Span")
            SpanL = 1000
        End If

        Dim LengthL As Double
        If IsNumeric(InLength.Text) Then
            LengthL = InLength.Text
        Else
            MsgBox("please enter a number for Length")
            LengthL = 1000
        End If

        Dim HeightL As Double
        If IsNumeric(InHeight.Text) Then
            HeightL = InHeight.Text
        ElseIf InHeight.Text > 6000 Then
            MsgBox("Height CANNOT be greater than 6000")
        Else
            MsgBox("please enter a number for Height")
            HeightL = 1000
        End If

        Dim PitchL As Double
        If IsNumeric(InPitch.Text) Then
            PitchL = InPitch.Text
        Else
            MsgBox("please enter a number for Angle")
            PitchL = 0
        End If

        Dim filepath As String
        filepath = FilepathDisplay.Text

        If filepath = "" Then
            MsgBox("Please select a folder")
        Else




            ' Get the Inventor Application object.
            '****************************************
            Dim inventorApp As Inventor.Application
            Try
                ' See if Inventor's running
                inventorApp = GetObject(, "Inventor.Application")
                inventorApp.Visible = True
                MsgBox("Connection Established")
            Catch ex As Exception
                MsgBox("Failed to attach to running instance, Openning a new one")

                Try
                    'Open a new one
                    inventorApp = CreateObject("Inventor.Application")
                    inventorApp.Visible = True
                Catch ex2 As Exception
                    MsgBox("Failed to connect to Inventor")
                End Try


            End Try

            'Defining Parameters to be INPUT from "FORM Application"
            '*******************************************************
            ' Get Channel Section by calling function ChannelSection()
            Dim Inputs(3) As Double
            Inputs = {SpanL, HeightL, LengthL}

            Dim oOutput() As Double
            Dim ChannelName As String
            oOutput = ChannelSection(Inputs)


            Dim ColSpan(4) As Double
            Dim ColHeight As Double
            Dim ColLength(4) As Double
            Dim ColAngle(4) As Double
            Dim BeamAngle(4) As Double
            Dim BeamLength As Double
            Dim Angle As Double
            Dim BeamHeight(4) As Double
            Dim BeamSpan(4) As Double
            Dim BLength(4) As Double

            Dim SecH As Double
            Dim SecB As Double
            Dim SecT As Double
            Dim SecL As Double

            SecH = oOutput(0)
            SecB = oOutput(1)
            SecT = oOutput(2)
            SecL = oOutput(3)

            ColSpan(0) = 0
            ColSpan(1) = SpanL
            ColSpan(2) = 0
            ColSpan(3) = SpanL

            ColLength(0) = 0
            ColLength(1) = 0
            ColLength(2) = LengthL
            ColLength(3) = LengthL

            ColHeight = HeightL

            ColAngle(0) = Math.PI / 2
            ColAngle(1) = Math.PI / 2
            ColAngle(2) = Math.PI * 3 / 2
            ColAngle(3) = Math.PI * 3 / 2

            Angle = PitchL

            BeamAngle(0) = 1 / 180 * Math.PI * (Angle - 90)
            BeamAngle(1) = 1 / 180 * Math.PI * (90 - Angle)
            BeamAngle(2) = 1 / 180 * Math.PI * (Angle - 90)
            BeamAngle(3) = 1 / 180 * Math.PI * (90 - Angle)

            BeamHeight(0) = ColHeight - SecH
            BeamHeight(1) = ColHeight
            BeamHeight(2) = ColHeight - SecH
            BeamHeight(3) = ColHeight

            BeamSpan(0) = ColSpan(0) - SecL
            BeamSpan(1) = ColSpan(1) - (SecH - SecL)
            BeamSpan(2) = ColSpan(2) + (SecH)
            BeamSpan(3) = ColSpan(3)

            BLength(0) = ColLength(0)
            BLength(1) = ColLength(1)
            BLength(2) = ColLength(2) + SecB
            BLength(3) = ColLength(3) + SecB



            BeamLength = (ColSpan(1) - SecH) / 2 * 1 / (Math.Cos(Math.PI / 180 * Angle))

            ' Creating Assembly and Part Document
            'Dim AssDoc As AssemblyDocument
            'AssDoc = inventorApp.Documents.Add(DocumentTypeEnum.kAssemblyDocumentObject)
            Dim PartDoc1 As PartDocument
            PartDoc1 = inventorApp.Documents.Add(Inventor.DocumentTypeEnum.kPartDocumentObject, inventorApp.FileManager.GetTemplateFile(Inventor.DocumentTypeEnum.kPartDocumentObject), True)

            Call CreateBeams(inventorApp, SecH, SecB, SecL, SecT, BeamLength, filepath)

            Dim PartDoc2 As PartDocument
            PartDoc2 = inventorApp.Documents.Add(Inventor.DocumentTypeEnum.kPartDocumentObject, inventorApp.FileManager.GetTemplateFile(Inventor.DocumentTypeEnum.kPartDocumentObject), True)

            Call CreateColumns(inventorApp, SecH, SecB, SecL, SecT, ColHeight, filepath)

            Dim PartDoc3 As PartDocument
            PartDoc3 = inventorApp.Documents.Add(Inventor.DocumentTypeEnum.kPartDocumentObject, inventorApp.FileManager.GetTemplateFile(Inventor.DocumentTypeEnum.kPartDocumentObject), True)

            Call CreatesecBeams(inventorApp, SecH, SecB, SecL, SecT, ColLength(3), filepath)

            '___ _________________________________________________________________________________________________________

            'Adding occurence of the object
            Dim oAssDoc As AssemblyDocument
            oAssDoc = inventorApp.Documents.Add(Inventor.DocumentTypeEnum.kAssemblyDocumentObject, inventorApp.FileManager.GetTemplateFile(Inventor.DocumentTypeEnum.kAssemblyDocumentObject), True)

            ' Sets the Columns of the frame
            For i = 0 To 3

                Dim oTransGeom As TransientGeometry
                oTransGeom = inventorApp.TransientGeometry

                'Roration the Component to suit the requirements
                'Create a 3D Vector
                Dim oRotVec As Vector
                oRotVec = oTransGeom.CreateVector(0, 1, 0)

                'Create point of rotation specific to the shape created
                Dim oPoR As Point
                oPoR = oTransGeom.CreatePoint(0, 0, 0)

                'Create Matrix
                Dim oMatrix As Matrix
                oMatrix = oTransGeom.CreateMatrix
                Call oMatrix.SetToRotation(ColAngle(i), oRotVec, oPoR)
                Call oMatrix.SetTranslation(oTransGeom.CreateVector(ColSpan(i), 0, ColLength(i)))

                Dim oAssCompDef As AssemblyComponentDefinition
                oAssCompDef = oAssDoc.ComponentDefinition

                Dim oOcc As ComponentOccurrence
                oOcc = oAssCompDef.Occurrences.Add(filepath & "\PartCol.ipt", oMatrix)
            Next

            ' Sets the Beams of the frame
            For i = 0 To 3

                Dim oTransGeom As TransientGeometry
                oTransGeom = inventorApp.TransientGeometry

                'Roration the Component to suit the requirements
                'Create a 3D Vector
                'This rotates the sectio about centroid to make the flage in vertical direction
                Dim oRotVec1 As Vector
                oRotVec1 = oTransGeom.CreateVector(0, 1, 0)

                'This allighn the component for its correct pitching angle
                Dim oRotVec As Vector
                oRotVec = oTransGeom.CreateVector(0, 0, 1)

                'Create point of rotation specific to the shape created
                Dim oPoR As Point
                oPoR = oTransGeom.CreatePoint(0, 0, 0)

                'Create Matrix
                Dim oMatrix1 As Matrix
                oMatrix1 = oTransGeom.CreateMatrix
                'Create Matrix
                Dim oMatrix As Matrix
                oMatrix = oTransGeom.CreateMatrix
                Call oMatrix1.SetToRotation(Math.PI / 2, oRotVec1, oPoR)
                Call oMatrix.SetToRotation(BeamAngle(i), oRotVec, oPoR)
                oMatrix1.PreMultiplyBy(oMatrix)
                Call oMatrix1.SetTranslation(oTransGeom.CreateVector(BeamSpan(i), BeamHeight(i), BLength(i)))

                Dim oAssCompDef As AssemblyComponentDefinition
                oAssCompDef = oAssDoc.ComponentDefinition

                Dim oOcc As ComponentOccurrence
                oOcc = oAssCompDef.Occurrences.Add(filepath & "\PartBeam.ipt", oMatrix1)
            Next

            ' Sets the secondary Beams of the frame
            For i = 0 To 1

                Dim oTransGeom As TransientGeometry
                oTransGeom = inventorApp.TransientGeometry

                'Roration the Component to suit the requirements
                'Create a 3D Vector
                'This rotates the sectio about centroid to make the flage in vertical direction
                Dim oRotVec1 As Vector
                oRotVec1 = oTransGeom.CreateVector(0, 1, 0)

                'This allighn the component for its correct pitching angle
                Dim oRotVec As Vector
                oRotVec = oTransGeom.CreateVector(1, 0, 0)

                'Create point of rotation specific to the shape created
                Dim oPoR As Point
                oPoR = oTransGeom.CreatePoint(0, 0, 0)

                'Create Matrix
                Dim oMatrix As Matrix
                oMatrix = oTransGeom.CreateMatrix
                Call oMatrix.SetToRotation(Math.PI / 2, oRotVec1, oPoR)
                Call oMatrix.SetToRotation(Math.PI / 2, oRotVec, oPoR)
                Call oMatrix.SetTranslation(oTransGeom.CreateVector(ColSpan(i), ColHeight - SecH, 0))

                Dim oAssCompDef As AssemblyComponentDefinition
                oAssCompDef = oAssDoc.ComponentDefinition

                Dim oOcc As ComponentOccurrence
                oOcc = oAssCompDef.Occurrences.Add(filepath & "\PartsecBeam.ipt", oMatrix)
            Next

            ' Save the assembly file for drawing creation
            If System.IO.File.Exists(filepath & "\FrameAssembly.iam") Then
                System.IO.File.Delete(filepath & "\FrameAssembly.iam")
                oAssDoc.SaveAs(filepath & "\FrameAssembly.iam", False)
                oAssDoc.Save()
            Else
                oAssDoc.SaveAs(filepath & "\FrameAssembly.iam", False)

            End If
            inventorApp.SilentOperation = False




        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim inventorApp As Inventor.Application
        inventorApp = GetObject(, "Inventor.Application")

        inventorApp.Documents.CloseAll()

    End Sub

    Private Sub Span_TextChanged(sender As Object, e As EventArgs) Handles InSpan.TextChanged


    End Sub

    Private Sub Length_TextChanged(sender As Object, e As EventArgs) Handles InLength.TextChanged


    End Sub

    Private Sub Height_TextChanged(sender As Object, e As EventArgs) Handles InHeight.TextChanged

    End Sub

    Private Sub Pitch_TextChanged(sender As Object, e As EventArgs) Handles InPitch.TextChanged

    End Sub



    Private Sub FolderBrowserDialog1_HelpRequest_1(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest



    End Sub

    Private Sub Select_Folder_Click(sender As Object, e As EventArgs) Handles Select_Folder.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim filedir As String
            filedir = FolderBrowserDialog1.SelectedPath
            FilepathDisplay.Text = filedir

        End If

    End Sub

    Private Sub Export_Drawing_Click(sender As Object, e As EventArgs) Handles Export_Drawing.Click

        Dim inventorApp As Inventor.Application
        inventorApp = GetObject(, "Inventor.Application")

        Dim filepath As String
        filepath = FilepathDisplay.Text

        Call DrawSheets(inventorApp, filepath)





    End Sub

    Private Sub Export_BOM_Click(sender As Object, e As EventArgs) Handles Export_BOM.Click

        Dim SpanL As Double

        If IsNumeric(InSpan.Text) Then
            SpanL = InSpan.Text
        Else
            MsgBox("please enter a number for Span")
            SpanL = 1000
        End If

        Dim LengthL As Double
        If IsNumeric(InLength.Text) Then
            LengthL = InLength.Text
        Else
            MsgBox("please enter a number for Length")
            LengthL = 1000
        End If

        Dim HeightL As Double
        If IsNumeric(InHeight.Text) Then
            HeightL = InHeight.Text
        ElseIf InHeight.Text > 6000 Then
            MsgBox("Height CANNOT be greater than 6000")
        Else
            MsgBox("please enter a number for Height")
            HeightL = 1000
        End If

        Dim PitchL As Double
        If IsNumeric(InPitch.Text) Then
            PitchL = InPitch.Text
        Else
            MsgBox("please enter a number for Angle")
            PitchL = 0
        End If

        Dim Inputs() As Double
        Inputs = {SpanL, HeightL, LengthL}

        Dim ProID = {{9000, 4500, 8000, 9}, {10000, 5100, 10000, 10}, {10000, 5000, 18000, 12}, {10000, 4500, 10000, 13}, {13000, 5100, 14000, 14},
            {13000, 4800, 18000, 15}, {13000, 4500, 13500, 15}, {15000, 5100, 18000, 12}, {15000, 5600, 18000, 13}, {15000, 5100, 18000, 14}, {18000, 5100, 22500, 15},
            {9000, 4500, 10000, 11}, {18000, 5600, 24000, 13}, {18000, 5100, 22500, 14}, {20000, 5400, 27000, 15}, {20000, 6000, 28000, 15}}

        Dim ChanID = {{102, 51, 1, 12.5}, {102, 51, 1.2, 12.5}, {102, 51, 1.5, 13.5}, {102, 51, 1.9, 14.5},
            {152, 64, 1.2, 14.5}, {152, 64, 1.5, 15.5}, {152, 64, 1.9, 16.5}, {152, 64, 2.4, 18.5},
            {203, 76, 1.5, 15.5}, {203, 76, 1.9, 19}, {203, 76, 2.4, 21}, {254, 76, 1.9, 18.5},
            {254, 76, 2.4, 20.5}, {300, 96, 2.4, 27.5}, {300, 96, 3, 31.5}, {350, 125, 3, 30}}

        Dim ChanName = {"C10010", "C10012", "C10015", "C10019", "C15012", "C15015", "C15019", "C15024", "C20015", "C20019", "C20024", "C25019", "C25024", "C30024", "C30030", "C35030"}
        Dim CID As Double = 0

        ' Identify a suitable Channel ID from the profile inputs
        For i = 0 To 15
            If Inputs(0) >= ProID(i, 0) And Inputs(1) <= ProID(i, 1) And Inputs(2) >= ProID(i, 2) Then
                CID = i

            End If
        Next

        ' If above criteria fail to identify unique Channel ID, Channel ID 9 is set as default
        If CID = 0 Then
            CID = 8
        End If

        '
        MsgBox("The Channel Section is: " & ChanName(CID))

    End Sub
End Class
