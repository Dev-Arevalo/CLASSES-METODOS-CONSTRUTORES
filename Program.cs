using METODOS.CURSOS;

Pessoa p1 = new Pessoa(nome:"Nathan Arevalo");//COM A CLASSE CONSTRUTOR
//p1.Nome = "franciele Messias"; "ESTÁ NO COMETÁRIO O FORMATO SEM A CLASSE CONSTRUTOR"

Pessoa p2 = new Pessoa(nome:"Franciele Messias");//COM A CLASSE CONSTRUTOR
// p2.Nome = "Nathan Arevalo"; "ESTÁ NO COMETÁRIO O FORMATO SEM A CLASSE CONSTRUTOR"

Pessoa CursoDeIngles = new Pessoa();
CursoDeIngles.Nome = "inglês";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();






