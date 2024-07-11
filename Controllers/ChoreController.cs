using Microsoft.AspNetCore.Mvc;
using HouseRules.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using HouseRules.Models;
using HouseRules.Models.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace HouseRules.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ChoreController : ControllerBase
{
    private HouseRulesDbContext _dbContext;

    public ChoreController(HouseRulesDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Get()
    {
        return Ok(_dbContext.chores);
    }

    [HttpGet("{id}")]
    [Authorize]

    public IActionResult GetById(int id)
    {
        Chore chore = _dbContext
        .chores
        .Include(c => c.choreCompletions)
        .Include(c => c.choreAssignments)
        .SingleOrDefault(c => c.Id == id);

            if(chore == null)
        {
            return NotFound();
        }
        return Ok(chore);
    }

   [HttpPost("{id}/complete")]
   [Authorize]

    public IActionResult CompleteChore(int id, int userId)
    {
        ChoreCompletion choreCompletion = new ChoreCompletion
        {
            UserProfileId = userId,
            ChoreId = id,
            CompletedOn = DateTime.Now,
        };
        _dbContext.choreCompletions.Add(choreCompletion);
        _dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPost]
    [Authorize (Roles = "Admin")]

    public IActionResult NewChore(Chore choreToBeAdded)
    {
        _dbContext.chores.Add(choreToBeAdded);
        _dbContext.SaveChanges();
        return Created($"/api/chore/{choreToBeAdded.Id}", choreToBeAdded);
    }

    [HttpDelete("{id}")]
    [Authorize (Roles = "Admin")]

    public IActionResult DeleteChore(int id)
    {
        Chore choreToDelete = _dbContext.chores.SingleOrDefault(c => c.Id == id);
        if(choreToDelete == null)
        {
            return NotFound();
        }
        _dbContext.chores.Remove(choreToDelete);
        _dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPost("{id}/assign")]
    [Authorize (Roles = "Admin")]

    public IActionResult AssignChore(int id, int userId)
    {
        ChoreAssignment choreAssignment = new ChoreAssignment
        {
            UserProfileId = userId,
            ChoreId = id
        };

        _dbContext.choreAssignments.Add(choreAssignment);
        _dbContext.SaveChanges();
        return NoContent();
    }

    [HttpPost("{id}/unassign")]
    [Authorize (Roles = "Admin")]
    public IActionResult UnassignChore(int id, int userId)
    {
        ChoreAssignment choreAssignment = _dbContext.choreAssignments.SingleOrDefault(c => c.ChoreId == id && c.UserProfileId == userId);
        
        if(choreAssignment == null)
        {
            return NotFound();
        }

        _dbContext.choreAssignments.Remove(choreAssignment);
        _dbContext.SaveChanges();

        return NoContent();
    }

    [HttpPut("{id}")]
    [Authorize (Roles = "Admin")]

    public IActionResult UpdateChore(Chore chore, int id)
    {
        Chore choreToUpdate = _dbContext.chores.SingleOrDefault(c => c.Id == id);

        if(choreToUpdate == null)
        {
            return NotFound();
        }
        else if(id != chore.Id)
        {
            return BadRequest();
        }

        choreToUpdate.Name = chore.Name;
        choreToUpdate.Difficulty = chore.Difficulty;
        choreToUpdate.ChoreFrequencyDays = chore.ChoreFrequencyDays;

        _dbContext.SaveChanges();
        return Ok();
    }
}