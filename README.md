# MilhasParaKm
Receba uma medida em milhas e exiba seu equivalente em quilômetros. A medida em km é 1,609 vezes a medida em milhas.

  Console.Write("Entre com a medida (em milhas): ");
        double milhas = Convert.ToDouble(Console.ReadLine());

        double quilometros = milhas * 1.609;

        Console.WriteLine($"{quilometros:F3} Km");
