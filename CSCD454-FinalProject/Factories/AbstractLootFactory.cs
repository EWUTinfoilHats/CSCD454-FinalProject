﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCD454_FinalProject.Factories
{
    public interface AbstractLootFactory
    {
        IList<Items.Item> GenerateLoot(int CR);
    }
}
