Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Public Class GuLangAPI
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class

Public Module GuModule
    Public G1 As String = "咕", G2 = "唧", G3 = "嘎", G4 = "呜"
    Public Function GetByte(str As String) As Integer
        Dim b1 As Byte
        Select Case str(0)
            Case G1
                b1 = 0
            Case G2
                b1 = 1
            Case G3
                b1 = 2
            Case G4
                b1 = 3
        End Select
        Return b1
    End Function
    Public Function GetGustr(num As Byte) As String
        Dim gu1 As Char
        Dim gu2 As Char
        Select Case num And (2 ^ 2 - 1)
            Case 0
                gu1 = G1
            Case 1
                gu1 = G2
            Case 2
                gu1 = G3
            Case 3
                gu1 = G4
        End Select

        Select Case (num >> CByte(2)) And (2 ^ 2 - 1)
            Case 0
                gu2 = G1
            Case 1
                gu2 = G2
            Case 2
                gu2 = G3
            Case 3
                gu2 = G4
        End Select
        Return gu1 & gu2
    End Function
    Public Function ChineseToGu(str0 As String, Optional Pwd As String = "") As String
        Dim strbulid As New StringBuilder
        If Pwd = "" Then
            strbulid.Append("咕~")
        Else
            strbulid.Append("咕~咕咕咕")
            Dim b As Short = str0.GetHashCode() And Short.MaxValue
            Dim b10 As Byte = CByte(b And (2 ^ 4 - 1))
            Dim b20 As Byte = (b >> 12S) And (2 ^ 4 - 1)
            Dim b30 As Byte = (b >> 8S) And (2 ^ 4 - 1)
            Dim b40 As Byte = (b >> 4S) And (2 ^ 4 - 1)
            strbulid.Append(GetGustr(b10))
            strbulid.Append(GetGustr(b40))
            strbulid.Append(GetGustr(b30))
            strbulid.Append(GetGustr(b20))
        End If
        Dim p As Int32
        For Each Chr0 In str0
            Dim a As Short = Asc(Chr0)
            If Pwd <> "" Then
                a = a Xor (Pwd(p).GetHashCode() And Short.MaxValue)
                p += 1
                If Pwd.Length = p Then
                    p = 0
                End If
            End If
            Dim b1 As Byte = CByte(a And (2 ^ 4 - 1))
            Dim b2 As Byte = (a >> 12S) And (2 ^ 4 - 1)
            Dim b3 As Byte = (a >> 8S) And (2 ^ 4 - 1)
            Dim b4 As Byte = (a >> 4S) And (2 ^ 4 - 1)
            strbulid.Append(GetGustr(b1))
            strbulid.Append(GetGustr(b4))
            strbulid.Append(GetGustr(b3))
            strbulid.Append(GetGustr(b2))
        Next
        Return strbulid.ToString()
    End Function
    Public Function GuToChinese(str0 As String, Optional Pwd As String = "n") As String
        If str0.StartsWith("咕~", StringComparison.CurrentCulture) Then
            Dim guarray As New List(Of String)
            Dim str1 As String = str0.Substring(2)
            Dim haspwd As Boolean = False
            Dim hash As Short = 0
            If str0.StartsWith("咕~咕咕咕", StringComparison.CurrentCulture) Then
                str1 = str1.Substring(3)
                Dim b0 As Integer = CInt(GetByte(str1(0)))
                Dim b1 As Integer = CInt(GetByte(str1(1))) << 2
                Dim b2 As Integer = CInt(GetByte(str1(2))) << 4
                Dim b3 As Integer = CInt(GetByte(str1(3))) << 6
                Dim b4 As Integer = CInt(GetByte(str1(4))) << 8
                Dim b5 As Integer = CInt(GetByte(str1(5))) << 10
                Dim b6 As Integer = CInt(GetByte(str1(6))) << 12
                Dim b7 As Integer = CInt(GetByte(str1(7))) << 14
                Dim sht As Int32 = b0 Or b1 Or b2 Or b3 Or b4 Or b5 Or b6 Or b7
                hash = sht
                str1 = str1.Substring(8)
                haspwd = True
            End If
            If str1.Length Mod 8 = 0 Then
                For i = 0 To str1.Length Step 8
                    If i = str1.Length Then
                        Exit For
                    End If
                    guarray.Add(str1.Substring(i, 8))
                Next
            Else
                Return "翻译失败咕"
            End If
            Dim strbulider As New StringBuilder
            Dim p As Int32
            For Each gua In guarray
                Dim b0 As Integer = CInt(GetByte(gua(0)))
                Dim b1 As Integer = CInt(GetByte(gua(1))) << 2
                Dim b2 As Integer = CInt(GetByte(gua(2))) << 4
                Dim b3 As Integer = CInt(GetByte(gua(3))) << 6
                Dim b4 As Integer = CInt(GetByte(gua(4))) << 8
                Dim b5 As Integer = CInt(GetByte(gua(5))) << 10
                Dim b6 As Integer = CInt(GetByte(gua(6))) << 12
                Dim b7 As Integer = CInt(GetByte(gua(7))) << 14
                Dim sht As Int32 = b0 Or b1 Or b2 Or b3 Or b4 Or b5 Or b6 Or b7
                If haspwd Then
                    strbulider.Append(Chr(sht Xor (Pwd(p).GetHashCode() And Short.MaxValue)))
                    p += 1
                    If Pwd.Length = p Then
                        p = 0
                    End If
                Else
                    strbulider.Append(Chr(sht))
                End If
            Next
            If ((strbulider.ToString().GetHashCode() And Short.MaxValue) = hash) Or Not (haspwd) Then
                Return strbulider.ToString()
            Else
                Return "密码不正确"
            End If
        Else
            Return "你这根本不是咕语吧咕咕"
        End If
        Return "翻译失败咕"
    End Function
    Public pjknx As New List(Of String)
    Public Function PojieGu(str0 As String) As String
        pjknx.Clear()
        Dim yuqip As Int64 = str0.Length * 20
        Dim yuqiq As Int64 = 0
        Dim po As Short = 0
        Dim words As Int32() = {0}
