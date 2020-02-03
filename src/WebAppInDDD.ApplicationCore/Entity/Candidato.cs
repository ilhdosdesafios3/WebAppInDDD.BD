using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebAppInDDD.ApplicationCore.Entity
{
    public class Candidato
    {
        public Candidato(string nome, string apelido, 
            string cpf, string telefonePrimario, string telefoneSecundario)
        {
            Nome = nome;
            Apelido = apelido;
            Cpf = cpf;
            TelefonePrimario = telefonePrimario;
            TelefoneSecundario = telefoneSecundario;
        }
        public Candidato(string nome, string apelido,
           string cpf)
        {
            Nome = nome;
            Apelido = apelido;
            Cpf = cpf;
            TelefonePrimario = "(75) 988693201";
            TelefoneSecundario = "(79) 996582197";
        }
        public Candidato()
        {
            Nome = "Denis";
            Apelido = "Inhonho";
            Cpf = "046.658.963-82";
            TelefonePrimario = "(75) 988693201";
            TelefoneSecundario = "(79) 996582197";
        }
        [Key]
        public int IdCandidato { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Cpf { get; set; }
        public string TelefonePrimario { get; set; }
        public string TelefoneSecundario { get; set; }
    }
}
