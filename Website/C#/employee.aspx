<%@ Page Language ="C#" Debug = "true"%>
<%@ Import Namespace = "System.Data.Odbc"%>

<%
	Response.Write("<html><head><title>EMPLOYEE ASP in C#</title></head><body>");
	
	//step1: Create ODBC Database connection,command, and datareader objects
	OdbcConnection myconn;
	OdbcCommand mycmd;
	OdbcDataReader myreader;
	
	//step2: connecting to a physical database using ODBC drivers for .mdb and .accdb files
	myconn= new OdbcConnection(@"DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=c:\inetpub\wwwroot\northwind.accdb");
	mycmd = new OdbcCommand("Select * from employees",myconn);
	Response.Write("<b>Data from the Names table in the Employees Access Database: C# Program</b><br>");
	
	//step3: Opening connection object and reader object(cursor in oracle)
	myconn.Open();
	myreader = mycmd.ExecuteReader();
	
	//step4: using a loop to go through the records in the reader(going through the cursor in oracle)
	
	 Response.Write("<table border = 1> <tr><td> ID </td><td> First Name</td><td> Last Name</td></tr>");
		
	while((myreader.Read()))
	{
		Response.Write("<tr>");
			Response.Write("<td>" + myreader["ID"] + "</td>");
			Response.Write("<td>" + myreader["First Name"] + "</td>");
			Response.Write("<td>" + myreader["Last Name"] + "</td>");
		Response.Write("</tr> <br>");
	
	}
	Response.Write("</table>");
	
	//step5: closing the reader and connection objects
	myreader.Close();
	myconn.Close();
	
%>
	<a href = "company.html"> Company's Homepage </a>
</body>
</html>