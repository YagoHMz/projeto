// nome
// 4 notas + media final
// reprovado ou aprovado
// acaba o programa ao digitar 0 no "nome"
// media geral da turma
string? nome="a";
double[] nota = new double[4]; // notas
double media=0;
double media_turma=0;
int qtalunos=0;

while (nome != "0")
{
    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();

    if (nome == "0")
    {
        break;

    }
    for (int i = 0; i < nota.Length; i++)
    {
        Console.WriteLine("Digite a nota do " + (i + 1) + " bimestre");
        Double.TryParse(Console.ReadLine(), out nota[i]);
        media += nota[i];
    }

    media = media / 4;
    media_turma += media;
    qtalunos++;

    if(media>=6)
    {
        Console.WriteLine("Aluno aprovado");
    }
    else
    {
        Console.WriteLine("Aluno reprovado"); 

    }
    

}

media_turma = media_turma / qtalunos;
Console.WriteLine("Quantidade de Alunos: "+qtalunos);
Console.WriteLine("Média da turma: "+media_turma);