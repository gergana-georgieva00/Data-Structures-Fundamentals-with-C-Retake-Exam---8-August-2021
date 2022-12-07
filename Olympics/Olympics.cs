using System;
using System.Collections.Generic;
public class Olympics : IOlympics
{
    private Dictionary<string, Competitor> competitorsByName = new Dictionary<string, Competitor>();
    private Dictionary<string, Competition> competitionsByName = new Dictionary<string, Competition>();
    private Dictionary<int, string> competitorsById = new Dictionary<int, string>();
    private Dictionary<int, string> competitionsById = new Dictionary<int, string>();

    public void AddCompetition(int id, string name, int score)
    {
        if (!competitionsById.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        competitionsById.Add(id, name);
        competitionsByName.Add(name, new Competition(name, id, score));
    }

    public void AddCompetitor(int id, string name)
    {
        if (competitorsById.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        competitorsById.Add(id, name);
        competitorsByName.Add(name, new Competitor(id, name));
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