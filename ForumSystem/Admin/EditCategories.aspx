<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" 
    Inherits="ForumSystem.Admin.EditCategories" %>

<asp:Content ID="ContentEditCategories" ContentPlaceHolderID="MainContent" runat="server">
   
     <div class="row">
        <div class="col-md-12">
            <h1>Edit Categories</h1>
        </div>

        <div class="col-md-12">
            <asp:GridView ID="GridViewCategories" runat="server" AutoGenerateColumns="false"
                AllowSorting="true" AllowPaging="true" PageSize="5" CssClass="gridview" 
                ItemType="ForumSystem.Models.Categories.EditCategoriesResponseModel" DataKeyNames="CategoryId"
                SelectMethod="GridViewCategories_GetData">
                <Columns>
                    <asp:BoundField DataField="CategoryName" 
                        HeaderText="Category Name" SortExpression="CategoryId" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButtonEdit" runat="server" CssClass="link-button"
                                Text="Edit" OnClick="LinkButtonEdit_Click"
                                CommandArgument="<%# Item.Id %>"
                                />
                            <asp:LinkButton ID="LinkButtonDelete" runat="server" CssClass="link-button"
                                Text="Delete" OnClick="LinkButtonDelete_Click"
                                CommandArgument="<%# Item.Id %>"
                                />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <div class="create-link">
                <asp:LinkButton ID="LinkButtonShowCreatePanel" runat="server" 
                    Text="Create New" CssClass="link-button"
                    OnClick="LinkButtonShowCreatePanel_Click" />
            </div>

            <asp:Panel ID="PanelDelete" runat="server" CssClass="panel" Visible="false">
                <h2>Confirm Category Deletion?</h2>
                <label>Category: <asp:TextBox runat="server" Text="Programming" ReadOnly="true" /></label>
                <asp:LinkButton ID="LinkButtonConfirmDelete" runat="server" 
                    Text="Yes" CssClass="link-button"
                    OnClick="LinkButtonConfirmDelete_Click" />
                <asp:LinkButton ID="LinkButtonCancelDelete" runat="server" 
                    Text="No" CssClass="link-button"
                    OnClick="LinkButtonCancelDelete_Click" />
            </asp:Panel>

            <asp:Panel ID="PanelEdit" runat="server" CssClass="panel" Visible="false">
                <h2>Edit Category</h2>
                <label>Category: <asp:TextBox runat="server" Text="Programming" /></label>
                <asp:LinkButton ID="LinkButtonEditSave" runat="server" 
                    Text="Save" CssClass="link-button"
                    OnClick="LinkButtonEditSave_Click" />
                <asp:LinkButton ID="LinkButtonCancelEdit" runat="server" 
                    Text="Cancel" CssClass="link-button"
                    OnClick="LinkButtonCancelEdit_Click" />
            </asp:Panel>

            <asp:Panel ID="PanelCreate" runat="server" CssClass="panel" Visible="false">
                <h2>Create New Category</h2>
                <label>Category: <asp:TextBox ID="TextBoxCategoryCreate" runat="server" 
                    placeholder="Enter category name..." /></label>
                <asp:LinkButton ID="LinkButtonCreate" runat="server"
                    Text="Create" CssClass="link-button"
                    OnClick="LinkButtonCreate_Click" />
                <asp:LinkButton ID="LinkButtonCancelCreate" runat="server"
                    Text="Cancel" CssClass="link-button"
                    OnClick="LinkButtonCancelCreate_Click" />
            </asp:Panel>

        </div>
    </div>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>

</asp:Content>
