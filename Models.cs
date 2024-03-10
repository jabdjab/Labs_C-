using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


public class Calendar : DbContext
{
    public DbSet<Leapnes> Leapness { get; set; }
    public DbSet<Interval> Intervals { get; set; }
    public DbSet<DayWeek> DayWeeks { get; set; }

    public string DbPath { get; }

    public Calendar()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "calendar.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

[PrimaryKey(nameof(Leapnes_id))]
public class Leapnes {
    public int Leapnes_id {get; set;}
    public int year {get; set;}

    public bool leap {get; set;}
}

[PrimaryKey(nameof(interval_id))]
public class Interval {
    public int interval_id {get; set;}
    public DateTime date1 {get; set;}
    public DateTime date2 {get; set;}
    public int interval {get; set;}
}

[PrimaryKey(nameof(DayWeekId))]
public class DayWeek {
    public int DayWeekId {get; set;}
    public DateTime date {get; set;}

    public int dayWeek {get; set;}
}