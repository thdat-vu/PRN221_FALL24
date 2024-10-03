using Candidate_BusinessObjects.Models;
using Candidate_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Services
{
    public class CandidateProfileService : ICandidateProfileService
    {
        private readonly ICandidateProfileRepo candidateProfileRepo;
        public CandidateProfileService()
        {
            candidateProfileRepo = new CandidateProfileRepo();
        }
        public bool CreateCandidateProfile(CandidateProfile candidateProfile) => candidateProfileRepo.CreateCandidateProfile(candidateProfile);
        public bool DeleteCandidateProfile(string id) => candidateProfileRepo.DeleteCandidateProfile(id);
        public CandidateProfile GetCandidateProfile(string id) => candidateProfileRepo.GetCandidateProfile(id);
        public List<CandidateProfile> GetCandidateProfiles() => candidateProfileRepo.GetCandidateProfiles();
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile) => candidateProfileRepo.UpdateCandidateProfile(candidateProfile);
        
    }
}
