using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadge
{
    public class Badges
    {
        public int BadgeID { get; set; }
        public string DoorName { get; set; }

        public string Name { get; set; }

        public Badges(int badgeID, string doorName, string name)
        {
            BadgeID = badgeID;
            DoorName = doorName;
            Name = name;

 

        }
        public Badges()
        { }

       

    }
}
