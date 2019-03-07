using AutoMapper;
using ProyectoFinal.Entidades;
using ProyectoFinal.Resources;


namespace ProyectoFinal.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Usuario, UsuarioResource>();

            CreateMap<UsuarioResource, Usuario>()
                .ForMember(u => u.UsuarioId, opt => opt.Ignore());


            CreateMap<Juego, JuegoResource>();

            CreateMap<JuegoResource, Juego>()
                .ForMember(j => j.CategoriaId, opt => opt.MapFrom(j => j.Categoria.CategoriaId))
                .ForMember(j => j.DesarrolladorId, opt => opt.MapFrom(j => j.Desarrollador.DesarrolladorId))

                .ForMember(j => j.JuegoId, opt => opt.Ignore())
                .ForMember(j => j.Categoria, opt => opt.Ignore())
                .ForMember(j => j.Desarrollador, opt => opt.Ignore());

            //CreateMap<JuegoQueryResource, JuegoQuery>()
            //    .ForMember(j => j.NombreCategoria, opt => opt.MapFrom(j => j.NombreCategoria));
            


            CreateMap<Categoria, CategoriaResource>();

            CreateMap<CategoriaResource, Categoria>()
                .ForMember(c => c.CategoriaId, opt => opt.Ignore());


            CreateMap<Desarrollador, DesarrolladorResource>();

            CreateMap<DesarrolladorResource, Desarrollador>()
                .ForMember(d => d.DesarrolladorId, opt => opt.Ignore());


            CreateMap<UsuarioResource, UsuarioJuegoResource>();

        }
    }
}
