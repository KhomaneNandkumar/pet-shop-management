<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="petinventory.aspx.cs" Inherits="NK_PET_SHOP.petinventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
     $(document).ready(function () {
         $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
     });
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Pet Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="imgs/imgsbooks.png" />
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
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3">
                                <label>Pet ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Pet ID"></asp:TextBox>
                                        <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server" OnClick="Button4_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-9">
                                <label>Pet Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Pet Name"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Category</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Dog" Value="Dog" />
                                        <asp:ListItem Text="Cat" Value="Cat" />
                                        <asp:ListItem Text="Bird" Value="Bird" />
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Gender<asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Male" Value="Male" />
                                        <asp:ListItem Text="Female" Value="Female" />
                                    </asp:DropDownList>
                                </label>
                                &nbsp;<div class="form-group">
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Bread</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Bread"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                       
                        <div class="row">
                            <div class="col-md-4">
                                <label>Age</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Age" ></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Vaccinated</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Done" Value="Done" />
                                        <asp:ListItem Text="Not Done" Value="Not Done" />
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>No.Of.Prev.Owners</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" placeholder="No.Of.Prev.Owner"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                       
                        <div class="row">
                             <div class="col-md-4">
     <label>Surgery Done</label>
     <div class="form-group">
         <asp:DropDownList class="form-control" ID="DropDownList3" runat="server">
             <asp:ListItem Text="Select" Value="select" />
             <asp:ListItem Text="Yes" Value="Yes" />
             <asp:ListItem Text="No" Value="No" />
         </asp:DropDownList>
     </div>
 </div>
                            
                            <div class="col-md-4">
                                <label>Price</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Price"></asp:TextBox>
                                </div>
                            </div>
                            
                        </div>
                        
                       
                        <div class="row">
                            <div class="col-12">
                                <label>Pet Description</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Pet Description" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button1_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Update" OnClick="Button3_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button2_Click" />
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
                                    <h4>Pet Inventory List</h4>
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
                         <th scope="col">Pet ID</th>
                         <th scope="col">Pet Name</th>
                         <th scope="col">Category</th>
                         <th scope="col">Gender</th>
                         <th scope="col">Age</th>
                         <th scope="col">Bread</th>
                         <th scope="col">Price</th>
                 </tr>
             </thead>
             <tbody>
             </tbody>
         </table>

     </div>
 </div>
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        <div class="row">
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered"  ID="GridView1" runat="server" >   </asp:GridView>
                               
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ></asp:SqlDataSource>
                               
                            </div>
                        </div>



                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

