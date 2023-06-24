using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Super_Market.Pages.Groups;

namespace Super_Market.Models
{
    public class Group_Method
    {
        public List<Groups_Class> AllGroups;

        public Group_Method()
        {
            AllGroups = new List<Groups_Class>
            {
                new Groups_Class{Id = 1,GroupName = "مجمدات"},
                new Groups_Class{Id = 2,GroupName = "بقوليات"},
                new Groups_Class{Id = 3,GroupName = "زيوت"}
            };
        }
        public List<Groups_Class>GetAllGroups()
        {
            return AllGroups;
        }
        
    }
}