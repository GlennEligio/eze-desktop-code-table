using EZECodesList.ADO.NETModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZECodesList.Repository
{
    public class ProfessorRepository
    {
        public ezeEntities1 context;
        private static ProfessorRepository instance = null;

        private ProfessorRepository () 
        {
            context = new ezeEntities1 ();
        }

        public static ProfessorRepository getInstance()
        {
            if(instance == null)
            {
                instance = new ProfessorRepository();
            }
            return instance;
        }

        public Professor getProfessorByContactNumber(string number)
        {
            Professor prof = context.Professors.Where(p => p.Contact_Number == number).FirstOrDefault();
            if(prof == null)
            {
                prof = new Professor ();
            }
            return prof;
        }

        public List<Professor> getProfessors()
        {
            return context.Professors.OrderBy(p => p.Name).ToList();
        }
    }
}
