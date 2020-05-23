using AspNetCoreDependencyInjection.Models;
using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class AppointmentRegisterationRule1 : IAppointmentRegisterationRule
    {
        public Task CheckRule(PatientInfo patientIfno)
        {
            Console.WriteLine("Rule 1 is checked");
            return Task.CompletedTask;
        }
    }

    public class AppointmentRegisterationRule2 : IAppointmentRegisterationRule
    {
        public Task CheckRule(PatientInfo patientIfno)
        {
            Console.WriteLine("Rule 2 is checked");
            return Task.CompletedTask;
        }
    }

    public class AppointmentRegisterationRule3 : IAppointmentRegisterationRule
    {
        public Task CheckRule(PatientInfo patientIfno)
        {
            Console.WriteLine("Rule 3 is checked");
            return Task.CompletedTask;
        }
    }

    public class AppointmentRegisterationRule4 : IAppointmentRegisterationRule
    {
        public Task CheckRule(PatientInfo patientIfno)
        {
            Console.WriteLine("Rule 4 is checked");
            return Task.CompletedTask;
        }
    }
}
