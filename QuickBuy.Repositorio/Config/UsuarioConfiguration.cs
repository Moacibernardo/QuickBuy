﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            
            //Builder utiliza o pafrão Fluent

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
               
            builder
                .Property(u => u.Sobrenome)
                .IsRequired()
                .HasMaxLength(50);
            

        }
    }
}