using d1000.Common.Domain.Models.Data.Base;
using d1000.Common.Domain.Models.Data.Escolas;
using d1000.Common.Domain.Models.Data.Alunos;
using d1000.Common.Domain.Models.Data.Turmas;
using d1000.Services.Base.Infrastructure.Maps;
using d1000.Services.Escolas.Infrastructure.Maps;
using d1000.Services.Alunos.Infrastructure.Maps;
using d1000.Services.Turmas.Infrastructure.Maps;
using d1000.Common.Models.Data.Base;
using d1000.Common.Infrastructure.Maps.Escolas;
using d1000.Common.Domain.Models.Data.Escolas.Entities;
using d1000.Common.Infrastructure.Maps.Alunos;
using d1000.Common.Domain.Models.Data.Alunos.Entities;
using d1000.Common.Infrastructure.Maps.Base;
using d1000.Common.Domain.Models.Data.Base.Entities;
using Microsoft.EntityFrameworkCore;
using d1000.Common.Domain.Data.Models;
using d1000.Common.Infrastructure.Maps;
namespace d1000.Common.Infrastructure
{
    public class d1000DataContext : DbContext
    {

        public d1000DataContext(DbContextOptions<d1000DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            #region "Autenticacao"

           // modelBuilder.Entity<V_DML_BA_USU_PERMISSAO>(e => e.ToView("V_DML_BA_USU_PERMISSAO").HasNoKey());

            #endregion

            #region "Base"

            modelBuilder.Entity<DML_BA_CARGO>(new DML_BA_CARGO_Map().Configure);
            modelBuilder.Entity<DML_BA_CIDADE>(new DML_BA_CIDADE_Map().Configure);
            modelBuilder.Entity<DML_BA_LOGRADOURO>(new DML_BA_LOGRADOURO_Map().Configure);
            modelBuilder.Entity<DML_BA_PAIS>(new DML_BA_PAIS_Map().Configure);
            modelBuilder.Entity<DML_BA_UF>(new DML_BA_UF_Map().Configure);
            modelBuilder.Entity<DML_BA_USU>(new DML_BA_USU_Map().Configure);
            modelBuilder.Entity<DML_BA_GRUPO_USU>(new DML_BA_GRUPO_USU_Map().Configure);
            modelBuilder.Entity<DML_BA_GRUPO_USU_PERMISSAO>(new DML_BA_GRUPO_USU_PERMISSAO_Map().Configure);
            modelBuilder.Entity<DML_BA_FILIAL>(new DML_BA_FILIAL_Map().Configure);
            modelBuilder.Entity<DML_BA_FILIAL_CONTATO>(new DML_BA_FILIAL_CONTATO_Map().Configure);
            modelBuilder.Entity<DML_BA_FORMA_PAG>(new DML_BA_FORMA_PAG_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_CONTATO>(new DML_BA_TIPO_CONTATO_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_DOCUMENTO>(new DML_BA_TIPO_DOCUMENTO_Map().Configure);
            modelBuilder.Entity<DML_BA_REGIAO>(new DML_BA_REGIAO_Map().Configure);
            modelBuilder.Entity<DML_BA_TELA>(new DML_BA_TELA_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_CARGO>(new DML_BA_TIPO_CARGO_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_CLIENTE>(new DML_BA_TIPO_CLIENTE_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_CONVENIO>(new DML_BA_TIPO_CONVENIO_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_PESSOA>(new DML_BA_TIPO_PESSOA_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_PROD_EQUIPAMENTO>(new DML_BA_TIPO_PROD_EQUIPAMENTO_Map().Configure);
            modelBuilder.Entity<DML_BA_USU_FILIAL>(new DML_BA_USU_FILIAL_Map().Configure);
            modelBuilder.Entity<DML_BA_USU_PERMISSAO>(new DML_BA_USU_PERMISSAO_Map().Configure);
            modelBuilder.Entity<DML_BA_USU_REDE>(new DML_BA_USU_REDE_Map().Configure);
           
            #endregion

            #region "Produtos"

            //modelBuilder.Entity<DML_BA_PROD>(new DML_BA_PROD_Map().Configure);
            //modelBuilder.Entity<DML_BA_FABRICANTE>(new DML_BA_FABRICANTE_Map().Configure);
            //modelBuilder.Entity<DML_BA_FORNECEDOR>(new DML_BA_FORNECEDOR_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_EAN>(new DML_BA_PROD_EAN_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_APRES>(new DML_BA_ATRIBUTO_ARVORE_APRES_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_CATEG>(new DML_BA_ATRIBUTO_ARVORE_CATEG_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_CLASS>(new DML_BA_ATRIBUTO_ARVORE_CLASS_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_CONSUMO>(new DML_BA_ATRIBUTO_ARVORE_CONSUMO_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_DEPTO>(new DML_BA_ATRIBUTO_ARVORE_DEPTO_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_EQUIVALENTE>(new DML_BA_ATRIBUTO_ARVORE_EQUIVALENTE_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_FAMILIA>(new DML_BA_ATRIBUTO_ARVORE_FAMILIA_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_LINHA>(new DML_BA_ATRIBUTO_ARVORE_LINHA_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_MARCA>(new DML_BA_ATRIBUTO_ARVORE_MARCA_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_MATRIZ_BCG>(new DML_BA_ATRIBUTO_ARVORE_MATRIZ_BCG_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_MIX>(new DML_BA_ATRIBUTO_ARVORE_MIX_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_PAPEL>(new DML_BA_ATRIBUTO_ARVORE_PAPEL_Map().Configure);
            //modelBuilder.Entity<DML_BA_ATRIBUTO_ARVORE_SEGMENTO>(new DML_BA_ATRIBUTO_ARVORE_SEGMENTO_Map().Configure);   
            //modelBuilder.Entity<DML_BA_PROD_ATRIBUTO>(new DML_BA_PROD_ATRIBUTO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PRINCIPIO_ATIVO>(new DML_BA_PRINCIPIO_ATIVO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_PRINCIPIO_ATIVO>(new DML_BA_PROD_CPL_PRINCIPIO_ATIVO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL>(new DML_BA_PROD_CPL_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CLASSIFICACAO_SNGPC>(new DML_BA_PROD_CLASSIFICACAO_SNGPC_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_COD_BENEFICIO>(new DML_BA_PROD_CPL_COD_BENEFICIO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_DT_NASC>(new DML_BA_PROD_CPL_DT_NASC_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_FORN>(new DML_BA_PROD_CPL_FORN_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_LOTE>(new DML_BA_PROD_CPL_LOTE_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_MEDIAF>(new DML_BA_PROD_CPL_MEDIAF_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_MEDIAP>(new DML_BA_PROD_CPL_MEDIAP_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_PRECO>(new DML_BA_PROD_CPL_PRECO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_SNGPC>(new DML_BA_PROD_CPL_SNGPC_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_GAVETA>(new DML_BA_PROD_GAVETA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_ORIGEM>(new DML_BA_PROD_ORIGEM_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_PRATELEIRA>(new DML_BA_PROD_PRATELEIRA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_REDE>(new DML_BA_PROD_REDE_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_SIGLA_CURVA>(new DML_BA_PROD_SIGLA_CURVA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_STS>(new DML_BA_PROD_STS_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_STS_MOTIVO>(new DML_BA_PROD_STS_MOTIVO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TP_LISTA>(new DML_BA_PROD_TP_LISTA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CPL_FARMACIA_POPULAR>(new DML_BA_PROD_CPL_FARMACIA_POPULAR_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_CONVENIO>(new DML_BA_PROD_CONVENIO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_LEVE_PAGUE>(new DML_BA_PROD_LEVE_PAGUE_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_LEVE_PAGUE_FAMILIA_CAMPANHA>(new DML_BA_PROD_LEVE_PAGUE_FAMILIA_CAMPANHA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_LEVE_PAGUE_FILIAL>(new DML_BA_PROD_LEVE_PAGUE_FILIAL_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_LEVE_PAGUE_PROD>(new DML_BA_PROD_LEVE_PAGUE_PROD_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_LEVE_PAGUE_PROD_CAMPANHA>(new DML_BA_PROD_LEVE_PAGUE_PROD_CAMPANHA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO>(new DML_BA_PROD_TBL_DESCONTO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO>(new DML_BA_PROD_TBL_DESCONTO_CARGO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO_CARGO>(new DML_BA_PROD_TBL_DESCONTO_CARGO_CARGO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO_CATEG>(new DML_BA_PROD_TBL_DESCONTO_CARGO_CATEG_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO_FAMILIA>(new DML_BA_PROD_TBL_DESCONTO_CARGO_FAMILIA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO_FILIAL>(new DML_BA_PROD_TBL_DESCONTO_CARGO_FILIAL_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO_LINHA>(new DML_BA_PROD_TBL_DESCONTO_CARGO_LINHA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CARGO_PROD>(new DML_BA_PROD_TBL_DESCONTO_CARGO_PROD_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_CATEG>(new DML_BA_PROD_TBL_DESCONTO_CATEG_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_FABRICANTE>(new DML_BA_PROD_TBL_DESCONTO_FABRICANTE_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_FAMILIA>(new DML_BA_PROD_TBL_DESCONTO_FAMILIA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_FILIAL>(new DML_BA_PROD_TBL_DESCONTO_FILIAL_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_LINHA>(new DML_BA_PROD_TBL_DESCONTO_LINHA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_PROD>(new DML_BA_PROD_TBL_DESCONTO_PROD_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_PROGRAMADO>(new DML_BA_PROD_TBL_DESCONTO_PROGRAMADO_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_QTDE>(new DML_BA_PROD_TBL_DESCONTO_QTDE_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_QTDE_CATEG>(new DML_BA_PROD_TBL_DESCONTO_QTDE_CATEG_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_QTDE_FILIAL>(new DML_BA_PROD_TBL_DESCONTO_QTDE_FILIAL_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_QTDE_LINHA>(new DML_BA_PROD_TBL_DESCONTO_QTDE_LINHA_Map().Configure);
            //modelBuilder.Entity<DML_BA_PROD_TBL_DESCONTO_QTDE_PROD>(new DML_BA_PROD_TBL_DESCONTO_QTDE_PROD_Map().Configure);


            #endregion

            #region "Escolas"

            modelBuilder.Entity<DML_BA_ESCOLA>(new DML_BA_ESCOLA_Map().Configure);
            modelBuilder.Entity<DML_BA_ESCOLA_LOGRADOURO>(new DML_BA_ESCOLA_LOGRADOURO_Map().Configure);
            modelBuilder.Entity<DML_BA_ESCOLA_CONTATO>(new DML_BA_ESCOLA_CONTATO_Map().Configure);
            //modelBuilder.Entity<DML_BA_TIPO_SEXO>(new DML_BA_TIPO_SEXO_Map().Configure);
            //modelBuilder.Entity<DML_BA_SIGLA_ORG_EXP>(new DML_BA_SIGLA_ORG_EXP_Map().Configure);
            //modelBuilder.Entity<DML_BA_CONVENIADO>(new DML_BA_CONVENIADO_Map().Configure);
            //modelBuilder.Entity<DML_BA_CONVENIO>(new DML_BA_CONVENIO_Map().Configure);

            #endregion

            #region "Alunos"

            modelBuilder.Entity<DML_BA_ALUNO>(new DML_BA_ALUNO_Map().Configure);
            modelBuilder.Entity<DML_BA_ALUNO_LOGRADOURO>(new DML_BA_ALUNO_LOGRADOURO_Map().Configure);
            modelBuilder.Entity<DML_BA_ALUNO_CONTATO>(new DML_BA_ALUNO_CONTATO_Map().Configure);
            modelBuilder.Entity<DML_BA_TIPO_SEXO>(new DML_BA_TIPO_SEXO_Map().Configure);
            modelBuilder.Entity<DML_BA_SIGLA_ORG_EXP>(new DML_BA_SIGLA_ORG_EXP_Map().Configure);
         
            #endregion

            #region "Turmass"

            modelBuilder.Entity<DML_BA_TURMA>(new DML_BA_TURMA_Map().Configure);
           
            #endregion

        }

        #region "Base"

        public DbSet<DML_BA_CARGO> DML_BA_CARGO { get; set; }
        public DbSet<DML_BA_CIDADE> DML_BA_CIDADE { get; set; }
        public DbSet<DML_BA_LOGRADOURO> DML_BA_LOGRADOURO { get; set; }
        public DbSet<DML_BA_PAIS> DML_BA_PAIS { get; set; }
        public DbSet<DML_BA_UF> DML_BA_UF { get; set; }
        public DbSet<DML_BA_USU> DML_BA_USU { get; set; }
        public DbSet<DML_BA_GRUPO_USU> DML_BA_GRUPO_USU { get; set; }
        public DbSet<DML_BA_GRUPO_USU_PERMISSAO> DML_BA_GRUPO_USU_PERMISSAO { get; set; }
        public DbSet<DML_BA_FILIAL> DML_BA_FILIAL { get; set; }
        public DbSet<DML_BA_FILIAL_CONTATO> DML_BA_FILIAL_CONTATO { get; set; }
        public DbSet<DML_BA_FORMA_PAG> DML_BA_FORMA_PAG { get; set; }
        public DbSet<DML_BA_TIPO_CONTATO> DML_BA_TIPO_CONTATO { get; set; }
        public DbSet<DML_BA_TIPO_DOCUMENTO> DML_BA_TIPO_DOCUMENTO { get; set; }
        public DbSet<DML_BA_REGIAO> DML_BA_REGIAO { get; set; }
        public DbSet<DML_BA_TELA> DML_BA_TELA { get; set; }
        public DbSet<DML_BA_TIPO_CARGO> DML_BA_TIPO_CARGO { get; set; }
        public DbSet<DML_BA_TIPO_CLIENTE> DML_BA_TIPO_CLIENTE { get; set; }
        public DbSet<DML_BA_TIPO_CONVENIO> DML_BA_TIPO_CONVENIO { get; set; }
        public DbSet<DML_BA_TIPO_PESSOA> DML_BA_TIPO_PESSOA { get; set; }
        public DbSet<DML_BA_TIPO_PROD_EQUIPAMENTO> DML_BA_TIPO_PROD_EQUIPAMENTO { get; set; }
        public DbSet<DML_BA_USU_FILIAL> DML_BA_USU_FILIAL { get; set; }
        public DbSet<DML_BA_USU_PERMISSAO> DML_BA_USU_PERMISSAO { get; set; }
        public DbSet<DML_BA_USU_REDE> DML_BA_USU_REDE { get; set; }
       
        #endregion

        #region "Escolas"
        public DbSet<DML_BA_ESCOLA> DML_BA_ESCOLA { get; set; }
        public DbSet<DML_BA_ESCOLA_LOGRADOURO> DML_BA_ESCOLA_LOGRADOURO { get; set; }
        public DbSet<DML_BA_ESCOLA_CONTATO> DML_BA_ESCOLA_CONTATO { get; set; }
        //public DbSet<DML_BA_SIGLA_ORG_EXP> DML_BA_SIGLA_ORG_EXP { get; set; }
        //public DbSet<DML_BA_TIPO_SEXO> DML_BA_TIPO_SEXO { get; set; }
        //public DbSet<DML_BA_CONVENIADO> DML_BA_CONVENIADO { get; set; }
        //public DbSet<DML_BA_CONVENIO> DML_BA_CONVENIO { get; set; }
        #endregion

        #region "Turmas"
        public DbSet<DML_BA_TURMA> DML_BA_TURMA { get; set; }
        #endregion

        #region "Alunos"
        public DbSet<DML_BA_ALUNO> DML_BA_ALUNO { get; set; }
        public DbSet<DML_BA_ALUNO_LOGRADOURO> DML_BA_ALUNO_LOGRADOURO { get; set; }
        public DbSet<DML_BA_ALUNO_CONTATO> DML_BA_ALUNO_CONTATO { get; set; }
        public DbSet<DML_BA_SIGLA_ORG_EXP> DML_BA_SIGLA_ORG_EXP { get; set; }
        public DbSet<DML_BA_TIPO_SEXO> DML_BA_TIPO_SEXO { get; set; }
        //public DbSet<DML_BA_CONVENIADO> DML_BA_CONVENIADO { get; set; }
        //public DbSet<DML_BA_CONVENIO> DML_BA_CONVENIO { get; set; }
        #endregion
  
    }
}
