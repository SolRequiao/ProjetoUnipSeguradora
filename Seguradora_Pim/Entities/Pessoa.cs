using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim
{
    //Pessoa, Funcionario, Segurado, Veiculo, Cotacao e Apolice
    public class Pessoa
    {
        //Conexao
        public string str_conexao = "Host=localhost;Username=postgres;Password=12121110;Database=db_seguradora";
        //Atributos
        private int _id_pessoa;
        private string _nome = "";
        private string _cpf_cnpj = "";
        private string _cnh = "";
        private string _genero = "";
        private string _data_nascimento = "";
        private string _cep = "";
        private string _cidade = "";
        private string _estado = "";
        private string _rua = "";
        private string _bairro = "";
        private int _numero;
        private string _complemento = "";
        private string _celular = "";
        private string _email = "";
        private string _senha_funcionario = "";

        //Getters e Setters
        public int Id_Pessoa {
            get => _id_pessoa;
            set { _id_pessoa = value; }
        }
        
        public string Nome {
            get => _nome; 
            set {_nome = value;}
        }

        public string Cpf_Cnpj { 
            get => _cpf_cnpj; 
            set { _cpf_cnpj = value; }
        }

        public string Cnh {
            get => _cnh;
            set { _cnh = value; }
        }

        public string Genero {
            get => _genero;
            set { _genero = value; }
        }

        public string Data_Nascimento {
            get => _data_nascimento;
            set { _data_nascimento = value; }
        }

        public string Cep {
            get => _cep;
            set { _cep = value; }
        }

        public string Cidade {
            get => _cidade;
            set { _cidade = value; }
        }

        public string Estado {
            get => _estado;
            set { _estado = value; }
        }

        public string Rua {
            get => _rua;
            set { _rua = value; }
        }

        public string Bairro {
            get => _bairro;
            set { _bairro = value; }
        }

        public int Numero {
            get => _numero;
            set { _numero = value; }
        }

        public string Complemento {
            get => _complemento;
            set { _complemento = value; }
        }

        public string Celular {
            get => _celular;
            set { _celular = value; }
        }

        public string Email {
            get => _email;
            set { _email = value; }
        }

    }

}
