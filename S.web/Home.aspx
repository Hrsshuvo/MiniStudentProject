<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="S.web.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-inverse">
      <a class="navbar-brand" href="#">
    <img src="https://mdbootstrap.com/img/logo/mdb-transparent.png" height="30" alt="mdb logo">
  </a>
  <div class="container-fluid">
    <ul class="nav navbar-nav">
      <li class="active"><a href="#">Home</a></li>
      
        <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Menu<span class="caret" aria-atomic="True"></span></a>
        <ul class="dropdown-menu">
          <input class="btn" type="text" value="Department" OnClick="window.open('Department.aspx')"">
             <input class="btn" type="text" value="Course" OnClick="window.open('Course.aspx')"">
            <input class="btn" type="text" value="Student" OnClick="window.open('Student.aspx')"">
                        <input class="btn" type="text" value="Student Info" OnClick="window.open('Info.aspx')"">

        </ul>
      </li>
        <li class="dropdown"><a class="dropdown-toggle" data-toggle="dropdown" href="#">Reports<span class="caret"></span></a>
        <ul class="dropdown-menu">
          <input class="btn" type="email" value="Department" OnClick="window.open('Department.aspx')"">
             <input class="btn" type="text" value="Course" OnClick="window.open('Course.aspx')"">
            <input class="btn" type="text" value="Student" OnClick="window.open('Student.aspx')"">
        </ul>
      </li>
    </ul>
  </div>
</nav>
        </div>
    </form>
</body>
</html>
