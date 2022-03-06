﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="StudentLibrary.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <title> Signup Form </title>
    <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Rubik:400,700'>
    <link rel="stylesheet" href="./wwwroot/css/login.css">
    <link rel="stylesheet" href="./wwwroot/lib/twitter-bootstrap/css/bootstrap.min.css">
</head>
<body>
    <div class="signcontainer-fluid signbg" style="background-image: url('https://wallpaperaccess.com/full/3847372.jpg')">
      <div class="row justify-content-center text-white">
        <div class="col-xs-12 col-sm-6 col-md-3">
          <form class="signform-container" method="POST" runat="server">
          <h4 className="text-white text-center"> Signup</h4>
            <hr />
            <div class="text-white form-group">
              <label for="name" class="white">
                Name <sup>*</sup>
              </label>
              
                <asp:TextBox ID="nameText" runat="server" type="text"
                class="form-control"
                name="name"
                placeholder="name"
                autoComplete="off"
                required="true"></asp:TextBox>
              <span className="error_form" id="uname_error_message"></span>
            </div>
              <div class="form-group">
              <label class="email">
                email <sup>*</sup>
              </label>
                <asp:TextBox ID="emailText" runat="server" type="text"
                class="form-control"
                name="email"
                placeholder="email"
                autoComplete="off"
                required="true"></asp:TextBox>
              
            </div>
            <div class="form-group">
              <label for="password">
                Password <sup>*</sup>
              </label>
              <asp:TextBox ID="passText" runat="server"
                type="password"
                class="form-control"
                name="password"
                placeholder="Password"
                required="true"
              />
            </div>
            <asp:Button ID="Button1" runat="server" Text="Submit"  class="submitbtn"/>
            <p class="para" id="signup-link">
                Already have an account?
             <a href="Login.aspx">Login</a>
              here
            </p>
          </form>
        </div>
      </div>
    </div>
    </body>
</html>