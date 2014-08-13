using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;

namespace CSCD454_FinalProject.Factories
{
    public interface AbstractCharacterFactory
    {
        Player CreateCharacter(string Class);
    }
}
