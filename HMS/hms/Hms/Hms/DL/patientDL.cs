using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hms.BL;
using System.IO;

namespace Hms.DL
{
    internal class patientDL
    {
        public static List<patient> patientList = new List<patient>();

        public static void addPatientInList(patient obj)
        {
            patientList.Add(obj);
        }

        public static void addPatientInFile()
        {
            string path = "patientFile.txt";
            StreamWriter patientFile = new StreamWriter(path,true);
            for(int i=0;i<patientList.Count;i++)
            {
                patientFile.WriteLine(patientList[i].PatientName + "," + patientList[i].PatientAge + "," + patientList[i].PatientGender + "," + patientList[i].PatientBlood + "," + patientList[i].PatientDisease + "," + patientList[i].PatientId + "," + patientList[i].PatientCnic + "," + patientList[i].PatientAddress);
            }
            patientFile.Flush();
            patientFile.Close();

        }

        public static void storePatientInFile()
        {
            string path = "patientFile.txt";
            StreamWriter patientFile = new StreamWriter(path);
            for (int i = 0; i < patientList.Count; i++)
            {
                patientFile.WriteLine(patientList[i].PatientName + "," + patientList[i].PatientAge + "," + patientList[i].PatientGender + "," + patientList[i].PatientBlood + "," + patientList[i].PatientDisease + "," + patientList[i].PatientId + "," + patientList[i].PatientCnic + "," + patientList[i].PatientAddress);
            }
            patientFile.Flush();
            patientFile.Close();

        }
        public static bool loadPatientFromFile()
        {
            string path = "patientFile.txt";
            StreamReader patientFile = new StreamReader(path);
            if(File.Exists(path))
            {
                string record;
                while((record = patientFile.ReadLine())!= null)
                {
                    string[] splittedRecord = record.Split(',');
                    string patientName = splittedRecord[0];
                    int patientAge = int.Parse(splittedRecord[1]);
                    string patientGender = splittedRecord[2];
                    string patientBlood = splittedRecord[3];
                    string patientDisease = splittedRecord[4];
                    int patientId = int.Parse(splittedRecord[5]); 
                    string patientCnic = splittedRecord[6];
                    string patientAddress = splittedRecord[7];
                    patient obj = new patient(patientName, patientAge, patientDisease, patientBlood, patientCnic, patientId, patientGender, patientAddress);
                    patientList.Add(obj);
                }
                patientFile.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void deletePatient(int index)
        {
            patientList.RemoveAt(index);
        }


    }
}
