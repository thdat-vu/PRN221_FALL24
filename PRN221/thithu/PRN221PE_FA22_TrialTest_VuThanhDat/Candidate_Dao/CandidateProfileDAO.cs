using Candidate_BusinessObjects.Models;
using Candidate_Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Daos
{
    public class CandidateProfileDAO
    {
        private CandidateManagementContext context;
        private static CandidateProfileDAO instance = null;

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }
        }
        public CandidateProfileDAO() {
            context = new CandidateManagementContext();
        }
        public List<CandidateProfile> GetCandidateProfiles() => context.CandidateProfiles.ToList();
        public CandidateProfile GetCandidateProfile(string id) => context.CandidateProfiles.FirstOrDefault(c => c.Equals(id));

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            try
            {
                context.Add(candidateProfile);
                context.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                //write log
            }
            return isSuccess;
        }
        public bool UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            try
            {
                CandidateProfile chosenCandidateProfile = GetCandidateProfile(candidateProfile.CandidateId);
                if (chosenCandidateProfile != null)
                {
                    context.Entry(chosenCandidateProfile).CurrentValues.SetValues(candidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                //write log
            }
            return isSuccess;
        }
        public bool DeleteCandidateProfile(string id)
        {
            bool isSuccess = false;
            try
            {
                CandidateProfile deletedCandidateProfile = GetCandidateProfile(id);
                if (deletedCandidateProfile != null)
                {
                    context.Remove(deletedCandidateProfile);
                    context.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                //write log
            }
            return isSuccess;
        }

        public void writeJson()
        {
            
        }
    }
}
