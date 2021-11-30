using System;
using System.Collections;
using System.Collections.Generic;

namespace SSContainer.Domain.Entities
{
    public class Empresa : Base
    {
        public Empresa()
        {
        }

        public Empresa(string cnpj, string nomeEmpresa, string razaoSocial,
                      string endereco, string telefone, string inscricaoEstadual)
        {
            CNPJ = cnpj;
            NomeEmpresa = nomeEmpresa;
            RazaoSocial = razaoSocial;
            Endereco = endereco;
            Telefone = telefone;
            InscricaoEstadual = inscricaoEstadual;

            DataCadastro = DateTime.Now;
            Ativo = true;
        }
        public string CNPJ { get; private set; }
        public string NomeEmpresa { get; private set; }
        public string RazaoSocial { get; private set; }
        //simplificando implementação do endereco...
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public string InscricaoEstadual { get; private set; }
        public bool Ativo { get; private set; }

        public ICollection<JoinEmpresas> Pedidos { get; set; }

        public void Update(string cnpj, string nomeEmpresa, string razaoSocial,
                           string endereco, string telefone, string inscricaoEstadual,
                           bool ativo)
        {
            CNPJ = cnpj;
            NomeEmpresa = nomeEmpresa;
            RazaoSocial = razaoSocial;
            Endereco = endereco;
            Telefone = telefone;
            InscricaoEstadual = inscricaoEstadual;

            Ativo = ativo;
        }
    }
}