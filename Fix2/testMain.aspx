<%@ Page Title="" Language="vb" AutoEventWireup="True" MasterPageFile="~/Main.Master" CodeBehind="testMain.aspx.vb" Inherits="Fix2.testMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

    <div class="row">
      
        <div class="col-md-4">
            <h2>Getting Started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
    <h3>專長(多選)</h3>
	<div class="abgne-menu-20140101-2">
	    <input type="checkbox" id="jquery" name="skill" checked>
	    <label for="jquery">jQuery</label>
 
	    <input type="checkbox" id="css3" name="skill">
	    <label for="css3">CSS3</label>
 
	    <input type="checkbox" id="html5" name="skill">
	    <label for="html5">HTML5</label>
 
	    <input type="checkbox" id="angularjs" name="skill">
	    <label for="angularjs">AngularJS</label>
	</div>
</asp:Content>
