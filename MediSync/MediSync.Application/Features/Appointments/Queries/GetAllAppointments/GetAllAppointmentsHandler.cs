using MediatR;
using MediSync.Domain.Entities;

namespace MediSync.Application.Features.Appointments.Queries.GetAllAppointments
{
    public class GetAllAppointmentsHandler : IRequestHandler<GetAllAppointmentsQuery, List<Appointment>>
    {
        public async Task<List<Appointment>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
        {
            // Repository buraya gelecek
            return new List<Appointment>();
        }
    }
}