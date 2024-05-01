using pilha_dinamica;

Livro cadastroLivro()
{
    Console.WriteLine("Digite o título do livro");
    return new(Console.ReadLine());
}

int menu()
{
    Console.Clear();
    Console.WriteLine("Menu Principal - pilha de livro");
    Console.WriteLine("Opções: ");
    Console.WriteLine("1- Inserir livro");
    Console.WriteLine("2- Remover livro");
    Console.WriteLine("3- Imprimir pilha");
    Console.WriteLine("4- Buscar livro");
    Console.WriteLine("0- Sair");
    Console.WriteLine("Informe a opção desejada: ");
    return int.Parse(Console.ReadLine());
}



PilhaLivro pilha = new PilhaLivro();
int opcao;
do
{    
    opcao = menu();

    switch (opcao)
    {
        case 1:
            pilha.push(cadastroLivro());
            break;
        case 2:
            pilha.pop();
            break;
        case 3:
            pilha.print();
            break;
        case 4: pilha.searchBook();
            break;
        case 0:
            Console.WriteLine("Programa encerrado!");
            break;
        default:
            Console.WriteLine("Opção inexistente!");
            break;
    }
} while (opcao != 0);