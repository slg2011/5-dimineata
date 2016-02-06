<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="proiectBaze.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;ADMINISTRATORI<br />
        <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource8">
            <Columns>
                <asp:BoundField DataField="id_admin" HeaderText="id_admin" SortExpression="id_admin" />
                <asp:BoundField DataField="Nume" HeaderText="Nume" SortExpression="Nume" />
                <asp:BoundField DataField="Prenume" HeaderText="Prenume" SortExpression="Prenume" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource8" runat="server" SelectMethod="GetAdmin" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        <br />
        LOG IN<asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="parola" HeaderText="parola" SortExpression="parola" />
                <asp:BoundField DataField="permis" HeaderText="permis" SortExpression="permis" />
            </Columns>
        </asp:GridView>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetUsers" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        <br />
        PROFESORI</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="id_prof" HeaderText="id_prof" SortExpression="id_prof" />
                <asp:BoundField DataField="Nume" HeaderText="Nume" SortExpression="Nume" />
                <asp:BoundField DataField="Prenume" HeaderText="Prenume" SortExpression="Prenume" />
                <asp:BoundField DataField="Telefon" HeaderText="Telefon" SortExpression="Telefon" />
                <asp:BoundField DataField="Departament" HeaderText="Departament" SortExpression="Departament" />
                <asp:BoundField DataField="Statut" HeaderText="Statut" SortExpression="Statut" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="Tip" HeaderText="Tip" SortExpression="Tip" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetProfesori" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        <br />
        STUDENTI<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3">
            <Columns>
                <asp:BoundField DataField="id_stud" HeaderText="id_stud" SortExpression="id_stud" />
                <asp:BoundField DataField="Nume" HeaderText="Nume" SortExpression="Nume" />
                <asp:BoundField DataField="Prenume" HeaderText="Prenume" SortExpression="Prenume" />
                <asp:BoundField DataField="Initiala_Parinte" HeaderText="Initiala_Parinte" SortExpression="Initiala_Parinte" />
                <asp:BoundField DataField="CNP" HeaderText="CNP" SortExpression="CNP" />
                <asp:BoundField DataField="Adresa" HeaderText="Adresa" SortExpression="Adresa" />
                <asp:BoundField DataField="Telefon" HeaderText="Telefon" SortExpression="Telefon" />
                <asp:BoundField DataField="Tip" HeaderText="Tip" SortExpression="Tip" />
                <asp:BoundField DataField="Taxa" HeaderText="Taxa" SortExpression="Taxa" />
                <asp:BoundField DataField="nume_grupa" HeaderText="nume_grupa" SortExpression="nume_grupa" />
                <asp:BoundField DataField="Credite" HeaderText="Credite" SortExpression="Credite" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetStudent" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        <br />
        GRUPA<asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource4">
            <Columns>
                <asp:BoundField DataField="id_grupa" HeaderText="id_grupa" SortExpression="id_grupa" />
                <asp:BoundField DataField="nume_grupa" HeaderText="nume_grupa" SortExpression="nume_grupa" />
                <asp:BoundField DataField="an" HeaderText="an" SortExpression="an" />
                <asp:BoundField DataField="nr_std" HeaderText="nr_std" SortExpression="nr_std" />
                <asp:BoundField DataField="indrumator" HeaderText="indrumator" SortExpression="indrumator" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetGrupe" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        <br />
        NOTE<asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource5">
            <Columns>
                <asp:BoundField DataField="nota" HeaderText="nota" SortExpression="nota" />
                <asp:BoundField DataField="nr_credite" HeaderText="nr_credite" SortExpression="nr_credite" />
                <asp:BoundField DataField="id_disc" HeaderText="id_disc" SortExpression="id_disc" />
                <asp:BoundField DataField="id_stud" HeaderText="id_stud" SortExpression="id_stud" />
                <asp:BoundField DataField="id_prof" HeaderText="id_prof" SortExpression="id_prof" />
                <asp:BoundField DataField="forma" HeaderText="forma" SortExpression="forma" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="GetNote" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        <br />
        DISCIPLINA<asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource6">
            <Columns>
                <asp:BoundField DataField="id_disc" HeaderText="id_disc" SortExpression="id_disc" />
                <asp:BoundField DataField="Denumire" HeaderText="Denumire" SortExpression="Denumire" />
                <asp:BoundField DataField="Nr_credite" HeaderText="Nr_credite" SortExpression="Nr_credite" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetDisciplina" TypeName="DataLayer.Data"></asp:ObjectDataSource>
        PROF_DATE<br />
        <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource7">
            <Columns>
                <asp:BoundField DataField="id_prof" HeaderText="id_prof" SortExpression="id_prof" />
                <asp:BoundField DataField="id_grupa" HeaderText="id_grupa" SortExpression="id_grupa" />
                <asp:BoundField DataField="id_disc" HeaderText="id_disc" SortExpression="id_disc" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource7" runat="server" SelectMethod="GetDateProf" TypeName="DataLayer.Data"></asp:ObjectDataSource>
    </form>
    </body>
</html>
