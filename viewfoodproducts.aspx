<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewfoodproducts.aspx.cs" Inherits="NK_PET_SHOP.viewfoodproducts" %>
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
                                <h4>Food Product Inventory List</h4>
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
                          <th scope="col">Food Product ID</th>
                          <th scope="col">Foood Product Name</th>
                          <th scope="col">Manufactoring Company Name</th>
                          <th scope="col">Manufactoring Date</th>
                          <th scope="col">Expiry Date</th>
                          <th scope="col">Better For</th>
                          <th scope="col">Price</th>
                          <th scope="col">Description</th>
                         
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
