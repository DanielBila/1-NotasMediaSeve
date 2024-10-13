using _1_NotasMediaSeve;

namespace NotasMediaSeve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teste;
            Notas nota = new Notas();
            Console.WriteLine("Qual seria o nome do Estudande:");
            string nome = Console.ReadLine();
            Console.WriteLine("Coloque as Três Notas:");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());
            double media = nota.Medias(nota1, nota2, nota3);
            Console.WriteLine($"A media do Estudante {nome} é {media.ToString("F2")}");
            Console.WriteLine($"O estudante {nome} foi {nota.Aprovado}");
            Console.WriteLine($"Faltou {nota.Faltou.ToString("F2")} pontos para ser Aprovado");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("NOME---MEDIA---STATUS");
            Console.WriteLine($"{nome}   {media}   {nota.Aprovado}");
            Console.WriteLine("Deseja Salvar este Aluno");
            Console.WriteLine("1-Sim");
            Console.WriteLine("2-Não");
            int salvarOuNão = int.Parse(Console.ReadLine());
            //Sim
            if (salvarOuNão == 1)
            {
                nota.NomeAlunoUm = nome;
                nota.NotasUm = media;
                nota.AlunoProvadoUm = nota.Aprovado;
                nota.VerificadoUm = true;
                Console.Clear();
                Console.WriteLine("Aluno Salvo");
                Task.Delay(1000).Wait();

            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Aluno não salvo");
                Task.Delay(1000).Wait();
            }
            // Loop
            bool loop = true;
            while (loop)
            {   
                Console.Clear();
                Console.WriteLine("1-Adicionar mais Alunos");
                Console.WriteLine("2-Verificar Alunos Salvos");
                Console.WriteLine("3-Excluir Aluno Salvo");
                Console.WriteLine("4-Sair");
                int adicionarVerificar = int.Parse(Console.ReadLine());
                //Adicionar
                if (adicionarVerificar == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Qual seria o nome do Estudande:");
                    nome = Console.ReadLine();
                    Console.WriteLine("Coloque as Três Notas:");
                    nota1 = double.Parse(Console.ReadLine());
                    nota2 = double.Parse(Console.ReadLine());
                    nota3 = double.Parse(Console.ReadLine());
                    media = nota.Medias(nota1, nota2, nota3);
                    Console.WriteLine($"A media do Estudante {nome} é {media.ToString("F2")}");
                    Console.WriteLine($"O estudante {nome} foi {nota.Aprovado}");
                    Console.WriteLine($"Faltou {nota.Faltou.ToString("F2")} pontos para ser Aprovado");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("NOME---MEDIA---STATUS");
                    Console.WriteLine($"{nome}   {media}   {nota.Aprovado}");
                    Console.WriteLine("Deseja Salvar este Aluno");
                    Console.WriteLine("1-Sim");
                    Console.WriteLine("2-Não");
                    salvarOuNão = int.Parse(Console.ReadLine());
                    //Sim
                    if (salvarOuNão == 1)
                    {   //Primero Ocupado
                        if (nota.VerificadoUm == true && nota.VerificadoDois == false) 
                        {
                            nota.NomeAlunoDois = nome;
                            nota.NotasDois = media;
                            nota.AlunoProvadoDois = nota.Aprovado;
                            nota.VerificadoDois = true;
                            Console.Clear();
                            Console.WriteLine("Aluno Salvo");
                            Task.Delay(1000).Wait();
                        }
                        //Primero Liver
                        else if(nota.VerificadoUm == false)
                        {
                            nota.NomeAlunoUm = nome;
                            nota.NotasUm = media;
                            nota.AlunoProvadoUm = nota.Aprovado;
                            nota.VerificadoUm = true;
                            Console.Clear();
                            Console.WriteLine("Aluno Salvo");
                            Task.Delay(1000).Wait();
                        }
                        //Segundo Ocupado
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == false)
                        {
                            nota.NomeAlunoTres = nome;
                            nota.NotasTres = media;
                            nota.AlunoProvadoTres = nota.Aprovado;
                            nota.VerificadoTres = true;
                            Console.Clear();
                            Console.WriteLine("Aluno Salvo");
                            Task.Delay(1000).Wait();
                        }
                        //Tresero Ocupado
                        else if (nota.VerificadoTres == true && nota.VerificadoQuatro == false)
                        {
                            nota.NomeAlunoQuatro = nome;
                            nota.NotasQuatro = media;
                            nota.AlunoProvadoQuatro = nota.Aprovado;
                            nota.VerificadoQuatro = true;
                            Console.Clear();
                            Console.WriteLine("Aluno Salvo");
                            Task.Delay(1000).Wait();
                        }
                        //Quato Ocupado
                        else if (nota.VerificadoQuatro == true && nota.VerificadoCinco == false)
                        {
                            nota.NomeAlunoCinco = nome;
                            nota.NotasCinco = media;
                            nota.AlunoProvadoCinco = nota.Aprovado;
                            nota.VerificadoCinco = true;
                            Console.Clear();
                            Console.WriteLine("Aluno Salvo");
                            Task.Delay(1000).Wait();
                        }
                        //Cinto Ocupado
                        else if (nota.VerificadoCinco == true )
                        {
                            Console.WriteLine("Erro Acabou a memoria");
                            Task.Delay(1000).Wait();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Aluno não salvo");
                        Task.Delay(1000).Wait();
                    }
                }
                if(adicionarVerificar == 2)
                {
                    Console.Clear();
                    Console.WriteLine(nota);
                    Console.ReadLine();
                }
                if (adicionarVerificar == 3)
                {
                    Console.Clear();
                    Console.WriteLine(nota);
                    Console.WriteLine("Digite o Numero do Aluno Que irar ser Deletado:");
                    int numeroExcluidoAluno = int.Parse(Console.ReadLine());
                    // Excluido 1
                    if (numeroExcluidoAluno == 1)
                    {   //Eslote cheio
                        if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true && nota.VerificadoCinco == true)
                        {   //Eslote 1 
                            nota.NomeAlunoUm = nota.NomeAlunoDois;
                            nota.NotasUm = nota.NotasDois;
                            nota.AlunoProvadoUm = nota.AlunoProvadoUm;
                            nota.VerificadoUm = true;
                            //Eslote 2
                            nota.NomeAlunoDois = nota.NomeAlunoTres;
                            nota.NotasDois = nota.NotasTres;
                            nota.AlunoProvadoDois = nota.AlunoProvadoTres;
                            //Eslote 3 
                            nota.NomeAlunoTres = nota.NomeAlunoQuatro;
                            nota.NotasTres = nota.NotasQuatro;
                            nota.AlunoProvadoTres = nota.AlunoProvadoQuatro;
                            //Eslote 4
                            nota.NomeAlunoQuatro = nota.NomeAlunoCinco;
                            nota.NotasQuatro = nota.NotasCinco;
                            nota.AlunoProvadoQuatro = nota.AlunoProvadoCinco;
                            //eslote 5
                            nota.NomeAlunoCinco = string.Empty;
                            nota.NotasCinco = 0;
                            nota.AlunoProvadoCinco = string.Empty;
                            nota.VerificadoCinco = false;

                        }
                        //4 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true)
                        {   //Eslote 1 
                            nota.NomeAlunoUm = nota.NomeAlunoDois;
                            nota.NotasUm = nota.NotasDois;
                            nota.AlunoProvadoUm = nota.AlunoProvadoUm;
                            nota.VerificadoUm = true;
                            //Eslote 2
                            nota.NomeAlunoDois = nota.NomeAlunoTres;
                            nota.NotasDois = nota.NotasTres;
                            nota.AlunoProvadoDois = nota.AlunoProvadoTres;
                            //Eslote 3 
                            nota.NomeAlunoTres = nota.NomeAlunoQuatro;
                            nota.NotasTres = nota.NotasQuatro;
                            nota.AlunoProvadoTres = nota.AlunoProvadoQuatro;
                            //Eslote 4
                            nota.NomeAlunoQuatro = string.Empty;
                            nota.NotasQuatro = 0;
                            nota.AlunoProvadoQuatro = string.Empty;
                            nota.VerificadoQuatro = false;
                        }
                        //3 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true)
                        {   //Eslote 1 
                            nota.NomeAlunoUm = nota.NomeAlunoDois;
                            nota.NotasUm = nota.NotasDois;
                            nota.AlunoProvadoUm = nota.AlunoProvadoUm;
                            nota.VerificadoUm = true;
                            //Eslote 2
                            nota.NomeAlunoDois = nota.NomeAlunoTres;
                            nota.NotasDois = nota.NotasTres;
                            nota.AlunoProvadoDois = nota.AlunoProvadoTres;
                            //Eslote 3 
                            nota.NomeAlunoTres = string.Empty;
                            nota.NotasTres = 0;
                            nota.AlunoProvadoTres = string.Empty;
                            nota.VerificadoTres = false;
                        }
                        //2 pessoas salva ----to casnsado socorro
                        else if (nota.VerificadoDois == true)
                        {   //Eslote 1 
                            nota.NomeAlunoUm = nota.NomeAlunoDois;
                            nota.NotasUm = nota.NotasDois;
                            nota.AlunoProvadoUm = nota.AlunoProvadoUm;
                            nota.VerificadoUm = true;
                            //Eslote 2
                            nota.NomeAlunoDois = string.Empty;
                            nota.NotasDois = 0;
                            nota.AlunoProvadoDois = string.Empty;
                            nota.VerificadoDois = false;
                        }
                        else if (nota.VerificadoUm == true)
                        {
                            nota.NomeAlunoUm = string.Empty;
                            nota.NotasUm = 0;
                            nota.AlunoProvadoUm = string.Empty;
                            nota.VerificadoUm = false;
                        }
                    }
                    else if (numeroExcluidoAluno == 2)
                    {   //Eslote cheio
                        if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true && nota.VerificadoCinco == true)
                        {
                            //Eslote 2
                            nota.NomeAlunoDois = nota.NomeAlunoTres;
                            nota.NotasDois = nota.NotasTres;
                            nota.AlunoProvadoDois = nota.AlunoProvadoTres;
                            //Eslote 3 
                            nota.NomeAlunoTres = nota.NomeAlunoQuatro;
                            nota.NotasTres = nota.NotasQuatro;
                            nota.AlunoProvadoTres = nota.AlunoProvadoQuatro;
                            //Eslote 4
                            nota.NomeAlunoQuatro = nota.NomeAlunoCinco;
                            nota.NotasQuatro = nota.NotasCinco;
                            nota.AlunoProvadoQuatro = nota.AlunoProvadoCinco;
                            //eslote 5
                            nota.NomeAlunoCinco = string.Empty;
                            nota.NotasCinco = 0;
                            nota.AlunoProvadoCinco = string.Empty;
                            nota.VerificadoCinco = false;

                        }
                        //4 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true)
                        {
                            //Eslote 2
                            nota.NomeAlunoDois = nota.NomeAlunoTres;
                            nota.NotasDois = nota.NotasTres;
                            nota.AlunoProvadoDois = nota.AlunoProvadoTres;
                            //Eslote 3 
                            nota.NomeAlunoTres = nota.NomeAlunoQuatro;
                            nota.NotasTres = nota.NotasQuatro;
                            nota.AlunoProvadoTres = nota.AlunoProvadoQuatro;
                            //Eslote 4
                            nota.NomeAlunoQuatro = string.Empty;
                            nota.NotasQuatro = 0;
                            nota.AlunoProvadoQuatro = string.Empty;
                            nota.VerificadoQuatro = false;
                        }
                        //3 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true)
                        {
                            //Eslote 2
                            nota.NomeAlunoDois = nota.NomeAlunoTres;
                            nota.NotasDois = nota.NotasTres;
                            nota.AlunoProvadoDois = nota.AlunoProvadoTres;
                            //Eslote 3 
                            nota.NomeAlunoTres = string.Empty;
                            nota.NotasTres = 0;
                            nota.AlunoProvadoTres = string.Empty;
                            nota.VerificadoTres = false;
                        }
                        //2 pessoas salva 
                        else if (nota.VerificadoDois == true)
                        {
                            //Eslote 2
                            nota.NomeAlunoDois = string.Empty;
                            nota.NotasDois = 0;
                            nota.AlunoProvadoDois = string.Empty;
                            nota.VerificadoDois = false;
                        }
                    }
                    // Aluno excluido 3
                    else if (numeroExcluidoAluno == 3)
                    {   //Eslote cheio
                        if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true && nota.VerificadoCinco == true)
                        {
                            //Eslote 3 
                            nota.NomeAlunoTres = nota.NomeAlunoQuatro;
                            nota.NotasTres = nota.NotasQuatro;
                            nota.AlunoProvadoTres = nota.AlunoProvadoQuatro;
                            //Eslote 4
                            nota.NomeAlunoQuatro = nota.NomeAlunoCinco;
                            nota.NotasQuatro = nota.NotasCinco;
                            nota.AlunoProvadoQuatro = nota.AlunoProvadoCinco;
                            //eslote 5
                            nota.NomeAlunoCinco = string.Empty;
                            nota.NotasCinco = 0;
                            nota.AlunoProvadoCinco = string.Empty;
                            nota.VerificadoCinco = false;

                        }
                        //4 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true)
                        {
                            //Eslote 3 
                            nota.NomeAlunoTres = nota.NomeAlunoQuatro;
                            nota.NotasTres = nota.NotasQuatro;
                            nota.AlunoProvadoTres = nota.AlunoProvadoQuatro;
                            //Eslote 4
                            nota.NomeAlunoQuatro = string.Empty;
                            nota.NotasQuatro = 0;
                            nota.AlunoProvadoQuatro = string.Empty;
                            nota.VerificadoQuatro = false;
                        }
                        //3 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true)
                        {
                            //Eslote 3 
                            nota.NomeAlunoTres = string.Empty;
                            nota.NotasTres = 0;
                            nota.AlunoProvadoTres = string.Empty;
                            nota.VerificadoTres = false;
                        }
                    }
                    else if (numeroExcluidoAluno == 4)
                    {   //Eslote cheio
                        if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true && nota.VerificadoCinco == true)
                        {
                            //Eslote 4
                            nota.NomeAlunoQuatro = nota.NomeAlunoCinco;
                            nota.NotasQuatro = nota.NotasCinco;
                            nota.AlunoProvadoQuatro = nota.AlunoProvadoCinco;
                            //eslote 5
                            nota.NomeAlunoCinco = string.Empty;
                            nota.NotasCinco = 0;
                            nota.AlunoProvadoCinco = string.Empty;
                            nota.VerificadoCinco = false;

                        }
                        //4 pessoa salva 
                        else if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true)
                        {
                            nota.NomeAlunoQuatro = string.Empty;
                            nota.NotasQuatro = 0;
                            nota.AlunoProvadoQuatro = string.Empty;
                            nota.VerificadoQuatro = false;
                        }
                    }
                    else if (numeroExcluidoAluno == 5)
                    {
                        if (nota.VerificadoDois == true && nota.VerificadoTres == true && nota.VerificadoQuatro == true && nota.VerificadoCinco == true)
                        {
                            //eslote 5
                            nota.NomeAlunoCinco = string.Empty;
                            nota.NotasCinco = 0;
                            nota.AlunoProvadoCinco = string.Empty;
                            nota.VerificadoCinco = false;

                        }
                    }
                }
                else if (adicionarVerificar == 4)
                {
                    loop = false;
                }                                                        
            }
        }
    }
}