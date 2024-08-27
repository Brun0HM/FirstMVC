﻿namespace PrimeiroMVC.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int RM { get; set; }

        //Modificar o método construtor
        // Inserir os dados que vieram por parametros nos atributos do Objeto
        public Aluno(int id, string nome, string email, int rm)
        {
            this.AlunoId = id;
            this.Nome = nome;
            this.Email = email;
            this.RM = rm;
        }
    }
}