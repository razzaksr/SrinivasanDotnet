using SrinivasanBasic;

String myCrew = "Zealous";
string myTeam = "zealous";

String myOrg = new string("Zealous Tech Corp");
string myCompany = new string("CyberPlobia");

String[] hhh = new String[] { "Vikram", "Santhanam", "Ramakrishnan      " };

Console.WriteLine(myCrew);
Console.WriteLine(myTeam);
Console.WriteLine(myOrg);
Console.WriteLine(myCompany);

Console.WriteLine(myCrew.Length);
Console.WriteLine(myTeam[4]);

myOrg=String.Join('\n',hhh);

Console.WriteLine(myOrg);
Console.WriteLine(myOrg.Length);

myCompany=String.Concat(myTeam,myCompany);// immutable

Console.WriteLine(myCompany);

myCrew = myCrew.ToLower();
Console.WriteLine(String.Compare(myTeam, myCrew));

myOrg = myOrg.Trim();

Console.WriteLine(myOrg.Length);

Console.WriteLine(myCompany.Substring(4,10));
Console.WriteLine(myOrg.Substring(5, 6));


//JagMulCreate jm = new JagMulCreate();
//jm.born();
/*
JagMulSearch sear=new JagMulSearch();
int alpha = -1, beta = -1;
sear.linear(out alpha,out beta, "bejoy");
Console.WriteLine(alpha+" "+beta);

sear.linear(out alpha, out beta, "Dilli");
Console.WriteLine(alpha + " " + beta);

sear.linear(out alpha, out beta, "tina");
Console.WriteLine(alpha + " " + beta);
*/

/*
double[,] hai = { { 3.4, 9.1, 7.8 }, { 89.2, 4.5, 2.5 }, { 9.2, 4.6, 12.4 }, { 4.5, 8.9, 5.9 } };

JagMulSort st = new JagMulSort();
st.bubble(hai);
*/