using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    public enum TipoRelacionamento
    {
        Pai,
        Mae,
        Irmao,
        Amigo,
        Outros
    }

    public class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string NumeroTelefone { get; set; }
        public TipoRelacionamento TipoRelacionamento { get; set; }

        public Contato(int codigo, string nome, string numeroTelefone, TipoRelacionamento tipoRelacionamento)
        {
            Codigo = codigo;
            Nome = nome;
            NumeroTelefone = numeroTelefone;
            TipoRelacionamento = tipoRelacionamento;
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        private List<Contato> _contatos;
       
        public Cliente(string nome, string cpf, string rg, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
        }

        public void ExibirContatos()
        {
            Console.WriteLine("\nLista de contatos:");

            _contatos.Sort(delegate (Contato c1, Contato c2)
            {
                return c1.Codigo.CompareTo(c2.Codigo);
            });
            _contatos.ForEach(delegate (Contato c)
            {
                Console.WriteLine(String.Format("{0} {1} {2} {3}", c.Codigo, c.Nome, c.NumeroTelefone, c.TipoRelacionamento));
            });
        }

        public bool ValidacaoContato(Contato contato)
        {
            if (_contatos is null)
            {
                _contatos = new List<Contato>();
                return true;
            }

            foreach (Contato contatoJaAdicionado in _contatos)
            {
                if (contato.NumeroTelefone == contatoJaAdicionado.NumeroTelefone && contato.TipoRelacionamento == contatoJaAdicionado.TipoRelacionamento)
                    return false;
                else
                    return true;
            }

            return true;
        }

        public void AdicionarContato(Contato contato)
        {
            if (ValidacaoContato(contato))
            {
                _contatos.Add(contato);
                Console.WriteLine(String.Format("Contato {0} foi adicionado com sucesso!", contato.Nome));
            }
            else
                Console.WriteLine(String.Format("Não foi possível concluir a operação. O contato {0} viola as restrições de adição.", contato.Nome));
        }

    }
}
