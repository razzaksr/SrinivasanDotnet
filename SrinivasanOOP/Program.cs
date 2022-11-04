using SrinivasanOOP;

Event eve1 = new Event();
eve1.eveId = 1; eve1.eveName = "Hackathon"; eve1.eveDate = DateTime.Parse("2022-10-10");
eve1.eveParts = new string[] {"Annamalai","Manoj","Rasheedha" };
eve1.eveWinner = "Rasheedha";

//Console.WriteLine(eve1.eveWinner+" "+eve1.eveId+" "+eve1.eveName+" "+eve1.eveParts+" "+eve1.eveDate);
Console.WriteLine(eve1);

Event eve2 = new Event(2100,"PPT",DateTime.Parse("2022-11-01"));
Console.WriteLine(eve2.eveWinner + " " + eve2.eveId + " " + eve2.eveName + " " + eve2.eveParts + " " + eve2.eveDate);
Event eve3 = new Event(2100, "PPT", new string[] { "Annamalai", "Manoj", "Rasheedha" }, DateTime.Parse("2022-11-01"),"Manoj");
Console.WriteLine(eve3.eveWinner + " " + eve3.eveId + " " + eve3.eveName + " " + eve3.eveParts + " " + eve3.eveDate);

