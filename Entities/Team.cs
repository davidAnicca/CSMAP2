﻿namespace CSMAP.Entities
{
    class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Team(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

}