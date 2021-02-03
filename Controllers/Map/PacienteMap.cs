using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controllers.Map
{
    class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {
            this.ToTable("Paciente");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_PACIENTE");
            this.Property(d => d.Nome).HasColumnName("NOME_PACIENTE");
            this.Property(d => d.Email).HasColumnName("EMAIL_PACIENTE");
            this.Property(d => d.Telefone).HasColumnName("TELEFONE_PACIENTE");
            this.Property(d => d.Celular).HasColumnName("CELULAR_PACIENTE");
            this.Property(d => d.CEP).HasColumnName("CEP_PACIENTE");
            this.Property(d => d.Endereco).HasColumnName("ENDERECO_PACIENTE");
            this.Property(d => d.Complemento).HasColumnName("COMPLEMENTO_PACIENTE");
            this.Property(d => d.Nascimento).HasColumnName("NASCIMENTO_PACIENTE");
            this.Property(d => d.Sexo).HasColumnName("SEXO_PACIENTE");
        }
    }
}
