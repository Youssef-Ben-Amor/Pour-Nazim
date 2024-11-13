using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tp3_2375637.Data;
using Tp3_2375637.Models;

namespace Tp3_2375637.Services
{
  public class ScoresService
  {
    private readonly Tp3_2375637Context _context;

    public ScoresService(Tp3_2375637Context context)
    {
      _context = context;
    }
    private bool IsContextValid() => _context != null && _context.Score != null;

    private bool ScoreExists(int id)
    {
      return _context.Score.Any(e => e.id == id);
    }
    public async Task<List<Score>?> GetTopPublicScores()
    {
      if (!IsContextValid()) return null;
      return await _context.Score.Where(u=>u.IsPublic).OrderByDescending(u => u.ScoreValue).Take(10).ToListAsync();
    }
    public async Task<bool> Edit(int id)
    {
      var score = await _context.Score.FindAsync(id);
      if (score == null)return false;
      score.IsPublic = !score.IsPublic;
      _context.Entry(score).Property(s => s.IsPublic).IsModified = true;
      try
      {
        await _context.SaveChangesAsync();
        return true;
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ScoreExists(id))
        {
          return false;
        }
        else
        {
          throw;
        }
      }
    }
    public async Task<Score?> GetScoreById(int id)
    {
      var score = await _context.Score.FindAsync(id);
      return score;
    }
    public bool IsScoreSetEmpty()
    {
      return _context == null || _context.Score == null;
    }
    public async Task<Score?> CreateScore(Score score)
    {
      if (IsScoreSetEmpty()) return null;
      _context.Score.Add(score);
      await _context.SaveChangesAsync();
      return score;
    }
  }
}
