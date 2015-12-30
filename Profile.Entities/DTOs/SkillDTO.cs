using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Entities
{
    public class SkillDTO
    {

        public SkillDTO()
        {
        }

        public SkillDTO(string description, int years)
        {
            this.Description = description;
            this.Years = years;
         
        }

        public string Description { get; set; }
        public int? Years { get; set; }
     
    }
}
