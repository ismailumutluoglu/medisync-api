using MediatR;
using MediSync.Domain.Entities;

namespace MediSync.Application.Features.Appointments.Queries.GetAllAppointments
{
    public class GetAllAppointmentsQuery : IRequest<List<Appointment>>
    {
    }
}