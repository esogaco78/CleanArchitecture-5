﻿using Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Persistence.RelationalDB.EntityConfigurations;

internal class UserOldPasswordConfiguration : IEntityTypeConfiguration<UserOldPassword>
{
    public void Configure(EntityTypeBuilder<UserOldPassword> builder)
    {
        builder.ToTable("UserOldPasswords");
        builder.HasKey(uop => uop.Id);
        builder.Property(uop => uop.Id).ValueGeneratedOnAdd();

        builder.HasOne(uop => uop.User).WithMany().HasForeignKey(uop => uop.UserId);
        builder.Property(uop => uop.PasswordHash).HasMaxLength(500).IsRequired();
        builder.Property(uop => uop.SetAtUtc).IsRequired();
    }
}
