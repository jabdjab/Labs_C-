public class Db_work
{
    public Calendar db;

    public Db_work(Calendar db_)
    {
        db = db_;
    }
    // leapnes
    public void Create(bool leap_, int year_, Calendar db)
    {
        Console.WriteLine("SaveToDatabase: leap by year");
        db.Add(new Leapnes { leap = leap_, year = year_ });
        db.SaveChanges();
    }

    public void Read(int year_, Calendar db)
    {
        Console.WriteLine("read");
        var leap = db.Leapness.Where(b => b.year == year_).ToList();
        Console.WriteLine(leap.Count==0 ? "doesn't have information" : leap[0].leap);
    }

    public void Remove(int year_, Calendar db)
    {
        Console.WriteLine("remove");
        var entries = db.Leapness.Where(b => b.year == year_).ToList();
        for (int i = 0; i < entries.Count; ++i)
        {
            Console.WriteLine($"Removing Leapnes({entries[i].year}, {entries[i].leap})");
            db.Remove(entries[i]);
        }
    }

    // Interval
    public void Create(DateTime date1_, DateTime date2_, int interval_, Calendar db)
    {
        Console.WriteLine("SaveToDatabase: distanse by dates");
        db.Add(new Interval { date1 = date1_, date2 = date2_, interval = interval_ });
        db.SaveChanges();
    }

    public void Read(DateTime date1_, DateTime date2_, Calendar db)
    {
        Console.WriteLine("read");
        var interval = db.Intervals.Where(b => b.date1 == date1_).OrderByDescending(p => p.date2 == date2_).ToList();
        Console.WriteLine(interval.Count==0 ? "doesn't have information" : interval[0].interval);

    }
    public void Remove(DateTime date1_, DateTime date2_, Calendar db)
    {
        Console.WriteLine("remove");
        var entries = db.Intervals.Where(b => b.date1 == date1_).OrderByDescending(p => p.date2 == date2_).ToList();
        for (int i = 0; i < entries.Count; ++i)
        {
            Console.WriteLine($"Removing Leapnes({entries[i].date1}, {entries[i].date2}, {entries[i].interval})");
            db.Remove(entries[i]);
        }
    }

    // Day Of a Week
    public void Create(DateTime date_, int dayWeek_, Calendar db)
    {
        Console.WriteLine("SaveToDatabase: dayweek by date");
        db.Add(new DayWeek { date = date_, dayWeek = dayWeek_ });
        db.SaveChanges();
    }

    public void Read(DateTime date_, Calendar db)
    {
        Console.WriteLine("read");
        var dayWeek = db.DayWeeks.Where(b => b.date == date_).ToList();
        Console.WriteLine(dayWeek.Count==0 ? "doesn't have information" : dayWeek[0].dayWeek);
    }
    public void Remove(DateTime date_, Calendar db)
    {
        Console.WriteLine("remove");
        var entries = db.DayWeeks.Where(b => b.date == date_).ToList();
        for (int i = 0; i < entries.Count; ++i)
        {
            Console.WriteLine($"Removing Leapnes({entries[i].date}, {entries[i].dayWeek})");
            db.Remove(entries[i]);
        }
    }
}