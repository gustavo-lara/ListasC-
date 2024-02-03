using Listas;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---TRABALHANDO COM LISTAS SIMPLES---\n\n");
        List<string> listaDeFrutas = new List<string>();

        Console.WriteLine("Adicionando itens na lista.");
        Console.WriteLine("Adicionando itens na lista..");
        Console.WriteLine("Adicionando itens na lista...\n");
        listaDeFrutas.Add("Banana");
        listaDeFrutas.Add("Maçã");
        listaDeFrutas.Add("Morango");
        listaDeFrutas.Add("Abacaxi");
        listaDeFrutas.Add("Manga Espada");

        Console.WriteLine("Lista de Frutas:");
        foreach (var fruta in listaDeFrutas)
        {
            Console.WriteLine($"{fruta}");
        }

        Console.WriteLine("\nExibindo itens específicos da lista:");
        Console.WriteLine(listaDeFrutas[1]);

        Console.WriteLine("\nInserindo item em posição específico na lista:");
        listaDeFrutas.Insert(3, "Laranja");

        Console.WriteLine("Nova lista de Frutas:");
        foreach (var fruta in listaDeFrutas)
        {
            Console.WriteLine($"{fruta}");
        }

        Console.WriteLine("\nAlterar itens da Lista:");
        listaDeFrutas[2] = "Melancia";

        Console.WriteLine("Exibindo item alterado da lista:");
        Console.WriteLine(listaDeFrutas[2]);

        Console.WriteLine("\nRemovendo item da lista de frutas por indice:");
        Console.WriteLine("Antes:");
        Console.WriteLine(listaDeFrutas[2]);
        Console.WriteLine("Depois:");
        listaDeFrutas.RemoveAt(2);
        Console.WriteLine(listaDeFrutas[2]);

        Console.WriteLine("\nRemovendo item da lista de frutas por valor:");
        Console.WriteLine("Antes:");
        foreach (var fruta in listaDeFrutas)
        {
            Console.WriteLine($"{fruta}");
        }
        listaDeFrutas.Remove("Banana");
        Console.WriteLine("\nDepois:");
        foreach (var fruta in listaDeFrutas)
        {
            Console.WriteLine($"{fruta}");
        }

        Console.WriteLine("\nRemovendo todos os itens da lista:");
        listaDeFrutas.Clear();
        foreach (var fruta in listaDeFrutas)
        {
            Console.WriteLine($"{fruta}");
        }

        Console.WriteLine("\n\n---TRABALHANDO COM LISTAS DE OBJETOS---\n\n");

        Aluno aluno1 = new Aluno("Jonh", "jonh@teste.com", 1111);
        Aluno aluno2 = new Aluno("Alice", "alice@teste.com", 2222);
        Aluno aluno3 = new Aluno("Gabriel", "gabriel@teste.com", 3333);

        List<Aluno> listaAlunos = new List<Aluno>();
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2);
        listaAlunos.Add(aluno3);

        Console.WriteLine("Imprimindo a lista de alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Email: {aluno.Email}, RM: {aluno.RM}");
        }

        Console.WriteLine("\nAlterando itens na lista...");
        listaAlunos[0].Nome = "Jonh da Silva";

        listaAlunos[1] = new Aluno("Maria da Silva", "mariadasilva@teste.com", 4444);

        Console.WriteLine("Imprimindo a lista de alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Email: {aluno.Email}, RM: {aluno.RM}");
        }

        Console.WriteLine("\nRemovendo itens da lista");
        listaAlunos.RemoveAt(1);

        Console.WriteLine("Imprimindo a lista de alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Email: {aluno.Email}, RM: {aluno.RM}");
        }

        listaAlunos.Remove(aluno3);
        Console.WriteLine("\nImprimindo a lista de alunos:");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Email: {aluno.Email}, RM: {aluno.RM}");
        }

        Console.WriteLine("\nRemovendo todos os itens da lista de alunos:");
        listaAlunos.Clear();

    }
}