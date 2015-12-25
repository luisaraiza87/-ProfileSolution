using Profile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Data
{
    public class SkillRepository
    {

        public List<SkillDTO> GetSkills()
        {
            var lista = new List<SkillDTO>();

            lista.Add(new SkillDTO("C#", "8"));
            lista.Add(new SkillDTO("VB .Net", "6"));
            lista.Add(new SkillDTO("Sql Server", "8"));
          
            return lista;


        }

    }
}
