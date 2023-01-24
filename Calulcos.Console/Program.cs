using calculos;
Console.WriteLine(Math.Round(4.850, 1, MidpointRounding.ToEven));
Console.WriteLine(Math.Round(4.850, 1, MidpointRounding.AwayFromZero));

decimal valorComparar1 = ((decimal)1.3).Round(1);
decimal valorComparar2 = ((decimal)1.7).Round(1);
decimal valorComparar3 = ((decimal)4.8).Round(1);
decimal valorComparar4 = ((decimal)4.6).Round(1);
decimal valorComparar5 = ((decimal)4.9).Round(1);

decimal valor1 = ((decimal)1.333);
decimal valor2 = ((decimal)1.666);
decimal valor3 = ((decimal)4.850);
decimal valor4 = ((decimal)4.550);
decimal valor5 = ((decimal)4.850);


Console.WriteLine($"Valor Original: {valor1} : Valor Arredon.: {valor1.Round(1)} : espera-se: {valorComparar1} : {valorComparar1.Equals(valor1.Round(1))}");
Console.WriteLine($"Valor Original: {valor2} : Valor Arredon.: {valor2.Round(1)} : espera-se: {valorComparar2} : {valorComparar2.Equals(valor2.Round(1))}");
Console.WriteLine($"Valor Original: {valor3} : Valor Arredon.: {valor3.Round(1)} : espera-se: {valorComparar3} : {valorComparar3.Equals(valor3.Round(1))}");
Console.WriteLine($"Valor Original: {valor4} : Valor Arredon.: {valor4.Round(1)} : espera-se: {valorComparar4} : {valorComparar4.Equals(valor4.Round(1))}");
Console.WriteLine($"Valor Original: {valor5} : Valor Arredon.: {valor5.Round(1)} : espera-se: {valorComparar5} : {valorComparar5.Equals(valor5.Round(1))}");


