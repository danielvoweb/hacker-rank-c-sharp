using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    public static class GradingStudents
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            return grades
                .Select(x =>
                {
                    bool failing = x < 38;
                    int nextMultiple = x + (5 - x % 5);
                    bool differenceGreaterThan = (nextMultiple - x) >= 3;
                    if (failing || differenceGreaterThan) return x;
                    return nextMultiple;
                }).ToList();
        }
    }
}
