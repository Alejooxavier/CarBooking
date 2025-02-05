﻿
using Microsoft.EntityFrameworkCore;
using Model;
using Persistence.Database.Config;

namespace Persistence.Database
{
	public class AplicacionDbContext : DbContext
	{
		public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options)
		{

		}

		public DbSet<CategoriaVehiculo> CategoriasVehiculo { get; set; }

		public DbSet<TipoVehiculo> TiposVehiculo { get; set; }

		public DbSet<ColoresVehiculo> ColoresVehiculo { get; set; }
		public DbSet<MarcasVehiculo> MarcasVehiculo { get; set; }
		public DbSet<Agencias> Agencias { get; set; }
		public DbSet<Clientes> Clientes { get; set; }

		//Sobrecargo el metodo para la creación de las entidades
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			//Llamo a las configuraciones creadas previamnete en Config de la persistencia
			new CategoriaVehiculoConfig(builder.Entity<CategoriaVehiculo>());
			new TipoVehiculoConfig(builder.Entity<TipoVehiculo>());
			new ColoresVehiculoConfig(builder.Entity<ColoresVehiculo>());
			new MarcasVehiculoConfig(builder.Entity<MarcasVehiculo>());
			new AgenciasConfig(builder.Entity<Agencias>());
			new ClientesConfig(builder.Entity<Clientes>());
		}
	}
}
