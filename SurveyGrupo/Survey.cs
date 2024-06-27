using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyGrupo
{
    internal class Survey
    {

        public string Name { get;set;}

        public string Birthdate { get;set;}

        public string FavoriteTeam { get; set; }

        public override string ToString()
        {
            return $"{Name} | {Birthdate} | {FavoriteTeam }";
        }
    }
}
