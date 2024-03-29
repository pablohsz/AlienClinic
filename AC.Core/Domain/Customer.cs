﻿

namespace AC.Core.Domain
{
    public class Customer
    {
        #region Private fields

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string Phone { get; set; }

        public string SocialId { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        #endregion Private fields
    }
}
