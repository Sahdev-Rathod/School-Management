<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMst.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="School_Management_System_Project.Admin.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-image:url('../image/pencil image.jpg'); width : 100%; height : 720px; background-repeat: no-repeat; background-size : cover; background-attachment : fixed;">
        <div class=" container p-md-4 p-sm-4">
            <div>
                <asp:Label ID="Msglbl" runat="server"></asp:Label>
            </div>
           <h2 class="text-center" style="margin-left:450px; position:absolute; top: 350px; font-size:40px;">Admin Home Page</h2>
        </div>
    </div>
</asp:Content>
