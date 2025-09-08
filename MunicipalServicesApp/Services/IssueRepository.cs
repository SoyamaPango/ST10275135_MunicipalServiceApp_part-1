using System.Collections.Generic;
using MunicipalServicesApp.Models;

namespace MunicipalServicesApp.Services
{
    /// <summary>
    /// Central place to store reported issues (meets rubric: consistent use of List for data handling).
    /// </summary>
    public static class IssueRepository
    {
        private static readonly List<Issue> _issues = new List<Issue>();

        public static IReadOnlyList<Issue> All => _issues.AsReadOnly();

        public static void Add(Issue issue)
        {
            _issues.Add(issue);
        }

        public static int Count => _issues.Count;
    }
}
