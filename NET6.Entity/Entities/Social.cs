using NET6.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Entity.Entities
{
    public class Social : EntityBase
    {
        public Social()
        {

        }
        public Social(string ıcon, string name, string createdBy,Guid linkId)
        {
            LinkId = linkId;
            Icon = ıcon;
            Name = name;
            CreatedBy = createdBy;
        }
        public string Icon { get; set; }
        public string Name { get; set; }
        public Guid? LinkId { get; set; }
        public Link Links { get; set; }
    }
}

