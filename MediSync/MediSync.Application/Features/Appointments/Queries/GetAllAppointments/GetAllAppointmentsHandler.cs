using MediatR;
using MediSync.Domain.Entities;
using MediSync.Domain.Interfaces;

namespace MediSync.Application.Features.Appointments.Queries.GetAllAppointments
{
    public class GetAllAppointmentsHandler : IRequestHandler<GetAllAppointmentsQuery, List<Appointment>>
    {
        private readonly IAppointmentRepository _repository;

        public GetAllAppointmentsHandler(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Appointment>> Handle(GetAllAppointmentsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}