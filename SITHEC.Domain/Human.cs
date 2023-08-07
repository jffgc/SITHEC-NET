using SITHEC.Domain.Common;
using static SITHEC.Domain.Enums.Enumerations;

namespace SITHEC.Domain
{
    public class Human : BaseDomainEntity
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public short Age { get; set; }
        public short Size { get; set; }
        public decimal Weight { get; set; }

    }
}
