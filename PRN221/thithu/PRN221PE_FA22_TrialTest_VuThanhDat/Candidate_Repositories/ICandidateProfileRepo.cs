using Candidate_BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repositories
{
    public interface ICandidateProfileRepo
    {
        public CandidateProfile GetCandidateProfile(string id);
        public List<CandidateProfile> GetCandidateProfiles();
        public bool CreateCandidateProfile(CandidateProfile candidateProfile);
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile);
        public bool DeleteCandidateProfile(string id);

    }
}
