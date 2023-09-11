using Microsoft.EntityFrameworkCore;
using RL.Data.DataModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RL.Data.DataModels
{
    
    public class PlanUser : IChangeTrackable
    {
        public int ProcedureId { get; set; }
        public int PlanId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
