using SITHEC.Application.Dtos.Common;
using static SITHEC.Domain.Enums.Enumerations;

namespace SITHEC.Application.Dtos.Human
{
    public class UpdateHumanDto : BaseDto
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public short Age { get; set; }
        public short Size { get; set; }
        public decimal Weight { get; set; }
    }
}
