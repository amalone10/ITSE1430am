using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public class Movie : IValidatableObject
    {
        public string Name { get; set; }                //auto properties(properties should not have side effects)

        public string Description { get; set; }

        public int ReleaseYear { get; set; } = 1900;

        public int RunLength { get; set; }

        public bool IsColor => ReleaseYear > 1940;      //read only property

        public bool isOwned { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required. ", new[] { nameof(Name) });

            if (ReleaseYear < 1900)
                yield return new ValidationResult("Release year must be >= 1900", new[] { nameof(ReleaseYear) });

            if (RunLength < 0)
                yield return new ValidationResult("Run length must be >= 0", new[] { nameof(RunLength) });
        }
    }
}
