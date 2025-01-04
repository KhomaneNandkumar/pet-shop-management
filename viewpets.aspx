<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewpets.aspx.cs" Inherits="NK_PET_SHOP.viewpets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row mx-auto">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Pet Inventory List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row mx-auto">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row ">
                            <div class="col">
                                <asp:Table ID="Table1" runat="server"></asp:Table>
                                <table class="table table-bordered">
                                    <thead>
                                        <tr>
                                            <th scope="col">
                                                <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                                                <th scope="col">Pet ID</th>
                                                <th scope="col">Pet Name</th>
                                                <th scope="col">Category</th>
                                                <th scope="col">Gender</th>
                                                <th scope="col">Age</th>
                                                <th scope="col">Bread</th>
                                                <th scope="col">Vaccinatd</th>
                                                <th scope="col">No.Of.Prev.Owner</th>
                                                <th scope="col">Surgery Done</th>
                                                <th scope="col">Price</th<th scope="col">Price</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>




                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

