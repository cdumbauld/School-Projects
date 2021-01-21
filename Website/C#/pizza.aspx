<%@ Page language = "c#"%>
<html>
 <body>
 <%
  System.IO.StreamWriter myOutFile = new
  System.IO.StreamWriter(@"c:\inetpub\wwwroot\2020\cd4132\pizza.txt",true);
  
  string errorMsg ="";
  string confirmMsg = "";
  bool errorFlag = false;
  string topMsg ="Topping(s): ";
  int small = 5;
  int med = 10;
  int larg = 15;
  int top = 1; 
  int toptotal = 0;
  int total = 0;
  
  if(Request.Form["txtName"] == "")
  {
	  errorFlag = true;
	  errorMsg = errorMsg + "Please fill in your name <br>";
  }
  else
  {
		confirmMsg = confirmMsg + "Name: " + Request.Form["txtName"] + "<br>";
  }
  
  if(Request.Form["txtAddress"] =="")
  {
	  errorFlag = true;
	  errorMsg = errorMsg + "Please fill in your address <br>";
  }
  else
  {
  confirmMsg = confirmMsg + "Address: " + Request.Form["txtAddress"] + "<br>";
  }
  if((Request.Form["radSize"] != "small") && (Request.Form["radSize"] != "medium") && (Request.Form["radSize"] !="large"))
  {
	  errorFlag = true;
	  errorMsg = errorMsg + "Please select a pizza size <br>";
  }
  else
  {
	  confirmMsg = confirmMsg + "Size: " + Request.Form["radSize"] + "<br>";
  }
  if((Request.Form["radDeliv"] !="delivery") && (Request.Form["radDeliv"] != "pickUp"))
  {
		errorFlag = true;
		errorMsg = errorMsg + "Please select delivery or pickup <br>";
  }
  else
  {
		confirmMsg = confirmMsg + Request.Form["radDeliv"] + "<br>";
  }
  
  //calculate total
  if(Request.Form["chkCheese"] == "cheese")
  {
	  toptotal = toptotal + 1;
	  topMsg = topMsg + "Cheese ";
  }
  if(Request.Form["chkBacon"] == "bacon")
  {
	  toptotal = toptotal + 1;
	  topMsg = topMsg + "Bacon ";
  }
  if(Request.Form["chkPep"] == "pep")
  {
	  toptotal = toptotal + 1;
	  topMsg = topMsg + "Pepperonni ";
  }
  if(Request.Form["chkHawaiian"] == "hawaiian")
  {
	  toptotal = toptotal + 1;
	  topMsg = topMsg + "Hawaiian";
  }
  
  if(Request.Form["radSize"] =="small")
  {
	  total = small + toptotal;
	  confirmMsg = confirmMsg + "total: $" + total + "<br>";
  }
  else if(Request.Form["radSize"] == "medium")
  {
		total = med + toptotal;
		confirmMsg = confirmMsg + "total: $" + total + "<br>";
  }
  else if(Request.Form["radsize"] == "large")
  {
	  total = larg + toptotal;
	  confirmMsg = confirmMsg + "total: $" + total + "<br>";
  }
  
  if(errorFlag == true)
  {
	  Response.Write(errorMsg);
  }
  else
  {
	 confirmMsg = confirmMsg + topMsg;
	 Response.Write(confirmMsg);
	 myOutFile.WriteLine("Date of Order: " + DateTime.Now);
	 myOutFile.WriteLine("Name: " + Request.Form["txtName"]);
	 myOutFile.WriteLine("Address: " + Request.Form["txtAddress"]);
	 myOutFile.WriteLine("Size: " + Request.Form["radSize"]);
	 myOutFile.WriteLine(Request.Form["radDeliv"]);
	 myOutFile.WriteLine("Total: $" + total);
	 myOutFile.WriteLine(topMsg);
	 myOutFile.WriteLine("--------------------------------------------------------------------------------------------------------");
	 
  }
  myOutFile.Close();
  
  
  %>
 </body>
</html>