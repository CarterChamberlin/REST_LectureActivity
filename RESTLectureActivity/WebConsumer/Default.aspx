<%@ Page Title="Home: " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebConsumer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>REST Web Service: Login & Password Generator</h2>
        <br />
    </div>

    <asp:Panel runat="server" ID="userInput" CssClass="jumbotron">
        <h3>User Input</h3>
        <p>First Name:
            <asp:TextBox ID="FIRST" runat="server" Width="400px"></asp:TextBox>
        </p>
        <p>Last Name:
            <asp:TextBox ID="LAST" runat="server" Width="400px"></asp:TextBox>
        </p>
        <p>Age:
            <asp:TextBox ID="AGE" runat="server" Width="400px"></asp:TextBox>
        </p>
        <asp:Button ID="SUBMIT" runat="server" OnClick="SUBMIT_Click" Text="Submit" />
    </asp:Panel>

    <asp:Panel runat="server" ID="programOutput" CssClass="jumbotron">
        <h3>Program Output</h3>
        <p>Login ID:
            <asp:TextBox ID="LOGINID" runat="server" Width="400px"></asp:TextBox>
        </p>
        <p>Password:
            <asp:TextBox ID="PASSWORD" runat="server" Width="400px"></asp:TextBox>
        </p>
    </asp:Panel>


</asp:Content>
