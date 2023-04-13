using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Hms.BL;

namespace Hms.DL
{
    internal class doctorDL
    {
        public static List<doctor> doctorList = new List<doctor>();

        public static void addDoctorInList(doctor obj)
        {
            doctorList.Add(obj);
        }

        public static void addDoctorInFile()
        {
            string path = "doctorFile.txt";
            StreamWriter doctorFile = new StreamWriter(path, true);
            for (int i = 0; i < doctorList.Count; i++)
            {
                doctorFile.WriteLine(doctorList[i].DoctorName + "," + doctorList[i].DoctorGender + "," + doctorList[i].DoctorAge + "," + doctorList[i].DoctorSpecialization + "," + doctorList[i].DoctorId + "," + doctorList[i].DoctorBlood + "," + doctorList[i].DoctorMobile + "," + doctorList[i].DoctorMail + "," + doctorList[i].DoctorAddress);
            }
            doctorFile.Flush();
            doctorFile.Close();
        }

        public static void storeinFile()
        {
            string path = "doctorFile.txt";
            StreamWriter doctorFile = new StreamWriter(path);
            for (int i = 0; i < doctorList.Count; i++)
            {
                doctorFile.WriteLine(doctorList[i].DoctorName + "," + doctorList[i].DoctorGender + "," + doctorList[i].DoctorAge + "," + doctorList[i].DoctorSpecialization + "," + doctorList[i].DoctorId + "," + doctorList[i].DoctorBlood + "," + doctorList[i].DoctorMobile + "," + doctorList[i].DoctorMail + "," + doctorList[i].DoctorAddress);
            }
            doctorFile.Flush();
            doctorFile.Close();
        }

        public static bool loadDoctorFromFile()
        {
            string path = "doctorFile.txt";
            StreamReader doctorFile = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = doctorFile.ReadLine())!= null)
                {
                    string doctorName, doctorGender, doctorAddress, doctorSpecialization, doctorMail, doctorMobile, doctorBlood;
                    int doctorAge, doctorId;
                    string[] splittedRecord = record.Split(',');
                    doctorName = splittedRecord[0];
                    doctorGender = splittedRecord[1];
                    doctorAge = int.Parse(splittedRecord[2]);
                    doctorSpecialization = splittedRecord[3];
                    doctorId = int.Parse(splittedRecord[4]);
                    doctorBlood = splittedRecord[5];
                    doctorMobile = splittedRecord[6];
                    doctorMail = splittedRecord[7];
                    doctorAddress = splittedRecord[8];
                    doctor obj = new doctor(doctorName, doctorAge, doctorGender, doctorSpecialization, doctorId, doctorAddress, doctorBlood, doctorMail, doctorMobile);
                    doctorList.Add(obj);
                }
                doctorFile.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void deleteDoctor(int index)
        {
            doctorList.RemoveAt(index);
        }

        public static void updateDoctor()
        {

        }
    }
}
