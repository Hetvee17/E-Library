<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentLibrary.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Start WOWSlider.com HEAD section -->
     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>complete responsive book website design tutorial </title>

    <!-- font awesome cdn link  -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css">

    <!-- custom css file link  -->
    <link rel="stylesheet" href="WWWroot/css/StyleSheet1.css">
    
<!-- End WOWSlider.com HEAD section -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <!-- header section starts  -->

    <header>

        <a href="#" class="logo"><i class="fas fa-books"></i>Books </a>

        <div id="menu-bar" class="fas fa-bars"></div>

        <nav class="navbar">
            <a href="#home">home</a>
            <a href="/Login.aspx">SignUp</a>            
            <a href="#popular">Popular</a>
            <a href="#issue">Issue</a>
        </nav>

    </header>

    <!-- header section ends -->

    <!-- home section starts  -->

    <section class="home" id="home">

        <div class="content">
            <h3>Love Reading Books...!</h3>
            <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Voluptas accusamus tempore temporibus rem amet laudantium animi optio voluptatum. Natus obcaecati unde porro nostrum ipsam itaque impedit incidunt rem quisquam eos!</p>
            <a href="#" class="btn">Issue Now</a>
        </div>

        <div class="image">
            <img src="images/123.jpg" alt="">
        </div>

    </section>

    <!-- home section ends -->


    <!-- popular section starts  -->

    <section class="popular" id="popular">

        <h1 class="heading"> most <span>popular</span> Novels </h1>

        <div class="box-container">

            <div class="box">                
                <img src="images/b-1.jpg" alt="">
                <h3> Crime </h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <a href="#" class="btn">Issue now</a>
            </div>
            <div class="box">               
                <img src="images/b-2.jpg" alt="">
                <h3> Romantic </h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <a href="#" class="btn">Issue now</a>
            </div>
            <div class="box">                
                <img src="images/b-3.jpg" alt="">
                <h3>Horror</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <a href="#" class="btn">Issue now</a>
            </div>
            <div class="box">               
                <img src="images/b-4.jpg" alt="">
                <h3> Mystery </h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <a href="#" class="btn">Issue now</a>
            </div>
            <div class="box">            
                <img src="images/b-5.jpg" alt="">
                <h3>Scientific</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <a href="#" class="btn">Issue now</a>
            </div>
            <div class="box">
                <img src="images/b-6.jpg" alt="">
                <h3>Greek pizza</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <a href="#" class="btn">Issue now</a>
            </div>

        </div>

    </section>

    <!-- popular section ends -->

   

   

    <!-- Popular Author section starts  -->

    <section class="review" id="review">

        <h1 class="heading"> Popular <span>Authors</span> </h1>

        <div class="box-container">

            <div class="box">
                <img src="images/a-1.jpg" alt="">
                <h3>Stephen King</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti delectus, ducimus facere quod ratione vel laboriosam? Est, maxime rem. Itaque.</p>
            </div>
            <div class="box">
                <img src="images/a-2.jpg" alt="">
                <h3>Danielle Steel</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti delectus, ducimus facere quod ratione vel laboriosam? Est, maxime rem. Itaque.</p>
            </div>
            <div class="box">
                <img src="images/a-3.jpg" alt="">
                <h3>Ken Follett</h3>
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="far fa-star"></i>
                </div>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti delectus, ducimus facere quod ratione vel laboriosam? Est, maxime rem. Itaque.</p>
            </div>

        </div>

    </section>

    <!-- review section ends -->

    <!-- order section starts  -->

    <section class="order" id="order">

        <h1 class="heading"> <span>Issue</span> now </h1>

        <div class="row">
        
            <div class="image">
                <img src="images/books.png" alt="">
            </div>

            <form action="">

                <div class="inputBox">
                    <input type="text" placeholder="name">
                    <input type="email" placeholder="email">
                </div>

                <div class="inputBox">
                    <input type="number" placeholder="number">
                    <input type="text" placeholder="Book name">
                </div>

                <textarea placeholder="address" name="" id="" cols="30" rows="10"></textarea>

                <input type="submit" value="order now" class="btn">

            </form>

        </div>

    </section>

    <!-- order section ends -->



    <!-- scroll top button  -->
    <a href="#home" class="fas fa-angle-up" id="scroll-top"></a>

    <!-- loader  -->
    <div class="loader-container">
        <img src="images/loader.gif" alt="">
    </div>

    <!-- custom js file link  -->
    <script src="WWWroot/js/JavaScript.js"></script>

</asp:Content>
