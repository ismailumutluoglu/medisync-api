using MediatR;
using MediSync.Domain.Entities;
using MediSync.Domain.Interfaces;

namespace MediSync.Application.Features.Appointments.Commands.CreateAppointment
{
    public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand, int>
    {
        private readonly IAppointmentRepository _repository;

        public CreateAppointmentHandler(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            var appointment = new Appointment
            {
                PatientId = request.PatientId,
                DoctorId = request.DoctorId,
                AppointmentDate = request.AppointmentDate,
                Notes = request.Notes,
                Status = "Pending",
                CreatedAt = DateTime.UtcNow
            };

            return await _repository.CreateAsync(appointment);
        }
    }
}