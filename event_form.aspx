<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="event_form.aspx.cs" Inherits="practical_4_114.event_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event Form</title>
</head>
<body>
    <form id="form1" runat="server">
       <table border="1">
            <tr>
                <td colspan="2">Student Event Registration</td>
            </tr>
            <tr>
                <td>Student Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enrollment No</td>
                <td>
                    <asp:TextBox ID="txtEnrollment" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Branch</td>
                <td>
                    <asp:DropDownList ID="ddlBranch" runat="server">
                        <asp:ListItem>Select Branch</asp:ListItem>
                        <asp:ListItem>Computer Engineering</asp:ListItem>
                        <asp:ListItem>IT</asp:ListItem>
                        <asp:ListItem>Mechanical</asp:ListItem>
                        <asp:ListItem>Civil</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
             <tr>
                <td>Event</td>
                <td>
                    <asp:DropDownList ID="ddlEvent" runat="server">
                        <asp:ListItem>Select Event</asp:ListItem>
                        <asp:ListItem>Hackathon</asp:ListItem>
                        <asp:ListItem>Quiz</asp:ListItem>
                        <asp:ListItem>Coding Competition</asp:ListItem>
                        <asp:ListItem>Project Exhibition</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButton ID="rbMale" runat="server"
                        Text="Male" GroupName="Gender" />

                    <asp:RadioButton ID="rbFemale" runat="server"
                        Text="Female" GroupName="Gender" />

                    <asp:RadioButton ID="rbOther" runat="server"
                        Text="Other" GroupName="Gender" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server"
                        Text="Submit"
    OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>