using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission.Entities.Models;

namespace Mission.Entities.ViewModel.MissionSkill
{
    public class UpsertMissionSkillRequestModel
    {
        public int Id { get; set; }
        public string SkillName { get; set; }

        public string Status { get; set; }
    }
}
