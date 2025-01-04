<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="NK_PET_SHOP.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=5.0">
  <title>About Us</title>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>

  <!-- Navbar -->
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
    <a class="navbar-brand" href="#">About Us</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav ml-auto">
        <li class="nav-item">
          <a class="nav-link" href="homepage.aspx">Home</a>
        </li>
       
        <!-- Add more links as needed -->
      </ul>
    </div>
  </nav>

  <!-- About Section -->
  <div class="container mt-5">
    <div class="row">
      <div class="col-md-8 mx-auto">
        <h2 class="text-center mb-4">About Pet Shop Management System</h2>
        <p>This is a pet shop management system designed to streamline the process of managing a pet store. Our system includes features such as:</p>
        <ul>
              <li> Multi User Login</li>
          <li> Pet Inventory Management</li>
          <li>Food Product Inventory Management</li>
             <li> Pet Selling Management</li>
             <li>Food Product Selling Management</li>
          <li>Customer Management</li>
          <li>Billing System</li>
          <!-- Add more features as needed -->
        </ul>
        <p>Our team is dedicated to providing an efficient and user-friendly solution for pet shop owners to manage their business effectively.</p>
        <p>Designed by: Karan Karhe,Nandkumar Khomane</p>
         
      </div>
    </div>
  </div>

  <!-- Bootstrap JS -->
  <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.4/dist/umd/popper.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
</asp:Content>
