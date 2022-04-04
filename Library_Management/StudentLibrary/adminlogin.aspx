<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="StudentLibrary.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body" style="background-image:url('https://media.istockphoto.com/photos/abstract-background-picture-id1145178576?k=20&m=1145178576&s=612x612&w=0&h=DeOI8DQFyTr13lAl58sCHN2-rmEilVc_vUa4vppR3UU='); background-repeat: no-repeat; background-size: 1000px 1000px;">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="150px" src="imgs/adminuser.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Admin Login</h3>
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
                        <label>Admin ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Admin ID"></asp:TextBox>
                        </div>

                         <br />

                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>

                         <br />

                        <div class="form-group">
                           <asp:Button class="btn btn-dark btn-block btn-lg" ID="Button1" runat="server" type="button" Text="Login" OnClick="Button1_Click" />
                        </div>
                     </div>
                  </div>
               </div>
            </div>

             <br />

            <a href="homepage.aspx"> Back to Home </a><br><br>
         </div>
      </div>
   </div>
</asp:Content>
