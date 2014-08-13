using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCD454_FinalProject.Entitys;
using CSCD454_FinalProject.UI;

namespace CSCD454_FinalProject.Factories
{
    public interface AbstractCharacterFactory
    {
        Player CreateCharacter(string Class, UserInteraction ui);
    }
}
