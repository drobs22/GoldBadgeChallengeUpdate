using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadge
{
    public class KomodoBadgeRepo
    {
        public Dictionary<int, string> BadgeItems { get; set; }


        public void BadgeInfo()
        {
            var badgeItems = new Dictionary<int, string>()
        {
            {1234, "A1, A2, A5" },
            {5678, "A2, A3, A4" },
            {2468, "A3" },


        };
        }

        private List<Badges> _badgesList = new List<Badges>();

        // Create

        //public void AddNewBadge()
        //{
        //    Dictionary<int, string> NewBadge = new Dictionary<int, string>();
        //    NewBadge.Add(1234, "A1");



        //}

        public void AddNewBadge(Badges badges)
        {
            _badgesList.Add(badges);
        }
        // Read

        public List<Badges> ShowBadges()
        {
            return _badgesList;
        }

        // Update

        public bool UpdateBadge(int originalID, Badges newBadge )
        {
            // Find Content

            Badges oldID = GetBadgeByID(originalID);

            // Update
            if (oldID != null)
            {
                oldID.BadgeID = newBadge.BadgeID;
                oldID.DoorName = newBadge.DoorName;
                oldID.Name = newBadge.Name;

                return true;
            }
            else
            {
                return false;
            }
        }


        // Delete
         
        public bool DeleteBadge(int id)
        {
            Badges badge = GetBadgeByID(id);

            if (badge == null)
            {
                return false;
            }
            int initialCount = _badgesList.Count;
            _badgesList.Remove(badge);

            if (initialCount > _badgesList.Count)
            {
                return true;
            }
            else 
            {
                return false;

            }


        }

        // Helper Method

        public Badges GetBadgeByID(int id)
        {
            foreach (Badges badge in _badgesList)
            {
                if (badge.BadgeID == id)
                {
                    return badge;
                }


            }

            return null;
        }

        public void UpdateBadge(string originalID, Badges addBadge)
        {
            throw new NotImplementedException();
        }
    }
}
