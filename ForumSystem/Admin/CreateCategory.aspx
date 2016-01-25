<%@ Page Title="Create Category" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="CreateCategory.aspx.cs"
    Inherits="ForumSystem.Admin.CreateCategory" %>

<asp:Content ID="ContentCreateCategory" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row jumbotron">
        <div class="col-md-12">
            <h1 class="text-center">Create Category</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-md-8 col-md-offset-2">
            <asp:Panel ID="PanelCreate" runat="server" CssClass="form-horizontal">
                <div class="form-group">
                    <label>Title</label>
                    <asp:TextBox ID="TextBoxCategoryTitle" runat="server"
                        placeholder="Enter category title ..."
                        CssClass="form-control" />
                </div>
                <div class="form-group">
                    <label>Visibility:</label>
                    <asp:DropDownList ID="DropDownVisibilities" runat="server"
                        DataTextField="Value" DataValueField="Key"
                        CssClass="form-control" />
                </div>
                <div class="text-center">
                    <asp:LinkButton ID="LinkButtonCreate" runat="server"
                        Text="Create" CssClass="btn btn-success"
                        OnClick="LinkButtonCreate_Click" />
                    <asp:LinkButton ID="LinkButtonClear" runat="server"
                        Text="Clear" CssClass="btn btn-default"
                        OnClick="LinkButtonClear_Click" />
                </div>
            </asp:Panel>
        </div>
    </div>

</asp:Content>
