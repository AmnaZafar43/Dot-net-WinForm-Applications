using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hms.BL
{
    internal class patient
    {
        private string patientName;
        private int patientAge;
        private string patientDisease;
        private string patientBlood;
        private string patientCnic;
        private int patientId;
        private string patientGender;
        private string patientAddress;

        public string PatientName { get => patientName; set => patientName = value; }
        public int PatientAge { get => patientAge; set => patientAge = value; }
        public string PatientDisease { get => patientDisease; set => patientDisease = value; }
        public string PatientBlood { get => patientBlood; set => patientBlood = value; }
        public string PatientCnic { get => patientCnic; set => patientCnic = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public string PatientGender { get => patientGender; set => patientGender = value; }
        public string PatientAddress { get => patientAddress; set => patientAddress = value; }

        public patient(string patientName, int patientAge, string patientDisease, string patientBlood, string patientCnic, int patientId, string patientGender, string patientAddress)
        {
            this.patientName = patientName;
            this.patientAge = patientAge;
            this.patientDisease = patientDisease;
            this.patientBlood = patientBlood;
            this.patientCnic = patientCnic;
            this.patientId = patientId;
            this.patientGender = patientGender;
            this.patientAddress = patientAddress;
        }
    }
}
