
string RetornoOperador()
{
    Console.WriteLine("Digite um operador: +, -, *, /");
    string resposta = Console.ReadLine();
    switch (resposta)
    {
        case "+":

            break;
        
        case "-":
            break;
        
        case "*":
            break;
        
        case "/":
            break;

        default:
            Console.WriteLine("Não é um operador!");
            break;
    }

    return resposta;
}

float RetornarValor()
{

    Console.WriteLine("Digite um número: ");
    string texto1 = Console.ReadLine();
    float numeroEscolhido = 6f;
    bool valorValidado = float.TryParse(texto1, out numeroEscolhido);

    if (valorValidado== false)
    {
        Console.WriteLine("Valor Inválido!");
    }
    return numeroEscolhido;
}
void Calcular()
{
    float numero1 = RetornarValor();
    float numero2 = RetornarValor();
}
