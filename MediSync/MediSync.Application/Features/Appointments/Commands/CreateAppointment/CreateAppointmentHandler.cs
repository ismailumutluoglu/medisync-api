using MediatR;
using MediSync.Domain.Entities;

namespace MediSync.Application.Features.Appointments.Commands.CreateAppointment
{
    public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand, int>
    {
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

            // Repository buraya gelecek
            return appointment.Id;
        }
    }
}