using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93,1434;
                                     Database = BD040162; 
                                     User ID = RA040162; 
                                     Password = 040162";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Organizador> Organizador { get; set; }
        public DbSet<CadastroFesta> CadastroFesta { get; set; }
        public DbSet<Convite> Convite { get; set; }

        public DbSet<Login> Login { get; set; }
        public DbSet<Participantes> Participantes { get; set; }

        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Estado>()
                .Property("UF")
                .HasColumnName("UF")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

           /////////////////////////////////////////////////////////////////////////
        
        
        
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .HasKey("UsuarioID");

            modelBuilder.Entity<Usuario>()
                .Property("UsuarioID")
                .HasColumnName("UsuarioID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Usuario>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();
            
            modelBuilder.Entity<Usuario>()
                .Property("DataNascimento")
                .HasColumnName("DataNascimento")
                .HasColumnType("varchar(200)")
                .IsRequired();
            
            modelBuilder.Entity<Usuario>()
                .Property("Telefone")
                .HasColumnName("Telefone")
                .HasColumnType("varchar(11)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Email")
                .HasColumnName("Email")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("char(11)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("Bairro")
                .HasColumnName("Bairro")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Usuario>()
                .Property("CEP")
                .HasColumnName("CEP")
                .HasColumnType("char(9)")
                .IsRequired();
            ////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<Organizador>()
                    .ToTable("Organizador")
                    .HasKey("OrganizadorID");

            modelBuilder.Entity<Organizador>()
                .Property("OrganizadorID")
                .HasColumnName("OrganizadorID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Organizador>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Organizador>()
                .Property("CPF")
                .HasColumnName("CPF")
                .HasColumnType("char(11)")
                .IsRequired();

            modelBuilder.Entity<Organizador>()
                .Property("Telefone")
                .HasColumnName("Telefone")
                .HasColumnType("varchar(11)")
                .IsRequired();


            /////////////////////////////////////////////////////////////////////////////// 

            modelBuilder.Entity<CadastroFesta>()
                .ToTable("CadastroFesta")
                .HasKey("FestaID");

            modelBuilder.Entity<CadastroFesta>()
                .Property("FestaID")
                .HasColumnName("FestaID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<CadastroFesta>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<CadastroFesta>()
                .Property("Endereco")
                .HasColumnName("Endereco")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<CadastroFesta>()
                .Property("UF")
                .HasColumnName("Estado")
                .HasColumnType("char(2)")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("DataFesta")
                .HasColumnName("DataFesta")
                .HasColumnType("datetime")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("Bairro")
                .HasColumnName("Bairro")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("PrecoIngresso")
                .HasColumnName("PrecoIngresso")
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("OrganizadorID")
                .HasColumnName("OrganizadorID")
                .HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<CadastroFesta>()
                .Property("ConviteID")
                .HasColumnName("ConviteID")
                .HasColumnType("int")
                .IsRequired();


            /////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<Convite>()
                .ToTable("Convite")
                .HasKey("ConviteID");

            modelBuilder.Entity<Convite>()
                .Property("ConviteID")
                .HasColumnName("ConviteID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Convite>()
                .Property("UsuarioID")
                .HasColumnName("UsuarioID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Convite>()
                .Property("OrganizadorID")
                .HasColumnName("OrganizadorID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Convite>()
                .Property("FestaID")
                .HasColumnName("FestaID")
                .HasColumnType("int")
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);

            /////////////////////////////////////////////////////////////////

            modelBuilder.Entity<Login>()
                .ToTable("Login")
                .HasKey("UsuarioID");

            modelBuilder.Entity<Login>()
                .Property("UsuarioID")
                .HasColumnName("UsuarioID")
                .HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<Login>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(200)")
                .IsRequired();
            modelBuilder.Entity<Login>()
                .Property("Senha")
                .HasColumnName("Senha")
                .HasColumnType("char(70)")
                .IsRequired();

            //////////////////////////////////////////////////

            modelBuilder.Entity<Participantes>()
                .ToTable("Participantes")
                .HasKey("ConviteID");
            modelBuilder.Entity<Participantes>()
                .Property("ConviteID")
                .HasColumnName("ConviteID")
                .HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<Participantes>()
                .Property("UsuarioID")
                .HasColumnName("UsuarioID")
                .HasColumnType("int")
                .IsRequired();
            modelBuilder.Entity<Participantes>()
                .Property("FestaID")
                .HasColumnName("FestaID")
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Participantes>()
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.UsuarioID);

            modelBuilder.Entity<Participantes>()
                .HasOne(f => f.NomeFesta)
                .WithMany()
                .HasForeignKey(f => f.FestaID);


        }






    }
}
