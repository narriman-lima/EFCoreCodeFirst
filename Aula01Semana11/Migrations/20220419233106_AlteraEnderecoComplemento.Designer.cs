// <auto-generated />
using System;
using Aula01Semana11;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aula01Semana11.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20220419233106_AlteraEnderecoComplemento")]
    partial class AlteraEnderecoComplemento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Aula01Semana11.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ProprietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("complemento");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("enderecos-sistema", (string)null);
                });

            modelBuilder.Entity("Aula01Semana11.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Area")
                        .HasColumnType("real")
                        .HasColumnName("area");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_atualizacao");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_criacao");

                    b.Property<string>("DescricaoCurta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descicao_curta");

                    b.Property<string>("DescricaoLonga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricao_longa");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<float>("Preco")
                        .HasColumnType("real")
                        .HasColumnName("preco");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("titulo");

                    b.Property<float>("ValorCondominio")
                        .HasColumnType("real")
                        .HasColumnName("valor_condominio");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ImovelId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImovelId");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Contato", b =>
                {
                    b.HasOne("Aula01Semana11.Models.Proprietario", null)
                        .WithMany("Contatos")
                        .HasForeignKey("ProprietarioId");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Imovel", b =>
                {
                    b.HasOne("Aula01Semana11.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Proprietario", b =>
                {
                    b.HasOne("Aula01Semana11.Models.Imovel", null)
                        .WithMany("Proprietarios")
                        .HasForeignKey("ImovelId");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Imovel", b =>
                {
                    b.Navigation("Proprietarios");
                });

            modelBuilder.Entity("Aula01Semana11.Models.Proprietario", b =>
                {
                    b.Navigation("Contatos");
                });
#pragma warning restore 612, 618
        }
    }
}
