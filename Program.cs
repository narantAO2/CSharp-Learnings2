class Program
{
    public static void Main(string[] args)
    {
        String texto = "1 - condicional \n 2 - FOR \n 3 - while \n 4 - foreach \n";
        int op = 0;

        do
        {
            Console.WriteLine(texto + "\n Digite um opção");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Condicional FOR");
                    break;
                case 2:
                    Console.WriteLine("Digite quantos numeros deseja visualizar");
                    int qtd = int.Parse(Console.ReadLine());
                    for (int i = 0; i < qtd; i++)
                    {
                        Console.WriteLine(" " + (1+i));
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    string valor = "A";
                    while(valor != "sim")
                    {
                        Console.WriteLine("A impressão será repetida até receber sim \nDigite um testo: ");
                        valor = Console.ReadLine();
                    }

                    break;
                case 4:
                    List<int> num = new() { 0, 1, 1, 5, 8, 13};
                    foreach (int item in num)
                    {
                        Console.WriteLine("O número é: " + item);
                    }
                    break;

            }
        } while (op != 0);
    }
}