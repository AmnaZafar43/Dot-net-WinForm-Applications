using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hms.BL
{
    internal class doctor
    {
        private string doctorName;
        private int doctorAge;
        private string doctorGender;
        private string doctorSpecialization;
        private int doctorId;
        private string doctorAddress;
        private string doctorBlood;
        private string doctorMobile;
        private string doctorMail;

        public string DoctorName { get => doctorName; set => doctorName = value; }
        public int DoctorAge { get => doctorAge; set => doctorAge = value; }
        public string DoctorGender { get => doctorGender; set => doctorGender = value; }
        public string DoctorSpecialization { get => doctorSpecialization; set => doctorSpecialization = value; }
        public int DoctorId { get => doctorId; set => doctorId = value; }
        public string DoctorAddress { get => doctorAddress; set => doctorAddress = value; }
        public string DoctorBlood { get => doctorBlood; set => doctorBlood = value; }
        public string DoctorMobile { get => doctorMobile; set => doctorMobile = value; }
        public string DoctorMail { get => doctorMail; set => doctorMail = value; }

        public doctor(string doctorName, int doctorAge, string doctorGender, string doctorSpecialization, int doctorId, string doctorAddress, string doctorBlood, string doctorMail, string doctorMobile)
        {
            this.DoctorName = doctorName;
            this.DoctorAge = doctorAge;
            this.DoctorSpecialization = doctorSpecialization;
            this.DoctorId = doctorId;
            this.DoctorAddress = doctorAddress;
            this.DoctorBlood = doctorBlood;
            this.DoctorMobile = doctorMobile;
            this.DoctorMail = doctorMail;
            this.DoctorGender = doctorGender;
        }
    }
}
