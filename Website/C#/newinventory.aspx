<%@ Page Language ="C#" Debug ="true"%>
<%@ Import Namespace ="System.Data.Odbc"%>
<%
	Response.Write("<html><head><title>Inventory</title></head><body><form name = 'form1' method = 'post'>");
	OdbcConnection myconn;
	OdbcCommand mycmd;
	OdbcDataReader myreader;
	string search = "";
	int qtyCount = 0;
	
	if(Request.Form["txtSearch"] == "")
	{
		Response.Write("Please Search for an item");
		
	}
	else
	{
		search = Request.Form["txtSearch"];
		myconn=new OdbcConnection (@"DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=c:\inetpub\wwwroot\2020\cd4132\company.accdb");
		// searches the inventory table for items the user inputs
		mycmd = new OdbcCommand("Select * from Inventory where itemName LIKE '%" + search + "%'", myconn);
	
	
	
		Response.Write("<b>Data from the Inventory table in the Company Database</b><br>");
	
		myconn.Open();
		myreader = mycmd.ExecuteReader();
	
		//Create table
		Response.Write("<center><table border =1> <tr> <td> Item Num</td><td> Name </td> <td> Description</td><td> Price</td><td> Quantity</td><td>Picture</td><td>Quantity Order</td></tr>");
		// displays the items that were searched for.
		while((myreader.Read()))
		{
			Response.Write("<tr>");
				Response.Write("<td>" + myreader["itemNum"] + "</td>");
				Response.Write("<td>" + myreader["itemName"] + "</td>");
				Response.Write("<td>" + myreader["description"] + "</td>");
				Response.Write("<td>$" + myreader["price"] + "</td>");
				Response.Write("<td>" + myreader["quantity"] + "</td>");
				Response.Write("<td> <img src = \"" + myreader["picture"] + "\"; width = 65; height = 65;><img></td>");
				Response.Write("<td> <input type = 'text' name = 'qty" + qtyCount.ToString() + "' size = 3> </td>");
			Response.Write("</tr> <br>");
			qtyCount = qtyCount + 1;
			
		}
	
		Response.Write("</table><br>");
		Response.Write("<input type = 'Submit' name = 'btnSubmit' size = 20> <input type = 'reset' name = 'btnReset' size = 20> </center><br>");
	
		myreader.Close();
		myconn.Close();
	}

%>
	<center><a href = "company.html"> Company's Homepage </a></center> 
	</form>
</body>
</html>