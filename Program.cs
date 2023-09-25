using escola;

do
{
	Console.Write("Digite nome: ");
	string nome = Console.ReadLine()!;
	Console.Write("Digite idade: ");
	int idade = Convert.ToInt16(Console.ReadLine());
	Console.Write("Digite RA: ");
	string ra = Console.ReadLine()!;
	Console.Write("Digite Np1: ");
	double np1 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Digite Np2: ");
	double np2 = Convert.ToDouble(Console.ReadLine());
	Console.Write("Digite Pim: ");
	double pim = Convert.ToDouble(Console.ReadLine());

	Aluno a1 = new Aluno();

	a1.nome = nome;
	a1.idade = idade;
	a1.ra = ra;

	a1.setNp1(np1);
	a1.setNp2(np2);
	a1.setPim(pim);

	a1.setMedia(np1,np2,pim);
	a1.setExame();
	a1.imprimir();

	Console.Write("Deseja continuar s/n ? ");
} while (Console.ReadLine() == (string) "s");
