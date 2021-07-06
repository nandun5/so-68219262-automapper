using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Soq._68219262.Console
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IEnumerable<IMySetting>, IMySettingLookup>()
                .ConstructUsing(s => new MySettingLookup())
                .ForMember(l => l.MySetting1,
                    o => o.MapFrom(sc =>
                        sc.FirstOrDefault(s => s.SettingName == nameof(IMySettingLookup.MySetting1)).SettingValue))
                .ForMember(l => l.MySetting2,
                    o => o.MapFrom(sc =>
                        sc.FirstOrDefault(s => s.SettingName == nameof(IMySettingLookup.MySetting2)).SettingValue));
        }
    }
}
