using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    [Description("A movie.")]
    public class Movie : IValidatableObject
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }                //auto properties(properties should not have side effects)

        public string Description { get; set; }

        [Range(1900, 2100, ErrorMessage = "Release year must be >= 1900.")]
        public int ReleaseYear { get; set; } = 1900;

        [Range(0, Int32.MaxValue, ErrorMessage = "Run length must be >= 0.")]
        public int RunLength { get; set; }

        public int Id { get; set; }

        public bool IsColor => ReleaseYear > 1940;      //read only property

        public bool IsOwned { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return null;
        }
    }
}
