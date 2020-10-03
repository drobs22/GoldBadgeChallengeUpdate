using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeChallenge
{
    public class KomodoCafeRepo
    {
        private List<Menu> _menuList = new List<Menu>();
        private List<TheBigTurkeyIngredients> _theBigTurkeyIngredients = new List<TheBigTurkeyIngredients>();
        private List<DontBeAChickenIngredients> _dontBeAChickenIngredients = new List<DontBeAChickenIngredients>();
        private List<WedgieIngredients> _wedgieIngredients = new List<WedgieIngredients>();


        // Create
        public void AddNewItem(Menu item)
        {
            _menuList.Add(item);
        }

        // Read
        public List<Menu> ShowMenu()
        {
            return _menuList;
        }

        public List<TheBigTurkeyIngredients> BigTurkeyIngredients()
        {
            return _theBigTurkeyIngredients;
        }

        public List<DontBeAChickenIngredients> DontBeAChickenIngredients()
        {
            return _dontBeAChickenIngredients;
        }

        public List<WedgieIngredients> WedgieIngredients()
        {
            return _wedgieIngredients;
        }

        // Delete      
        public bool RemoveItemFromMenu(string name)
        {
            Menu item = GetItemByName(name);
            if(item == null)
            {
                return false;
            }

            int initialCount = _menuList.Count;
            _menuList.Remove(item);
                
            if(initialCount > _menuList.Count)
            {
                return true;
            }
            else
            {
                return false;

            }


            
        }

        // Helper Method
        private Menu GetItemByName(string name)
        {
            foreach (Menu item in _menuList)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
    }

 

        
        


    


}
