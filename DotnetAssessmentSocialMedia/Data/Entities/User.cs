using System;
using System.Collections.Generic;

namespace DotnetAssessmentSocialMedia.Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        public Profile Profile { get; set; }

        public Credentials Credentials { get; set; }

        public DateTime Joined { get; set; }

        public Boolean Deleted { get; set; }



    }
}
