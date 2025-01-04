<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminbilling.aspx.cs" Inherits="NK_PET_SHOP.adminbilling" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
         $(document).ready(function () {
             $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
         });
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-5">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <h3>Billing Information</h3>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h2>NK PET SHOP</h2>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5 mx-auto">
                            <center>
                                <label>Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                                </div>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3 mx-auto">
                            <label>Member ID</label>
                            <div class="form-group">
                                <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Member ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-7 mx-auto">
                            <label>Member Name</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Member Name" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3  mx-auto">
                            <label>Pet ID</label>
                            <div class="form-group">
                                <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Pet ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Go" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-7 mx-auto">
                            <label>Pet Name</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Pet Name" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3 mx-auto">
                            <label>Quantity</label>
                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="Quantity" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-7 mx-auto">
                            <label>Price</label>
                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="Price" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3 mx-auto">
                            <label>Food Product ID</label>
                            <div class="form-group">
                                <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Food Product ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary" ID="Button3" runat="server" Text="Go" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-7 mx-auto">
                            <label>Food Product Name</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Food Product Name" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3 mx-auto">
                            <label>Quantity</label>
                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="TextBox10" runat="server" placeholder="Quantity" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-7 mx-auto">
                            <label>Price</label>
                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="TextBox11" runat="server" placeholder="Price" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4 mx-auto">
                            <center>
                                <label>Grand Total Is</label>
                            </center>
                            <div class="form-group">
                                <asp:TextBox class="form-control" ID="TextBox2" runat="server" placeholder="Grand Total" TextMode="Number"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6 mx-auto">
                            <center>
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button4" runat="server" Text="Print" />
                                </div>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <center>
                                <h2><b>THANK YOU VISIT AGAIN!!!</b></h2>
                            </center>
                        </div>
                    </div>


                </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br>
            <br>
        </div>
        <div class="col-md-7">
            <div class="card">
                <div class="card-body">
                    <div class="row">
                        <div class="col">
                            <center>
                                <h4>Biiling List</h4>
                            </center>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <hr>
                        </div>
                    </div>
                      <div class="row">
      <div class="col">
          <asp:Table ID="Table1" runat="server"></asp:Table>
          <table class="table table-bordered">
              <thead>
                  <tr>
                      <th scope="col">
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                          Member ID</th>
                      <th scope="col">Member Name</th>
                      <th scope="col">Pet ID</th>
                      <th scope="col">Pet Name</th
                      <th scope="col">Quantity</th>
                       <th scope="col">Food Product ID</th>
                      <th scope="col">Food Product Name</th
                       <th scope="col">Quantity</th>
                       <th scope="col">Total Price</th>
                  </tr>
              </thead>
              <tbody>
              </tbody>
          </table>

      </div>
  </div>

                    
                    
                    
                    <div class="row">
                        <div class="col">
                            <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>

</asp:Content>

