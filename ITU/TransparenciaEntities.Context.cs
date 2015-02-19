﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITU
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TransparenciaEntities : DbContext
    {
        public TransparenciaEntities()
            : base("name=TransparenciaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatalogoTransparencia> CatalogoTransparencia { get; set; }
        public virtual DbSet<CatalogoTransparenciaReportes> CatalogoTransparenciaReportes { get; set; }
        public virtual DbSet<ControlesMaestrosTiposRangos> ControlesMaestrosTiposRangos { get; set; }
        public virtual DbSet<MapeosReportes> MapeosReportes { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    
        public virtual int sp_ActualizaCatalogoTransparenciaReportes(Nullable<System.Guid> id, Nullable<System.Guid> mapeoId, string nombreArchivo, string descripcionArchivo, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<bool> visible, Nullable<System.Guid> modificadoPor)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(System.Guid));
    
            var mapeoIdParameter = mapeoId.HasValue ?
                new ObjectParameter("mapeoId", mapeoId) :
                new ObjectParameter("mapeoId", typeof(System.Guid));
    
            var nombreArchivoParameter = nombreArchivo != null ?
                new ObjectParameter("nombreArchivo", nombreArchivo) :
                new ObjectParameter("nombreArchivo", typeof(string));
    
            var descripcionArchivoParameter = descripcionArchivo != null ?
                new ObjectParameter("descripcionArchivo", descripcionArchivo) :
                new ObjectParameter("descripcionArchivo", typeof(string));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("fechaInicio", fechaInicio) :
                new ObjectParameter("fechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("fechaFin", fechaFin) :
                new ObjectParameter("fechaFin", typeof(System.DateTime));
    
            var visibleParameter = visible.HasValue ?
                new ObjectParameter("visible", visible) :
                new ObjectParameter("visible", typeof(bool));
    
            var modificadoPorParameter = modificadoPor.HasValue ?
                new ObjectParameter("modificadoPor", modificadoPor) :
                new ObjectParameter("modificadoPor", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ActualizaCatalogoTransparenciaReportes", idParameter, mapeoIdParameter, nombreArchivoParameter, descripcionArchivoParameter, fechaInicioParameter, fechaFinParameter, visibleParameter, modificadoPorParameter);
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> sp_CreaCatalogoTransparenciaReportes(Nullable<System.Guid> mapeoId, string nombreArchivo, string descripcionArchivo, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFin, Nullable<bool> visible, Nullable<System.Guid> subidoPor, Nullable<bool> verificaReistro)
        {
            var mapeoIdParameter = mapeoId.HasValue ?
                new ObjectParameter("mapeoId", mapeoId) :
                new ObjectParameter("mapeoId", typeof(System.Guid));
    
            var nombreArchivoParameter = nombreArchivo != null ?
                new ObjectParameter("nombreArchivo", nombreArchivo) :
                new ObjectParameter("nombreArchivo", typeof(string));
    
            var descripcionArchivoParameter = descripcionArchivo != null ?
                new ObjectParameter("descripcionArchivo", descripcionArchivo) :
                new ObjectParameter("descripcionArchivo", typeof(string));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("fechaInicio", fechaInicio) :
                new ObjectParameter("fechaInicio", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("fechaFin", fechaFin) :
                new ObjectParameter("fechaFin", typeof(System.DateTime));
    
            var visibleParameter = visible.HasValue ?
                new ObjectParameter("visible", visible) :
                new ObjectParameter("visible", typeof(bool));
    
            var subidoPorParameter = subidoPor.HasValue ?
                new ObjectParameter("subidoPor", subidoPor) :
                new ObjectParameter("subidoPor", typeof(System.Guid));
    
            var verificaReistroParameter = verificaReistro.HasValue ?
                new ObjectParameter("verificaReistro", verificaReistro) :
                new ObjectParameter("verificaReistro", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("sp_CreaCatalogoTransparenciaReportes", mapeoIdParameter, nombreArchivoParameter, descripcionArchivoParameter, fechaInicioParameter, fechaFinParameter, visibleParameter, subidoPorParameter, verificaReistroParameter);
        }
    
        public virtual int sp_EliminaNodoCatalogoTransparenciaReportes(Nullable<System.Guid> nodoId, Nullable<System.Guid> modificadoPor)
        {
            var nodoIdParameter = nodoId.HasValue ?
                new ObjectParameter("nodoId", nodoId) :
                new ObjectParameter("nodoId", typeof(System.Guid));
    
            var modificadoPorParameter = modificadoPor.HasValue ?
                new ObjectParameter("modificadoPor", modificadoPor) :
                new ObjectParameter("modificadoPor", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaNodoCatalogoTransparenciaReportes", nodoIdParameter, modificadoPorParameter);
        }
    }
}
