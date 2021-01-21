<%@ Page Language = "C#" Debug ="true"%>
<%@ Import Namespace = "System.Data.Odbc"%>
<%	
	Response.Write("<html> <body>");
	string errorMsg = "";
	bool errorFlag = false;
	OdbcConnection myconn;
	OdbcCommand mycmd;
	OdbcDataReader myreader;
	
	if(Request.Form["txtNum"] =="")
	{
		errorFlag = true;
		errorMsg = errorMsg + "Please fill in the item number! <br>";
	}
	if(Request.Form["txtName"] == "")
	{
		errorFlag = true;
		errorMsg = errorMsg + "Please fill in the item name! <br>";
	}
	if(Request.Form["txtPrice"] == "")
	{
		errorFlag = true;
		errorMsg = errorMsg + "Please fill in the item price! <br>";
	}
	if(Request.Form["txtQty"] == "")
	{
		errorFlag = true;
		errorMsg = errorMsg + "Please fill in the item quantity! <br>";
	}
	if(Request.Form["txtPic"] == "")
	{
		errorFlag = true;
		errorMsg = errorMsg + "Please fill the file name of the picture! <br>";
	}
	if(Request.Form["description"] == "") 
	{
		errorFlag = true;
		errorMsg = errorMsg + "Please fill in the description of the item! <br>";
	}
	if(errorFlag == true)
	{
		Response.Write(errorMsg);
	}
	else
	{
		myconn=new OdbcConnection (@"DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=c:\inetpub\wwwroot\2020\cd4132\company.accdb");
		mycmd = new OdbcCommand("Insert into Inventory values('" + Request.Form["txtNum"] + "' , '" + Request.Form["txtName"] + "' , '" + Request.Form["description"] + "' , '" + Request.Form["txtPrice"] + "' , '" + Request.Form["txtQty"] + "' , '" + Request.Form["txtPic"] + "')",myconn);
		myconn.Open();
		myreader = mycmd.ExecuteReader();
		myreader.Close();
		myconn.Close();
		Response.Write("Item Added!");
	}
%>
</body>
</html>