using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _1_NotasMediaSeve
{
    internal class Notas
    {        
        public double MediaDoAluno;
        public string Aprovado;
        public double Faltou;

        //Aluno 1 
        public string NomeAlunoUm;
        public double NotasUm;
        public string AlunoProvadoUm;
        public bool VerificadoUm;
        //Aluno 2
        public string NomeAlunoDois;
        public double NotasDois;
        public string AlunoProvadoDois;
        public bool VerificadoDois;
        //Aluno 3 
        public string NomeAlunoTres;
        public double NotasTres;
        public string AlunoProvadoTres;
        public bool VerificadoTres;
        //Aluno 4
        public string NomeAlunoQuatro;
        public double NotasQuatro;
        public string AlunoProvadoQuatro;
        public bool VerificadoQuatro;
        //Aluno 5
        public string NomeAlunoCinco;
        public double NotasCinco;
        public string AlunoProvadoCinco;
        public bool VerificadoCinco;


        public double Medias(double nota1, double nota2, double nota3)
        {
            double media = (nota1 + nota2 + nota3) / 3;
            MediaDoAluno = media;
            if (MediaDoAluno <= 3)
            {
                Faltou = 6 - media ;
                Aprovado = "Reprovado";              
            }
            else if (MediaDoAluno >= 4 && MediaDoAluno <= 5) 
            {   
                Faltou =  6 - media ;
                Aprovado = "Recuperação";
                
            }else if (MediaDoAluno >= 6)
            {
                Faltou = 0;
                Aprovado = "Aprovado";             
            }
            return media;      
        }

        public override string ToString()
        {
            if (VerificadoUm == false)
            {
                return "Nenhum Aluno Salvado";
            }
            else if (VerificadoUm == true && VerificadoDois == false) 
            {
                return $" NOME---MEDIA---STATUS"+ "\n" +
                       $"1-{NomeAlunoUm}   {NotasUm.ToString("F2")}   {AlunoProvadoUm}";
            }
            else if(VerificadoUm == true && VerificadoDois == true && VerificadoTres == false)
            {
                return $" NOME---MEDIA---STATUS" + "\n" +
                       $"1-{NomeAlunoUm}   {NotasUm.ToString("F2")}   {AlunoProvadoUm}"+ "\n"+
                       $"2-{NomeAlunoDois}   {NotasDois.ToString("F2")}   {AlunoProvadoDois}";
            }
            else if (VerificadoUm == true && VerificadoDois == true && VerificadoTres == true && VerificadoQuatro == false)
            {
                return $" NOME---MEDIA---STATUS" + "\n" +
                       $"1- {NomeAlunoUm}   {NotasUm.ToString("F2")}   {AlunoProvadoUm}" +"\n" +
                       $"2-{NomeAlunoDois}   {NotasDois.ToString("F2")}   {AlunoProvadoDois}"+ "\n" +
                       $"3-{NomeAlunoTres}   {NotasTres.ToString("F2")}   {AlunoProvadoTres}";
            }
            else if (VerificadoUm == true && VerificadoDois == true && VerificadoTres == true && VerificadoQuatro == true && VerificadoCinco == false)
            {
                return $" NOME---MEDIA---STATUS" + "\n" +
                       $"1- {NomeAlunoUm}   {NotasUm.ToString("F2")}   {AlunoProvadoUm}" + "\n" +
                       $"2-{NomeAlunoDois}   {NotasDois.ToString("F2")}   {AlunoProvadoDois}" + "\n" +
                       $"3-{NomeAlunoTres}   {NotasTres.ToString("F2")}   {AlunoProvadoTres}"+ "\n" +
                       $"4-{NomeAlunoQuatro}   {NotasQuatro.ToString("F2")}   {AlunoProvadoQuatro}";
            }
            else if (VerificadoUm == true && VerificadoDois == true && VerificadoTres == true && VerificadoQuatro == true && VerificadoCinco == true)
            {
                return $" NOME---MEDIA---STATUS" + "\n" +
                       $"1- {NomeAlunoUm}   {NotasUm.ToString("F2")}   {AlunoProvadoUm}" + "\n" +
                       $"2-{NomeAlunoDois}   {NotasDois.ToString("F2")}   {AlunoProvadoDois}" + "\n" +
                       $"3-{NomeAlunoTres}   {NotasTres.ToString("F2")}   {AlunoProvadoTres}" + "\n" +
                       $"4-{NomeAlunoQuatro}   {NotasQuatro.ToString("F2")}   {AlunoProvadoQuatro}"+ "\n" +
                       $"5-{NomeAlunoCinco}   {NotasCinco.ToString("F2")}   {AlunoProvadoCinco}";
            }
            return ":3";
        }
    }
}
