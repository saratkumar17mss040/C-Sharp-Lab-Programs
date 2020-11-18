<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Navigate.aspx.cs" Inherits="Navigate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Navigation - 🧭</title>
    <style>

    body {
        margin: 0;
        padding: 0;
    }

    ul {
      list-style-type: none;
      margin: 0;
      padding: 0;
      background-color: black;
      overflow: hidden;
    }

    li {
      float: left;
    }

    li a {
      display: block;
      color: white;
      text-align: center;
      padding: 14px 16px;
      text-decoration: none;
    }

    li:hover {
        background-color: cornflowerblue;
    }

    
</style>
</head>
<body>
         <ul>
              <li><a runat="server" href="~/MyProfile.aspx">My relative Profile</a></li>
              <li><a href="https://github.com/saratkumar17mss040">My github Profile</a></li>
        </ul>
        <h1>Hello i am sarath ! 👨‍💻</h1>
        <p>A simple example for navigating both relative and absolute paths !</p>
</body>
</html>
