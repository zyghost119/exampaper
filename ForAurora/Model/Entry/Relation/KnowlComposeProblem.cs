using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAurora.Model.Entry.Relation
{
    /// <summary>
    /// 知识点组成试题
    /// </summary>
    public class KnowlComposeProblem:Entry
    {
        private string uk_problem_id;
        private string uk_knowledge_point_ids;

        public string ProblemId 
        {
            get
            {
                return uk_problem_id;
            }

            set
            {
                uk_problem_id = value;
            }
        }

        public string KnowlIds   
        {
            get
            {
                return uk_knowledge_point_ids;
            }

            set
            {
                uk_knowledge_point_ids = value;
            }
        }
    }
}
