using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FormExample.Models
{
    public class AddRowViewModel
    {
        public int Index { get; set; }
        public List<SelectListItem> EducationList { get; set; }

        public List<Education> UserEducation { get; set; }
    }

    public class Education
    {
        public string Name { get; set; }
        public string Grade { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        public string FullName { get; set; }

        public List<SelectListItem> EducationList { get; set; }

        public List<Education> UserEducation { get; set; }
    }
}
