<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs"
    Inherits="ForumSystem.Admin.EditCategories" %>

<asp:Content ID="ContentEditCategories" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row jumbotron">
        <div class="col-md-12 text-center">
            <h1>Edit Categories</h1>
        </div>
    </div>
    <div class="row">
        <div class="col-md-18 col-offset-2">
            <asp:GridView ID="GridViewCategories" runat="server" AutoGenerateColumns="false"
                AllowSorting="true" AllowPaging="true" PageSize="5"
                CssClass="table table-striped table-bordered" RowStyle-CssClass="td" HeaderStyle-CssClass="th"
                ItemType="ForumSystem.Models.Category" DataKeyNames="Id"
                SelectMethod="GridViewCategories_GetData">
                <Columns>
                    <asp:BoundField DataField="Name"
                        HeaderText="Category Name" SortExpression="Id" />
                    <asp:BoundField DataField="Visibility"
                        HeaderText="Visibility" SortExpression="Visibility" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton runat="server" ID="LinkButtonEdit"
                                Text="Edit" CommandName="Edit" CssClass="btn btn-primary" />
                            <asp:LinkButton runat="server" ID="LinkButtonDelete"
                                Text="Delete" CommandName="Delete" CssClass="btn btn-danger" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:LinkButton runat="server" ID="LinkButtonEdit"
                                Text="Save" CommandName="Update" CssClass="btn btn-success" />
                            <asp:LinkButton runat="server" ID="LinkButtonDelete"
                                Text="Cancel" CommandName="Cancel" CssClass="btn btn-default" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <div class="create-link">
                <asp:LinkButton ID="LinkButtonShowCreatePanel" runat="server"
                    Text="Create New" CssClass="btn btn-primary"
                    OnClick="LinkButtonShowCreatePanel_Click" />
            </div>

        </div>
    </div>

</asp:Content>
