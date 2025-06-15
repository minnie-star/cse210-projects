using System;
using System.Collections.Generic;

public class Player
{
    public int _totalPoints { get; private set; }
    private List<string> _badges = new List<string>();
    public string _userName { get; set; }

    public Player(string UserName)
    {
        _userName = UserName;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
        UpdateLevelAndBadges();
    }

    public string GetLevel()
    {
        if (_totalPoints < 1000) return "Novice";
        if (_totalPoints < 5000) return "Hero";
        return "Legend";
    }

    private void UpdateLevelAndBadges()
    {
        if (_totalPoints >= 1000 && !_badges.Contains("1000 Points Badge"))
        {
            _badges.Add("1000 Points Badge");
            Console.WriteLine("🏅 You earned the '1000 Points Badge'!");
        }
        if (_totalPoints >= 5000 && !_badges.Contains("5000 Points Badge"))
        {
            _badges.Add("5000 Points Badge");
            Console.WriteLine("🏅 You earned the '5000 Points Badge'!");
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Total Points: {_totalPoints} | Level: {GetLevel()}");
        Console.WriteLine("Badges: " + (_badges.Count > 0 ? string.Join(", ", _badges) : "None"));
    }
}