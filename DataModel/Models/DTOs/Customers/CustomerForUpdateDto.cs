using DataModel.Models.DTOs.Warranty;

namespace DataModel.Models.DTOs.Customers
{
    public class CustomerForUpdateDto : CustomerForManipulationDto
    {
        public IEnumerable<WarrantiyForCreationDto>? CustomerWarranties { get; set; }
    }
}
