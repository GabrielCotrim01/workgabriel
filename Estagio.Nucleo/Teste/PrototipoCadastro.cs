﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estagio.Nucleo;
using Estagio.Nucleo.Repositorio;

namespace Teste
{
    public partial class PrototipoCadastro : Form
    {
        public PrototipoCadastro()
        {
            InitializeComponent();

            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AllowUserToResizeColumns = false;

            var colunaID = new DataGridViewTextBoxColumn();
            colunaID.HeaderText = "ID";
            colunaID.DataPropertyName = "ColunaID";
            colunaID.Width = 90;
            colunaID.ReadOnly = true;
            dgvProdutos.Columns.Add(colunaID);

            var colunaDescricao = new DataGridViewTextBoxColumn();
            colunaDescricao.HeaderText = "Descrição";
            colunaDescricao.DataPropertyName = "ColunaDescricao";
            colunaDescricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProdutos.Columns.Add(colunaDescricao);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Produto prodUm = new Produto();
            prodUm.Descricao = "Maçã";
            prodUm.Id = 1;
            prodUm.PrecoUnitario = 2.0m;
            prodUm.QuantidadeMinimaEstoque = 5;
            RepositorioDeProduto.Instancia.Add(prodUm);

            Produto prodDois = new Produto();
            prodDois.Descricao = "Pera";
            prodDois.Id = 2;
            prodDois.PrecoUnitario = 3.0m;
            prodDois.QuantidadeMinimaEstoque = 3;
            RepositorioDeProduto.Instancia.Add(prodDois);

            bsProdutos.DataSource = RepositorioDeProduto.Instancia.GetAll();
            bsProdutos.ResetBindings(false);
            dgvProdutos.DataSource = bsProdutos;
        }

        private void PrototipoCadastro_Load(object sender, EventArgs e)
        {


        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
