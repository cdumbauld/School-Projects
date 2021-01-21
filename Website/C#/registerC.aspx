<%@ Page language = "c#"%>
<html>
 <body>
 <%
  System.IO.StreamWriter myOutFile = new
  System.IO.StreamWriter(@"c:\inetpub\wwwroot\2020\cd4132\registerFile.txt",true);
  
  
  
  string confirmMsg = "";
  string errorMsg = "";
  bool errorFlag = false;
  
  if(Request.Form["txtFname"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please Enter in your name!<br>";
  }
  else
  {
	confirmMsg = confirmMsg + "First Name: " + Request.Form["txtFname"] + "<br>";
  }
  
  if(Request.Form["txtLname"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please Enter in your last name! <br>";
  }	
  else
  {
	confirmMsg = confirmMsg + "Last Name: " + Request.Form["txtLname"] + "<br>";
  }
  
  if(Request.Form["txtAddress"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please enter in your address! <br>";
  }
  else 
  {
	confirmMsg = confirmMsg + "Address: " + Request.Form["txtAddress"] + "<br>";
  }
  
  if(Request.Form["state"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please select your state! <br>";
  }
  else
  {
	confirmMsg = confirmMsg + "State: " + Request.Form["state"] + "<br>";
  }
  
  if(Request.Form["txtCity"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please enter in your city! <br>";
  }
  else
  {
	confirmMsg = confirmMsg + "City: " + Request.Form["txtCity"] + "<br>";
  }
  
  if(Request.Form["txtZip"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please enter in your zip code! <br>";
  }
  else
  {
	confirmMsg = confirmMsg + "Zip: " + Request.Form["txtZip"] + "<br>";
  }
  
  if(Request.Form["txtEmail"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please enter in your email! <br>";
  }
  else
  {
	confirmMsg = confirmMsg + "Email: " + Request.Form["txtEmail"] + "<br>";
  }
  
  if(Request.Form["txtPassword"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please enter a password! <br>";
  }
  
  if(Request.Form["txtCpassword"] == "")
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please enter your password again! <br>";
  }
  
  if(Request.Form["txtPassword"] != Request.Form["txtCpassword"])
  {
	errorFlag = true;
	errorMsg = errorMsg + "Your Passwords do not match! <br>";
  }
  
  if((Request.Form["rdGender"] != "Male") && (Request.Form["rdGender"] != "Female") && (Request.Form["rdGender"] !="other"))
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please select your gender! <br>";
  }
  
  if((Request.Form["rdGender"]) == "other" && (Request.Form["txtOther"] == ""))
  {
	errorFlag = true;
	errorMsg = errorMsg + "Please type in your gender! <br>";
  }
  
  if(errorFlag == true)
  {
	Response.Write(errorMsg);
  }
  else
  {
	Response.Write(confirmMsg);
	myOutFile.WriteLine("Date of Registration " + DateTime.Now);
	myOutFile.WriteLine("First Name: " + Request.Form["txtFname"]);
	myOutFile.WriteLine("Last Name: " + Request.Form["txtLname"]);
	myOutFile.WriteLine("Address: " + Request.Form["txtAddress"] + " " + Request.Form["txtCity"] + " " + Request.Form["state"] + " ," + Request.Form["txtZip"]);
	myOutFile.WriteLine("Email: " + Request.Form["txtEmail"]);
	myOutFile.WriteLine("Password: " + Request.Form["txtPassword"]);
	
	if(Request.Form["rdGender"] == "other")
	{
		myOutFile.WriteLine("Gender: " + Request.Form["txtOther"]);
	}
	else
	{
		myOutFile.WriteLine("Gender: " + Request.Form["rdGender"]);
	}
	myOutFile.WriteLine("--------------------------------------------------------------------------------------------------------");
  }
  
  myOutFile.Close();

 
 %>
 
 </body>
</html>

