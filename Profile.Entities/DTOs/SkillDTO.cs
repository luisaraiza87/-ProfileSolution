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

        public SkillDTO(string descripcion, string anios)
        {
            this.Anios = anios;
            this.Descripcion = descripcion;
         
        }

        public string Descripcion { get; set; }
        public string Anios { get; set; }
     
    }
}
