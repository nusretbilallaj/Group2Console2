
using Group2Console2;

Console.WriteLine("Kolegji AAB");
//
// int rroga = 1200;
// string personi = "Brentian Mala";
// Console.WriteLine($"Personi {personi} e ka rrogen {rroga} EUR");
// //if (rroga<=500)
// //{
// //    Console.WriteLine("Rroge mesatara");
// //}
// //else if (rroga <= 1000)
// //{
// //    Console.WriteLine("Rroge e mire");
// //}
// //else
// //{
// //    Console.WriteLine("Rroge super i mirë");
// //}
//
//
// KalkuloRrogen(rroga);
//
//
// int rroga2 = 5000;
// KalkuloRrogen(rroga2);
// //if (rroga2<=500)
// //{
// //    Console.WriteLine("Rroge messatare!");
// //}
// //else if (rroga2 <= 100)
// //{
// //    Console.WriteLine("Rroge e mirë!");
// //}
// //else
// //{
// //    Console.WriteLine("Rroge super e mire!");
// //}
//
// void KalkuloRrogen(int rrogap)
// {
//     if (rrogap <= 500)
//     {
//         Console.WriteLine($"Rroga {rrogap} është rrogë messatare!");
//     }
//     else if (rrogap <= 100)
//     {
//         Console.WriteLine($"Rroga {rrogap} është rrogë e mirë!");
//     }
//     else
//     {
//         Console.WriteLine($"Rroga {rrogap} është rrogë super e mire!");
//     }
// }
//
// var punetoret = new List<string>();
// punetoret.Add("Shqipdon Bajrami");
// punetoret.Add("Ermal Abazi");
// punetoret.Add("Faton Sejdiu");
// punetoret.Add("Munker Tac");
// punetoret.Add("I Panjohur");
//
// Console.WriteLine("Lista e studenteve!");
// Console.WriteLine("--------------------");
// foreach (var punetori in punetoret)
// {
//     Console.WriteLine(punetori);
// }
// Console.WriteLine("--------------------");

Studenti studenti1=new Studenti("Munker","Tac",20,"Prishtine");
studenti1.Pershendete();
//studenti1.Emri="Munker";
//studenti1.Mbiemri="Tac";
//studenti1.Mosha=20;
//studenti1.Adresa="Prishtine";

Profesor profesori1= new Profesor("Leron","Berisha");
profesori1.Pershendete();