wa:
        If str0.StartsWith("咕~", StringComparison.CurrentCulture) Then
            Dim guarray As New List(Of String)
            Dim str1 As String = str0.Substring(2)
            Dim haspwd As Boolean = False
            Dim hash As Short = 0

            If str0.StartsWith("咕~咕咕咕", StringComparison.CurrentCulture) Then
                str1 = str1.Substring(3)
                Dim b0 As Integer = CInt(GetByte(str1(0)))
                Dim b1 As Integer = CInt(GetByte(str1(1))) << 2
                Dim b2 As Integer = CInt(GetByte(str1(2))) << 4
                Dim b3 As Integer = CInt(GetByte(str1(3))) << 6
                Dim b4 As Integer = CInt(GetByte(str1(4))) << 8
                Dim b5 As Integer = CInt(GetByte(str1(5))) << 10
                Dim b6 As Integer = CInt(GetByte(str1(6))) << 12
                Dim b7 As Integer = CInt(GetByte(str1(7))) << 14
                Dim sht As Int32 = b0 Or b1 Or b2 Or b3 Or b4 Or b5 Or b6 Or b7
                hash = sht
                str1 = str1.Substring(8)
                haspwd = True
            End If
            If str1.Length Mod 8 = 0 Then
                For i = 0 To str1.Length Step 8
                    If i = str1.Length Then
                        Exit For
                    End If
                    guarray.Add(str1.Substring(i, 8))
                Next
            Else
                Return "翻译失败咕"
            End If
            Dim strbulider As New StringBuilder
            Dim p As Int32
            For Each gua In guarray
                Dim b0 As Integer = CInt(GetByte(gua(0)))
                Dim b1 As Integer = CInt(GetByte(gua(1))) << 2
                Dim b2 As Integer = CInt(GetByte(gua(2))) << 4
                Dim b3 As Integer = CInt(GetByte(gua(3))) << 6
                Dim b4 As Integer = CInt(GetByte(gua(4))) << 8
                Dim b5 As Integer = CInt(GetByte(gua(5))) << 10
                Dim b6 As Integer = CInt(GetByte(gua(6))) << 12
                Dim b7 As Integer = CInt(GetByte(gua(7))) << 14
                Dim sht As Int32 = b0 Or b1 Or b2 Or b3 Or b4 Or b5 Or b6 Or b7
                If haspwd Then
                    strbulider.Append(Chr(sht Xor (words(p).GetHashCode() And Short.MaxValue)))
                    p += 1
                    If words.Length = p Then
                        p = 0
                    End If
                Else
                    strbulider.Append(Chr(sht))
                End If
            Next
            If ((strbulider.ToString().GetHashCode() And Short.MaxValue) = hash) Then
                yuqiq += 1
                If yuqiq = yuqip Then
                    Return Nothing
                End If
                If pjknx.Contains(strbulider.ToString()) Then
                Else
                    pjknx.Add(strbulider.ToString())
                End If
                strbulider.Clear()
                GoTo wa
            Else
                words(po) += 1
                For awewarwe = 0 To words.Length - 1
                    For i = 0 To words.Length - 1
                        If words(i) > Short.MaxValue Then
                            If i + 1 >= words.Length Then
                                ReDim Preserve words(i + 1)
                                words(i + 1) += 1
                            Else
                                words(i + 1) += 1
                            End If
                            words(i) = 0
                        End If
                    Next
                Next
                If words.Length > 50 Then
                    Return Nothing
                End If
                GoTo wa
            End If
        Else
            Return "翻译失败咕"
        End If
        Return "翻译失败咕"
    End Function
End Module
