Console.Write("Entre com a medida (em milhas): ");
double milhas = Convert.ToDouble(Console.ReadLine());

double quilometros = milhas * 1.609;

Console.WriteLine($"{quilometros:N3} Km");
