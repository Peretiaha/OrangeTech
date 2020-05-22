using AutoMapper;
using OrangeTech.Models.Models;
using OrangeTech.Web.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace OrangeTech.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Work, Work>();

            CreateMap<Service, Service>();

            CreateMap<Work, WorkShortViewModel>()
                .ForMember(x=>x.Image, w=>w.MapFrom(x=>x.Images[0].Img))
                .ReverseMap();

            CreateMap<Service, ServiceShortViewModel>()
                .ForMember(x => x.Image, w => w.MapFrom(x => x.Images[0].Img))
                .ReverseMap();

            CreateMap<RegisterViewModel, User>().ReverseMap();

            CreateMap<User, LoginViewModel>().ReverseMap();

            CreateMap<WorkViewModel, Work>()
                .ForMember(x => x.Images, w => w.Ignore())
                .AfterMap((workViewModel, work) =>
                {
                    work.Images = new List<Image>();

                    for (int i = 0; i < workViewModel.Images.Count; i++)
                    {
                        byte[] imageData = null;
                        using (var binaryReader = new BinaryReader(workViewModel.Images[i].OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)workViewModel.Images[i].Length);
                        }
                        
                        work.Images.Add(new Image
                        {
                            Img = imageData
                        });
                    }
                }).ReverseMap();

            CreateMap<ServiceViewModel, Service>()
                .ForMember(x => x.Images, w => w.Ignore())
                .AfterMap((serviceViewModel, service) =>
                {
                    service.Images = new List<Image>();

                    for (int i = 0; i < serviceViewModel.Images.Count; i++)
                    {
                        byte[] imageData = null;
                        using (var binaryReader = new BinaryReader(serviceViewModel.Images[i].OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)serviceViewModel.Images[i].Length);
                        }

                        service.Images.Add(new Image
                        {
                            Img = imageData
                        });
                    }
                }).ReverseMap();
        }
    }
}
