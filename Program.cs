int INDICE = 13, SOMA = 0, K = 0;

for(K = 0; K < INDICE; K++)
{
    SOMA = SOMA + K;
}

Console.WriteLine($"{SOMA}");


/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.Write("Informe um número: ");
int numeroInserido = Convert.ToInt32(Console.ReadLine());
if (PertenceASequenciaFibonacci(numeroInserido))
{
    Console.WriteLine($"{numeroInserido} pertence à sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{numeroInserido} não pertence à sequência de Fibonacci.");
}

static bool PertenceASequenciaFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            if (a == numero)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

static string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray();
        int inicio = 0;
        int fim = str.Length - 1;

        while (inicio < fim)
        {
            // Troca os caracteres nas posições inicio e fim
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            // Move os índices para a próxima posição
            inicio++;
            fim--;
        }

        return new string(caracteres);
    }


Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        string resultadoInvertido = InverterString(entrada);

        Console.WriteLine($"String invertida: {resultadoInvertido}");
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



