<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projecta._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Next Technology</h1>
        <p class="lead">This is a Website which provides services virtually for its customers ranging from PC and Electronic sale, laptop consultation and repaires.</p>
        <p><a href="/About" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Services We Offer</h2>
            <p>Next Technology Computer Shop offers a wide range of PC products including Laptops, Desktops printers and accessories. Whether it's basic home computer, Business system or Gaming machine we can build it.</p>
            <p>
                <a class="btn btn-default" href="/ProductList">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Our Difference</h2>
            <p>Run by computer enthusiasts, not just sales people.</p>
            <p>Excellent customer service</p>
            <p>Very competitive prices</p>
            <p>Quick turn around time</p>
            <p>
                <a class="btn btn-default" href="/About">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Products</h2>
            <p>
                Next Technology L.T.D Company offer best Products in the Cyprus.
            </p>
            <p>The company offer Desktops,Laptops,Mobile Phones and Tablets </p>
            <p>Big advantages for Second Hand Products.</p>
            <p>The Next Technology L.T.D offer Free Router and Switch Setups.</p>
            <p>
                <a class="btn btn-default" href="/ProductList">Learn more &raquo;</a>
            </p>
        </div>
    </div>
       
</asp:Content>