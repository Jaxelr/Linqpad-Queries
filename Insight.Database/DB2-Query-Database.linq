<Query Kind="Program">
  <NuGetReference>IBM.Data.DB2</NuGetReference>
  <NuGetReference>Insight.Database</NuGetReference>
  <NuGetReference>Insight.Database.Providers.DB2</NuGetReference>
  <Namespace>IBM.Data.DB2</Namespace>
  <Namespace>Insight.Database</Namespace>
</Query>

//Query DB2 using Insight.Database.

void Main()
{
	var conn = new DB2Connection(connstring);
	var resp = conn.QuerySql<Response>("SELECT DISTINCT TCL_TYPE_CODE AS Code, TCL_TYPE_DESC AS Desc FROM TCL_TYPE_CD_LOOKUP");
	
	resp.Dump("TCL Codes");
}

// Define other methods and classes here
string connstring = "Database=HSCRP;Server=10.31.1.68:60016;UserID=appsuid;Password=Comp1ete4you;CurrentSchema=HS";

class Response
{ 
	public string Code { get; set; }
	public string Desc { get; set; }
}