using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM: IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Required]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }
        public string? RequestComments { get; set; }

        //model.isvalid dedigimizde burasi cagirilacak
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("Start date must be before end date", new[] {nameof(StartDate), nameof(EndDate)});
            }

            if (RequestComments?.Length > 250)
            {
                yield return new ValidationResult("Comments are too long", new[] { nameof(RequestComments)});
            }
        }
    }
}
