using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using Tp3_2375637.Data;
using Tp3_2375637.Models;
using Tp3_2375637.Services;

namespace Tp3_2375637.Controllers
{
  [Route("api/[controller]/[Action]")]
  [ApiController]
  [Authorize]
  public class ScoresController : ControllerBase
  {
    readonly UserManager<User> UserManager;
    private readonly ScoresService _scoresService ;

    public ScoresController(ScoresService scoresService ,UserManager<User> userManager)
    {
      _scoresService = scoresService;
      UserManager = userManager;
    }

    // GET: api/Scores
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<Score>>> GetPublicScore()
    {
      List<Score>? scores = await _scoresService.GetTopPublicScores();
      if (scores == null) return StatusCode(StatusCodes.Status500InternalServerError);
      return Ok(scores);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> ChangeScoreVisibility(int id)
    {
      var result = await _scoresService.Edit(id);
      if (!result)return NotFound(new { Message = "Le score n'existe plus." });
      return NoContent();
    }

    // GET: api/Scores/id
    [HttpGet("{id}")]
    [AllowAnonymous]

    public async Task<ActionResult<Score>> GetScore(int id)
    {
      var score = await _scoresService.GetScoreById(id);
      if (score == null)return NotFound();
      return Ok(score);
    }

    // GET: api/Scores/5
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Score>>> GetMyScore()
    {
      User? user = await UserManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
      if (_scoresService.IsScoreSetEmpty()) return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Veuillez réessayer plus tard" });
      if (user != null) return user.Scores;
      return StatusCode(StatusCodes.Status400BadRequest, new { Message = "Utilisateur non trouvé." });
    }

    // POST: api/Scores
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Score>> PostScore(Score score)
    {
      User? user = await UserManager.FindByIdAsync(User.FindFirstValue(ClaimTypes.NameIdentifier));
      if (user == null) return Unauthorized();
      score.User = user;
      Score? newscore = await _scoresService.CreateScore(score);
      if (newscore == null) return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Veillez réessayer plus tard." });
      return Ok(newscore);
      
    }
  }
}
