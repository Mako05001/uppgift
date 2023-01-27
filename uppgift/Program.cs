string[] S = { "Ja", "Nej", "Kanske", "Fråga mig igen", "Om du har tur", "Aldrig", "Tveksam", "Kanske inte","väldigt tveksamt", "Kan inte förutsäga nu"};
Random Sl = new Random();

string F = " ";

while (F != "a")    {
    Console.WriteLine("Skriv en fråga till Magic 8-ball");
    F = Console.ReadLine();

    if (F == "a") {
        break;
    }
    Console.WriteLine(S[Sl.Next(S.Length)]);
    Console.WriteLine();
}