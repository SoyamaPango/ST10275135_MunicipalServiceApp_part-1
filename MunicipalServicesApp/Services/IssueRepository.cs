using System.Collections.Generic;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp.Services
{
   
    public static class IssueRepository
    {
        private static List<Issue> issues = new List<Issue>();

        public static void Add(Issue issue)
        {
            issues.Add(issue);
        }

        public static List<Issue> GetAll()
        {
            return issues;
        }

        public static int Count()
        {
            return issues.Count;
        }
    }
}
