using Microsoft.AspNetCore.Mvc;
using QuestionsApp.Contracts.Questions;

namespace QuestionsApp.Presenters.Controllers.Questions;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateQuestionDto dto,
        CancellationToken cancellationToken)
    {
        return Ok("Question created");
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] GetQuestionsDto dto,
        CancellationToken cancellationToken)
    {
        return Ok("Questions get");
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(
        [FromRoute] Guid id,
        CancellationToken cancellationToken)
    {
        return Ok("Questions get by id");
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateQuestionDto dto,
        CancellationToken cancellationToken)
    {
        return Ok("Question updated");
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(
        [FromRoute] Guid id,
        [FromBody] UpdateQuestionDto dto,
        CancellationToken cancellationToken)
    {
        return Ok("Question deleted");
    }

    [HttpPut("{id:guid}/solution")]
    public async Task<IActionResult> SelectSolution(
        [FromRoute] Guid id,
        [FromQuery] Guid solutionId,
        CancellationToken cancellationToken)
    {
        return Ok("Solution selected");
    }

    [HttpPost("{id:guid}/answers")]
    public async Task<IActionResult> AddAnswer(
        [FromRoute] Guid id,
        [FromBody] AddAnswerDto dto,
        CancellationToken cancellationToken)
    {
        return Ok("Answer added");
    }
}