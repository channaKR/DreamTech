using AutoMapper;
using ProgramManager.Model;

namespace ProgramManager.DTO
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {

            //CreateMap<TSource, TDestination>();
            /*
             TSource: The type of the source object.
             TDestination: The type of the destination object.
             */
            CreateMap<StudnetModel,StudnetDto>();
            CreateMap<StudnetDto, StudnetModel>();
            CreateMap<CourseName, CourseNameDto>();
        }

    }
}
