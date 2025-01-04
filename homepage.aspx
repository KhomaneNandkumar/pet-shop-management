<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="NK_PET_SHOP.homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/ownstylesheet2.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <division>
        <img src="imgs/home back (1).jpg" class="img-fluid" />
    </division>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Our Features</h2>
                        <p><b>Our 3 Primary Features -</b></p>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/imgs/digital-inventory.png" />
                        <h4>Digital Pets Inventory</h4>
                        <p class="text-justify">We provide an digital inventory to search easily improve more functinality of the system digital inventory helps to find pets and products</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/imgs/search-online.png" />
                        <h4>Search Pets and Food Products</h4>
                        <p class="text-justify">in this system user can easily able to find out their required pets and their food products. </p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/imgs/defaulters-list.png" />
                        <h4>Defaulter List</h4>
                        <p class="text-justify">we have an defaulter list to verify the user past performance on the system</p>
                    </center>
                </div>
            </div>
        </div>
    </section>
  
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Our Process</h2>
                        <p><b>We have a Simple 3 Step Process</b></p>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/imgs/sign-up.png" />
                        <h4>Sign Up</h4>
                        <p class="text-justify">After the successfully registration of new user they are give the livetime access of the syytem via sign up</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/imgs/search-online.png" />
                        <h4>Search Pets and Food</h4>
                        <p class="text-justify">in this system user can easily able to find out their required pets and their food products.</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                        <img width="150px" src="imgs/imgs/library.png" />
                        <h4>Visit Us</h4>
                        <p class="text-justify">once you likes the our work and functionalities we are requested to you visit again.</p>
                    </center>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
