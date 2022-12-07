using System;
using System.Collections.Generic;
public class Olympics : IOlympics
{
    public void AddCompetition(int id, string name, int participantsLimit)
    {
        throw new NotImplementedException();
    }

    public void AddCompetitor(int id, string name)
    {
        throw new NotImplementedException();
    }

    public void Compete(int competitorId, int competitionId)
    {
        throw new NotImplementedException();
    }

    public int CompetitionsCount()
    {
        throw new NotImplementedException();
    }

    public int CompetitorsCount()
    {
        throw new NotImplementedException();
    }

    public bool Contains(int competitionId, Competitor comp)
    {
        throw new NotImplementedException();
    }

    public void Disqualify(int competitionId, int competitorId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Competitor> FindCompetitorsInRange(long min, long max)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Competitor> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public Competition GetCompetition(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Competitor> SearchWithNameLength(int min, int max)
    {
        throw new NotImplementedException();
    }
}