using Profile.Data;
using Profile.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Business
{
    public class SkillComponent
    {

        public List<SkillDTO> GetSkills()
        {
            var data = new SkillRepository();
            var list = data.GetSkills();

            

            return list;


        }
    }
}
