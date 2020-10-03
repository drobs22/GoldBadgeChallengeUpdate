using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims
{
    public class KomodoClaimsRepo
    {
        private List<Claims> _claimsList = new List<Claims>();

        // Create

        public void AddNewClaim(Claims claim)
        {
           _claimsList.Add(claim);
        }
        // Read

        public List<Claims> ShowClaims()
        {
            return _claimsList;
        }

        // Update



        // Delete


        // Helper Method
        public Claims GetClaimByID(int id)
        {
            foreach (Claims claim in _claimsList)
            {
                if (claim.ClaimID == id)
                {
                    return claim;
                }

            }
            return null;
        }
    }
}
