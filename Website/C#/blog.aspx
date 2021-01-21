<%@ Page language = "c#"%>
<html>
	<body>
	
	<%
		
		System.IO.StreamWriter outfile = new System.IO.StreamWriter(@"c:\inetpub\wwwroot\2020\cd4132\blog.html",true);
	
		bool errorFlag = false;
		string errorMsg = "";
	
		if(Request.Form["txtName"] == "")
		{
			errorFlag = true;
			errorMsg = errorMsg + "Please enter in your name! <br>";
		}
		if(Request.Form["txtEmail"] == "")
		{
			errorFlag = true;
			errorMsg = errorMsg + "Please enter in your email! <br>";
		}
		if(Request.Form["comments"] == "")
		{
			errorFlag = true;
			errorMsg = errorMsg + "Please leave a comment or complaint";
		}
	
		if(errorFlag == true)
		{
			Response.Write(errorMsg);
			outfile.Close();
		}
		else
		{
			outfile.WriteLine("<center>");
			outfile.WriteLine("--------------------------------------------------------<br>");
			outfile.WriteLine("Date of Post: " + DateTime.Now+"<br>");
			outfile.WriteLine("Name: " + Request.Form["txtName"]+"<br>");
			outfile.WriteLine("Email: " + Request.Form["txtEmail"]+"<br>");
			outfile.WriteLine("IPNumber: " + (HttpContext.Current.Request.ServerVariables["Remote_ADDR"]+"<br>"));
			outfile.WriteLine(Request.Form["comments"]+"<br>");
			outfile.WriteLine("</center>");
			outfile.Close();
			Response.Redirect("blog.html");
		}
	%>
		
	</body>
</html>