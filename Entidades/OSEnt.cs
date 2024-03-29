﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OSEnt
    {
        private int id;
        private string nomepet;
        private string especie;
        private string raca;
        private string proprietario;
        private string telefone;
        private string email;
        private string c_especiais;
        private string alergico;
        private string observacao;

        private string servico1;
        private string checkserv1;
        private string valorserv1;

        private string servico2;
        private string checkserv2;
        private string valorserv2;
        private string servico3;
        private string checkserv3;
        private string valorserv3;
        private string servico4;
        private string valorserv4;

        private string taxaentrega;
        private string hora;

        private DateTime data;
        private DateTime dataos;
        private string valortotal;
        private string desconto;
        private string valorfinal;
        
        private string formapgto1;
        private string valor1;

        private string checkpgto2;
        private string formapgto2;
        private string valor2;

        private string checkpgto3;
        private string formapgto3;
        private string valor3;

        public int Id { get => id; set => id = value; }
        public string Nomepet { get => nomepet; set => nomepet = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raca { get => raca; set => raca = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string C_especiais { get => c_especiais; set => c_especiais = value; }
        public string Alergico { get => alergico; set => alergico = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Servico1 { get => servico1; set => servico1 = value; }
        public string Checkserv1 { get => checkserv1; set => checkserv1 = value; }
        public string Valorserv1 { get => valorserv1; set => valorserv1 = value; }
        public string Servico2 { get => servico2; set => servico2 = value; }
        public string Checkserv2 { get => checkserv2; set => checkserv2 = value; }
        public string Valorserv2 { get => valorserv2; set => valorserv2 = value; }
        public string Servico3 { get => servico3; set => servico3 = value; }
        public string Checkserv3 { get => checkserv3; set => checkserv3 = value; }
        public string Valorserv3 { get => valorserv3; set => valorserv3 = value; }
        public string Servico4 { get => servico4; set => servico4 = value; }
        public string Valorserv4 { get => valorserv4; set => valorserv4 = value; }
        public string Taxaentrega { get => taxaentrega; set => taxaentrega = value; }
        public string Hora { get => hora; set => hora = value; }
        public DateTime Data { get => data; set => data = value; }
        public DateTime Dataos { get => dataos; set => dataos = value; }
        public string Valortotal { get => valortotal; set => valortotal = value; }
        public string Desconto { get => desconto; set => desconto = value; }
        public string Valorfinal { get => valorfinal; set => valorfinal = value; }
        public string Formapgto1 { get => formapgto1; set => formapgto1 = value; }
        public string Valor1 { get => valor1; set => valor1 = value; }
        public string Checkpgto2 { get => checkpgto2; set => checkpgto2 = value; }
        public string Formapgto2 { get => formapgto2; set => formapgto2 = value; }
        public string Valor2 { get => valor2; set => valor2 = value; }
        public string Checkpgto3 { get => checkpgto3; set => checkpgto3 = value; }
        public string Formapgto3 { get => formapgto3; set => formapgto3 = value; }
        public string Valor3 { get => valor3; set => valor3 = value; }
    }
}