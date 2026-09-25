using Microsoft.AspNetCore.Authorization;
using MediatR;
using MediSync.Application.Features.Appointments.Commands.CreateAppointment;
using MediSync.Application.Features.Appointments.Queries.GetAllAppointments;
using Microsoft.AspNetCore.Mvc;

namespace MediSync.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppointmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllAppointmentsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAppointmentCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }
    }
}