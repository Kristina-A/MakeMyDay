﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases.Neo4j.DomainModel.Relationships
{
    public class Follow
    {

        public User follower { get; set; }
        public User followed { get; set; }

        public string time { get; set; }

    }
}
